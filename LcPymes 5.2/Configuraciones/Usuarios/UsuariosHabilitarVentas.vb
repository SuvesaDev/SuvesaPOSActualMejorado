Imports System.Data
Imports System.data.sqlclient
Imports System.Windows.Forms

Public Class UsuariosHabilitarVentas
    Inherits FrmPlantilla

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
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AdapterUsuariosHabilitar As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSetUsuarioHabi1 As LcPymes_5._2.DataSetUsuarioHabi
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Public WithEvents TxtNombre As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents TxtCedula As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(UsuariosHabilitarVentas))
        Me.TxtNombre = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.AdapterUsuariosHabilitar = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DataSetUsuarioHabi1 = New LcPymes_5._2.DataSetUsuarioHabi
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtCedula = New System.Windows.Forms.TextBox
        CType(Me.DataSetUsuarioHabi1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Visible = False
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 88)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(474, 52)
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Visible = False
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
        Me.DataNavigator.Location = New System.Drawing.Point(338, 170)
        Me.DataNavigator.Name = "DataNavigator"
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(474, 32)
        Me.TituloModulo.Text = "                       Usuarios Habilitar Ventas"
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Text = "Inhabilitar"
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Text = "Habilitar"
        '
        'TxtNombre
        '
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.ForeColor = System.Drawing.Color.Blue
        Me.TxtNombre.Location = New System.Drawing.Point(128, 56)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(336, 13)
        Me.TxtNombre.TabIndex = 88
        Me.TxtNombre.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(128, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 12)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Nombre Completo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdapterUsuariosHabilitar
        '
        Me.AdapterUsuariosHabilitar.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterUsuariosHabilitar.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterUsuariosHabilitar.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterUsuariosHabilitar.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Usuario", "Id_Usuario"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Entrada", "Clave_Entrada"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna"), New System.Data.Common.DataColumnMapping("Perfil", "Perfil"), New System.Data.Common.DataColumnMapping("Foto", "Foto"), New System.Data.Common.DataColumnMapping("Iniciales", "Iniciales"), New System.Data.Common.DataColumnMapping("CambiarPrecio", "CambiarPrecio"), New System.Data.Common.DataColumnMapping("Porc_Precio", "Porc_Precio"), New System.Data.Common.DataColumnMapping("Aplicar_Desc", "Aplicar_Desc"), New System.Data.Common.DataColumnMapping("Porc_Desc", "Porc_Desc"), New System.Data.Common.DataColumnMapping("Exist_Negativa", "Exist_Negativa")})})
        Me.AdapterUsuariosHabilitar.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Usuarios WHERE (Id_Usuario = @Original_Id_Usuario)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Usuario", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""ERMIS-PC"";packet size=4096;integrated security=SSPI;data source=""" & _
        "ERMIS-PC\SQL2000"";persist security info=False;initial catalog=Seguridad"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Usuarios(Id_Usuario, Nombre, Clave_Entrada, Clave_Interna, Perfil, Fo" & _
        "to, Iniciales, CambiarPrecio, Porc_Precio, Aplicar_Desc, Porc_Desc, Exist_Negati" & _
        "va) VALUES (@Id_Usuario, @Nombre, @Clave_Entrada, @Clave_Interna, @Perfil, @Foto" & _
        ", @Iniciales, @CambiarPrecio, @Porc_Precio, @Aplicar_Desc, @Porc_Desc, @Exist_Ne" & _
        "gativa); SELECT Id_Usuario, Nombre, Clave_Entrada, Clave_Interna, Perfil, Foto, " & _
        "Iniciales, CambiarPrecio, Porc_Precio, Aplicar_Desc, Porc_Desc, Exist_Negativa F" & _
        "ROM Usuarios WHERE (Id_Usuario = @Id_Usuario)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Usuario", System.Data.SqlDbType.VarChar, 50, "Id_Usuario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Clave_Entrada", System.Data.SqlDbType.VarChar, 30, "Clave_Entrada"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Clave_Interna", System.Data.SqlDbType.VarChar, 30, "Clave_Interna"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Perfil", System.Data.SqlDbType.Int, 4, "Perfil"))
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
        Me.SqlSelectCommand1.CommandText = "SELECT Id_Usuario, Nombre, Clave_Entrada, Clave_Interna, Perfil, Foto, Iniciales," & _
        " CambiarPrecio, Porc_Precio, Aplicar_Desc, Porc_Desc, Exist_Negativa FROM Usuari" & _
        "os"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Usuarios SET Id_Usuario = @Id_Usuario, Nombre = @Nombre, Clave_Entrada = @" & _
        "Clave_Entrada, Clave_Interna = @Clave_Interna, Perfil = @Perfil, Foto = @Foto, I" & _
        "niciales = @Iniciales, CambiarPrecio = @CambiarPrecio, Porc_Precio = @Porc_Preci" & _
        "o, Aplicar_Desc = @Aplicar_Desc, Porc_Desc = @Porc_Desc, Exist_Negativa = @Exist" & _
        "_Negativa WHERE (Id_Usuario = @Original_Id_Usuario); SELECT Id_Usuario, Nombre, " & _
        "Clave_Entrada, Clave_Interna, Perfil, Foto, Iniciales, CambiarPrecio, Porc_Preci" & _
        "o, Aplicar_Desc, Porc_Desc, Exist_Negativa FROM Usuarios WHERE (Id_Usuario = @Id" & _
        "_Usuario)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Usuario", System.Data.SqlDbType.VarChar, 50, "Id_Usuario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Clave_Entrada", System.Data.SqlDbType.VarChar, 30, "Clave_Entrada"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Clave_Interna", System.Data.SqlDbType.VarChar, 30, "Clave_Interna"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Perfil", System.Data.SqlDbType.Int, 4, "Perfil"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Foto", System.Data.SqlDbType.VarBinary, 2147483647, "Foto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Iniciales", System.Data.SqlDbType.VarChar, 4, "Iniciales"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CambiarPrecio", System.Data.SqlDbType.Bit, 1, "CambiarPrecio"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porc_Precio", System.Data.SqlDbType.Float, 8, "Porc_Precio"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Aplicar_Desc", System.Data.SqlDbType.Bit, 1, "Aplicar_Desc"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porc_Desc", System.Data.SqlDbType.Float, 8, "Porc_Desc"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Exist_Negativa", System.Data.SqlDbType.Bit, 1, "Exist_Negativa"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Usuario", System.Data.DataRowVersion.Original, Nothing))
        '
        'DataSetUsuarioHabi1
        '
        Me.DataSetUsuarioHabi1.DataSetName = "DataSetUsuarioHabi"
        Me.DataSetUsuarioHabi1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 12)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Cedula"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtCedula
        '
        Me.TxtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCedula.ForeColor = System.Drawing.Color.Blue
        Me.TxtCedula.Location = New System.Drawing.Point(8, 56)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.ReadOnly = True
        Me.TxtCedula.Size = New System.Drawing.Size(104, 13)
        Me.TxtCedula.TabIndex = 92
        Me.TxtCedula.Text = ""
        '
        'UsuariosHabilitarVentas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(474, 140)
        Me.Controls.Add(Me.TxtCedula)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UsuariosHabilitarVentas"
        Me.Text = "Usuarios Habilitar Ventas"
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtNombre, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtCedula, 0)
        CType(Me.DataSetUsuarioHabi1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub UsuariosHabilitarVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

      
    End Sub

    Private Sub TituloModulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TituloModulo.Click

    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0
            Case 1 : Me.buscar_Usuario()
            Case 2 : Botonhabilitar()
            Case 3 : Botonhabilitar()
            Case 4
            Case 6 : If MessageBox.Show("¿Desea Cerrar el Módulo de Usuario?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then Me.Close()
        End Select
    End Sub

    Public Sub buscar_Usuario()

        Dim CConexion As New Conexion
        Dim CedulaUsua As String
        Dim BuscarDescarga As New cFunciones
        Dim c As String
        c = BuscarDescarga.BuscarDatos("SELECT cedula,Nombre FROM Usuarios", "Nombre", "Buscar Usuario ...", CadenaConexionSeePOS)
        If c <> "" Then
            CedulaUsua = c
        Else
            Exit Sub
        End If
        Me.SqlConnection1 = CConexion.Conectar
        CargarInformacionUsuario(CedulaUsua)
        If Chekeoanulaciones(CedulaUsua) >= 3 Then
            Me.ToolBar1.Buttons.Item(2).Enabled = True
            Me.ToolBar1.Buttons.Item(3).Enabled = False
        Else
            Me.ToolBar1.Buttons.Item(2).Enabled = False
            Me.ToolBar1.Buttons.Item(3).Enabled = True
        End If
    End Sub



    Private Sub TxtNombre_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNombre.KeyDown

        If e.KeyCode = Keys.F1 Then
            buscar_Usuario()
        End If

    End Sub

    Private Function Chekeoanulaciones(ByVal _codigo As String)

        Dim ContadorAnulaciones As Integer
        Dim SQL As New GestioDatos
        Dim sentencia As String = "SELECT COUNT(*) AS Anulados FROM registro_anulaciones WHERE (cedula_usuario = '" & _codigo & "') AND (fecha = dbo.dateonly(getdate()) AND (justificacion = 0)) AND (Permiso = 0)"
        ContadorAnulaciones = SQL.Ejecuta(sentencia).Rows(0).Item(0)
        Return ContadorAnulaciones

    End Function

    Private Sub CargarInformacionUsuario(ByVal _codigo As String)

        Dim ff As New cFunciones
        Dim Dt As New DataTable

        ff.Llenar_Tabla_Generico("Select cedula, Nombre from usuarios where Cedula = '" & _codigo & "'", Dt, CadenaConexionSeePOS)

        If Dt.Rows.Count > 0 Then
            Me.TxtNombre.Text = Dt.Rows(0).Item("Nombre")
            Me.TxtCedula.Text = Dt.Rows(0).Item("Cedula")
        End If

    End Sub

    Private Sub Botonhabilitar()
        If Me.TxtCedula.Text <> "" Then
            CargarAnulacionesUsuario(TxtCedula.Text)
        End If
    End Sub

    Private Sub CargarAnulacionesUsuario(ByVal _codigo As String)
        'Dim fecha As New Date
        Dim Fx As New cFunciones
        Dim Dt As New DataTable
        'fecha = Date.Now.ToShortDateString
        Fx.Llenar_Tabla_Generico("select * from dbo.registro_anulaciones where cedula_usuario = '" & _codigo & "' and fecha = dbo.dateonly(getdate())", Dt, CadenaConexionSeePOS)
        'AND (fecha = dbo.dateonly(getdate())"
        If Dt.Rows.Count > 0 Then
            GuardaPermiso(_codigo)
        End If

    End Sub

    Private Sub GuardaPermiso(ByVal _id As Integer)
        Dim SQL As New GestioDatos
        If Me.ToolBar1.Buttons.Item(2).Enabled = True Then
            SQL.Ejecuta("update dbo.registro_anulaciones set permiso = 1 where Cedula_usuario = " & _id)
            Me.ToolBar1.Buttons.Item(3).Enabled = True
            Me.ToolBar1.Buttons.Item(2).Enabled = False
            Exit Sub
        ElseIf Me.ToolBar1.Buttons.Item(3).Enabled = True Then
            SQL.Ejecuta("update dbo.registro_anulaciones set permiso = 0 where Cedula_usuario = " & _id)
            Me.ToolBar1.Buttons.Item(3).Enabled = False
            Me.ToolBar1.Buttons.Item(2).Enabled = True
            Exit Sub
        End If
    End Sub
End Class
