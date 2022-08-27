Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class frmCambiaCaja
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
    Friend WithEvents ComboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextNumero As ValidText.ValidText
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DtVence As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ValidText1 As ValidText.ValidText
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ValidText2 As ValidText.ValidText
    Friend WithEvents btnPasar As System.Windows.Forms.Button
    Friend WithEvents DataSetDevolucionVentas1 As LcPymes_5._2.DataSetDevolucionVentas
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents txtCedulaUsuario As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ComboTipo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextNumero = New ValidText.ValidText
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.DataSetDevolucionVentas1 = New LcPymes_5._2.DataSetDevolucionVentas
        Me.Label5 = New System.Windows.Forms.Label
        Me.DtVence = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ValidText1 = New ValidText.ValidText
        Me.Label6 = New System.Windows.Forms.Label
        Me.ValidText2 = New ValidText.ValidText
        Me.btnPasar = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label36 = New System.Windows.Forms.Label
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.txtNombreUsuario = New System.Windows.Forms.Label
        Me.txtCedulaUsuario = New System.Windows.Forms.TextBox
        CType(Me.DataSetDevolucionVentas1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboTipo
        '
        Me.ComboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboTipo.Items.AddRange(New Object() {"CON", "CRE", "PVE", "TCO", "TCR", "MCO", "MCR"})
        Me.ComboTipo.Location = New System.Drawing.Point(0, 16)
        Me.ComboTipo.Name = "ComboTipo"
        Me.ComboTipo.Size = New System.Drawing.Size(104, 21)
        Me.ComboTipo.TabIndex = 204
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(112, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 16)
        Me.Label1.TabIndex = 203
        Me.Label1.Text = "Número"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 202
        Me.Label2.Text = "Tipo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextNumero
        '
        Me.TextNumero.FieldReference = Nothing
        Me.TextNumero.Location = New System.Drawing.Point(112, 16)
        Me.TextNumero.MaskEdit = ""
        Me.TextNumero.Name = "TextNumero"
        Me.TextNumero.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TextNumero.Required = False
        Me.TextNumero.ShowErrorIcon = False
        Me.TextNumero.Size = New System.Drawing.Size(102, 20)
        Me.TextNumero.TabIndex = 205
        Me.TextNumero.Text = ""
        Me.TextNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextNumero.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.TextNumero.ValidText = Nothing
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetDevolucionVentas1, "Ventas.Nombre_Cliente"))
        Me.txtNombre.Enabled = False
        Me.txtNombre.ForeColor = System.Drawing.Color.Blue
        Me.txtNombre.Location = New System.Drawing.Point(0, 56)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(344, 20)
        Me.txtNombre.TabIndex = 207
        Me.txtNombre.Text = ""
        '
        'DataSetDevolucionVentas1
        '
        Me.DataSetDevolucionVentas1.DataSetName = "DataSetDevolucionVentas"
        Me.DataSetDevolucionVentas1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(0, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(344, 16)
        Me.Label5.TabIndex = 206
        Me.Label5.Text = "Nombre del Cliente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DtVence
        '
        Me.DtVence.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtVence.Checked = False
        Me.DtVence.CustomFormat = ""
        Me.DtVence.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataSetDevolucionVentas1, "Ventas.Fecha"))
        Me.DtVence.Enabled = False
        Me.DtVence.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtVence.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DtVence.Location = New System.Drawing.Point(224, 16)
        Me.DtVence.Name = "DtVence"
        Me.DtVence.Size = New System.Drawing.Size(120, 20)
        Me.DtVence.TabIndex = 209
        Me.DtVence.Value = New Date(2006, 3, 15, 10, 56, 38, 537)
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(224, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 208
        Me.Label4.Text = "Fecha"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(0, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 210
        Me.Label3.Text = "Apertura Actual"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ValidText1
        '
        Me.ValidText1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetDevolucionVentas1, "Ventas.Num_Apertura"))
        Me.ValidText1.FieldReference = Nothing
        Me.ValidText1.Location = New System.Drawing.Point(0, 104)
        Me.ValidText1.MaskEdit = ""
        Me.ValidText1.Name = "ValidText1"
        Me.ValidText1.ReadOnly = True
        Me.ValidText1.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.ValidText1.Required = False
        Me.ValidText1.ShowErrorIcon = False
        Me.ValidText1.Size = New System.Drawing.Size(102, 20)
        Me.ValidText1.TabIndex = 211
        Me.ValidText1.Text = ""
        Me.ValidText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ValidText1.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.ValidText1.ValidText = Nothing
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(120, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 16)
        Me.Label6.TabIndex = 212
        Me.Label6.Text = "(F1) Apertura"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ValidText2
        '
        Me.ValidText2.FieldReference = Nothing
        Me.ValidText2.Location = New System.Drawing.Point(120, 104)
        Me.ValidText2.MaskEdit = ""
        Me.ValidText2.Name = "ValidText2"
        Me.ValidText2.ReadOnly = True
        Me.ValidText2.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.ValidText2.Required = False
        Me.ValidText2.ShowErrorIcon = False
        Me.ValidText2.Size = New System.Drawing.Size(102, 20)
        Me.ValidText2.TabIndex = 213
        Me.ValidText2.Text = ""
        Me.ValidText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ValidText2.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.ValidText2.ValidText = Nothing
        '
        'btnPasar
        '
        Me.btnPasar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPasar.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnPasar.Location = New System.Drawing.Point(232, 88)
        Me.btnPasar.Name = "btnPasar"
        Me.btnPasar.Size = New System.Drawing.Size(112, 40)
        Me.btnPasar.TabIndex = 214
        Me.btnPasar.Text = "Pasar"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboTipo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextNumero)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.DtVence)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ValidText1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.ValidText2)
        Me.Panel1.Controls.Add(Me.btnPasar)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(344, 128)
        Me.Panel1.TabIndex = 215
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label36)
        Me.Panel2.Controls.Add(Me.txtUsuario)
        Me.Panel2.Controls.Add(Me.txtNombreUsuario)
        Me.Panel2.Controls.Add(Me.txtCedulaUsuario)
        Me.Panel2.Location = New System.Drawing.Point(16, 152)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(336, 14)
        Me.Panel2.TabIndex = 216
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(-8, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 13)
        Me.Label36.TabIndex = 1
        Me.Label36.Text = "Usuario->"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(64, 0)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(56, 13)
        Me.txtUsuario.TabIndex = 0
        Me.txtUsuario.Text = ""
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BackColor = System.Drawing.Color.Transparent
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(121, 0)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(163, 13)
        Me.txtNombreUsuario.TabIndex = 2
        '
        'txtCedulaUsuario
        '
        Me.txtCedulaUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtCedulaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCedulaUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedulaUsuario.Enabled = False
        Me.txtCedulaUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtCedulaUsuario.Location = New System.Drawing.Point(211, 16)
        Me.txtCedulaUsuario.Name = "txtCedulaUsuario"
        Me.txtCedulaUsuario.Size = New System.Drawing.Size(72, 13)
        Me.txtCedulaUsuario.TabIndex = 170
        Me.txtCedulaUsuario.Text = ""
        '
        'frmCambiaCaja
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(360, 173)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCambiaCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Caja"
        CType(Me.DataSetDevolucionVentas1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub TextNumero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextNumero.TextChanged

    End Sub

    Private Sub TextNumero_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextNumero.KeyDown
        Dim Num_Fatura As String
        Dim Cfunciones As New Cfunciones
        Dim cConexion As New Conexion
        Dim rs As SqlDataReader
        Dim Venta As DataTable
        Dim identificador As Double
        Try
            If e.KeyCode = Keys.F1 Then

                identificador = CDbl(Cfunciones.Buscar_X_Descripcion_Fecha("Select Id, cast(num_factura as varchar) + '-' + TIPO as Factura, Nombre_Cliente as Cliente,Fecha from Ventas where Anulado = 0 Order by Fecha DESC", "Cliente", "Fecha", "Buscar Factura de Venta"))
                rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT Tipo, Num_Factura from Ventas where Id =" & identificador)
                If rs.HasRows = False Then
                    MsgBox("La Factura no esta digitada", MsgBoxStyle.Information, "Atención...")
                    TextNumero.Focus()
                End If
                While rs.Read
                    Try
                        TextNumero.Text = rs("Num_Factura")
                        ComboTipo.Text = rs("Tipo")
                    Catch eEndEdit As System.Data.NoNullAllowedException
                        System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
                    End Try
                End While
                rs.Close()
                cConexion.DesConectar(cConexion.sQlconexion)
                'si esta venta aun no ha sido anulada
            End If
            If e.KeyCode = Keys.Enter Then
                If ValidarBusqueda() Then
                    LLenarFactura(CDbl(TextNumero.Text), ComboTipo.Text)
                    If Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Count > 0 Then
                        DtVence.Value = Me.DataSetDevolucionVentas1.Ventas(0).Fecha
                        Me.txtNombre.Text = Me.DataSetDevolucionVentas1.Ventas(0).Nombre_Cliente
                        Me.ValidText1.Text = Me.DataSetDevolucionVentas1.Ventas(0).Num_Apertura

                        If Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Tipo") = "CON" And Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("FacturaCancelado") = False Then
                            MsgBox("Esta factura de CONTADO no ha sido Pagada, No se puede realizar la operacion", MsgBoxStyle.Information)
                            Exit Sub
                        End If

                        If Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Anulado") = True Then
                            MsgBox("La Factura Nª " & TextNumero.Text & " ha sido anulada, no se pueden realizar la operacion", MsgBoxStyle.Information)
                            Me.DataSetDevolucionVentas1.Ventas.Clear()
                            Me.DataSetDevolucionVentas1.articulos_ventas_devueltos.Clear()

                            Exit Sub
                        End If
                    End If
                End If
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub

    Function ValidarBusqueda() As Boolean
        If Me.ComboTipo.Text.Length > 0 Then

        Else
            MsgBox("Debes Seleccionar un numero de factura ", MsgBoxStyle.Information, "Atención...........")
            ComboTipo.Focus()
            Return False
        End If
        If Me.TextNumero.Text.Length > 0 Then

        Else
            MsgBox("Debes Digitar un numero de factura ", MsgBoxStyle.Information, "Atención...........")
            TextNumero.Focus()
            Return False
        End If
        Return True
    End Function

    Function LLenarFactura(ByVal Num_Factura As Double, ByVal Tipo As String)
        Dim cnn As SqlConnection = Nothing
        Try
            Me.DataSetDevolucionVentas1.Ventas.Clear()
            'Obtenemos la cadena de conexión adecuada
            Dim sConn As String = CadenaConexionSeePOS

            cnn = New SqlConnection(sConn)
            cnn.Open()
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM Ventas WHERE (Tipo = @Tipo) AND (Num_Factura = @Num_Factura)"

            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmd.Parameters.Add(New SqlParameter("@Tipo", SqlDbType.VarChar))
            cmd.Parameters.Add(New SqlParameter("@Num_Factura", SqlDbType.BigInt))
            'cmd.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.VarChar))
            'cmd.Parameters.Add(New SqlParameter("@Tipo", SqlDbType.Int))
            cmd.Parameters("@Tipo").Value = Tipo
            cmd.Parameters("@Num_Factura").Value = Num_Factura
            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            ' Llenamos la tabla

            da.Fill(Me.DataSetDevolucionVentas1.Ventas)

        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try
    End Function

    Private Sub ValidText2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ValidText2.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim cFunciones As New cFunciones
            Dim c As String
            c = cFunciones.BuscarDatos("SELECT NApertura, Nombre, Num_Caja from aperturacaja where Estado = 'A' AND Anulado = 0 AND NApertura <> " & ValidText1.Text, "Nombre")
            If c <> "" Then
                ValidText2.Text = c
            Else
                ValidText2.Text = ""
            End If
        End If
    End Sub

    Private Sub Limpiar()
        Me.DataSetDevolucionVentas1.Ventas.Clear()
        Me.ValidText2.Text = ""
        Me.ValidText1.Text = ""
        Me.txtNombre.Text = ""
    End Sub

    Private Sub Valida(ByVal _pas As String)
        Dim dts As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Cedula, Nombre from Usuarios where Clave_Interna = '" & _pas & "'", dts, CadenaConexionSeePOS)
        If dts.Rows.Count > 0 Then
            Me.txtNombreUsuario.Text = dts.Rows(0).Item("Nombre")
            If VerificandoAcceso_a_Modulos("CambiaCaja", "CambiaCaja", dts.Rows(0).Item("Cedula"), "Administración") = False Then
                Me.Panel1.Enabled = False
                MsgBox("El usuario no tiene el permiso para realizar esta operacion", MsgBoxStyle.Exclamation, Text)
            Else
                Me.Panel1.Enabled = True
                Me.ComboTipo.Select()
            End If
        Else
            Me.Panel1.Enabled = False
            Me.txtNombreUsuario.Text = " -  -  -  -  -"
        End If
    End Sub

    Private Sub btnPasar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPasar.Click
        Try
            Dim db As New GestioDatos
            Dim Tipo As String = ""
            If Me.ValidText2.Text <> "" Then
                If Me.ValidText1.Text <> Me.ValidText2.Text Then
                    If MsgBox("Desea cambiar de caja la factura # " & Me.DataSetDevolucionVentas1.Ventas(0).Num_Factura, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion") = MsgBoxResult.No Then
                        Exit Sub
                    End If
                    Select Case Me.DataSetDevolucionVentas1.Ventas(0).Tipo
                        Case "MCO"
                            Tipo = "FVM"
                        Case "PVE"
                            Tipo = "FVP"
                        Case "TCO"
                            Tipo = "FVT"
                        Case "CON"
                            Tipo = "FVC"
                        Case Else
                            Tipo = ""
                    End Select
                    If Tipo <> "" Then
                        db.Ejecuta("update ventas set Num_Apertura = " & Me.ValidText2.Text & " where id = " & Me.DataSetDevolucionVentas1.Ventas(0).Id)
                        db.Ejecuta("update opcionesdepago set Numapertura = " & Me.ValidText2.Text & " where Documento = " & Me.DataSetDevolucionVentas1.Ventas(0).Num_Factura & " and TipoDocumento = '" & Tipo & "'")
                        MsgBox("Cambio Realizado!!!", MsgBoxStyle.Information, Text)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
        End Try
    End Sub

    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Valida(Me.txtUsuario.Text)
        End If
    End Sub
End Class
