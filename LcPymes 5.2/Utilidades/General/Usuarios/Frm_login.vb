Imports System.Data
Imports System.Data.SqlClient
Imports System.Threading
Imports System.IO
Imports System.Windows.Forms

Public Class Frm_login
    Inherits System.Windows.Forms.Form

#Region "Variables"
    Public Usuario As New Usuario_Logeado
    Public conectado As Boolean
    Private SubSistema As String
    Dim X As Byte
    Friend tipo As Int16 = 0
    Private conn As New SqlConnection
    Private rdrlogin As SqlDataReader
    Dim contador As Byte
    Friend WithEvents cboPuntoVenta As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Dim objmutex As Mutex
#End Region

#Region " Windows Form Designer generated code "

    Public Sub New(Optional ByVal Sistema As String = "SeePOs")
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call      
        SubSistema = Sistema
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
    Friend WithEvents txt_clave As System.Windows.Forms.TextBox
    Friend WithEvents bttn_salir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Adapter_Usua_Loggin As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSetUsuario_logging1 As DataSetUsuario_logging
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents lnkCambiarContrasena As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents adconfiguracion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_login))
        Me.txt_clave = New System.Windows.Forms.TextBox
        Me.bttn_salir = New DevExpress.XtraEditors.SimpleButton
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.DataSetUsuario_logging1 = New LcPymes_5._2.DataSetUsuario_logging
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Adapter_Usua_Loggin = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.lnkCambiarContrasena = New System.Windows.Forms.LinkLabel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.adconfiguracion = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.cboPuntoVenta = New System.Windows.Forms.ComboBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.DataSetUsuario_logging1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_clave
        '
        Me.txt_clave.BackColor = System.Drawing.SystemColors.Highlight
        Me.txt_clave.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clave.ForeColor = System.Drawing.Color.Transparent
        Me.txt_clave.Location = New System.Drawing.Point(131, 156)
        Me.txt_clave.MaxLength = 10
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_clave.Size = New System.Drawing.Size(204, 25)
        Me.txt_clave.TabIndex = 1
        '
        'bttn_salir
        '
        Me.bttn_salir.Image = CType(resources.GetObject("bttn_salir.Image"), System.Drawing.Image)
        Me.bttn_salir.Location = New System.Drawing.Point(219, 212)
        Me.bttn_salir.Name = "bttn_salir"
        Me.bttn_salir.Size = New System.Drawing.Size(128, 40)
        Me.bttn_salir.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer)))
        Me.bttn_salir.TabIndex = 3
        Me.bttn_salir.Text = "Cancelar"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.Highlight
        Me.ComboBox1.DataSource = Me.DataSetUsuario_logging1
        Me.ComboBox1.DisplayMember = "Usuarios.Nombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Transparent
        Me.ComboBox1.Location = New System.Drawing.Point(131, 116)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(208, 28)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "Usuarios.Cedula"
        '
        'DataSetUsuario_logging1
        '
        Me.DataSetUsuario_logging1.DataSetName = "DataSetUsuario_logging"
        Me.DataSetUsuario_logging1.Locale = New System.Globalization.CultureInfo("es-MX")
        Me.DataSetUsuario_logging1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(-37, 144)
        Me.PictureEdit1.Name = "PictureEdit1"
        '
        '
        '
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.PictureEdit1.Size = New System.Drawing.Size(4, 8)
        Me.PictureEdit1.TabIndex = 15
        Me.PictureEdit1.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.Items.AddRange(New Object() {"(""Local"")"})
        Me.ComboBox2.Location = New System.Drawing.Point(199, 156)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(124, 21)
        Me.ComboBox2.TabIndex = 16
        Me.ComboBox2.Text = "(""Local"")"
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(195, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Engenie"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(736, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 15)
        Me.Label2.TabIndex = 18
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""DESKTOP-T96OM6J"";packet size=4096;integrated security=SSPI;data s" & _
            "ource=""DESKTOP-T96OM6J\DESARROLLO"";persist security info=False;initial catalog=s" & _
            "eepos"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'Adapter_Usua_Loggin
        '
        Me.Adapter_Usua_Loggin.SelectCommand = Me.SqlSelectCommand1
        Me.Adapter_Usua_Loggin.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Entrada", "Clave_Entrada"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna"), New System.Data.Common.DataColumnMapping("Foto", "Foto"), New System.Data.Common.DataColumnMapping("CambiarPrecio", "CambiarPrecio"), New System.Data.Common.DataColumnMapping("Porc_Precio", "Porc_Precio"), New System.Data.Common.DataColumnMapping("Aplicar_Desc", "Aplicar_Desc"), New System.Data.Common.DataColumnMapping("Porc_Desc", "Porc_Desc"), New System.Data.Common.DataColumnMapping("Exist_Negativa", "Exist_Negativa")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Id_Usuario AS Cedula, Nombre, Clave_Entrada, Clave_Interna, Foto, CambiarP" & _
            "recio, Porc_Precio, Aplicar_Desc, Porc_Desc, Exist_Negativa FROM Usuarios where Fuera = 0"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'lnkCambiarContrasena
        '
        Me.lnkCambiarContrasena.BackColor = System.Drawing.Color.Transparent
        Me.lnkCambiarContrasena.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkCambiarContrasena.LinkColor = System.Drawing.Color.White
        Me.lnkCambiarContrasena.Location = New System.Drawing.Point(128, 184)
        Me.lnkCambiarContrasena.Name = "lnkCambiarContrasena"
        Me.lnkCambiarContrasena.Size = New System.Drawing.Size(141, 16)
        Me.lnkCambiarContrasena.TabIndex = 21
        Me.lnkCambiarContrasena.TabStop = True
        Me.lnkCambiarContrasena.Text = "Cambiar contraseña"
        Me.lnkCambiarContrasena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Crimson
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(120, 8)
        Me.Panel1.TabIndex = 22
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SlateBlue
        Me.Panel4.Location = New System.Drawing.Point(44, 36)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(120, 8)
        Me.Panel4.TabIndex = 25
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel5.Location = New System.Drawing.Point(160, 36)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(120, 8)
        Me.Panel5.TabIndex = 26
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel6.Location = New System.Drawing.Point(280, 36)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(124, 8)
        Me.Panel6.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel2.Location = New System.Drawing.Point(120, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(120, 8)
        Me.Panel2.TabIndex = 23
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel3.Location = New System.Drawing.Point(240, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(124, 8)
        Me.Panel3.TabIndex = 24
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Controls.Add(Me.Panel10)
        Me.Panel7.Location = New System.Drawing.Point(364, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(120, 8)
        Me.Panel7.TabIndex = 26
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.SlateBlue
        Me.Panel8.Location = New System.Drawing.Point(44, 36)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(120, 8)
        Me.Panel8.TabIndex = 25
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel9.Location = New System.Drawing.Point(160, 36)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(120, 8)
        Me.Panel9.TabIndex = 26
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel10.Location = New System.Drawing.Point(280, 36)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(124, 8)
        Me.Panel10.TabIndex = 27
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel11.Location = New System.Drawing.Point(484, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(120, 8)
        Me.Panel11.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(11, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(412, 28)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Bienvenido"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(83, 112)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 32)
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(83, 148)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(36, 32)
        Me.PictureBox3.TabIndex = 33
        Me.PictureBox3.TabStop = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(87, 212)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(128, 40)
        Me.SimpleButton1.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer)))
        Me.SimpleButton1.TabIndex = 34
        Me.SimpleButton1.Text = "Entrar"
        '
        'adconfiguracion
        '
        Me.adconfiguracion.DeleteCommand = Me.SqlDeleteCommand1
        Me.adconfiguracion.InsertCommand = Me.SqlInsertCommand1
        Me.adconfiguracion.SelectCommand = Me.SqlSelectCommand2
        Me.adconfiguracion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "configuraciones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Empresa", "Empresa"), New System.Data.Common.DataColumnMapping("Tel_01", "Tel_01"), New System.Data.Common.DataColumnMapping("Tel_02", "Tel_02"), New System.Data.Common.DataColumnMapping("Fax_01", "Fax_01"), New System.Data.Common.DataColumnMapping("Fax_02", "Fax_02"), New System.Data.Common.DataColumnMapping("Direccion", "Direccion"), New System.Data.Common.DataColumnMapping("Imp_Venta", "Imp_Venta"), New System.Data.Common.DataColumnMapping("Frase", "Frase"), New System.Data.Common.DataColumnMapping("Cajeros", "Cajeros"), New System.Data.Common.DataColumnMapping("Logo", "Logo"), New System.Data.Common.DataColumnMapping("Intereses", "Intereses"), New System.Data.Common.DataColumnMapping("UnicoConsecutivo", "UnicoConsecutivo"), New System.Data.Common.DataColumnMapping("NumeroConsecutivo", "NumeroConsecutivo"), New System.Data.Common.DataColumnMapping("ConsContado", "ConsContado"), New System.Data.Common.DataColumnMapping("NumeroContado", "NumeroContado"), New System.Data.Common.DataColumnMapping("ConsCredito", "ConsCredito"), New System.Data.Common.DataColumnMapping("NumeroCredito", "NumeroCredito"), New System.Data.Common.DataColumnMapping("ConsPuntoVenta", "ConsPuntoVenta"), New System.Data.Common.DataColumnMapping("NumeroPuntoVenta", "NumeroPuntoVenta"), New System.Data.Common.DataColumnMapping("Taller", "Taller"), New System.Data.Common.DataColumnMapping("TallerContado", "TallerContado"), New System.Data.Common.DataColumnMapping("TallerCredito", "TallerCredito"), New System.Data.Common.DataColumnMapping("Imprimir_en_Factura_Personalizada", "Imprimir_en_Factura_Personalizada"), New System.Data.Common.DataColumnMapping("FormatoCheck", "FormatoCheck"), New System.Data.Common.DataColumnMapping("Contabilidad", "Contabilidad"), New System.Data.Common.DataColumnMapping("CambiaPrecioCredito", "CambiaPrecioCredito"), New System.Data.Common.DataColumnMapping("Mascotas", "Mascotas"), New System.Data.Common.DataColumnMapping("MascotasContado", "MascotasContado"), New System.Data.Common.DataColumnMapping("MascotasCredito", "MascotasCredito"), New System.Data.Common.DataColumnMapping("regalias", "regalias")})})
        Me.adconfiguracion.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cajeros", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cajeros", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CambiaPrecioCredito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CambiaPrecioCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ConsContado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ConsContado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ConsCredito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ConsCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ConsPuntoVenta", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ConsPuntoVenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contabilidad", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Empresa", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Empresa", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fax_01", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax_01", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fax_02", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax_02", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FormatoCheck", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormatoCheck", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Frase", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Frase", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Imp_Venta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imp_Venta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Imprimir_en_Factura_Personalizada", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imprimir_en_Factura_Personalizada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Intereses", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Intereses", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mascotas", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mascotas", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MascotasContado", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MascotasContado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MascotasCredito", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MascotasCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumeroConsecutivo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroConsecutivo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumeroContado", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroContado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumeroCredito", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumeroPuntoVenta", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroPuntoVenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Taller", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Taller", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TallerContado", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TallerContado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TallerCredito", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TallerCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tel_01", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tel_01", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tel_02", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tel_02", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnicoConsecutivo", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UnicoConsecutivo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_regalias", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "regalias", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 255, "Cedula"), New System.Data.SqlClient.SqlParameter("@Empresa", System.Data.SqlDbType.VarChar, 255, "Empresa"), New System.Data.SqlClient.SqlParameter("@Tel_01", System.Data.SqlDbType.VarChar, 255, "Tel_01"), New System.Data.SqlClient.SqlParameter("@Tel_02", System.Data.SqlDbType.VarChar, 255, "Tel_02"), New System.Data.SqlClient.SqlParameter("@Fax_01", System.Data.SqlDbType.VarChar, 255, "Fax_01"), New System.Data.SqlClient.SqlParameter("@Fax_02", System.Data.SqlDbType.VarChar, 255, "Fax_02"), New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 255, "Direccion"), New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 8, "Imp_Venta"), New System.Data.SqlClient.SqlParameter("@Frase", System.Data.SqlDbType.VarChar, 255, "Frase"), New System.Data.SqlClient.SqlParameter("@Cajeros", System.Data.SqlDbType.Int, 4, "Cajeros"), New System.Data.SqlClient.SqlParameter("@Logo", System.Data.SqlDbType.VarBinary, 2147483647, "Logo"), New System.Data.SqlClient.SqlParameter("@Intereses", System.Data.SqlDbType.Int, 4, "Intereses"), New System.Data.SqlClient.SqlParameter("@UnicoConsecutivo", System.Data.SqlDbType.Bit, 1, "UnicoConsecutivo"), New System.Data.SqlClient.SqlParameter("@NumeroConsecutivo", System.Data.SqlDbType.BigInt, 8, "NumeroConsecutivo"), New System.Data.SqlClient.SqlParameter("@ConsContado", System.Data.SqlDbType.Bit, 1, "ConsContado"), New System.Data.SqlClient.SqlParameter("@NumeroContado", System.Data.SqlDbType.BigInt, 8, "NumeroContado"), New System.Data.SqlClient.SqlParameter("@ConsCredito", System.Data.SqlDbType.Bit, 1, "ConsCredito"), New System.Data.SqlClient.SqlParameter("@NumeroCredito", System.Data.SqlDbType.BigInt, 8, "NumeroCredito"), New System.Data.SqlClient.SqlParameter("@ConsPuntoVenta", System.Data.SqlDbType.Bit, 1, "ConsPuntoVenta"), New System.Data.SqlClient.SqlParameter("@NumeroPuntoVenta", System.Data.SqlDbType.BigInt, 8, "NumeroPuntoVenta"), New System.Data.SqlClient.SqlParameter("@Taller", System.Data.SqlDbType.Bit, 1, "Taller"), New System.Data.SqlClient.SqlParameter("@TallerContado", System.Data.SqlDbType.BigInt, 8, "TallerContado"), New System.Data.SqlClient.SqlParameter("@TallerCredito", System.Data.SqlDbType.BigInt, 8, "TallerCredito"), New System.Data.SqlClient.SqlParameter("@Imprimir_en_Factura_Personalizada", System.Data.SqlDbType.Bit, 1, "Imprimir_en_Factura_Personalizada"), New System.Data.SqlClient.SqlParameter("@FormatoCheck", System.Data.SqlDbType.Bit, 1, "FormatoCheck"), New System.Data.SqlClient.SqlParameter("@Contabilidad", System.Data.SqlDbType.Bit, 1, "Contabilidad"), New System.Data.SqlClient.SqlParameter("@CambiaPrecioCredito", System.Data.SqlDbType.Bit, 1, "CambiaPrecioCredito"), New System.Data.SqlClient.SqlParameter("@Mascotas", System.Data.SqlDbType.Bit, 1, "Mascotas"), New System.Data.SqlClient.SqlParameter("@MascotasContado", System.Data.SqlDbType.BigInt, 8, "MascotasContado"), New System.Data.SqlClient.SqlParameter("@MascotasCredito", System.Data.SqlDbType.BigInt, 8, "MascotasCredito"), New System.Data.SqlClient.SqlParameter("@regalias", System.Data.SqlDbType.Bit, 1, "regalias")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 255, "Cedula"), New System.Data.SqlClient.SqlParameter("@Empresa", System.Data.SqlDbType.VarChar, 255, "Empresa"), New System.Data.SqlClient.SqlParameter("@Tel_01", System.Data.SqlDbType.VarChar, 255, "Tel_01"), New System.Data.SqlClient.SqlParameter("@Tel_02", System.Data.SqlDbType.VarChar, 255, "Tel_02"), New System.Data.SqlClient.SqlParameter("@Fax_01", System.Data.SqlDbType.VarChar, 255, "Fax_01"), New System.Data.SqlClient.SqlParameter("@Fax_02", System.Data.SqlDbType.VarChar, 255, "Fax_02"), New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 255, "Direccion"), New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 8, "Imp_Venta"), New System.Data.SqlClient.SqlParameter("@Frase", System.Data.SqlDbType.VarChar, 255, "Frase"), New System.Data.SqlClient.SqlParameter("@Cajeros", System.Data.SqlDbType.Int, 4, "Cajeros"), New System.Data.SqlClient.SqlParameter("@Logo", System.Data.SqlDbType.VarBinary, 2147483647, "Logo"), New System.Data.SqlClient.SqlParameter("@Intereses", System.Data.SqlDbType.Int, 4, "Intereses"), New System.Data.SqlClient.SqlParameter("@UnicoConsecutivo", System.Data.SqlDbType.Bit, 1, "UnicoConsecutivo"), New System.Data.SqlClient.SqlParameter("@NumeroConsecutivo", System.Data.SqlDbType.BigInt, 8, "NumeroConsecutivo"), New System.Data.SqlClient.SqlParameter("@ConsContado", System.Data.SqlDbType.Bit, 1, "ConsContado"), New System.Data.SqlClient.SqlParameter("@NumeroContado", System.Data.SqlDbType.BigInt, 8, "NumeroContado"), New System.Data.SqlClient.SqlParameter("@ConsCredito", System.Data.SqlDbType.Bit, 1, "ConsCredito"), New System.Data.SqlClient.SqlParameter("@NumeroCredito", System.Data.SqlDbType.BigInt, 8, "NumeroCredito"), New System.Data.SqlClient.SqlParameter("@ConsPuntoVenta", System.Data.SqlDbType.Bit, 1, "ConsPuntoVenta"), New System.Data.SqlClient.SqlParameter("@NumeroPuntoVenta", System.Data.SqlDbType.BigInt, 8, "NumeroPuntoVenta"), New System.Data.SqlClient.SqlParameter("@Taller", System.Data.SqlDbType.Bit, 1, "Taller"), New System.Data.SqlClient.SqlParameter("@TallerContado", System.Data.SqlDbType.BigInt, 8, "TallerContado"), New System.Data.SqlClient.SqlParameter("@TallerCredito", System.Data.SqlDbType.BigInt, 8, "TallerCredito"), New System.Data.SqlClient.SqlParameter("@Imprimir_en_Factura_Personalizada", System.Data.SqlDbType.Bit, 1, "Imprimir_en_Factura_Personalizada"), New System.Data.SqlClient.SqlParameter("@FormatoCheck", System.Data.SqlDbType.Bit, 1, "FormatoCheck"), New System.Data.SqlClient.SqlParameter("@Contabilidad", System.Data.SqlDbType.Bit, 1, "Contabilidad"), New System.Data.SqlClient.SqlParameter("@CambiaPrecioCredito", System.Data.SqlDbType.Bit, 1, "CambiaPrecioCredito"), New System.Data.SqlClient.SqlParameter("@Mascotas", System.Data.SqlDbType.Bit, 1, "Mascotas"), New System.Data.SqlClient.SqlParameter("@MascotasContado", System.Data.SqlDbType.BigInt, 8, "MascotasContado"), New System.Data.SqlClient.SqlParameter("@MascotasCredito", System.Data.SqlDbType.BigInt, 8, "MascotasCredito"), New System.Data.SqlClient.SqlParameter("@regalias", System.Data.SqlDbType.Bit, 1, "regalias"), New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cajeros", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cajeros", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CambiaPrecioCredito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CambiaPrecioCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ConsContado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ConsContado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ConsCredito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ConsCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ConsPuntoVenta", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ConsPuntoVenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contabilidad", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Empresa", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Empresa", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fax_01", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax_01", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fax_02", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax_02", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FormatoCheck", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormatoCheck", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Frase", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Frase", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Imp_Venta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imp_Venta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Imprimir_en_Factura_Personalizada", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imprimir_en_Factura_Personalizada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Intereses", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Intereses", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mascotas", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mascotas", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MascotasContado", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MascotasContado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MascotasCredito", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MascotasCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumeroConsecutivo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroConsecutivo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumeroContado", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroContado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumeroCredito", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumeroPuntoVenta", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroPuntoVenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Taller", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Taller", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TallerContado", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TallerContado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TallerCredito", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TallerCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tel_01", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tel_01", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tel_02", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tel_02", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnicoConsecutivo", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UnicoConsecutivo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_regalias", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "regalias", System.Data.DataRowVersion.Original, Nothing)})
        '
        'cboPuntoVenta
        '
        Me.cboPuntoVenta.BackColor = System.Drawing.SystemColors.Highlight
        Me.cboPuntoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPuntoVenta.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPuntoVenta.ForeColor = System.Drawing.Color.Transparent
        Me.cboPuntoVenta.Location = New System.Drawing.Point(131, 73)
        Me.cboPuntoVenta.Name = "cboPuntoVenta"
        Me.cboPuntoVenta.Size = New System.Drawing.Size(208, 28)
        Me.cboPuntoVenta.TabIndex = 35
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.LcPymes_5._2.My.Resources.Resources.if_18_330400
        Me.PictureBox1.Location = New System.Drawing.Point(84, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 32)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'Frm_login
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(428, 288)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cboPuntoVenta)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_clave)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lnkCambiarContrasena)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.bttn_salir)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_login"
        Me.Opacity = 0.99
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Veterinaria"
        CType(Me.DataSetUsuario_logging1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Load"
    Private Sub Frm_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.CargarPuntosdeVenta()
            Dim SystemNormal As String = GetSetting("SeeSOFT", "SeePOS", "SystemNormal")

            Me.SqlConnection1.ConnectionString = CadenaConexionSeguridad()
            Me.Adapter_Usua_Loggin.Fill(Me.DataSetUsuario_logging1, "Usuarios")

            Me.SqlConnection1.ConnectionString = GetSetting("SeeSOFT", SubSistema, "Conexion")
            Me.adconfiguracion.Fill(Me.DataSetUsuario_logging1, "configuraciones")
            ComboBox1.Text = GetSetting("SeeSOFT", "Seguridad", "LastUser")
            Dim dts As New DataTable
            cFunciones.Llenar_Tabla_Generico("select * from configuraciones", dts, CadenaConexionSeePOS)
            Label3.Text = dts.Rows(0).Item("empresa")

            'objmutex = New Mutex(False, "SINGLE_INSTANCE_APP_MUTEX")
            'If objmutex.WaitOne(0, False) = False Then
            '    objmutex.Close()
            '    objmutex = Nothing
            '    MessageBox.Show("Hay una instancia de la aplicación corriendo actualmente.  El módulo se desactivará", "Sistema SeePos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Exit Sub
            'End If

        Catch ex As SystemException
            MsgBox(ex.Message)

            If MsgBox("Desea realizar un diagnostico de conexion.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Error al iniciar") = MsgBoxResult.Yes Then
                Dim frm As New frmBuscarConexion
                frm.ShowDialog()
            End If
        End Try
    End Sub
#End Region

#Region "Controles funciones"
    Private Sub txt_clave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_clave.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Loggin_Usuario() Then
                Me.CambiarPuntodeVenta()
                Me.Close()
                conectado = True
            End If
        End If
    End Sub

    Private Sub bttn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmmain As New MainForm
        If Loggin_Usuario() Then
            Me.Close()
            conectado = True
        Else
            conectado = False
        End If
    End Sub

    Private Sub bttn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_salir.Click
        conectado = False
        Me.Close()
    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_clave.Focus()
        End If
    End Sub

    Private Sub txt_clave_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_clave.GotFocus
        txt_clave.SelectAll()
    End Sub
#End Region

#Region "Loggin_Usuario"
    Function Loggin_Usuario() As Boolean
        Try
            If Me.BindingContext(Me.DataSetUsuario_logging1.Usuarios).Count > 0 Then
                Dim Usuario_autorizadores() As System.Data.DataRow
                Dim Usua As System.Data.DataRow
                Usuario_autorizadores = Me.DataSetUsuario_logging1.Usuarios.Select("Clave_Entrada = '" & txt_clave.Text & "' And Nombre = '" & Me.ComboBox1.Text & "'")
                If Usuario_autorizadores.Length <> 0 Then
                    Usua = Usuario_autorizadores(0)
                    Usuario.Cedula = Usua("Cedula")
                    Usuario.Nombre = Usua("Nombre")
                    Usuario.Clave_Entrada = Usua("Clave_Entrada")
                    Usuario.Clave_Interna = Usua("Clave_Interna")
                    Usuario.CambiarPrecio = Usua("CambiarPrecio")
                    Usuario.Porc_Precio = Usua("Porc_Precio")
                    Usuario.Aplicar_Desc = Usua("Aplicar_Desc")
                    Usuario.Porc_Desc = Usua("Porc_Desc")
                    Usuario.Exist_Negativa = Usua("Exist_Negativa")
                    SaveSetting("SeeSOFT", "Seguridad", "LastUser", ComboBox1.Text)
                    Me.DialogResult = DialogResult.OK
                    Return True
                Else ' si no existe una contraseñla como esta
                    MsgBox("Clave Entrada incorrecta", MsgBoxStyle.Exclamation)
                    txt_clave.Text = ""
                    txt_clave.Focus()
                    Return False
                End If
            Else
                MsgBox("No Existen Usuarios, ingrese datos")
                Return False
                txt_clave.Focus()
            End If
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function
#End Region

#Region "Cambiar Contraseña"
    Private Sub lnkCambiarContrasena_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCambiarContrasena.LinkClicked
        Dim frmCambiarContrasena As New frmCambioContrasena
        frmCambiarContrasena.IdUsuario = DataSetUsuario_logging1.Usuarios(Me.ComboBox1.SelectedIndex).Cedula
        frmCambiarContrasena.ContrasenaActual = Me.txt_clave.Text
        frmCambiarContrasena.ShowDialog()
        Me.Adapter_Usua_Loggin.Fill(Me.DataSetUsuario_logging1, "Usuarios")
    End Sub
#End Region

    Private Sub txt_clave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_clave.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Loggin_Usuario() Then
            Me.Close()
            conectado = True
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If Loggin_Usuario() Then
            Me.CambiarPuntodeVenta()
            Me.Close()
            conectado = True
        Else
            conectado = False
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private PuntosdeVenta As DataTable
    Private Servidor As String = ""
    Public BasedeDatos As String = ""
    Private CadenaConexion As String = ""
    Public Descripcion As String = ""
    Private UsuarioDB As String = ""
    Private ClaveDB As String = ""

    Private Function BuscaDatos(ByVal _Texto As String) As String
        Dim Resultado As String = ""
        Dim inicia As Boolean = False
        For Each c As Char In _Texto
            If inicia = True Then
                If c <> ";" Then
                    Resultado += c
                End If
            End If
            If c = "=" Then inicia = True
        Next
        Return Resultado
    End Function

    Private Sub CargarPuntosdeVenta()

        If GetSetting("SeeSOFT", "SeePOS", regeditSegura) = "" Then
            SaveSetting("SeeSOFT", "SeePOS", regeditSegura, "0")
        End If

        Dim db As New GestioDatos
        Dim SystemNormal As String = GetSetting("SeeSOFT", "SeePOS", regeditSegura)

       
        Dim Conexion() As String = CadenaConexionSeePOS.Split(";")
        Me.Servidor = Me.BuscaDatos(Conexion(0))
        Me.BasedeDatos = Me.BuscaDatos(Conexion(1))
        Try
            If CadenaConexionSeePOS.Contains("Integrated Security=true") = False Then
                Me.UsuarioDB = Me.BuscaDatos(Conexion(2))
                Me.ClaveDB = Me.BuscaDatos(Conexion(3))
            Else
                Me.UsuarioDB = ""
                Me.ClaveDB = ""
            End If
        Catch ex As Exception
        End Try
        
        If GetRegistroSeePOS("VeTodosPVE") = "1" Then
            Me.PuntosdeVenta = db.Ejecuta("Select IdPuntoVenta, PuntoVenta, BasedeDatos, Descripcion, Mascota, Taller From " & TablaSeguridad() & ".dbo.PuntodeVenta Where Relacion In(Select Relacion from " & TablaSeguridad() & ".dbo.PuntodeVenta where BasedeDatos = '" & Me.BasedeDatos & "') order by PuntoVenta")
        Else
            If SystemNormal = "1" Then
                'carga todos los pntos de venta
                Me.PuntosdeVenta = db.Ejecuta("Select IdPuntoVenta, PuntoVenta, BasedeDatos, Descripcion, Mascota, Taller From " & TablaSeguridad() & ".dbo.PuntodeVenta order by PuntoVenta")
            Else
                'solo carga los puntos de venta relacionadas
                Me.PuntosdeVenta = db.Ejecuta("Select IdPuntoVenta, PuntoVenta, BasedeDatos, Descripcion, Mascota, Taller From " & TablaSeguridad() & ".dbo.PuntodeVenta Where Relacion In(Select Relacion from " & TablaSeguridad() & ".dbo.PuntodeVenta where BasedeDatos = '" & Me.BasedeDatos & "') order by PuntoVenta")
            End If
        End If

        If Not Me.PuntosdeVenta.Rows.Count > 1 Then
            Me.cboPuntoVenta.Enabled = False
        End If

        Me.cboPuntoVenta.DataSource = Me.PuntosdeVenta
        Me.cboPuntoVenta.ValueMember = "IdPuntoVenta"
        Me.cboPuntoVenta.DisplayMember = "PuntoVenta"

        Dim Fila() As DataRow
        Fila = Me.PuntosdeVenta.Select("BasedeDatos = '" & Me.BasedeDatos & "'")
        Me.cboPuntoVenta.Text = Fila(0).Item("PuntoVenta")
    End Sub

    Private Sub CambiarPuntodeVenta()
        Dim Fila() As DataRow
        Fila = Me.PuntosdeVenta.Select("IdPuntoVenta = " & Me.cboPuntoVenta.SelectedValue)
        Me.BasedeDatos = Fila(0).Item("BasedeDatos")
        Me.Descripcion = Fila(0).Item("Descripcion")

        If Me.UsuarioDB = "" Then
            Me.CadenaConexion = "Data Source=" & Me.Servidor & "; Initial Catalog=" & BasedeDatos & "; Integrated Security=true;"
        Else
            Me.CadenaConexion = "Data Source=" & Me.Servidor & "; Initial Catalog=" & BasedeDatos & "; User Id=" & Me.UsuarioDB & ";Password=" & Me.ClaveDB & ";"
        End If

        SaveSetting("SeeSOFT", "SeePOs", "Conexion", CadenaConexion)
        SaveSetting("Hotel", "Hotel", "Conexion", CadenaConexion)
        SaveSetting("SeeSOFT", "SeePOs", "empresa", Me.Descripcion)
        SaveSetting("SeeSOFT", "SeePOs", "sistema_mascotas", Fila(0).Item("Mascota"))
        SaveSetting("SeeSOFT", "SeePOs", "sistema_taller", Fila(0).Item("Taller"))
    End Sub

End Class
