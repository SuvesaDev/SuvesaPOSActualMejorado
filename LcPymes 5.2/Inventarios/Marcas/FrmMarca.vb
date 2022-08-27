Imports System.Data.SqlClient
Imports System.Data
Public Class FrmMarca
    Inherits FrmPlantilla  'System.Windows.Forms.Form

    Dim NuevaConexion As String
    Dim sqlConexion As SqlConnection
    Dim usua As Usuario_Logeado
    Dim strModulo As String = ""
    Public CConexion As New Conexion
#Region " Windows Form Designer generated code "

    Public Sub New(ByVal Usuario_Parametro As Object, Optional ByVal Conexion As String = "")
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        NuevaConexion = Conexion
        usua = Usuario_Parametro

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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents SqlConnection As System.Data.SqlClient.SqlConnection
    Friend WithEvents DaMarca As System.Data.SqlClient.SqlDataAdapter

    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtMarca As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter

    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DataSetMarca As DataSetMarca
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmMarca))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SqlConnection = New System.Data.SqlClient.SqlConnection
        Me.DaMarca = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtCodigo = New System.Windows.Forms.TextBox
        Me.DataSetMarca = New LcPymes_5._2.DataSetMarca
        Me.TxtMarca = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSetMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 108)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(458, 52)
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
        Me.DataNavigator.DataMember = "Marcas"
        Me.DataNavigator.DataSource = Me.DataSetMarca
        Me.DataNavigator.Location = New System.Drawing.Point(320, 136)
        Me.DataNavigator.Name = "DataNavigator"
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(458, 32)
        Me.TituloModulo.Text = "Módulo de pantallas"
        Me.TituloModulo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'SqlConnection
        '
        Me.SqlConnection.ConnectionString = "workstation id=""JHONNY-8CDDB6F1"";packet size=4096;integrated security=SSPI;data s" & _
        "ource=SEESERVER;persist security info=False;initial catalog=Seepos"
        '
        'DaMarca
        '
        Me.DaMarca.DeleteCommand = Me.SqlDeleteCommand1
        Me.DaMarca.InsertCommand = Me.SqlInsertCommand1
        Me.DaMarca.SelectCommand = Me.SqlSelectCommand1
        Me.DaMarca.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Marcas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Marca", "Marca"), New System.Data.Common.DataColumnMapping("CodMarca", "CodMarca")})})
        Me.DaMarca.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Marcas WHERE (CodMarca = @Original_CodMarca) AND (Marca = @Original_M" & _
        "arca)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMarca", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMarca", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Marca", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Marca", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Marcas(Marca) VALUES (@Marca); SELECT Marca, CodMarca FROM Marcas WHE" & _
        "RE (CodMarca = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Marca", System.Data.SqlDbType.VarChar, 50, "Marca"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Marca, CodMarca FROM Marcas"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Marcas SET Marca = @Marca WHERE (CodMarca = @Original_CodMarca) AND (Marca" & _
        " = @Original_Marca); SELECT Marca, CodMarca FROM Marcas WHERE (CodMarca = @CodMa" & _
        "rca)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Marca", System.Data.SqlDbType.VarChar, 50, "Marca"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMarca", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMarca", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Marca", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Marca", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMarca", System.Data.SqlDbType.Int, 4, "CodMarca"))
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtCodigo)
        Me.GroupBox1.Controls.Add(Me.TxtMarca)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 64)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Código"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCodigo
        '
        Me.TxtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetMarca, "Marcas.CodMarca"))
        Me.TxtCodigo.ForeColor = System.Drawing.Color.Black
        Me.TxtCodigo.Location = New System.Drawing.Point(8, 32)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.TabIndex = 2
        Me.TxtCodigo.Text = ""
        Me.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataSetMarca
        '
        Me.DataSetMarca.DataSetName = "DataSetMarca"
        Me.DataSetMarca.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'TxtMarca
        '
        Me.TxtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMarca.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetMarca, "Marcas.Marca"))
        Me.TxtMarca.Location = New System.Drawing.Point(120, 32)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(328, 20)
        Me.TxtMarca.TabIndex = 1
        Me.TxtMarca.Text = ""
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(120, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pantalla"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Table", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Código", "Código")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT isnull(CodMarca),0) + 1 AS Código FROM Marcas"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection
        '
        'FrmMarca
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(458, 160)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmMarca"
        Me.Text = "Pantallas"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSetMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmMarca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim cod As String
            Me.SqlConnection.ConnectionString = IIf(NuevaConexion = "", CadenaConexionSeePOS, NuevaConexion)
            strModulo = IIf(NuevaConexion = "", "SeePOS", "SeePos")
            'SqlConnection.ConnectionString = CadenaConexionSeePOS
            Me.DaMarca.Fill(Me.DataSetMarca.Marcas)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function Nuevo()
        Try
            Me.BindingContext(Me.DataSetMarca.Marcas).EndCurrentEdit()
            Me.BindingContext(Me.DataSetMarca.Marcas).AddNew()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Function
    Function Registrar()
        Try
            Me.BindingContext(Me.DataSetMarca.Marcas).EndCurrentEdit()
            Me.DaMarca.Update(Me.DataSetMarca.Marcas)
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
                        Me.NuevosDatos(Me.DataSetMarca, Me.DataSetMarca.Marcas.ToString)
                        ToolBar1.Buttons(0).Text = "Cancelar"
                        ToolBar1.Buttons(0).ImageIndex = 8
                        Me.ToolBar1.Buttons(2).Enabled = True
                        DataNavigator.Enabled = False
                        Me.ToolBarBuscar.Enabled = False
                        Me.ToolBarImprimir.Enabled = False
                        Me.ToolBarEliminar.Enabled = False
                    Else
                        Me.BindingContext(Me.DataSetMarca, "Marcas").CancelCurrentEdit()
                        ToolBar1.Buttons(0).Text = "Nuevo"
                        ToolBar1.Buttons(0).ImageIndex = 0
                        Me.ToolBar1.Buttons(2).Enabled = False
                        DataNavigator.Enabled = True
                        Me.ToolBarBuscar.Enabled = True
                        Me.ToolBarImprimir.Enabled = True
                        Me.ToolBarEliminar.Enabled = True
                    End If

                Case 1 : If PMU.Find Then Me.Buscar_Marcas() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                Case 2 : If PMU.Update Then
                        Me.RegistrarDatos(Me.DaMarca, Me.DataSetMarca, Me.DataSetMarca.Marcas.ToString)
                        DataNavigator.Enabled = True
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

    Sub imprimir()
        Try
            'LFCHG 07122006
            Me.ToolBar1.Buttons(4).Enabled = False
            Dim Marcas_Reporte As New Reporte_Marcas
            CrystalReportsConexion.LoadShow(Marcas_Reporte, Me.MdiParent, Me.SqlConnection.ConnectionString)
            Me.ToolBar1.Buttons(4).Enabled = True
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EliminaMarca()
        Try
            Dim rs As SqlDataReader
            If Me.BindingContext(Me.DataSetMarca.Marcas).Count > 0 Then

                'Evaluo si las subfamilias estan asociadas a un articulo 
                Dim strCodigoMarca As String = Me.BindingContext(Me.DataSetMarca, "Marcas").Current("CodMarca")
                'Habro la conexion 
                sqlConexion = CConexion.Conectar(strModulo)
                'Realizo la busqueda en la base de datos
                rs = CConexion.GetRecorset(sqlConexion, "SELECT Codigo FROM Inventario WHERE CodMarca = '" & strCodigoMarca & "'")
                'Evaluo si encontro registros dentro de la tabla inventario
                If rs.Read Then
                    MsgBox("No se puede eliminar esta Marca por que existe articulos en el inventario que pertenecen a esta")
                    rs.Close()
                    CConexion.DesConectar(sqlConexion)
                    Exit Sub
                End If
                'Si no encontro registros eliminara el registro actual
                Me.EliminarDatos(Me.DaMarca, Me.DataSetMarca, Me.DataSetMarca.Marcas.ToString)
            End If
            rs.Close()
            CConexion.DesConectar(sqlConexion)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Sub Buscar_Marcas()
        Try
            Dim Fx As New cFunciones
            Dim valor As String
            Dim pos As Integer
            Dim vista As DataView

            valor = Fx.BuscarDatos("Select CodMarca, Marca from Marcas", "Marca", "Buscar Marcas...", Me.SqlConnection.ConnectionString)

            If valor = "" Then
                Exit Sub
            Else
                vista = Me.DataSetMarca.Marcas.DefaultView
                vista.Sort = "CodMarca"
                pos = vista.Find(CDbl(valor))
                Me.BindingContext(Me.DataSetMarca, "Marcas").Position = pos
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub

End Class
