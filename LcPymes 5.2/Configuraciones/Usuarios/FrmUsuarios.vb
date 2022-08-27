Imports System.Data
Imports System.data.sqlclient
Imports System.Windows.Forms
Public Class Frmusuario
    Inherits FrmPlantilla

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        ' Me.PictureEdit1.DataBindings.Add(New Binding("EditValue", Me.DatasetUsuario1, "Usuarios.Foto"))
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


    Public WithEvents TextBox2 As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents TextBox3 As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents TextBox4 As System.Windows.Forms.TextBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    'Public WithEvents TextBox5 As System.Windows.Forms.TextBox
    'Public WithEvents TextBox6 As System.Windows.Forms.TextBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxPerfilUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterUsuario As System.Data.SqlClient.SqlDataAdapter
    'Friend WithEvents DataSetUsuario As Hotel.DataSetUsuario_logging
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Public WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataNavigator1 As DevExpress.XtraEditors.DataNavigator
    Public WithEvents TextBox7 As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DatasetUsuario1 As DatasetUsuario
    Public WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AdapterPerfil As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents btnAgregarPerfil As System.Windows.Forms.Button
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterPerfilxUsuario As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents colId_Perfil As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents TxtDescuentoPorcentaje As DevExpress.XtraEditors.TextEdit
    Public WithEvents TxtCambioPrecioPorcentaje As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Public WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frmusuario))
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ComboBoxPerfilUsuario = New System.Windows.Forms.ComboBox
        Me.DatasetUsuario1 = New LcPymes_5._2.DatasetUsuario
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.AdapterUsuario = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider
        Me.Label3 = New System.Windows.Forms.Label
        Me.DataNavigator1 = New DevExpress.XtraEditors.DataNavigator
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.AdapterPerfil = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.btnAgregarPerfil = New System.Windows.Forms.Button
        Me.AdapterPerfilxUsuario = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colId_Perfil = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label10 = New System.Windows.Forms.Label
        Me.CheckBox6 = New System.Windows.Forms.CheckBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtDescuentoPorcentaje = New DevExpress.XtraEditors.TextEdit
        Me.TxtCambioPrecioPorcentaje = New DevExpress.XtraEditors.TextEdit
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        CType(Me.DatasetUsuario1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TxtDescuentoPorcentaje.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCambioPrecioPorcentaje.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBarExcel
        '
        Me.ToolBarExcel.Text = "Inhabilitar"
        '
        'ToolBar1
        '
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 216)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(522, 56)
        Me.ToolBar1.TabIndex = 7
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.ImageIndex = 3
        Me.ToolBarImprimir.Text = "Eliminar"
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.Location = New System.Drawing.Point(656, 744)
        Me.DataNavigator.Name = "DataNavigator"
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(522, 32)
        Me.TituloModulo.Text = "              Registros Usuarios"
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.ImageIndex = 1
        Me.ToolBarEliminar.Text = "Buscar"
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.ImageIndex = 9
        Me.ToolBarBuscar.Text = "Editar"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Blue
        Me.TextBox1.Location = New System.Drawing.Point(72, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(88, 13)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Blue
        Me.TextBox2.Location = New System.Drawing.Point(96, 56)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(336, 13)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(96, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 12)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Nombre Completo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox3
        '
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.TextBox3.ForeColor = System.Drawing.Color.Blue
        Me.TextBox3.Location = New System.Drawing.Point(96, 88)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TextBox3.Size = New System.Drawing.Size(104, 20)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.Text = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(96, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 12)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Clave de Acceso"
        '
        'TextBox4
        '
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.TextBox4.ForeColor = System.Drawing.Color.Blue
        Me.TextBox4.Location = New System.Drawing.Point(208, 88)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TextBox4.Size = New System.Drawing.Size(104, 20)
        Me.TextBox4.TabIndex = 4
        Me.TextBox4.Text = ""
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(208, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 12)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Clave de Interna"
        '
        'ComboBoxPerfilUsuario
        '
        Me.ComboBoxPerfilUsuario.DataSource = Me.DatasetUsuario1
        Me.ComboBoxPerfilUsuario.DisplayMember = "Perfil.Nombre_Perfil"
        Me.ComboBoxPerfilUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPerfilUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPerfilUsuario.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ComboBoxPerfilUsuario.Location = New System.Drawing.Point(336, 88)
        Me.ComboBoxPerfilUsuario.Name = "ComboBoxPerfilUsuario"
        Me.ComboBoxPerfilUsuario.Size = New System.Drawing.Size(144, 21)
        Me.ComboBoxPerfilUsuario.TabIndex = 5
        Me.ComboBoxPerfilUsuario.ValueMember = "Perfil.Id_Perfil"
        '
        'DatasetUsuario1
        '
        Me.DatasetUsuario1.DataSetName = "DatasetUsuario"
        Me.DatasetUsuario1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(336, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 12)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Perfil de Acceso"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Location = New System.Drawing.Point(3, 34)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Size = New System.Drawing.Size(88, 80)
        Me.PictureEdit1.TabIndex = 6
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=NEMESIS;packet size=4096;integrated security=SSPI;data source=""."";" & _
        "persist security info=False;initial catalog=Seguridad"
        '
        'AdapterUsuario
        '
        Me.AdapterUsuario.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterUsuario.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterUsuario.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterUsuario.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Usuario", "Id_Usuario"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Entrada", "Clave_Entrada"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna"), New System.Data.Common.DataColumnMapping("Foto", "Foto"), New System.Data.Common.DataColumnMapping("Iniciales", "Iniciales"), New System.Data.Common.DataColumnMapping("CambiarPrecio", "CambiarPrecio"), New System.Data.Common.DataColumnMapping("Porc_Precio", "Porc_Precio"), New System.Data.Common.DataColumnMapping("Aplicar_Desc", "Aplicar_Desc"), New System.Data.Common.DataColumnMapping("Porc_Desc", "Porc_Desc"), New System.Data.Common.DataColumnMapping("Exist_Negativa", "Exist_Negativa")})})
        Me.AdapterUsuario.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Usuarios WHERE (Id_Usuario = @Original_Id_Usuario) AND (Aplicar_Desc " & _
        "= @Original_Aplicar_Desc) AND (CambiarPrecio = @Original_CambiarPrecio) AND (Cla" & _
        "ve_Entrada = @Original_Clave_Entrada) AND (Clave_Interna = @Original_Clave_Inter" & _
        "na) AND (Exist_Negativa = @Original_Exist_Negativa) AND (Iniciales = @Original_I" & _
        "niciales) AND (Nombre = @Original_Nombre) AND (Porc_Desc = @Original_Porc_Desc) " & _
        "AND (Porc_Precio = @Original_Porc_Precio)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Aplicar_Desc", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Aplicar_Desc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CambiarPrecio", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CambiarPrecio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Clave_Entrada", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Clave_Entrada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Clave_Interna", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Clave_Interna", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Exist_Negativa", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exist_Negativa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Iniciales", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Iniciales", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porc_Desc", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porc_Desc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porc_Precio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porc_Precio", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Usuarios(Id_Usuario, Nombre, Clave_Entrada, Clave_Interna, Foto, Inic" & _
        "iales, CambiarPrecio, Porc_Precio, Aplicar_Desc, Porc_Desc, Exist_Negativa) VALU" & _
        "ES (@Id_Usuario, @Nombre, @Clave_Entrada, @Clave_Interna, @Foto, @Iniciales, @Ca" & _
        "mbiarPrecio, @Porc_Precio, @Aplicar_Desc, @Porc_Desc, @Exist_Negativa); SELECT I" & _
        "d_Usuario, Nombre, Clave_Entrada, Clave_Interna, Foto, Iniciales, CambiarPrecio," & _
        " Porc_Precio, Aplicar_Desc, Porc_Desc, Exist_Negativa FROM Usuarios WHERE (Id_Us" & _
        "uario = @Id_Usuario)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Usuario", System.Data.SqlDbType.VarChar, 50, "Id_Usuario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Clave_Entrada", System.Data.SqlDbType.VarChar, 30, "Clave_Entrada"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Clave_Interna", System.Data.SqlDbType.VarChar, 30, "Clave_Interna"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Foto", System.Data.SqlDbType.VarBinary, 2147483647, "Foto"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Iniciales", System.Data.SqlDbType.VarChar, 4, "Iniciales"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CambiarPrecio", System.Data.SqlDbType.Bit, 1, "CambiarPrecio"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porc_Precio", System.Data.SqlDbType.Float, 8, "Porc_Precio"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Aplicar_Desc", System.Data.SqlDbType.Bit, 1, "Aplicar_Desc"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porc_Desc", System.Data.SqlDbType.Float, 8, "Porc_Desc"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Exist_Negativa", System.Data.SqlDbType.Bit, 1, "Exist_Negativa"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Id_Usuario, Nombre, Clave_Entrada, Clave_Interna, Foto, Iniciales, Cambiar" & _
        "Precio, Porc_Precio, Aplicar_Desc, Porc_Desc, Exist_Negativa FROM Usuarios"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Usuarios SET Nombre = @Nombre, Clave_Entrada = @Clave_Entrada, Clave_Inter" & _
        "na = @Clave_Interna, Foto = @Foto, Iniciales = @Iniciales, CambiarPrecio = @Camb" & _
        "iarPrecio, Porc_Precio = @Porc_Precio, Aplicar_Desc = @Aplicar_Desc, Porc_Desc =" & _
        " @Porc_Desc, Exist_Negativa = @Exist_Negativa WHERE (Id_Usuario = @Original_Id_U" & _
        "suario); SELECT Id_Usuario, Nombre, Clave_Entrada, Clave_Interna, Foto, Iniciale" & _
        "s, CambiarPrecio, Porc_Precio, Aplicar_Desc, Porc_Desc, Exist_Negativa FROM Usua" & _
        "rios WHERE (Id_Usuario = @Id_Usuario)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Clave_Entrada", System.Data.SqlDbType.VarChar, 30, "Clave_Entrada"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Clave_Interna", System.Data.SqlDbType.VarChar, 30, "Clave_Interna"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Foto", System.Data.SqlDbType.VarBinary, 16, "Foto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Iniciales", System.Data.SqlDbType.VarChar, 4, "Iniciales"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CambiarPrecio", System.Data.SqlDbType.Bit, 1, "CambiarPrecio"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porc_Precio", System.Data.SqlDbType.Float, 8, "Porc_Precio"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Aplicar_Desc", System.Data.SqlDbType.Bit, 1, "Aplicar_Desc"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porc_Desc", System.Data.SqlDbType.Float, 8, "Porc_Desc"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Exist_Negativa", System.Data.SqlDbType.Bit, 1, "Exist_Negativa"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Usuario", System.Data.SqlDbType.VarChar, 50, "Id_Usuario"))
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(0, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 12)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Id Usuario"
        '
        'DataNavigator1
        '
        Me.DataNavigator1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataNavigator1.Buttons.Append.Visible = False
        Me.DataNavigator1.Buttons.CancelEdit.Visible = False
        Me.DataNavigator1.Buttons.EndEdit.Visible = False
        Me.DataNavigator1.Buttons.Remove.Visible = False
        Me.DataNavigator1.DataMember = "Usuarios"
        Me.DataNavigator1.DataSource = Me.DatasetUsuario1
        Me.DataNavigator1.Location = New System.Drawing.Point(360, 232)
        Me.DataNavigator1.Name = "DataNavigator1"
        Me.DataNavigator1.Size = New System.Drawing.Size(134, 24)
        Me.DataNavigator1.TabIndex = 8
        Me.DataNavigator1.Text = "DataNavigator1"
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.ForeColor = System.Drawing.Color.Blue
        Me.TextBox7.Location = New System.Drawing.Point(440, 56)
        Me.TextBox7.MaxLength = 3
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(72, 13)
        Me.TextBox7.TabIndex = 2
        Me.TextBox7.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(440, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 12)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Iniciales"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(0, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 12)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Id Usuario"
        '
        'TextBox8
        '
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.ForeColor = System.Drawing.Color.Blue
        Me.TextBox8.Location = New System.Drawing.Point(72, 16)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(88, 13)
        Me.TextBox8.TabIndex = 0
        Me.TextBox8.Text = ""
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'AdapterPerfil
        '
        Me.AdapterPerfil.DeleteCommand = Me.SqlDeleteCommand2
        Me.AdapterPerfil.InsertCommand = Me.SqlInsertCommand2
        Me.AdapterPerfil.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterPerfil.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Perfil", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Perfil", "Id_Perfil"), New System.Data.Common.DataColumnMapping("Nombre_Perfil", "Nombre_Perfil")})})
        Me.AdapterPerfil.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM Perfil WHERE (Id_Perfil = @Original_Id_Perfil) AND (Nombre_Perfil = @" & _
        "Original_Nombre_Perfil)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Perfil", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Perfil", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Perfil", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Perfil", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO Perfil(Nombre_Perfil) VALUES (@Nombre_Perfil); SELECT Id_Perfil, Nomb" & _
        "re_Perfil FROM Perfil WHERE (Id_Perfil = @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Perfil", System.Data.SqlDbType.VarChar, 50, "Nombre_Perfil"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Id_Perfil, Nombre_Perfil FROM Perfil"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE Perfil SET Nombre_Perfil = @Nombre_Perfil WHERE (Id_Perfil = @Original_Id_" & _
        "Perfil) AND (Nombre_Perfil = @Original_Nombre_Perfil); SELECT Id_Perfil, Nombre_" & _
        "Perfil FROM Perfil WHERE (Id_Perfil = @Id_Perfil)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Perfil", System.Data.SqlDbType.VarChar, 50, "Nombre_Perfil"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Perfil", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Perfil", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Perfil", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Perfil", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Perfil", System.Data.SqlDbType.Int, 4, "Id_Perfil"))
        '
        'btnAgregarPerfil
        '
        Me.btnAgregarPerfil.Image = CType(resources.GetObject("btnAgregarPerfil.Image"), System.Drawing.Image)
        Me.btnAgregarPerfil.Location = New System.Drawing.Point(480, 88)
        Me.btnAgregarPerfil.Name = "btnAgregarPerfil"
        Me.btnAgregarPerfil.Size = New System.Drawing.Size(32, 20)
        Me.btnAgregarPerfil.TabIndex = 103
        '
        'AdapterPerfilxUsuario
        '
        Me.AdapterPerfilxUsuario.DeleteCommand = Me.SqlDeleteCommand4
        Me.AdapterPerfilxUsuario.InsertCommand = Me.SqlInsertCommand4
        Me.AdapterPerfilxUsuario.SelectCommand = Me.SqlSelectCommand4
        Me.AdapterPerfilxUsuario.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Perfil_x_Usuario", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Perfil", "Id_Perfil"), New System.Data.Common.DataColumnMapping("Id_Usuario", "Id_Usuario"), New System.Data.Common.DataColumnMapping("Id_PerUser", "Id_PerUser")})})
        Me.AdapterPerfilxUsuario.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM Perfil_x_Usuario WHERE (Id_PerUser = @Original_Id_PerUser) AND (Id_Pe" & _
        "rfil = @Original_Id_Perfil) AND (Id_Usuario = @Original_Id_Usuario)"
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_PerUser", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_PerUser", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Perfil", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Perfil", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Usuario", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO Perfil_x_Usuario(Id_Perfil, Id_Usuario) VALUES (@Id_Perfil, @Id_Usuar" & _
        "io); SELECT Id_Perfil, Id_Usuario, Id_PerUser FROM Perfil_x_Usuario WHERE (Id_Pe" & _
        "rUser = @@IDENTITY)"
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Perfil", System.Data.SqlDbType.Int, 4, "Id_Perfil"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Usuario", System.Data.SqlDbType.VarChar, 50, "Id_Usuario"))
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Id_Perfil, Id_Usuario, Id_PerUser FROM Perfil_x_Usuario"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE Perfil_x_Usuario SET Id_Perfil = @Id_Perfil, Id_Usuario = @Id_Usuario WHER" & _
        "E (Id_PerUser = @Original_Id_PerUser) AND (Id_Perfil = @Original_Id_Perfil) AND " & _
        "(Id_Usuario = @Original_Id_Usuario); SELECT Id_Perfil, Id_Usuario, Id_PerUser FR" & _
        "OM Perfil_x_Usuario WHERE (Id_PerUser = @Id_PerUser)"
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Perfil", System.Data.SqlDbType.Int, 4, "Id_Perfil"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Usuario", System.Data.SqlDbType.VarChar, 50, "Id_Usuario"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_PerUser", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_PerUser", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Perfil", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Perfil", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_PerUser", System.Data.SqlDbType.Int, 4, "Id_PerUser"))
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Usuarios.UsuariosPerfil_x_Usuario"
        Me.GridControl1.DataSource = Me.DatasetUsuario1
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(336, 112)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(176, 80)
        Me.GridControl1.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.TabIndex = 105
        Me.GridControl1.Text = "GridControl1"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId_Perfil})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colId_Perfil
        '
        Me.colId_Perfil.Caption = "Perfiles Asignados"
        Me.colId_Perfil.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colId_Perfil.FieldName = "Id_Perfil"
        Me.colId_Perfil.Name = "colId_Perfil"
        Me.colId_Perfil.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colId_Perfil.VisibleIndex = 0
        Me.colId_Perfil.Width = 190
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.DatasetUsuario1.Perfil
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Nombre_Perfil"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "Id_Perfil"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.CheckBox6)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TxtDescuentoPorcentaje)
        Me.Panel1.Controls.Add(Me.TxtCambioPrecioPorcentaje)
        Me.Panel1.Controls.Add(Me.CheckBox4)
        Me.Panel1.Controls.Add(Me.CheckBox5)
        Me.Panel1.Location = New System.Drawing.Point(96, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(224, 80)
        Me.Panel1.TabIndex = 106
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.SkyBlue
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(2, 2)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(216, 12)
        Me.Label10.TabIndex = 98
        Me.Label10.Text = "Opciones en Ventas y cotizaciones"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckBox6
        '
        Me.CheckBox6.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CheckBox6.Location = New System.Drawing.Point(8, 20)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(208, 16)
        Me.CheckBox6.TabIndex = 97
        Me.CheckBox6.Text = "Ventas con Existencia en Negativo"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(178, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 12)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "%"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(178, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 12)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "%"
        '
        'TxtDescuentoPorcentaje
        '
        Me.TxtDescuentoPorcentaje.EditValue = "0"
        Me.TxtDescuentoPorcentaje.Location = New System.Drawing.Point(122, 50)
        Me.TxtDescuentoPorcentaje.Name = "TxtDescuentoPorcentaje"
        '
        'TxtDescuentoPorcentaje.Properties
        '
        Me.TxtDescuentoPorcentaje.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtDescuentoPorcentaje.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtDescuentoPorcentaje.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtDescuentoPorcentaje.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtDescuentoPorcentaje.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtDescuentoPorcentaje.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtDescuentoPorcentaje.Size = New System.Drawing.Size(56, 17)
        Me.TxtDescuentoPorcentaje.TabIndex = 94
        '
        'TxtCambioPrecioPorcentaje
        '
        Me.TxtCambioPrecioPorcentaje.EditValue = "0"
        Me.TxtCambioPrecioPorcentaje.Location = New System.Drawing.Point(122, 34)
        Me.TxtCambioPrecioPorcentaje.Name = "TxtCambioPrecioPorcentaje"
        '
        'TxtCambioPrecioPorcentaje.Properties
        '
        Me.TxtCambioPrecioPorcentaje.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtCambioPrecioPorcentaje.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtCambioPrecioPorcentaje.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtCambioPrecioPorcentaje.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtCambioPrecioPorcentaje.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtCambioPrecioPorcentaje.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtCambioPrecioPorcentaje.Size = New System.Drawing.Size(56, 17)
        Me.TxtCambioPrecioPorcentaje.TabIndex = 92
        '
        'CheckBox4
        '
        Me.CheckBox4.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CheckBox4.Location = New System.Drawing.Point(8, 36)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(120, 13)
        Me.CheckBox4.TabIndex = 91
        Me.CheckBox4.Text = "Cambiar Precios"
        '
        'CheckBox5
        '
        Me.CheckBox5.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CheckBox5.Location = New System.Drawing.Point(8, 52)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(120, 15)
        Me.CheckBox5.TabIndex = 93
        Me.CheckBox5.Text = "Aplicar Descuentos"
        '
        'Frmusuario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(522, 272)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.btnAgregarPerfil)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataNavigator1)
        Me.Controls.Add(Me.ComboBoxPerfilUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(520, 208)
        Me.Name = "Frmusuario"
        Me.Text = "Administrador de Usuario"
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.PictureEdit1, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TextBox2, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TextBox3, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TextBox4, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.ComboBoxPerfilUsuario, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TextBox7, 0)
        Me.Controls.SetChildIndex(Me.TextBox8, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.btnAgregarPerfil, 0)
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        CType(Me.DatasetUsuario1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.TxtDescuentoPorcentaje.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCambioPrecioPorcentaje.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Funciones Varias"
    'Private Sub desactivaCampos()
    '    Me.TextBox2.Enabled = False
    '    Me.TextBox3.Enabled = False
    '    Me.TextBox4.Enabled = False
    '    Me.TextBox7.Enabled = False
    '    Me.TextBox8.Enabled = False
    '    Me.ComboBoxPerfilUsuario.Enabled = False
    '    Me.PictureEdit1.Enabled = False
    '    Me.btnAgregarPerfil.Enabled = False
    '    GridControl1.Enabled = False
    '    Panel1.Enabled = False
    'End Sub
    Private Sub Activar_desactivar_Campos(ByVal Valor As Boolean) ' Reduccion de Codigo Fuente.. :) SAJ: 28033007 
        Me.TextBox2.Enabled = Valor
        Me.TextBox3.Enabled = Valor
        Me.TextBox4.Enabled = Valor
        Me.TextBox7.Enabled = Valor
        Me.TextBox8.Enabled = Valor
        Me.ComboBoxPerfilUsuario.Enabled = Valor
        Me.PictureEdit1.Enabled = Valor
        Me.btnAgregarPerfil.Enabled = Valor
        GridControl1.Enabled = Valor
        Panel1.Enabled = Valor
    End Sub


    'Private Sub activaCampos()
    '    Me.TextBox2.Enabled = True
    '    Me.TextBox3.Enabled = True
    '    Me.TextBox4.Enabled = True
    '    Me.TextBox7.Enabled = True
    '    Me.TextBox8.Enabled = True
    '    Me.ComboBoxPerfilUsuario.Enabled = True
    '    Me.PictureEdit1.Enabled = True
    '    Me.btnAgregarPerfil.Enabled = True
    '    GridControl1.Enabled = True

    'End Sub

    Function Binding()


        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DatasetUsuario1, "Usuarios.Id_Usuario"))
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DatasetUsuario1, "Usuarios.Nombre"))
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DatasetUsuario1, "Usuarios.Clave_Entrada"))
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DatasetUsuario1, "Usuarios.Clave_Interna"))
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DatasetUsuario1, "Usuarios.Iniciales"))
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DatasetUsuario1, "Usuarios.Id_Usuario"))

        'SAJ : 28032007 NUEVOS CAMPOS 
        Me.CheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DatasetUsuario1, "Usuarios.CambiarPrecio"))
        Me.CheckBox5.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DatasetUsuario1, "Usuarios.Aplicar_Desc"))
        Me.CheckBox6.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DatasetUsuario1, "Usuarios.Exist_Negativa"))
        Me.TxtDescuentoPorcentaje.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DatasetUsuario1, "Usuarios.Porc_Desc"))
        Me.TxtCambioPrecioPorcentaje.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DatasetUsuario1, "Usuarios.Porc_Precio"))

        Me.PictureEdit1.DataBindings.Add(New Binding("EditValue", Me.DatasetUsuario1, "Usuarios.Foto"))

    End Function

    Function Nuevo()
        Try

            If Me.ToolBarNuevo.Text = "Nuevo" Then

                Me.ToolBarNuevo.Text = "Cancel"
                Me.ToolBarNuevo.ImageIndex = 4
                Me.btnAgregarPerfil.Enabled = False
                Me.ToolBarBuscar.Enabled = False
                Me.ToolBarEliminar.Enabled = False
                Me.ToolBarRegistrar.Enabled = True

                Me.BindingContext(Me.DatasetUsuario1, "Usuarios").EndCurrentEdit()
                Me.BindingContext(Me.DatasetUsuario1, "Usuarios").AddNew()
                'Me.ComboBoxPerfilUsuario.SelectedIndex = 1
                Activar_desactivar_Campos(True)
                ComboBoxPerfilUsuario.Enabled = False
                btnAgregarPerfil.Enabled = False
                TextBox8.Focus()
                DataNavigator1.Enabled = False

            Else

                Me.ToolBarNuevo.Text = "Nuevo"
                Me.ToolBarNuevo.ImageIndex = 0
                Me.ToolBarBuscar.Enabled = True
                Me.ToolBarEliminar.Enabled = True
                Me.ToolBarRegistrar.Enabled = False

                Activar_desactivar_Campos(False)
                Me.BindingContext(Me.DatasetUsuario1, "Usuarios").CancelCurrentEdit()
                DataNavigator1.Enabled = True

            End If
        Catch ex As Exception
            Dim mesg As String = "Problemas al hacer un Usuario Nuevo." & vbCrLf & _
                                 "Intente Iniciar el formulario Otra vez, " & vbCrLf & _
                                 "si el problema persiste comuniquelo al 'Administrador del Sistema'" & vbCrLf & _
                                 "'" & ex.Message & "'"
            MsgBox(mesg, MsgBoxStyle.Critical, "Atención")
        End Try
    End Function

    Function Editar()
        Try
            If Me.ToolBarBuscar.Text = "Editar" Then
                Me.ToolBarBuscar.Text = "Cancel"
                Me.ToolBarBuscar.ImageIndex = 4
                Me.ToolBarNuevo.Enabled = False
                Me.ToolBarEliminar.Enabled = False
                Me.ToolBarRegistrar.Enabled = True
                Activar_desactivar_Campos(True)
                TextBox8.Focus()
                DataNavigator1.Enabled = False
            Else
                Me.BindingContext(Me.DatasetUsuario1, "Usuarios").CancelCurrentEdit()
                Me.ToolBarBuscar.Text = "Editar"
                Me.ToolBarBuscar.ImageIndex = 9
                Me.ToolBarNuevo.Enabled = True
                Me.ToolBarEliminar.Enabled = True
                Me.ToolBarRegistrar.Enabled = False
                Activar_desactivar_Campos(False)
                DataNavigator1.Enabled = True
            End If

        Catch ex As Exception
            Dim mesg As String = "Problemas al Editar un Usuario." & vbCrLf & _
                                 "Intente Iniciar el formulario Otra vez, " & vbCrLf & _
                                 "si el problema persiste comuniquelo al 'Administrador del Sistema'" & vbCrLf & _
                                 "'" & ex.Message & "'"
            MsgBox(mesg, MsgBoxStyle.Critical, "Atención")
        End Try
    End Function

    Function Registra()
        Try

            Me.BindingContext(Me.DatasetUsuario1, "Usuarios").EndCurrentEdit()
            Me.AdapterUsuario.Update(Me.DatasetUsuario1.Usuarios)

            Me.BindingContext(Me.DatasetUsuario1, "Perfil_x_Usuario").EndCurrentEdit()
            Me.AdapterPerfilxUsuario.Update(Me.DatasetUsuario1.Perfil_x_Usuario)

            Me.BindingContext(Me.DatasetUsuario1, "Perfil").EndCurrentEdit()
            Me.AdapterPerfil.Update(Me.DatasetUsuario1.Perfil)

            Me.GridControl1.Refresh()
            Me.DatasetUsuario1.GetChanges()

            Activar_desactivar_Campos(False)

            DataNavigator1.Enabled = True

            'toolBar
            Me.ToolBarNuevo.Text = "Nuevo"
            Me.ToolBarNuevo.ImageIndex = 0
            Me.ToolBarBuscar.Text = "Editar"
            Me.ToolBarBuscar.ImageIndex = 9
            Me.ToolBarBuscar.Enabled = True
            Me.ToolBarNuevo.Enabled = True
            Me.ToolBarRegistrar.Enabled = False
            Me.ToolBarEliminar.Enabled = True

        Catch ex As SystemException
            Dim mesg As String = "Problemas al Registrar un Usuario." & vbCrLf & _
                                 "Intente Iniciar el formulario Otra vez, " & vbCrLf & _
                                 "si el problema persiste comuniquelo al 'Administrador del Sistema'" & vbCrLf & _
                                 "'" & ex.Message & "'"
            MsgBox(mesg, MsgBoxStyle.Critical, "Atención")
        End Try

    End Function
#End Region
    Dim cedula As String
    Private Sub FrmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Me.SqlConnection1.ConnectionString = CadenaConexionSeguridad

            'SAJ 28032006 : SOLO PAR AEFECTOS DE OCULTAR EL PANEL CUANDO NO SEA LCPYMES
            Me.Panel1.Visible = IIf(CadenaConexionSeePOS <> "", True, False)

            Me.AdapterUsuario.Fill(Me.DatasetUsuario1.Usuarios)
            Me.AdapterPerfil.Fill(Me.DatasetUsuario1.Perfil)
            Me.AdapterPerfilxUsuario.Fill(Me.DatasetUsuario1.Perfil_x_Usuario)
            Binding()
            Activar_desactivar_Campos(False)
            Me.ToolBarRegistrar.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")

            Dim mesg As String = "Problemas al iniciar." & vbCrLf & _
                                 "El fomulario Intente Iniciar el formulario Otra vez," & vbCrLf & _
                                 " si el problema persiste comuniqueselo al 'Administrador del Sistema'"
            MsgBox(mesg, MsgBoxStyle.Critical, "Atención")
            Me.Close()
        End Try
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TextBox3.Focus()
        End If
    End Sub

    Private Sub TextBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TextBox4.Focus()
        End If
    End Sub

    Private Sub TextBox4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ComboBoxPerfilUsuario.Focus()
        End If
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0 : Me.Nuevo()
            Case 1 : Editar()
            Case 2 : Me.Registra()
            Case 3 : Me.buscarUsuario()
            Case 4 : Me.subBuscaPerfil()
                'Case 5 : Botonhabilitar()
            Case 6 : If MessageBox.Show("¿Desea Cerrar el Módulo de Usuario?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then Me.Close()

        End Select
    End Sub


    Private Sub ComboBoxPerfilUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBoxPerfilUsuario.KeyPress
        If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
            e.Handled = True  ' esto invalida la tecla pulsada
        End If
    End Sub

    Private Sub btnAgregarPerfil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPerfil.Click
        subAgregaPerfil()
    End Sub
    'AGREGA UN NUEVO PERFIL AL GRID
    Private Sub subAgregaPerfil()
        Try
            Dim strEvaluaPerfil As String = ""
            Dim strEvaluaUsuario As String = ""

            'Evaluo si el usuario existe
            strEvaluaUsuario = funEvaluaUsuario()


            If strEvaluaUsuario = "Existe" Then '#2

                'EVALUA SI EL PERFIL YA EXISTE ASIGNADO A ESTE USUARIO
                strEvaluaPerfil = funVerificaPerfil()


                'SINO EXISTE INGRESA A QUI Y LO CARGA AL GRID
                If strEvaluaPerfil <> "Existe" Then '#2

                    'carga los datos en el data grid
                    Me.BindingContext(Me.DatasetUsuario1, "Usuarios.UsuariosPerfil_x_Usuario").CancelCurrentEdit()
                    Me.BindingContext(Me.DatasetUsuario1, "Usuarios.UsuariosPerfil_x_Usuario").AddNew()
                    Me.BindingContext(Me.DatasetUsuario1, "Usuarios.UsuariosPerfil_x_Usuario").Current("Id_Perfil") = ComboBoxPerfilUsuario.SelectedValue
                    Me.BindingContext(Me.DatasetUsuario1, "Usuarios.UsuariosPerfil_x_Usuario").Current("Id_Usuario") = TextBox8.Text
                    Me.BindingContext(Me.DatasetUsuario1, "Usuarios.UsuariosPerfil_x_Usuario").EndCurrentEdit()
                    GridControl1.Refresh()

                    Me.GridControl1.Refresh()
                    Me.DatasetUsuario1.GetChanges()

                    If Me.BindingContext(Me.DatasetUsuario1, "Usuarios").Position = 0 Then

                        Me.BindingContext(Me.DatasetUsuario1, "Usuarios").Position -= 1

                    Else

                        Me.BindingContext(Me.DatasetUsuario1, "Usuarios").Position -= 1
                        Me.BindingContext(Me.DatasetUsuario1, "Usuarios").Position += 1

                    End If




                Else
                    'SI EL PERIL EXISTE PRESENTA ESTE MENSAJE
                    MsgBox("Este perfil ya existe para este usuario", MsgBoxStyle.Exclamation, "Atención")

                End If '#2

            Else

                MsgBox("Debe primero registrar el usuario para agregar varios perfiles", MsgBoxStyle.Exclamation, "Atención")
            End If '#3
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Sub
    'Verifica si el Perfil ya esta asignado existe
    Private Function funVerificaPerfil() As String

        Dim pRow As DataRow
        'EVALUO LOS DATOS EN EL GRID LOS DATOS QUE CONTIENE Y LOS COMPARO CON LOS QUE INGRESARE
        For Each pRow In Me.DatasetUsuario1.Tables("Perfil_x_Usuario").Rows

            'evaluo los datos de una fila con los datos que ingresare
            If pRow("Id_perfil") = Me.ComboBoxPerfilUsuario.SelectedValue And pRow("Id_Usuario") = Me.TextBox8.Text Then

                Return "Existe"
                Exit Function

            End If

        Next

        Return "No_Existe"

    End Function

    'evalua si el usuario existe en el grid
    Private Function funEvaluaUsuario() As String

        Dim pRow As DataRow

        'EVALUO LOS DATOS EN EL GRID LOS DATOS QUE CONTIENE Y LOS COMPARO CON LOS QUE INGRESARE
        For Each pRow In Me.DatasetUsuario1.Tables("Usuarios").Rows

            'evaluo los datos de una fila con los datos que ingresare
            If pRow("Id_Usuario") = Me.TextBox8.Text Then

                Return "Existe"
                Exit Function

            End If

        Next



        Return "No Existe"



    End Function
    'Busca un Perfil antes de Eliminarlo
    Sub subBuscaPerfil()


        Dim pRow As DataRow

        'EVALUO LOS DATOS EN EL GRID LOS DATOS QUE CONTIENE Y LOS COMPARO CON LOS QUE INGRESARE
        For Each pRow In Me.DatasetUsuario1.Tables("Perfil_x_Usuario").Rows

            'evaluo los datos de una fila con los datos que ingresare
            If pRow("Id_Usuario") = Me.TextBox8.Text Then

                MsgBox("Debe eliminar los perfiles antes de eliminar el usuario", MsgBoxStyle.Exclamation, "Atención")
                Exit Sub

            End If

        Next

        'Si no tiene ningun perfil entonces llamara al evento eliminarDatos para borrar al usuario
        Me.EliminarDatos(Me.AdapterUsuario, Me.DatasetUsuario1, Me.DatasetUsuario1.Usuarios.TableName)


    End Sub


    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.subEliminaPerfil()
        End If
    End Sub
    Sub subEliminaPerfil()
        'Elimina el perfil asociado
        ''   Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").RemoveAt(Me.BindingContext(Me.DataSetPerfilUsuario1, "Perfil").Position)
        If Me.BindingContext(Me.DatasetUsuario1, "Usuarios.UsuariosPerfil_x_Usuario").Count > 0 Then  ' si hay ubicaciones
            Me.BindingContext(Me.DatasetUsuario1, "Usuarios.UsuariosPerfil_x_Usuario").RemoveAt(Me.BindingContext(Me.DatasetUsuario1, "Usuarios.UsuariosPerfil_x_Usuario").Position)
            Me.BindingContext(Me.DatasetUsuario1, "Usuarios.UsuariosPerfil_x_Usuario").EndCurrentEdit()
            Me.BindingContext(Me.DatasetUsuario1, "Usuarios.UsuariosPerfil_x_Usuario").EndCurrentEdit()

            If Me.BindingContext(Me.DatasetUsuario1, "Usuarios").Position = 0 Then

                Me.BindingContext(Me.DatasetUsuario1, "Usuarios").Position -= 1

            Else

                Me.BindingContext(Me.DatasetUsuario1, "Usuarios").Position -= 1
                Me.BindingContext(Me.DatasetUsuario1, "Usuarios").Position += 1

            End If

            Me.BindingContext(Me.DatasetUsuario1, "Perfil_x_Usuario").EndCurrentEdit()
            Me.AdapterPerfilxUsuario.Update(Me.DatasetUsuario1.Perfil_x_Usuario)

            Me.BindingContext(Me.DatasetUsuario1, "Usuarios").EndCurrentEdit()
            Me.AdapterUsuario.Update(Me.DatasetUsuario1.Usuarios)

            Me.BindingContext(Me.DatasetUsuario1, "Perfil").EndCurrentEdit()
            Me.AdapterPerfil.Update(Me.DatasetUsuario1.Perfil)

            Me.GridControl1.Refresh()
            Me.DatasetUsuario1.GetChanges()
        Else
            MsgBox("No Existen Mas Datos Para Eliminar", MsgBoxStyle.Information)


        End If

    End Sub

    Private Sub buscarUsuario()


        Dim funcion As New cFunciones
        Dim Id As String

        Try

            Id = funcion.BuscarDatos("SELECT Id_Usuario,Nombre FROM Usuarios", "Nombre", "Buscar Usuario ...", Me.SqlConnection1.ConnectionString)
            cedula = Id
            LlenarUsuario(Id)

            'nuevo
            Me.ToolBar1.Buttons(0).Enabled = True
            'buscar
            Me.ToolBar1.Buttons(1).Enabled = True
            'editar
            Me.ToolBar1.Buttons(2).Enabled = True
            'registrar
            Me.ToolBar1.Buttons(3).Enabled = True
            'eliminar
            Me.ToolBar1.Buttons(4).Enabled = True
            'Imprimir
            Me.ToolBar1.Buttons(5).Enabled = True
            'Cerrar
            Me.ToolBar1.Buttons(6).Enabled = True
            ' Bloquear() : Bloquear_Detalle()
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try


    End Sub


    Function LlenarUsuario(ByVal Id As String)
        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        Dim cConexion As New Conexion
        'Dentro de un Try/Catch por si se produce un error
        Try

            Dim a As Integer = Me.BindingContext(DatasetUsuario1, "Usuarios").Count
            While a <> 0

                If Id = Me.BindingContext(DatasetUsuario1, "Usuarios").Current("Id_Usuario") Then
                    Exit While
                End If

                a -= 1
                Me.BindingContext(DatasetUsuario1, "Usuarios").Position = a

            End While




        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
        End Try
    End Function

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        TxtCambioPrecioPorcentaje.Enabled = CheckBox4.Checked
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        Me.TxtDescuentoPorcentaje.Enabled = Me.CheckBox5.Checked
    End Sub

End Class
