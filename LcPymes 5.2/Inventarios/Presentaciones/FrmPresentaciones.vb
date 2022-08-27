Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class FrmPresentaciones
    Inherits System.Windows.Forms.Form

    Dim NuevaConexion As String
    Dim usua As Usuario_Logeado
    Dim strModulo As String
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents SqlConnection As System.Data.SqlClient.SqlConnection
    Friend WithEvents DaPresentaciones As System.Data.SqlClient.SqlDataAdapter

    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DataSetPresentaciones As DataSetPresentaciones
    Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    Friend WithEvents DataNavigator1 As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarEliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPresentaciones))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.DataSetPresentaciones = New DataSetPresentaciones
        Me.Label2 = New System.Windows.Forms.Label
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarEliminar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SqlConnection = New System.Data.SqlClient.SqlConnection
        Me.DaPresentaciones = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DataNavigator1 = New DevExpress.XtraEditors.DataNavigator
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSetPresentaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetPresentaciones, "Presentaciones.Presentaciones"))
        Me.TextBox2.Location = New System.Drawing.Point(8, 32)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(432, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = ""
        '
        'DataSetPresentaciones
        '
        Me.DataSetPresentaciones.DataSetName = "DataSetPresentaciones"
        Me.DataSetPresentaciones.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(432, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarEliminar, Me.ToolBarRegistrar, Me.ToolBarImprimir, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 114)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(456, 52)
        Me.ToolBar1.TabIndex = 62
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Text = "Nuevo"
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.ImageIndex = 1
        Me.ToolBarBuscar.Text = "Buscar"
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.ImageIndex = 3
        Me.ToolBarEliminar.Text = "Eliminar"
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Text = "Registrar"
        '
        'ToolBarImprimir
        '
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
        'DaPresentaciones
        '
        Me.DaPresentaciones.DeleteCommand = Me.SqlDeleteCommand1
        Me.DaPresentaciones.InsertCommand = Me.SqlInsertCommand1
        Me.DaPresentaciones.SelectCommand = Me.SqlSelectCommand1
        Me.DaPresentaciones.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Presentaciones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Presentaciones", "Presentaciones"), New System.Data.Common.DataColumnMapping("CodPres", "CodPres")})})
        Me.DaPresentaciones.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Presentaciones WHERE (CodPres = @Original_CodPres) AND (Presentacione" & _
        "s = @Original_Presentaciones)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodPres", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodPres", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Presentaciones", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Presentaciones", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Presentaciones(Presentaciones) VALUES (@Presentaciones); SELECT Prese" & _
        "ntaciones, CodPres FROM Presentaciones WHERE (CodPres = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Presentaciones", System.Data.SqlDbType.VarChar, 50, "Presentaciones"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Presentaciones, CodPres FROM Presentaciones"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Presentaciones SET Presentaciones = @Presentaciones WHERE (CodPres = @Orig" & _
        "inal_CodPres) AND (Presentaciones = @Original_Presentaciones); SELECT Presentaci" & _
        "ones, CodPres FROM Presentaciones WHERE (CodPres = @CodPres)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Presentaciones", System.Data.SqlDbType.VarChar, 50, "Presentaciones"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodPres", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodPres", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Presentaciones", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Presentaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodPres", System.Data.SqlDbType.Int, 4, "CodPres"))
        '
        'DataNavigator1
        '
        Me.DataNavigator1.Buttons.Append.Enabled = False
        Me.DataNavigator1.Buttons.Append.Visible = False
        Me.DataNavigator1.Buttons.CancelEdit.Enabled = False
        Me.DataNavigator1.Buttons.CancelEdit.Visible = False
        Me.DataNavigator1.Buttons.EndEdit.Visible = False
        Me.DataNavigator1.Buttons.First.Visible = False
        Me.DataNavigator1.Buttons.NextPage.Visible = False
        Me.DataNavigator1.Buttons.Remove.Visible = False
        Me.DataNavigator1.DataMember = "Presentaciones"
        Me.DataNavigator1.DataSource = Me.DataSetPresentaciones
        Me.DataNavigator1.Location = New System.Drawing.Point(295, 136)
        Me.DataNavigator1.Name = "DataNavigator1"
        Me.DataNavigator1.Size = New System.Drawing.Size(160, 21)
        Me.DataNavigator1.TabIndex = 63
        Me.DataNavigator1.Text = "DataNavigator1"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(456, 40)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Formulario de Presentaciones"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmPresentaciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(456, 166)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolBar1)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(464, 200)
        Me.Name = "FrmPresentaciones"
        Me.Text = "Presentaciones"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSetPresentaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FemPresentaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Me.SqlConnection.ConnectionString = IIf(NuevaConexion = "", CadenaConexionSeePOS, NuevaConexion)
            '  SqlConnection.ConnectionString = CadenaConexionSeePOS
            strModulo = IIf(NuevaConexion = "", "SeePOS", "SeePos")
            Me.DaPresentaciones.Fill(DataSetPresentaciones, "Presentaciones")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function Nueva()
        Try
            'LFCHG 07122006
            If ToolBar1.Buttons(0).Text = "Nuevo" Then
                ToolBar1.Buttons(0).Text = "Cancelar"
                ToolBar1.Buttons(0).ImageIndex = 8
                Me.BindingContext(Me.DataSetPresentaciones, "Presentaciones").EndCurrentEdit()
                Me.BindingContext(Me.DataSetPresentaciones, "Presentaciones").AddNew()
                DataNavigator1.Enabled = False
                Me.ToolBarBuscar.Enabled = False
                Me.ToolBarImprimir.Enabled = False
                Me.ToolBarEliminar.Enabled = False
            Else
                Me.BindingContext(Me.DataSetPresentaciones, "Presentaciones").CancelCurrentEdit()
                ToolBar1.Buttons(0).Text = "Nuevo"
                ToolBar1.Buttons(0).ImageIndex = 0
                DataNavigator1.Enabled = True
                Me.ToolBarBuscar.Enabled = True
                Me.ToolBarImprimir.Enabled = True
                Me.ToolBarEliminar.Enabled = True
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Function
    Function Registrar()
        Try
            'LFCHG 07122006
            Me.BindingContext(DataSetPresentaciones, "Presentaciones").EndCurrentEdit()
            Me.DaPresentaciones.Update(DataSetPresentaciones, "Presentaciones")
            ToolBar1.Buttons(0).Text = "Nuevo"
            ToolBar1.Buttons(0).ImageIndex = 0
            DataNavigator1.Enabled = True
            Me.ToolBarBuscar.Enabled = True
            Me.ToolBarImprimir.Enabled = True
            Me.ToolBarEliminar.Enabled = True
            MsgBox("Datos Registrados Satisfactoriamente", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("No se puede eliminar la presentación porque existen artículos en el inventario ligados a la presentación, O error de red")
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Function
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Try

        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modu

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : Nueva()
            Case 2 : If PMU.Find Then Buscar_Presentaciones() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3 : If PMU.Delete Then eliminar() Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 4 : If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 5 : If PMU.Print Then Me.imprimir() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 6 : Me.Close()
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub eliminar()
        Dim resp As Integer
        Try 'se intenta hacer

            If Me.BindingContext(Me.DataSetPresentaciones, "Presentaciones").Count > 0 Then    ' si hay ubicaciones

                resp = MessageBox.Show("¿Desea eliminar esta Presentación?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                'If resp = 6 Then
                If resp = 6 Then
                    'Evaluo si las subfamilias estan asociadas a un articulo 
                    Dim tabla As New DataTable
                    Dim strCodigoPresentaciones As String = Me.BindingContext(Me.DataSetPresentaciones, "Presentaciones").Current("CodPres")
                    cFunciones.Llenar_Tabla_Generico("SELECT Codigo FROM Inventario WHERE CodPresentacion = '" & strCodigoPresentaciones & "'", tabla, Me.SqlConnection.ConnectionString)
                    If tabla.Rows.Count > 0 Then
                        MsgBox("No se puede eliminar esta Presentacion por que existe articulos en el inventario que pertenecen a esta")
                        Exit Sub
                    End If
                    Me.BindingContext(Me.DataSetPresentaciones, "Presentaciones").RemoveAt(Me.BindingContext(Me.DataSetPresentaciones, "Presentaciones").Position)
                    Me.BindingContext(Me.DataSetPresentaciones, "Presentaciones").EndCurrentEdit()
                    Registrar()
                End If
            Else
                MsgBox("No Existen Presentaciones que Eliminar", MsgBoxStyle.Information)
            End If
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub imprimir()
        Try
            Me.ToolBar1.Buttons(3).Enabled = False
            Dim Presentaciones_Reporte As New Reporte_Presentaciones

            CrystalReportsConexion.LoadShow(Presentaciones_Reporte, MdiParent, Me.SqlConnection.ConnectionString)
            Me.ToolBar1.Buttons(3).Enabled = True
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Buscar_Presentaciones()
        Try
            Dim Fx As New cFunciones
            Dim valor As String
            Dim pos As Integer
            Dim vista As DataView
            valor = Fx.BuscarDatos("Select CodPres, Presentaciones from Presentaciones", "Presentaciones", "Buscar Presentaciones...", Me.SqlConnection.ConnectionString)
            If valor = "" Then
                Exit Sub
            Else

                vista = Me.DataSetPresentaciones.Presentaciones.DefaultView
                vista.Sort = "CodPres"
                pos = vista.Find(CDbl(valor))
                Me.BindingContext(Me.DataSetPresentaciones, "Presentaciones").Position = pos
            End If


        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
