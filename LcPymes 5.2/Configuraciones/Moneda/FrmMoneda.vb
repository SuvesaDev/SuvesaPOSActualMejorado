Imports System.Windows.Forms
Public Class FrmMoneda
    Inherits FrmPlantilla
    Dim NuevaConexion As String
    Dim usua As Object
#Region " Windows Form Designer generated code "

    Public Sub New(ByVal Usuario_Parametro As Object, Optional ByVal Conexion As String = "")
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        usua = Usuario_Parametro

        NuevaConexion = Conexion
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
    Friend WithEvents SqlConnection As System.Data.SqlClient.SqlConnection
    Friend WithEvents DaMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsMoneda1 As DataSetMoneda
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtCompra As System.Windows.Forms.TextBox
    Friend WithEvents TxtSimbolo As System.Windows.Forms.TextBox
    Friend WithEvents TxtVenta As System.Windows.Forms.TextBox
    Friend WithEvents TxtMoneda As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents DataSetMoneda As DataSetMoneda
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txtCuentaContable As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMoneda))
        Me.SqlConnection = New System.Data.SqlClient.SqlConnection
        Me.DaMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCuentaContable = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtCompra = New System.Windows.Forms.TextBox
        Me.TxtSimbolo = New System.Windows.Forms.TextBox
        Me.TxtVenta = New System.Windows.Forms.TextBox
        Me.TxtMoneda = New System.Windows.Forms.TextBox
        Me.TxtCodigo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataSetMoneda = New LcPymes_5._2.DataSetMoneda
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSetMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.ImageIndex = 9
        Me.ToolBarBuscar.Text = "Editar"
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.Images.SetKeyName(0, "")
        Me.ImageList.Images.SetKeyName(1, "")
        Me.ImageList.Images.SetKeyName(2, "")
        Me.ImageList.Images.SetKeyName(3, "")
        Me.ImageList.Images.SetKeyName(4, "")
        Me.ImageList.Images.SetKeyName(5, "")
        Me.ImageList.Images.SetKeyName(6, "")
        Me.ImageList.Images.SetKeyName(7, "")
        Me.ImageList.Images.SetKeyName(8, "")
        '
        'ToolBar1
        '
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 147)
        Me.ToolBar1.Size = New System.Drawing.Size(458, 52)
        '
        'DataNavigator
        '
        Me.DataNavigator.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.DataMember = "Moneda"
        Me.DataNavigator.DataSource = Me.DataSetMoneda
        Me.DataNavigator.Location = New System.Drawing.Point(248, 176)
        Me.DataNavigator.Size = New System.Drawing.Size(207, 21)
        Me.DataNavigator.Text = ""
        '
        'TituloModulo
        '
        Me.TituloModulo.Size = New System.Drawing.Size(458, 32)
        Me.TituloModulo.Text = "                             Registro de Monedas"
        '
        'SqlConnection
        '
        Me.SqlConnection.ConnectionString = "workstation id=SEESOFTELIAS;packet size=4096;integrated security=SSPI;data source" & _
            "=""(local)"";persist security info=False;initial catalog=Seguridad"
        Me.SqlConnection.FireInfoMessageEventOnUserErrors = False
        '
        'DaMoneda
        '
        Me.DaMoneda.DeleteCommand = Me.SqlDeleteCommand1
        Me.DaMoneda.InsertCommand = Me.SqlInsertCommand1
        Me.DaMoneda.SelectCommand = Me.SqlSelectCommand1
        Me.DaMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable")})})
        Me.DaMoneda.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"), New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 75, "CuentaContable")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo, CuentaContable " & _
            "FROM Moneda"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"), New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 75, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCuentaContable)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtCompra)
        Me.GroupBox1.Controls.Add(Me.TxtSimbolo)
        Me.GroupBox1.Controls.Add(Me.TxtVenta)
        Me.GroupBox1.Controls.Add(Me.TxtMoneda)
        Me.GroupBox1.Controls.Add(Me.TxtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 104)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        '
        'txtCuentaContable
        '
        Me.txtCuentaContable.Location = New System.Drawing.Point(336, 80)
        Me.txtCuentaContable.Name = "txtCuentaContable"
        Me.txtCuentaContable.Size = New System.Drawing.Size(112, 20)
        Me.txtCuentaContable.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(336, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cuenta contable:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCompra
        '
        Me.TxtCompra.Location = New System.Drawing.Point(8, 80)
        Me.TxtCompra.Name = "TxtCompra"
        Me.TxtCompra.Size = New System.Drawing.Size(96, 20)
        Me.TxtCompra.TabIndex = 2
        '
        'TxtSimbolo
        '
        Me.TxtSimbolo.Location = New System.Drawing.Point(216, 80)
        Me.TxtSimbolo.Name = "TxtSimbolo"
        Me.TxtSimbolo.Size = New System.Drawing.Size(112, 20)
        Me.TxtSimbolo.TabIndex = 4
        '
        'TxtVenta
        '
        Me.TxtVenta.Location = New System.Drawing.Point(112, 80)
        Me.TxtVenta.Name = "TxtVenta"
        Me.TxtVenta.Size = New System.Drawing.Size(100, 20)
        Me.TxtVenta.TabIndex = 3
        '
        'TxtMoneda
        '
        Me.TxtMoneda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMoneda.Location = New System.Drawing.Point(120, 32)
        Me.TxtMoneda.Name = "TxtMoneda"
        Me.TxtMoneda.Size = New System.Drawing.Size(312, 20)
        Me.TxtMoneda.TabIndex = 1
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(8, 32)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodigo.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(216, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Simbolo"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(112, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Valor de Venta"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(8, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Código"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor de Compra"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(120, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de Moneda"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSetMoneda
        '
        Me.DataSetMoneda.DataSetName = "DataSetMoneda"
        Me.DataSetMoneda.Locale = New System.Globalization.CultureInfo("")
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
        Me.ImageList1.Images.SetKeyName(9, "")
        '
        'FrmMoneda
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(458, 199)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmMoneda"
        Me.Text = "Moneda"
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataSetMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmMoneda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' SqlConnection.ConnectionString = CadenaConexionSeguridad
        SqlConnection.ConnectionString = IIf(NuevaConexion = "", CadenaConexionSeePOS, NuevaConexion)
        Me.DaMoneda.Fill(Me.DataSetMoneda, "Moneda")
        Me.ToolBar1.Buttons(4).Visible = False
        desactivaCampos()
        Binding()
        DataNavigator.Enabled = True
        Me.StartPosition = FormStartPosition.CenterParent
    End Sub
  
    Private Sub TxtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtCompra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCompra.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtMoneda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMoneda.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub TxtVenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtVenta.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub


    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0 : Nuevo() 'Me.NuevosDatos1(Me.DataSetMoneda, Me.DataSetMoneda.Moneda.ToString)
            Case 1 : Editar()
            Case 2 : If PMU.Update Then Registra() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3 : If PMU.Delete Then Me.EliminarDatos(Me.DaMoneda, Me.DataSetMoneda, Me.DataSetMoneda.Moneda.ToString) Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 4 : If PMU.Update Then Me.RegistrarDatos(Me.DaMoneda, Me.DataSetMoneda, Me.DataSetMoneda.Moneda.ToString) Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 6 : Me.Cerrar()
        End Select
    End Sub
    'Define dataset y tablas para crear  un nuevo campo
    Function Nuevo()
        Try

            If Me.ToolBarNuevo.Text = "Nuevo" Then

                Me.ToolBarNuevo.Text = "Cancel"
                Me.ToolBarNuevo.ImageIndex = 4

                Me.ToolBarBuscar.Enabled = False
                Me.ToolBarEliminar.Enabled = False
                Me.ToolBarRegistrar.Enabled = True

                Me.BindingContext(Me.DataSetMoneda, "Moneda").EndCurrentEdit()
                Me.BindingContext(Me.DataSetMoneda, "Moneda").AddNew()

                activaCampos()



                DataNavigator.Enabled = False

            Else

                Me.ToolBarNuevo.Text = "Nuevo"
                Me.ToolBarNuevo.ImageIndex = 0
                Me.ToolBarBuscar.Enabled = True
                Me.ToolBarEliminar.Enabled = True
                Me.ToolBarRegistrar.Enabled = False

                desactivaCampos()
                Me.BindingContext(Me.DataSetMoneda, "Moneda").CancelCurrentEdit()
                DataNavigator.Enabled = True

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
                activaCampos()
                'TextBox8.Focus()
                DataNavigator.Enabled = False
            Else
                Me.BindingContext(Me.DataSetMoneda, "Moneda").CancelCurrentEdit()
                Me.ToolBarBuscar.Text = "Editar"
                Me.ToolBarBuscar.ImageIndex = 9
                Me.ToolBarNuevo.Enabled = True
                Me.ToolBarEliminar.Enabled = True
                Me.ToolBarRegistrar.Enabled = False
                DataNavigator.Enabled = True
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

            Me.BindingContext(Me.DataSetMoneda, "Moneda").EndCurrentEdit()
            Me.DaMoneda.Update(Me.DataSetMoneda.Moneda)

            Me.DataSetMoneda.GetChanges()

            desactivaCampos()
            DataNavigator.Enabled = True

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
    Private Sub desactivaCampos()

        Me.TxtCodigo.Enabled = False
        Me.TxtCompra.Enabled = False
        Me.TxtMoneda.Enabled = False
        Me.TxtSimbolo.Enabled = False
        Me.TxtVenta.Enabled = False
        Me.txtCuentaContable.Enabled = False
    End Sub
    Private Sub activaCampos()

        Me.TxtCodigo.Enabled = True
        Me.TxtCompra.Enabled = True
        Me.TxtMoneda.Enabled = True
        Me.TxtSimbolo.Enabled = True
        Me.TxtVenta.Enabled = True
        Me.txtCuentaContable.Enabled = True

    End Sub
    Function Binding()


        Me.TxtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetMoneda, "Moneda.CodMoneda"))
        Me.TxtMoneda.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetMoneda, "Moneda.MonedaNombre"))
        Me.TxtCompra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetMoneda, "Moneda.ValorCompra"))
        Me.TxtVenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetMoneda, "Moneda.ValorVenta"))
        Me.TxtSimbolo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetMoneda, "Moneda.Simbolo"))
        Me.txtCuentaContable.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetMoneda, "Moneda.CuentaContable"))
      

    End Function

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtCuentaContable_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuentaContable.TextChanged

    End Sub

    Private Sub txtCuentaContable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaContable.KeyDown
        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta(txtCuentaContable)

        End If

        If e.KeyCode = Keys.Enter Then

            If txtCuentaContable.Text.Length = 0 Then

                Exit Sub
            End If
            If Buscar(txtCuentaContable) = False Then
                Me.txtCuentaContable.Focus()
            End If
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub LlamarFmrBuscarAsientoVenta(ByRef ObjetoTxtCodigo As Windows.Forms.TextBox)


        Dim busca As New fmrBuscarMayorizacionAsiento
        busca.NuevaConexion = GetSetting("SeeSoft", "Contabilidad", "CONEXION")
        busca.sqlstring = " select CC.cuentacontable as [Cuenta contable],CC.descripcion as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " & _
" where Movimiento=1 "
        busca.campo = "descripcion"
        busca.sqlStringAdicional = " ORDER BY CuentaContable  "
        busca.ShowDialog()

        If busca.codigo Is Nothing Then Exit Sub


        ObjetoTxtCodigo.Text = busca.codigo

        SendKeys.Send("{TAB}")

    End Sub

    Private Function Buscar(ByRef ObjetoTxtCodigo As Windows.Forms.TextBox) As Boolean

        If ObjetoTxtCodigo.Text.Length = 0 Then

            Exit Function
        End If


        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String = "SELECT Id,descripcion  FROM CuentaContable WHERE CuentaContable ='" & ObjetoTxtCodigo.Text & "'"

        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Contabilidad", "CONEXION")
        cnnConexion.Open()
        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        If rstReader Is Nothing Then
            ObjetoTxtCodigo.Text = ""


            MsgBox("No existe ese codigo de cuenta", MsgBoxStyle.Information)
            Exit Function
        End If

        If rstReader.Read = False Then
            ObjetoTxtCodigo.Text = ""


            MsgBox("No existe ese codigo de cuenta", MsgBoxStyle.Information)
            Exit Function
        End If

        If rstReader.IsDBNull(0) Then
            ObjetoTxtCodigo.Text = ""


            MsgBox("No existe ese codigo de cuenta", MsgBoxStyle.Information)
            Exit Function
        End If


        cnnConexion.Close()
        Buscar = True
    End Function

    
    Private Sub TxtSimbolo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSimbolo.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class
