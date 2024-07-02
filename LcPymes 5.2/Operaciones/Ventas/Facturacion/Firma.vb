Imports System.Data
Imports System.Data.SqlClient

Public Class Firma
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents AdapterEncargadoCompras As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DataSet_EncargadoCompras1 As LcPymes_5._2.DataSet_EncargadoCompras
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarCedula As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents CB_Encargado As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.BCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAgregarCedula = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_Encargado = New System.Windows.Forms.ComboBox()
        Me.DataSet_EncargadoCompras1 = New LcPymes_5._2.DataSet_EncargadoCompras()
        Me.AdapterEncargadoCompras = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet_EncargadoCompras1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BAceptar
        '
        Me.BAceptar.Location = New System.Drawing.Point(90, 139)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(72, 24)
        Me.BAceptar.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.BAceptar.TabIndex = 1
        Me.BAceptar.Text = "Aceptar"
        '
        'BCancelar
        '
        Me.BCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BCancelar.Location = New System.Drawing.Point(202, 139)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(72, 24)
        Me.BCancelar.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.BCancelar.TabIndex = 2
        Me.BCancelar.Text = "Cancelar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.btnAgregarCedula)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCedula)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 125)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Firma la factura"
        '
        'btnAgregarCedula
        '
        Me.btnAgregarCedula.Image = Global.LcPymes_5._2.My.Resources.Resources.page_add
        Me.btnAgregarCedula.Location = New System.Drawing.Point(311, 31)
        Me.btnAgregarCedula.Name = "btnAgregarCedula"
        Me.btnAgregarCedula.Size = New System.Drawing.Size(25, 24)
        Me.btnAgregarCedula.TabIndex = 4
        Me.btnAgregarCedula.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre "
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(8, 33)
        Me.txtCedula.MaxLength = 13
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(301, 20)
        Me.txtCedula.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese el NUMERO de cedula"
        '
        'CB_Encargado
        '
        Me.CB_Encargado.DataSource = Me.DataSet_EncargadoCompras1.encargadocompras
        Me.CB_Encargado.DisplayMember = "Nombre"
        Me.CB_Encargado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CB_Encargado.Enabled = False
        Me.CB_Encargado.Location = New System.Drawing.Point(397, 90)
        Me.CB_Encargado.Name = "CB_Encargado"
        Me.CB_Encargado.Size = New System.Drawing.Size(173, 21)
        Me.CB_Encargado.TabIndex = 0
        Me.CB_Encargado.ValueMember = "Nombre"
        '
        'DataSet_EncargadoCompras1
        '
        Me.DataSet_EncargadoCompras1.DataSetName = "DataSet_EncargadoCompras"
        Me.DataSet_EncargadoCompras1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DataSet_EncargadoCompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdapterEncargadoCompras
        '
        Me.AdapterEncargadoCompras.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterEncargadoCompras.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "encargadocompras", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Cliente", "Cliente")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Nombre, Cliente FROM encargadocompras"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
    "persist security info=False;initial catalog=SeePos"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(8, 82)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(301, 20)
        Me.txtNombre.TabIndex = 5
        '
        'Firma
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.BCancelar
        Me.ClientSize = New System.Drawing.Size(365, 175)
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CB_Encargado)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Firma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Firma"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataSet_EncargadoCompras1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Public Cliente As String
    Public Encargado As String
    Private sqlConexion As SqlConnection
#End Region

#Region "Load"
    Private Sub Firma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = CadenaConexionSeePOS
            Carga_encargados(Cliente)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Carga_encargados(ByVal Cliente As String)
        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        '
        ' Dentro de un Try/Catch por si se produce un error
        Try
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = CadenaConexionSeePOS
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            ' Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT Cliente, Nombre From EncargadoCompras WHERE (Cliente = @Cliente)"

            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Cliente", SqlDbType.Decimal))
            cmdv.Parameters("@Cliente").Value = CDec(Cliente)

            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(Me.DataSet_EncargadoCompras1, "encargadocompras")

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
    End Sub
#End Region

#Region "Funciones controles"
    Private Sub BAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAceptar.Click
        Try
            If Me.txtNombre.Text <> "" Then
                Encargado = txtNombre.Text
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancelar.Click
        Try
            DialogResult = Windows.Forms.DialogResult.Cancel
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CB_Encargado_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CB_Encargado.GotFocus
        CB_Encargado.SelectAll()
    End Sub
#End Region

    Private Function GetNombre(_Cedula As String) As String
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select NOMBRECOMPLETO2 from ENTIDADES_FISICAS where cedula2 = '" & _Cedula & "'", dt, CadenaConexionCedulas)
        If dt.Rows.Count > 0 Then

            Return dt.Rows(0).Item("NOMBRECOMPLETO2")
        Else
            Dim dt2 As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select NOMBRE from ENTIDADES_FIRMA where CEDULA = '" & _Cedula & "'", dt2, CadenaConexionCedulas)
            If dt2.Rows.Count > 0 Then
                Return dt2.Rows(0).Item("NOMBRE")
            Else
                Return "0"
            End If
        End If
    End Function

    Private Sub CB_Encargado_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles CB_Encargado.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub BuscarCedula()
        Dim nombre As String = Me.GetNombre(Me.txtCedula.Text)
        If nombre <> "0" Then
            Me.txtNombre.Text = nombre
        Else
            Try
                Me.txtNombre.Text = ""
                Dim ObtenerDatosCliente As api.Hacienda.Entidad = api.Hacienda.Consultar_x_Cedula(Me.txtCedula.Text)
                Me.txtNombre.Text = ObtenerDatosCliente.nombre
            Catch ex As Exception
            End Try

        End If
    End Sub

    Private Sub txtCedula_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtCedula.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            Me.BuscarCedula()
        End If
    End Sub

    Private Sub txtCedula_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtCedula.KeyPress
         e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub btnAgregarCedula_Click(sender As Object, e As EventArgs) Handles btnAgregarCedula.Click
        Dim frm As New frmFirmaNuevaCedula
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.txtCedula.Text = frm.txtCedula.Text
            Me.BuscarCedula()
        End If
    End Sub

End Class
