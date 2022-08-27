Imports System.Data.SqlClient
Imports System.Data
Imports system.Windows.Forms

Public Class FrmConfiguracion
    Inherits System.Windows.Forms.Form
    Dim existe As Boolean = False
    Private cConexion As Conexion
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Private sqlConexion As SqlConnection

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        'pictureEdit1.DataBindings.Add(New Binding("EditValue", DsConfiguracion, "configuraciones.Logo"))
        Me.PictureEdit1.DataBindings.Add(New binding("EditValue", DsConfiguracion, "configuraciones.Logo"))
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents VTTel2 As System.Windows.Forms.TextBox
    Friend WithEvents VTFax2 As System.Windows.Forms.TextBox
    Friend WithEvents VTFax1 As System.Windows.Forms.TextBox
    Friend WithEvents VTTel1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtFrase As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtInteres As System.Windows.Forms.TextBox
    Friend WithEvents TxtCajeros As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    'Friend WithEvents DsConfiguracion As Inventario.DsConfiguracion
    Friend WithEvents DaConfiguracion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents TxtImpuesto As System.Windows.Forms.TextBox
    Friend WithEvents SqlConnection As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsConfiguracion As DsConfiguracion
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents CheckBoxFacturaPersonalizada As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxUnico As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCredito As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxContadoPVE As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxContado As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxNumUnico As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNumCRE As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNumPVE As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNumCON As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxCambiaPrecio As System.Windows.Forms.CheckBox
    Friend WithEvents ck_Taller As System.Windows.Forms.CheckBox
    Friend WithEvents txtTallerContado As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTallerCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtMascotasCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtMascotasContado As System.Windows.Forms.TextBox
    Friend WithEvents ck_Mascotas As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents txt_mensaje As System.Windows.Forms.RichTextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_asunto As System.Windows.Forms.TextBox
    Friend WithEvents dacorreo As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents txt_dir_correo As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents txt_clave As System.Windows.Forms.TextBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtclave As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtclave1 As System.Windows.Forms.TextBox
    Friend WithEvents adpermiso As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cbousuarios As System.Windows.Forms.ComboBox
    Friend WithEvents adusuarios As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents ck_regalias As System.Windows.Forms.CheckBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfiguracion))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtDireccion = New System.Windows.Forms.TextBox
        Me.DsConfiguracion = New LcPymes_5._2.DsConfiguracion
        Me.VTTel2 = New System.Windows.Forms.TextBox
        Me.VTFax2 = New System.Windows.Forms.TextBox
        Me.VTFax1 = New System.Windows.Forms.TextBox
        Me.VTTel1 = New System.Windows.Forms.TextBox
        Me.TxtFrase = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtCedula = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtEmpresa = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.ck_regalias = New System.Windows.Forms.CheckBox
        Me.txtMascotasCredito = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtMascotasContado = New System.Windows.Forms.TextBox
        Me.ck_Mascotas = New System.Windows.Forms.CheckBox
        Me.txtTallerCredito = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtTallerContado = New System.Windows.Forms.TextBox
        Me.ck_Taller = New System.Windows.Forms.CheckBox
        Me.CheckBoxCambiaPrecio = New System.Windows.Forms.CheckBox
        Me.TextBoxNumUnico = New System.Windows.Forms.TextBox
        Me.CheckBoxFacturaPersonalizada = New System.Windows.Forms.CheckBox
        Me.CheckBoxUnico = New System.Windows.Forms.CheckBox
        Me.TextBoxNumCRE = New System.Windows.Forms.TextBox
        Me.TextBoxNumPVE = New System.Windows.Forms.TextBox
        Me.CheckBoxCredito = New System.Windows.Forms.CheckBox
        Me.CheckBoxContadoPVE = New System.Windows.Forms.CheckBox
        Me.CheckBoxContado = New System.Windows.Forms.CheckBox
        Me.TextBoxNumCON = New System.Windows.Forms.TextBox
        Me.TxtCajeros = New System.Windows.Forms.TextBox
        Me.TxtInteres = New System.Windows.Forms.TextBox
        Me.TxtImpuesto = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.txt_dir_correo = New System.Windows.Forms.TextBox
        Me.txt_asunto = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txt_clave = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.txt_mensaje = New System.Windows.Forms.RichTextBox
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.btneliminar = New System.Windows.Forms.Button
        Me.cbousuarios = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtclave1 = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtclave = New System.Windows.Forms.TextBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton
        Me.DaConfiguracion = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.dacorreo = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.adpermiso = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.adusuarios = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DsConfiguracion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(408, 256)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(400, 230)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Empresas"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtDireccion)
        Me.GroupBox2.Controls.Add(Me.VTTel2)
        Me.GroupBox2.Controls.Add(Me.VTFax2)
        Me.GroupBox2.Controls.Add(Me.VTFax1)
        Me.GroupBox2.Controls.Add(Me.VTTel1)
        Me.GroupBox2.Controls.Add(Me.TxtFrase)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtCedula)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtEmpresa)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 176)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'TxtDireccion
        '
        Me.TxtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Direccion", True))
        Me.TxtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.ForeColor = System.Drawing.Color.Blue
        Me.TxtDireccion.Location = New System.Drawing.Point(12, 150)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(376, 13)
        Me.TxtDireccion.TabIndex = 7
        '
        'DsConfiguracion
        '
        Me.DsConfiguracion.DataSetName = "DsConfiguracion"
        Me.DsConfiguracion.Locale = New System.Globalization.CultureInfo("")
        Me.DsConfiguracion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VTTel2
        '
        Me.VTTel2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VTTel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Tel_02", True))
        Me.VTTel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VTTel2.ForeColor = System.Drawing.Color.Blue
        Me.VTTel2.Location = New System.Drawing.Point(316, 70)
        Me.VTTel2.Name = "VTTel2"
        Me.VTTel2.Size = New System.Drawing.Size(72, 13)
        Me.VTTel2.TabIndex = 3
        '
        'VTFax2
        '
        Me.VTFax2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VTFax2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Fax_02", True))
        Me.VTFax2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VTFax2.ForeColor = System.Drawing.Color.Blue
        Me.VTFax2.Location = New System.Drawing.Point(316, 110)
        Me.VTFax2.Name = "VTFax2"
        Me.VTFax2.Size = New System.Drawing.Size(72, 13)
        Me.VTFax2.TabIndex = 5
        '
        'VTFax1
        '
        Me.VTFax1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VTFax1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Fax_01", True))
        Me.VTFax1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VTFax1.ForeColor = System.Drawing.Color.Blue
        Me.VTFax1.Location = New System.Drawing.Point(228, 110)
        Me.VTFax1.Name = "VTFax1"
        Me.VTFax1.Size = New System.Drawing.Size(76, 13)
        Me.VTFax1.TabIndex = 4
        '
        'VTTel1
        '
        Me.VTTel1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VTTel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Tel_01", True))
        Me.VTTel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VTTel1.ForeColor = System.Drawing.Color.Blue
        Me.VTTel1.Location = New System.Drawing.Point(228, 70)
        Me.VTTel1.Name = "VTTel1"
        Me.VTTel1.Size = New System.Drawing.Size(72, 13)
        Me.VTTel1.TabIndex = 2
        '
        'TxtFrase
        '
        Me.TxtFrase.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFrase.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Frase", True))
        Me.TxtFrase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFrase.ForeColor = System.Drawing.Color.Blue
        Me.TxtFrase.Location = New System.Drawing.Point(12, 110)
        Me.TxtFrase.Name = "TxtFrase"
        Me.TxtFrase.Size = New System.Drawing.Size(176, 13)
        Me.TxtFrase.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(12, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(376, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Dirección"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(228, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Fax (es)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(12, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Frase Publicitaria"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCedula
        '
        Me.TxtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCedula.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Cedula", True))
        Me.TxtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCedula.ForeColor = System.Drawing.Color.Blue
        Me.TxtCedula.Location = New System.Drawing.Point(12, 70)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(176, 13)
        Me.TxtCedula.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(228, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Teléfono (s)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Cédula Jurídica"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtEmpresa
        '
        Me.TxtEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtEmpresa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Empresa", True))
        Me.TxtEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmpresa.ForeColor = System.Drawing.Color.Blue
        Me.TxtEmpresa.Location = New System.Drawing.Point(12, 30)
        Me.TxtEmpresa.Name = "TxtEmpresa"
        Me.TxtEmpresa.Size = New System.Drawing.Size(376, 13)
        Me.TxtEmpresa.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Empresa"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(400, 230)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Valores"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.ck_regalias)
        Me.GroupBox1.Controls.Add(Me.txtMascotasCredito)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtMascotasContado)
        Me.GroupBox1.Controls.Add(Me.ck_Mascotas)
        Me.GroupBox1.Controls.Add(Me.txtTallerCredito)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtTallerContado)
        Me.GroupBox1.Controls.Add(Me.ck_Taller)
        Me.GroupBox1.Controls.Add(Me.CheckBoxCambiaPrecio)
        Me.GroupBox1.Controls.Add(Me.TextBoxNumUnico)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFacturaPersonalizada)
        Me.GroupBox1.Controls.Add(Me.CheckBoxUnico)
        Me.GroupBox1.Controls.Add(Me.TextBoxNumCRE)
        Me.GroupBox1.Controls.Add(Me.TextBoxNumPVE)
        Me.GroupBox1.Controls.Add(Me.CheckBoxCredito)
        Me.GroupBox1.Controls.Add(Me.CheckBoxContadoPVE)
        Me.GroupBox1.Controls.Add(Me.CheckBoxContado)
        Me.GroupBox1.Controls.Add(Me.TextBoxNumCON)
        Me.GroupBox1.Controls.Add(Me.TxtCajeros)
        Me.GroupBox1.Controls.Add(Me.TxtInteres)
        Me.GroupBox1.Controls.Add(Me.TxtImpuesto)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 219)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CheckBox2
        '
        Me.CheckBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsConfiguracion, "configuraciones.editar_nombre", True))
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.Red
        Me.CheckBox2.Location = New System.Drawing.Point(27, 183)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(357, 30)
        Me.CheckBox2.TabIndex = 32
        Me.CheckBox2.Text = "Se puede editar el nombre en facturas"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'ck_regalias
        '
        Me.ck_regalias.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsConfiguracion, "configuraciones.regalias", True))
        Me.ck_regalias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ck_regalias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ck_regalias.Location = New System.Drawing.Point(24, 112)
        Me.ck_regalias.Name = "ck_regalias"
        Me.ck_regalias.Size = New System.Drawing.Size(104, 24)
        Me.ck_regalias.TabIndex = 31
        Me.ck_regalias.Text = "Activar regalias"
        '
        'txtMascotasCredito
        '
        Me.txtMascotasCredito.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMascotasCredito.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.MascotasCredito", True))
        Me.txtMascotasCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMascotasCredito.ForeColor = System.Drawing.Color.Blue
        Me.txtMascotasCredito.Location = New System.Drawing.Point(312, 112)
        Me.txtMascotasCredito.Name = "txtMascotasCredito"
        Me.txtMascotasCredito.Size = New System.Drawing.Size(72, 13)
        Me.txtMascotasCredito.TabIndex = 30
        Me.txtMascotasCredito.Text = "0.00"
        Me.txtMascotasCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(240, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Crédito"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(240, 128)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 16)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Contado"
        '
        'txtMascotasContado
        '
        Me.txtMascotasContado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMascotasContado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.MascotasContado", True))
        Me.txtMascotasContado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMascotasContado.ForeColor = System.Drawing.Color.Blue
        Me.txtMascotasContado.Location = New System.Drawing.Point(312, 128)
        Me.txtMascotasContado.Name = "txtMascotasContado"
        Me.txtMascotasContado.Size = New System.Drawing.Size(72, 13)
        Me.txtMascotasContado.TabIndex = 27
        Me.txtMascotasContado.Text = "0.00"
        Me.txtMascotasContado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ck_Mascotas
        '
        Me.ck_Mascotas.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ck_Mascotas.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsConfiguracion, "configuraciones.Mascotas", True))
        Me.ck_Mascotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_Mascotas.ForeColor = System.Drawing.Color.Blue
        Me.ck_Mascotas.Location = New System.Drawing.Point(168, 112)
        Me.ck_Mascotas.Name = "ck_Mascotas"
        Me.ck_Mascotas.Size = New System.Drawing.Size(80, 16)
        Me.ck_Mascotas.TabIndex = 26
        Me.ck_Mascotas.Text = "Mascotas"
        Me.ck_Mascotas.UseVisualStyleBackColor = False
        '
        'txtTallerCredito
        '
        Me.txtTallerCredito.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTallerCredito.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.TallerCredito", True))
        Me.txtTallerCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTallerCredito.ForeColor = System.Drawing.Color.Blue
        Me.txtTallerCredito.Location = New System.Drawing.Point(312, 79)
        Me.txtTallerCredito.Name = "txtTallerCredito"
        Me.txtTallerCredito.Size = New System.Drawing.Size(72, 13)
        Me.txtTallerCredito.TabIndex = 25
        Me.txtTallerCredito.Text = "0.00"
        Me.txtTallerCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(240, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Crédito"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(240, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Contado"
        '
        'txtTallerContado
        '
        Me.txtTallerContado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTallerContado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.TallerContado", True))
        Me.txtTallerContado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTallerContado.ForeColor = System.Drawing.Color.Blue
        Me.txtTallerContado.Location = New System.Drawing.Point(312, 95)
        Me.txtTallerContado.Name = "txtTallerContado"
        Me.txtTallerContado.Size = New System.Drawing.Size(72, 13)
        Me.txtTallerContado.TabIndex = 22
        Me.txtTallerContado.Text = "0.00"
        Me.txtTallerContado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ck_Taller
        '
        Me.ck_Taller.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ck_Taller.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsConfiguracion, "configuraciones.Taller", True))
        Me.ck_Taller.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_Taller.ForeColor = System.Drawing.Color.Blue
        Me.ck_Taller.Location = New System.Drawing.Point(168, 79)
        Me.ck_Taller.Name = "ck_Taller"
        Me.ck_Taller.Size = New System.Drawing.Size(80, 16)
        Me.ck_Taller.TabIndex = 21
        Me.ck_Taller.Text = "Taller"
        Me.ck_Taller.UseVisualStyleBackColor = False
        '
        'CheckBoxCambiaPrecio
        '
        Me.CheckBoxCambiaPrecio.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CheckBoxCambiaPrecio.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsConfiguracion, "configuraciones.CambiaPrecioCredito", True))
        Me.CheckBoxCambiaPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxCambiaPrecio.ForeColor = System.Drawing.Color.Blue
        Me.CheckBoxCambiaPrecio.Location = New System.Drawing.Point(168, 145)
        Me.CheckBoxCambiaPrecio.Name = "CheckBoxCambiaPrecio"
        Me.CheckBoxCambiaPrecio.Size = New System.Drawing.Size(216, 16)
        Me.CheckBoxCambiaPrecio.TabIndex = 20
        Me.CheckBoxCambiaPrecio.Text = "Cambia Precio Personalizado"
        Me.CheckBoxCambiaPrecio.UseVisualStyleBackColor = False
        '
        'TextBoxNumUnico
        '
        Me.TextBoxNumUnico.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxNumUnico.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.NumeroConsecutivo", True))
        Me.TextBoxNumUnico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNumUnico.ForeColor = System.Drawing.Color.Blue
        Me.TextBoxNumUnico.Location = New System.Drawing.Point(312, 15)
        Me.TextBoxNumUnico.Name = "TextBoxNumUnico"
        Me.TextBoxNumUnico.Size = New System.Drawing.Size(72, 13)
        Me.TextBoxNumUnico.TabIndex = 18
        Me.TextBoxNumUnico.Text = "0.00"
        Me.TextBoxNumUnico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CheckBoxFacturaPersonalizada
        '
        Me.CheckBoxFacturaPersonalizada.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CheckBoxFacturaPersonalizada.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsConfiguracion, "configuraciones.Imprimir_en_Factura_Personalizada", True))
        Me.CheckBoxFacturaPersonalizada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxFacturaPersonalizada.ForeColor = System.Drawing.Color.Blue
        Me.CheckBoxFacturaPersonalizada.Location = New System.Drawing.Point(168, 161)
        Me.CheckBoxFacturaPersonalizada.Name = "CheckBoxFacturaPersonalizada"
        Me.CheckBoxFacturaPersonalizada.Size = New System.Drawing.Size(216, 16)
        Me.CheckBoxFacturaPersonalizada.TabIndex = 19
        Me.CheckBoxFacturaPersonalizada.Text = "Utilizar Factura Personalizada"
        Me.CheckBoxFacturaPersonalizada.UseVisualStyleBackColor = False
        '
        'CheckBoxUnico
        '
        Me.CheckBoxUnico.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CheckBoxUnico.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsConfiguracion, "configuraciones.UnicoConsecutivo", True))
        Me.CheckBoxUnico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxUnico.ForeColor = System.Drawing.Color.Blue
        Me.CheckBoxUnico.Location = New System.Drawing.Point(168, 15)
        Me.CheckBoxUnico.Name = "CheckBoxUnico"
        Me.CheckBoxUnico.Size = New System.Drawing.Size(144, 16)
        Me.CheckBoxUnico.TabIndex = 17
        Me.CheckBoxUnico.Text = "Consecutivo Unico"
        Me.CheckBoxUnico.UseVisualStyleBackColor = False
        '
        'TextBoxNumCRE
        '
        Me.TextBoxNumCRE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxNumCRE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.NumeroCredito", True))
        Me.TextBoxNumCRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNumCRE.ForeColor = System.Drawing.Color.Blue
        Me.TextBoxNumCRE.Location = New System.Drawing.Point(312, 31)
        Me.TextBoxNumCRE.Name = "TextBoxNumCRE"
        Me.TextBoxNumCRE.Size = New System.Drawing.Size(72, 13)
        Me.TextBoxNumCRE.TabIndex = 16
        Me.TextBoxNumCRE.Text = "0.00"
        Me.TextBoxNumCRE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxNumPVE
        '
        Me.TextBoxNumPVE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxNumPVE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.NumeroPuntoVenta", True))
        Me.TextBoxNumPVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNumPVE.ForeColor = System.Drawing.Color.Blue
        Me.TextBoxNumPVE.Location = New System.Drawing.Point(312, 63)
        Me.TextBoxNumPVE.Name = "TextBoxNumPVE"
        Me.TextBoxNumPVE.Size = New System.Drawing.Size(72, 13)
        Me.TextBoxNumPVE.TabIndex = 15
        Me.TextBoxNumPVE.Text = "0.00"
        Me.TextBoxNumPVE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CheckBoxCredito
        '
        Me.CheckBoxCredito.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CheckBoxCredito.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsConfiguracion, "configuraciones.ConsCredito", True))
        Me.CheckBoxCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxCredito.ForeColor = System.Drawing.Color.Blue
        Me.CheckBoxCredito.Location = New System.Drawing.Point(168, 31)
        Me.CheckBoxCredito.Name = "CheckBoxCredito"
        Me.CheckBoxCredito.Size = New System.Drawing.Size(144, 16)
        Me.CheckBoxCredito.TabIndex = 14
        Me.CheckBoxCredito.Text = "Consecutivo Crédito"
        Me.CheckBoxCredito.UseVisualStyleBackColor = False
        '
        'CheckBoxContadoPVE
        '
        Me.CheckBoxContadoPVE.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CheckBoxContadoPVE.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsConfiguracion, "configuraciones.ConsPuntoVenta", True))
        Me.CheckBoxContadoPVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxContadoPVE.ForeColor = System.Drawing.Color.Blue
        Me.CheckBoxContadoPVE.Location = New System.Drawing.Point(168, 63)
        Me.CheckBoxContadoPVE.Name = "CheckBoxContadoPVE"
        Me.CheckBoxContadoPVE.Size = New System.Drawing.Size(144, 16)
        Me.CheckBoxContadoPVE.TabIndex = 13
        Me.CheckBoxContadoPVE.Text = "Consecutivo PVE"
        Me.CheckBoxContadoPVE.UseVisualStyleBackColor = False
        '
        'CheckBoxContado
        '
        Me.CheckBoxContado.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CheckBoxContado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsConfiguracion, "configuraciones.ConsContado", True))
        Me.CheckBoxContado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxContado.ForeColor = System.Drawing.Color.Blue
        Me.CheckBoxContado.Location = New System.Drawing.Point(168, 47)
        Me.CheckBoxContado.Name = "CheckBoxContado"
        Me.CheckBoxContado.Size = New System.Drawing.Size(144, 16)
        Me.CheckBoxContado.TabIndex = 12
        Me.CheckBoxContado.Text = "Consecutivo Contado"
        Me.CheckBoxContado.UseVisualStyleBackColor = False
        '
        'TextBoxNumCON
        '
        Me.TextBoxNumCON.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxNumCON.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.NumeroContado", True))
        Me.TextBoxNumCON.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNumCON.ForeColor = System.Drawing.Color.Blue
        Me.TextBoxNumCON.Location = New System.Drawing.Point(312, 47)
        Me.TextBoxNumCON.Name = "TextBoxNumCON"
        Me.TextBoxNumCON.Size = New System.Drawing.Size(72, 13)
        Me.TextBoxNumCON.TabIndex = 11
        Me.TextBoxNumCON.Text = "0.00"
        Me.TextBoxNumCON.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtCajeros
        '
        Me.TxtCajeros.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCajeros.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Cajeros", True))
        Me.TxtCajeros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCajeros.ForeColor = System.Drawing.Color.Blue
        Me.TxtCajeros.Location = New System.Drawing.Point(24, 95)
        Me.TxtCajeros.Name = "TxtCajeros"
        Me.TxtCajeros.Size = New System.Drawing.Size(128, 13)
        Me.TxtCajeros.TabIndex = 10
        Me.TxtCajeros.Text = "0.00"
        Me.TxtCajeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtInteres
        '
        Me.TxtInteres.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtInteres.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Intereses", True))
        Me.TxtInteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInteres.ForeColor = System.Drawing.Color.Blue
        Me.TxtInteres.Location = New System.Drawing.Point(24, 63)
        Me.TxtInteres.Name = "TxtInteres"
        Me.TxtInteres.Size = New System.Drawing.Size(128, 13)
        Me.TxtInteres.TabIndex = 9
        Me.TxtInteres.Text = "0.00"
        Me.TxtInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtImpuesto
        '
        Me.TxtImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtImpuesto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Imp_Venta", True))
        Me.TxtImpuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImpuesto.ForeColor = System.Drawing.Color.Blue
        Me.TxtImpuesto.Location = New System.Drawing.Point(24, 31)
        Me.TxtImpuesto.Name = "TxtImpuesto"
        Me.TxtImpuesto.Size = New System.Drawing.Size(128, 13)
        Me.TxtImpuesto.TabIndex = 8
        Me.TxtImpuesto.Text = "0.00"
        Me.TxtImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(24, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Número de Cajeros"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(24, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Intereses"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(24, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Impuesto Venta"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PictureEdit1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(400, 230)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Logo"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Location = New System.Drawing.Point(103, 3)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Size = New System.Drawing.Size(192, 176)
        Me.PictureEdit1.TabIndex = 21
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.txt_dir_correo)
        Me.TabPage4.Controls.Add(Me.txt_asunto)
        Me.TabPage4.Controls.Add(Me.Label14)
        Me.TabPage4.Controls.Add(Me.Label18)
        Me.TabPage4.Controls.Add(Me.txt_clave)
        Me.TabPage4.Controls.Add(Me.Label16)
        Me.TabPage4.Controls.Add(Me.Label17)
        Me.TabPage4.Controls.Add(Me.CheckBox1)
        Me.TabPage4.Controls.Add(Me.txt_mensaje)
        Me.TabPage4.Location = New System.Drawing.Point(4, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(400, 230)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Notificaciones de correo"
        '
        'txt_dir_correo
        '
        Me.txt_dir_correo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "correo.direccion_correo", True))
        Me.txt_dir_correo.Location = New System.Drawing.Point(120, 32)
        Me.txt_dir_correo.Name = "txt_dir_correo"
        Me.txt_dir_correo.Size = New System.Drawing.Size(256, 20)
        Me.txt_dir_correo.TabIndex = 11
        '
        'txt_asunto
        '
        Me.txt_asunto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "correo.asunto", True))
        Me.txt_asunto.Location = New System.Drawing.Point(120, 80)
        Me.txt_asunto.Name = "txt_asunto"
        Me.txt_asunto.Size = New System.Drawing.Size(256, 20)
        Me.txt_asunto.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(72, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 23)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Asunto"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(8, 104)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 23)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Mensaje"
        '
        'txt_clave
        '
        Me.txt_clave.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "correo.clave", True))
        Me.txt_clave.Location = New System.Drawing.Point(120, 56)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_clave.Size = New System.Drawing.Size(256, 20)
        Me.txt_clave.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(48, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 23)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Contraseña"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(8, 32)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(112, 23)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Dirección de correo"
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(8, 8)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(264, 16)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Mostrar facturas vencidas al inicio del programa"
        '
        'txt_mensaje
        '
        Me.txt_mensaje.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "correo.mensaje", True))
        Me.txt_mensaje.Location = New System.Drawing.Point(8, 128)
        Me.txt_mensaje.Name = "txt_mensaje"
        Me.txt_mensaje.Size = New System.Drawing.Size(384, 40)
        Me.txt_mensaje.TabIndex = 0
        Me.txt_mensaje.Text = ""
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.btneliminar)
        Me.TabPage5.Controls.Add(Me.cbousuarios)
        Me.TabPage5.Controls.Add(Me.Label21)
        Me.TabPage5.Controls.Add(Me.Button1)
        Me.TabPage5.Controls.Add(Me.Label20)
        Me.TabPage5.Controls.Add(Me.txtclave1)
        Me.TabPage5.Controls.Add(Me.Label19)
        Me.TabPage5.Controls.Add(Me.Label15)
        Me.TabPage5.Controls.Add(Me.txtclave)
        Me.TabPage5.Location = New System.Drawing.Point(4, 4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(400, 230)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Permiso"
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(264, 136)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 24)
        Me.btneliminar.TabIndex = 9
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.Visible = False
        '
        'cbousuarios
        '
        Me.cbousuarios.DataSource = Me.DsConfiguracion
        Me.cbousuarios.DisplayMember = "Usuarios.Nombre"
        Me.cbousuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbousuarios.Location = New System.Drawing.Point(160, 56)
        Me.cbousuarios.Name = "cbousuarios"
        Me.cbousuarios.Size = New System.Drawing.Size(176, 21)
        Me.cbousuarios.TabIndex = 8
        Me.cbousuarios.ValueMember = "Usuarios.Cedula"
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(112, 64)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(48, 16)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Usuario:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(160, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 24)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Guardar"
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(80, 112)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 16)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Repetir Clave:"
        '
        'txtclave1
        '
        Me.txtclave1.Location = New System.Drawing.Point(160, 112)
        Me.txtclave1.Name = "txtclave1"
        Me.txtclave1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtclave1.Size = New System.Drawing.Size(100, 20)
        Me.txtclave1.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(112, 8)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(168, 23)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Permiso para Habilitar inventario"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(120, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 16)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Clave:"
        '
        'txtclave
        '
        Me.txtclave.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "permisos.clave", True))
        Me.txtclave.Location = New System.Drawing.Point(160, 88)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtclave.Size = New System.Drawing.Size(100, 20)
        Me.txtclave.TabIndex = 0
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
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarRegistrar, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 262)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(408, 52)
        Me.ToolBar1.TabIndex = 61
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Name = "ToolBarNuevo"
        Me.ToolBarNuevo.Text = "Nuevo"
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Name = "ToolBarRegistrar"
        Me.ToolBarRegistrar.Text = "Registrar"
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Name = "ToolBarCerrar"
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'DaConfiguracion
        '
        Me.DaConfiguracion.DeleteCommand = Me.SqlDeleteCommand1
        Me.DaConfiguracion.InsertCommand = Me.SqlInsertCommand1
        Me.DaConfiguracion.SelectCommand = Me.SqlSelectCommand1
        Me.DaConfiguracion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "configuraciones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Empresa", "Empresa"), New System.Data.Common.DataColumnMapping("Tel_01", "Tel_01"), New System.Data.Common.DataColumnMapping("Tel_02", "Tel_02"), New System.Data.Common.DataColumnMapping("Fax_01", "Fax_01"), New System.Data.Common.DataColumnMapping("Fax_02", "Fax_02"), New System.Data.Common.DataColumnMapping("Direccion", "Direccion"), New System.Data.Common.DataColumnMapping("Imp_Venta", "Imp_Venta"), New System.Data.Common.DataColumnMapping("Frase", "Frase"), New System.Data.Common.DataColumnMapping("Cajeros", "Cajeros"), New System.Data.Common.DataColumnMapping("Logo", "Logo"), New System.Data.Common.DataColumnMapping("Intereses", "Intereses"), New System.Data.Common.DataColumnMapping("UnicoConsecutivo", "UnicoConsecutivo"), New System.Data.Common.DataColumnMapping("NumeroConsecutivo", "NumeroConsecutivo"), New System.Data.Common.DataColumnMapping("ConsContado", "ConsContado"), New System.Data.Common.DataColumnMapping("NumeroContado", "NumeroContado"), New System.Data.Common.DataColumnMapping("ConsCredito", "ConsCredito"), New System.Data.Common.DataColumnMapping("NumeroCredito", "NumeroCredito"), New System.Data.Common.DataColumnMapping("ConsPuntoVenta", "ConsPuntoVenta"), New System.Data.Common.DataColumnMapping("NumeroPuntoVenta", "NumeroPuntoVenta"), New System.Data.Common.DataColumnMapping("Taller", "Taller"), New System.Data.Common.DataColumnMapping("TallerContado", "TallerContado"), New System.Data.Common.DataColumnMapping("TallerCredito", "TallerCredito"), New System.Data.Common.DataColumnMapping("Imprimir_en_Factura_Personalizada", "Imprimir_en_Factura_Personalizada"), New System.Data.Common.DataColumnMapping("FormatoCheck", "FormatoCheck"), New System.Data.Common.DataColumnMapping("Contabilidad", "Contabilidad"), New System.Data.Common.DataColumnMapping("CambiaPrecioCredito", "CambiaPrecioCredito"), New System.Data.Common.DataColumnMapping("Mascotas", "Mascotas"), New System.Data.Common.DataColumnMapping("MascotasContado", "MascotasContado"), New System.Data.Common.DataColumnMapping("MascotasCredito", "MascotasCredito"), New System.Data.Common.DataColumnMapping("regalias", "regalias"), New System.Data.Common.DataColumnMapping("editar_nombre", "editar_nombre")})})
        Me.DaConfiguracion.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Empresa", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Empresa", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tel_01", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tel_01", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tel_02", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tel_02", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fax_01", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax_01", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fax_02", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax_02", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Imp_Venta", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imp_Venta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Frase", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Frase", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cajeros", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cajeros", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Intereses", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Intereses", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnicoConsecutivo", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UnicoConsecutivo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumeroConsecutivo", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroConsecutivo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ConsContado", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ConsContado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumeroContado", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroContado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ConsCredito", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ConsCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumeroCredito", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ConsPuntoVenta", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ConsPuntoVenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumeroPuntoVenta", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroPuntoVenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Taller", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Taller", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TallerContado", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TallerContado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TallerCredito", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TallerCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Imprimir_en_Factura_Personalizada", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imprimir_en_Factura_Personalizada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FormatoCheck", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormatoCheck", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contabilidad", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CambiaPrecioCredito", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CambiaPrecioCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mascotas", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mascotas", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MascotasContado", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MascotasContado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MascotasCredito", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MascotasCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_regalias", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "regalias", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_regalias", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "regalias", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_editar_nombre", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "editar_nombre", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_editar_nombre", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "editar_nombre", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlConnection
        '
        Me.SqlConnection.ConnectionString = "Data Source=.;Initial Catalog=seepos;Integrated Security=True"
        Me.SqlConnection.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 0, "Cedula"), New System.Data.SqlClient.SqlParameter("@Empresa", System.Data.SqlDbType.VarChar, 0, "Empresa"), New System.Data.SqlClient.SqlParameter("@Tel_01", System.Data.SqlDbType.VarChar, 0, "Tel_01"), New System.Data.SqlClient.SqlParameter("@Tel_02", System.Data.SqlDbType.VarChar, 0, "Tel_02"), New System.Data.SqlClient.SqlParameter("@Fax_01", System.Data.SqlDbType.VarChar, 0, "Fax_01"), New System.Data.SqlClient.SqlParameter("@Fax_02", System.Data.SqlDbType.VarChar, 0, "Fax_02"), New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 0, "Direccion"), New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 0, "Imp_Venta"), New System.Data.SqlClient.SqlParameter("@Frase", System.Data.SqlDbType.VarChar, 0, "Frase"), New System.Data.SqlClient.SqlParameter("@Cajeros", System.Data.SqlDbType.Int, 0, "Cajeros"), New System.Data.SqlClient.SqlParameter("@Logo", System.Data.SqlDbType.Image, 0, "Logo"), New System.Data.SqlClient.SqlParameter("@Intereses", System.Data.SqlDbType.Int, 0, "Intereses"), New System.Data.SqlClient.SqlParameter("@UnicoConsecutivo", System.Data.SqlDbType.Bit, 0, "UnicoConsecutivo"), New System.Data.SqlClient.SqlParameter("@NumeroConsecutivo", System.Data.SqlDbType.BigInt, 0, "NumeroConsecutivo"), New System.Data.SqlClient.SqlParameter("@ConsContado", System.Data.SqlDbType.Bit, 0, "ConsContado"), New System.Data.SqlClient.SqlParameter("@NumeroContado", System.Data.SqlDbType.BigInt, 0, "NumeroContado"), New System.Data.SqlClient.SqlParameter("@ConsCredito", System.Data.SqlDbType.Bit, 0, "ConsCredito"), New System.Data.SqlClient.SqlParameter("@NumeroCredito", System.Data.SqlDbType.BigInt, 0, "NumeroCredito"), New System.Data.SqlClient.SqlParameter("@ConsPuntoVenta", System.Data.SqlDbType.Bit, 0, "ConsPuntoVenta"), New System.Data.SqlClient.SqlParameter("@NumeroPuntoVenta", System.Data.SqlDbType.BigInt, 0, "NumeroPuntoVenta"), New System.Data.SqlClient.SqlParameter("@Taller", System.Data.SqlDbType.Bit, 0, "Taller"), New System.Data.SqlClient.SqlParameter("@TallerContado", System.Data.SqlDbType.BigInt, 0, "TallerContado"), New System.Data.SqlClient.SqlParameter("@TallerCredito", System.Data.SqlDbType.BigInt, 0, "TallerCredito"), New System.Data.SqlClient.SqlParameter("@Imprimir_en_Factura_Personalizada", System.Data.SqlDbType.Bit, 0, "Imprimir_en_Factura_Personalizada"), New System.Data.SqlClient.SqlParameter("@FormatoCheck", System.Data.SqlDbType.Bit, 0, "FormatoCheck"), New System.Data.SqlClient.SqlParameter("@Contabilidad", System.Data.SqlDbType.Bit, 0, "Contabilidad"), New System.Data.SqlClient.SqlParameter("@CambiaPrecioCredito", System.Data.SqlDbType.Bit, 0, "CambiaPrecioCredito"), New System.Data.SqlClient.SqlParameter("@Mascotas", System.Data.SqlDbType.Bit, 0, "Mascotas"), New System.Data.SqlClient.SqlParameter("@MascotasContado", System.Data.SqlDbType.BigInt, 0, "MascotasContado"), New System.Data.SqlClient.SqlParameter("@MascotasCredito", System.Data.SqlDbType.BigInt, 0, "MascotasCredito"), New System.Data.SqlClient.SqlParameter("@regalias", System.Data.SqlDbType.Bit, 0, "regalias"), New System.Data.SqlClient.SqlParameter("@editar_nombre", System.Data.SqlDbType.Bit, 0, "editar_nombre")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 0, "Cedula"), New System.Data.SqlClient.SqlParameter("@Empresa", System.Data.SqlDbType.VarChar, 0, "Empresa"), New System.Data.SqlClient.SqlParameter("@Tel_01", System.Data.SqlDbType.VarChar, 0, "Tel_01"), New System.Data.SqlClient.SqlParameter("@Tel_02", System.Data.SqlDbType.VarChar, 0, "Tel_02"), New System.Data.SqlClient.SqlParameter("@Fax_01", System.Data.SqlDbType.VarChar, 0, "Fax_01"), New System.Data.SqlClient.SqlParameter("@Fax_02", System.Data.SqlDbType.VarChar, 0, "Fax_02"), New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 0, "Direccion"), New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 0, "Imp_Venta"), New System.Data.SqlClient.SqlParameter("@Frase", System.Data.SqlDbType.VarChar, 0, "Frase"), New System.Data.SqlClient.SqlParameter("@Cajeros", System.Data.SqlDbType.Int, 0, "Cajeros"), New System.Data.SqlClient.SqlParameter("@Logo", System.Data.SqlDbType.Image, 0, "Logo"), New System.Data.SqlClient.SqlParameter("@Intereses", System.Data.SqlDbType.Int, 0, "Intereses"), New System.Data.SqlClient.SqlParameter("@UnicoConsecutivo", System.Data.SqlDbType.Bit, 0, "UnicoConsecutivo"), New System.Data.SqlClient.SqlParameter("@NumeroConsecutivo", System.Data.SqlDbType.BigInt, 0, "NumeroConsecutivo"), New System.Data.SqlClient.SqlParameter("@ConsContado", System.Data.SqlDbType.Bit, 0, "ConsContado"), New System.Data.SqlClient.SqlParameter("@NumeroContado", System.Data.SqlDbType.BigInt, 0, "NumeroContado"), New System.Data.SqlClient.SqlParameter("@ConsCredito", System.Data.SqlDbType.Bit, 0, "ConsCredito"), New System.Data.SqlClient.SqlParameter("@NumeroCredito", System.Data.SqlDbType.BigInt, 0, "NumeroCredito"), New System.Data.SqlClient.SqlParameter("@ConsPuntoVenta", System.Data.SqlDbType.Bit, 0, "ConsPuntoVenta"), New System.Data.SqlClient.SqlParameter("@NumeroPuntoVenta", System.Data.SqlDbType.BigInt, 0, "NumeroPuntoVenta"), New System.Data.SqlClient.SqlParameter("@Taller", System.Data.SqlDbType.Bit, 0, "Taller"), New System.Data.SqlClient.SqlParameter("@TallerContado", System.Data.SqlDbType.BigInt, 0, "TallerContado"), New System.Data.SqlClient.SqlParameter("@TallerCredito", System.Data.SqlDbType.BigInt, 0, "TallerCredito"), New System.Data.SqlClient.SqlParameter("@Imprimir_en_Factura_Personalizada", System.Data.SqlDbType.Bit, 0, "Imprimir_en_Factura_Personalizada"), New System.Data.SqlClient.SqlParameter("@FormatoCheck", System.Data.SqlDbType.Bit, 0, "FormatoCheck"), New System.Data.SqlClient.SqlParameter("@Contabilidad", System.Data.SqlDbType.Bit, 0, "Contabilidad"), New System.Data.SqlClient.SqlParameter("@CambiaPrecioCredito", System.Data.SqlDbType.Bit, 0, "CambiaPrecioCredito"), New System.Data.SqlClient.SqlParameter("@Mascotas", System.Data.SqlDbType.Bit, 0, "Mascotas"), New System.Data.SqlClient.SqlParameter("@MascotasContado", System.Data.SqlDbType.BigInt, 0, "MascotasContado"), New System.Data.SqlClient.SqlParameter("@MascotasCredito", System.Data.SqlDbType.BigInt, 0, "MascotasCredito"), New System.Data.SqlClient.SqlParameter("@regalias", System.Data.SqlDbType.Bit, 0, "regalias"), New System.Data.SqlClient.SqlParameter("@editar_nombre", System.Data.SqlDbType.Bit, 0, "editar_nombre"), New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Empresa", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Empresa", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tel_01", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tel_01", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tel_02", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tel_02", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fax_01", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax_01", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fax_02", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax_02", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Imp_Venta", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imp_Venta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Frase", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Frase", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cajeros", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cajeros", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Intereses", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Intereses", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnicoConsecutivo", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UnicoConsecutivo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumeroConsecutivo", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroConsecutivo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ConsContado", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ConsContado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumeroContado", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroContado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ConsCredito", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ConsCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumeroCredito", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ConsPuntoVenta", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ConsPuntoVenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumeroPuntoVenta", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroPuntoVenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Taller", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Taller", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TallerContado", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TallerContado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TallerCredito", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TallerCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Imprimir_en_Factura_Personalizada", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imprimir_en_Factura_Personalizada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FormatoCheck", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormatoCheck", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contabilidad", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CambiaPrecioCredito", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CambiaPrecioCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mascotas", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mascotas", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MascotasContado", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MascotasContado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MascotasCredito", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MascotasCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_regalias", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "regalias", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_regalias", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "regalias", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_editar_nombre", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "editar_nombre", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_editar_nombre", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "editar_nombre", System.Data.DataRowVersion.Original, Nothing)})
        '
        'dacorreo
        '
        Me.dacorreo.DeleteCommand = Me.SqlDeleteCommand2
        Me.dacorreo.InsertCommand = Me.SqlInsertCommand2
        Me.dacorreo.SelectCommand = Me.SqlSelectCommand2
        Me.dacorreo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "correo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("clave", "clave"), New System.Data.Common.DataColumnMapping("asunto", "asunto"), New System.Data.Common.DataColumnMapping("mensaje", "mensaje"), New System.Data.Common.DataColumnMapping("direccion_correo", "direccion_correo")})})
        Me.dacorreo.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM correo WHERE (direccion_correo = @Original_direccion_correo)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_direccion_correo", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion_correo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@clave", System.Data.SqlDbType.VarChar, 50, "clave"), New System.Data.SqlClient.SqlParameter("@asunto", System.Data.SqlDbType.NVarChar, 10, "asunto"), New System.Data.SqlClient.SqlParameter("@mensaje", System.Data.SqlDbType.NVarChar, 10, "mensaje"), New System.Data.SqlClient.SqlParameter("@direccion_correo", System.Data.SqlDbType.VarChar, 150, "direccion_correo")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT clave, asunto, mensaje, direccion_correo FROM correo"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@clave", System.Data.SqlDbType.VarChar, 50, "clave"), New System.Data.SqlClient.SqlParameter("@asunto", System.Data.SqlDbType.NVarChar, 10, "asunto"), New System.Data.SqlClient.SqlParameter("@mensaje", System.Data.SqlDbType.NVarChar, 10, "mensaje"), New System.Data.SqlClient.SqlParameter("@direccion_correo", System.Data.SqlDbType.VarChar, 150, "direccion_correo"), New System.Data.SqlClient.SqlParameter("@Original_direccion_correo", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion_correo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'adpermiso
        '
        Me.adpermiso.DeleteCommand = Me.SqlDeleteCommand3
        Me.adpermiso.InsertCommand = Me.SqlInsertCommand3
        Me.adpermiso.SelectCommand = Me.SqlSelectCommand3
        Me.adpermiso.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "permisos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("usuario", "usuario"), New System.Data.Common.DataColumnMapping("clave", "clave"), New System.Data.Common.DataColumnMapping("id", "id")})})
        Me.adpermiso.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM permisos WHERE (id = @Original_id) AND (clave = @Original_clave) AND " & _
            "(usuario = @Original_usuario)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_clave", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "clave", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_usuario", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "usuario", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO permisos(usuario, clave) VALUES (@usuario, @clave); SELECT usuario, c" & _
            "lave, id FROM permisos WHERE (id = @@IDENTITY)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.NVarChar, 50, "usuario"), New System.Data.SqlClient.SqlParameter("@clave", System.Data.SqlDbType.NVarChar, 50, "clave")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT usuario, clave, id FROM permisos"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.NVarChar, 50, "usuario"), New System.Data.SqlClient.SqlParameter("@clave", System.Data.SqlDbType.NVarChar, 50, "clave"), New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_clave", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "clave", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_usuario", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.BigInt, 8, "id")})
        '
        'adusuarios
        '
        Me.adusuarios.InsertCommand = Me.SqlInsertCommand4
        Me.adusuarios.SelectCommand = Me.SqlSelectCommand4
        Me.adusuarios.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Id_Usuario", "Id_Usuario"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Entrada", "Clave_Entrada"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna"), New System.Data.Common.DataColumnMapping("Perfil", "Perfil"), New System.Data.Common.DataColumnMapping("Foto", "Foto"), New System.Data.Common.DataColumnMapping("Iniciales", "Iniciales"), New System.Data.Common.DataColumnMapping("CambiarPrecio", "CambiarPrecio"), New System.Data.Common.DataColumnMapping("Porc_Precio", "Porc_Precio"), New System.Data.Common.DataColumnMapping("Aplicar_Desc", "Aplicar_Desc"), New System.Data.Common.DataColumnMapping("Porc_Desc", "Porc_Desc"), New System.Data.Common.DataColumnMapping("Exist_Negativa", "Exist_Negativa")})})
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = resources.GetString("SqlInsertCommand4.CommandText")
        Me.SqlInsertCommand4.Connection = Me.SqlConnection
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 50, "Cedula"), New System.Data.SqlClient.SqlParameter("@Id_Usuario", System.Data.SqlDbType.VarChar, 50, "Id_Usuario"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"), New System.Data.SqlClient.SqlParameter("@Clave_Entrada", System.Data.SqlDbType.VarChar, 30, "Clave_Entrada"), New System.Data.SqlClient.SqlParameter("@Clave_Interna", System.Data.SqlDbType.VarChar, 30, "Clave_Interna"), New System.Data.SqlClient.SqlParameter("@Perfil", System.Data.SqlDbType.Int, 4, "Perfil"), New System.Data.SqlClient.SqlParameter("@Foto", System.Data.SqlDbType.VarBinary, 2147483647, "Foto"), New System.Data.SqlClient.SqlParameter("@Iniciales", System.Data.SqlDbType.VarChar, 4, "Iniciales"), New System.Data.SqlClient.SqlParameter("@CambiarPrecio", System.Data.SqlDbType.Bit, 1, "CambiarPrecio"), New System.Data.SqlClient.SqlParameter("@Porc_Precio", System.Data.SqlDbType.Float, 8, "Porc_Precio"), New System.Data.SqlClient.SqlParameter("@Aplicar_Desc", System.Data.SqlDbType.Bit, 1, "Aplicar_Desc"), New System.Data.SqlClient.SqlParameter("@Porc_Desc", System.Data.SqlDbType.Float, 8, "Porc_Desc"), New System.Data.SqlClient.SqlParameter("@Exist_Negativa", System.Data.SqlDbType.Bit, 1, "Exist_Negativa")})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Cedula, Id_Usuario, Nombre, Clave_Entrada, Clave_Interna, Perfil, Foto, In" & _
            "iciales, CambiarPrecio, Porc_Precio, Aplicar_Desc, Porc_Desc, Exist_Negativa FRO" & _
            "M Usuarios"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection
        '
        'FrmConfiguracion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(408, 314)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Name = "FrmConfiguracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DsConfiguracion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variable"
    Public usuario As String
#End Region

    Private Sub FrmConfiguración_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'TabPage4.Visible = False
            SqlConnection.ConnectionString = CadenaConexionSeePOS
            adusuarios.Fill(Me.DsConfiguracion.Usuarios)
            DaConfiguracion.Fill(Me.DsConfiguracion.configuraciones)
            Me.dacorreo.Fill(Me.DsConfiguracion.correo)

            DsConfiguracion.configuraciones.InteresesColumn.DefaultValue = 0
            DsConfiguracion.configuraciones.Imp_VentaColumn.DefaultValue = 0
            DsConfiguracion.configuraciones.CajerosColumn.DefaultValue = 0
            DsConfiguracion.configuraciones.NumeroConsecutivoColumn.DefaultValue = 0
            DsConfiguracion.configuraciones.NumeroCreditoColumn.DefaultValue = 0
            DsConfiguracion.configuraciones.NumeroContadoColumn.DefaultValue = 0
            DsConfiguracion.configuraciones.NumeroPuntoVentaColumn.DefaultValue = 0
            DsConfiguracion.configuraciones.TallerContadoColumn.DefaultValue = 0
            DsConfiguracion.configuraciones.TallerCreditoColumn.DefaultValue = 0
            DsConfiguracion.configuraciones.MascotasContadoColumn.DefaultValue = 0
            DsConfiguracion.configuraciones.MascotasCreditoColumn.DefaultValue = 0

            If GetSetting("SeeSOFT", "SeePOs", "ver_vencidas") = "SI" Then
                Me.CheckBox1.Checked = True
            Else
                Me.CheckBox1.Checked = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje")
        End Try
    End Sub

    Private Sub binding()
        Me.TxtInteres.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Intereses"))
        Me.TxtImpuesto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Imp_Venta"))
        Me.CheckBoxContado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsConfiguracion, "configuraciones.ConsContado"))
        Me.TextBoxNumCON.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.NumeroContado"))
        Me.TextBoxNumPVE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.NumeroPuntoVenta"))
        Me.CheckBoxCredito.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsConfiguracion, "configuraciones.ConsCredito"))
        Me.CheckBoxContadoPVE.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsConfiguracion, "configuraciones.ConsPuntoVenta"))
        Me.CheckBoxFacturaPersonalizada.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsConfiguracion, "configuraciones.Imprimir_en_Factura_Personalizada"))
        Me.CheckBoxCambiaPrecio.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsConfiguracion, "configuracion.CambiaPrecioCredito"))
        Me.CheckBoxUnico.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsConfiguracion, "configuraciones.UnicoConsecutivo"))
        Me.TextBoxNumCRE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.NumeroCredito"))
        Me.TxtCedula.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Cedula"))
        Me.TxtEmpresa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Empresa"))
        Me.TextBoxNumUnico.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.NumeroConsecutivo"))
        Me.VTFax1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Fax_01"))
        Me.VTFax2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Fax_02"))
        Me.VTTel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Tel_02"))
        Me.TxtDireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Direccion"))
        Me.TxtFrase.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Frase"))
        Me.VTTel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Tel_01"))
        'Me.ck_regalias.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Tel_01"))
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : nuevo()

            Case 2 : registrar()

            Case 3 : Me.Close()

        End Select
    End Sub
    Sub AGREGAR_EMAIL()
       
    End Sub
    Private Sub nuevo()
        Try
            Me.BindingContext(Me.DsConfiguracion, "Configuraciones").EndCurrentEdit()
            Me.BindingContext(Me.DsConfiguracion, "Configuraciones").AddNew()

            Me.BindingContext(Me.DsConfiguracion, "permisos").EndCurrentEdit()
            Me.BindingContext(Me.DsConfiguracion, "permisos").AddNew()

            Me.BindingContext(Me.DsConfiguracion, "correo").EndCurrentEdit()
            Me.BindingContext(Me.DsConfiguracion, "correo").AddNew()
            'TxtInteres.Text = "0.00"
            ' TxtImpuesto.Text = "0.00"
            'TxtCajeros.Text = "0.00"
            'TxtDolar.Text = "0.00"
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub registrar()

        'SaveSetting("SeeSOFT", "SeePOs", "clave", Me.txtclave.Text)

        If Me.SqlConnection.State <> Me.SqlConnection.State.Open Then Me.SqlConnection.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection.BeginTransaction
        Try
            Me.BindingContext(Me.DsConfiguracion, "Configuraciones").EndCurrentEdit()
            'Me.BindingContext(Me.DsConfiguracion, "correo").EndCurrentEdit()
            Me.BindingContext(Me.DsConfiguracion, "permisos").EndCurrentEdit()

            Me.SqlInsertCommand1.Transaction = Trans
            Me.SqlUpdateCommand1.Transaction = Trans
            'Me.SqlInsertCommand3.Transaction = Trans
            'Me.SqlUpdateCommand3.Transaction = Trans

            Me.adpermiso.Update(Me.DsConfiguracion.permisos)
            Me.DaConfiguracion.Update(Me.DsConfiguracion.configuraciones)

            Trans.Commit()

            MsgBox("Los datos fueron ingresados correctamente")

        Catch ex As Exception
            'SqlConnection.BeginTransaction.Rollback()
            Trans.Rollback()
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub TxtEmpresa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEmpresa.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtCedula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCedula.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtCajeros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCajeros.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtDireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDireccion.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtDolar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxNumCON.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtFrase_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFrase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtImpuesto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtImpuesto.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtInteres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtInteres.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub VTFax1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles VTFax1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub VTFax2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles VTFax2.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub VTTel1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles VTTel1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub VTTel2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles VTTel2.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CheckBoxUnico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxUnico.CheckedChanged
        If CheckBoxUnico.Checked = True Then
            Me.CheckBoxCredito.Enabled = False
            Me.CheckBoxContado.Enabled = False


            Me.CheckBoxCredito.Checked = False
            Me.CheckBoxContado.Checked = False
            Me.TextBoxNumUnico.Enabled = True
            Me.TextBoxNumCON.Enabled = False
            Me.TextBoxNumCRE.Enabled = False


        Else
            Me.CheckBoxCredito.Enabled = True
            Me.CheckBoxContado.Enabled = True
            Me.TextBoxNumUnico.Enabled = False
            Me.TextBoxNumCON.Enabled = True
            Me.TextBoxNumCRE.Enabled = True

            Me.CheckBoxCredito.Checked = True
            Me.CheckBoxContado.Checked = True

        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            SaveSetting("SeeSOFT", "SeePOs", "ver_vencidas", "SI")
        Else
            SaveSetting("SeeSOFT", "SeePOs", "ver_vencidas", "NO")
        End If
    End Sub

    Sub guardar_permiso()
        Dim datos As New GestioDatos
        Dim consul As String
        Try
            consul = "' , " & Me.cbousuarios.SelectedValue & "' , " & txtclave.Text & "'"
            If existe Then
                datos.Ejecuta("Update permisos set clave = '" & Me.txtclave.Text & "' where usuario = '" & Me.cbousuarios.SelectedValue & "'")
                MsgBox("Se guardo correctamente", MsgBoxStyle.Information, "Guardar")
            Else
                datos.Ejecuta("insert into permisos (usuario,clave) values('" & Me.cbousuarios.SelectedValue & "' , '" & txtclave.Text & "')")
                MsgBox("Se guardo correctamente", MsgBoxStyle.Information, "Guardar")
            End If
           
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
       
    End Sub
    Sub validar()
        If txtclave.Text <> txtclave1.Text Then
            MsgBox("Las claves son diferentes, vuelva a ingresar la contraseña", MsgBoxStyle.Critical)
            txtclave.Text = ""
            txtclave1.Text = ""
            txtclave.Focus()
        Else
            guardar_permiso()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        validar()
    End Sub

    Private Sub cbousuarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbousuarios.SelectedIndexChanged
        Dim dts As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from permisos", dts, CadenaConexionSeePOS)
        Try
            For i As Integer = 0 To dts.Rows.Count - 1
                If dts.Rows(i).Item("usuario") = Me.cbousuarios.SelectedValue Then
                    txtclave.Text = dts.Rows(i).Item("clave")
                    txtclave1.Text = dts.Rows(i).Item("clave")
                    existe = True
                    Me.btneliminar.Visible = True
                    Exit Sub
                End If
            Next
            txtclave.Text = ""
            txtclave1.Text = ""
            Me.btneliminar.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Dim datos As New GestioDatos
        datos.Ejecuta("delete from permisos where usuario = '" & Me.cbousuarios.SelectedValue & "'")
        MsgBox("Se elimino correctamente", MsgBoxStyle.Information, "Guardar")
        txtclave.Text = ""
        txtclave1.Text = ""
    End Sub
End Class
