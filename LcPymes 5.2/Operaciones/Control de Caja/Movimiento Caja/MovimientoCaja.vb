Imports System.Data
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Drawing.Printing


Public Class MovimientoCaja
    Inherits FrmPlantilla

#Region "Variables"
    Dim cedu, nombre As String
    Dim NApertura As Double
    Dim cargando As Boolean = False
    Dim registra As Boolean = False
    Friend WithEvents txtCodigoCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents ckVincular As System.Windows.Forms.CheckBox
    Friend WithEvents btnBuscarCliente As System.Windows.Forms.Button
    Dim usua
#End Region

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub


    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        usua = Usuario_Parametro
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
    Friend WithEvents Option_Entrada As System.Windows.Forms.RadioButton
    Friend WithEvents Option_Salida As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label_Fecha As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBo_Moneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Adapter_Moneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DataSet_MovimientoCaja1 As DataSet_MovimientoCaja
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Text_Observaciones As System.Windows.Forms.TextBox
    Friend WithEvents Apertura_Caja As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adapter_MovimientoCaja As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label_TipoCambio As System.Windows.Forms.Label
    Friend WithEvents Calc_Monto As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Tipo_Cambio As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Check_Anulado As System.Windows.Forms.CheckBox
    Friend WithEvents Label_Anulado As System.Windows.Forms.Label
    Friend WithEvents LabelId As System.Windows.Forms.Label
    Friend WithEvents CK_PVE As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MovimientoCaja))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Option_Salida = New System.Windows.Forms.RadioButton()
        Me.DataSet_MovimientoCaja1 = New LcPymes_5._2.DataSet_MovimientoCaja()
        Me.Option_Entrada = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label_Fecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBo_Moneda = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.Adapter_Moneda = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Text_Observaciones = New System.Windows.Forms.TextBox()
        Me.Apertura_Caja = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_MovimientoCaja = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.Label_TipoCambio = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Calc_Monto = New DevExpress.XtraEditors.CalcEdit()
        Me.Tipo_Cambio = New System.Windows.Forms.TextBox()
        Me.Check_Anulado = New System.Windows.Forms.CheckBox()
        Me.Label_Anulado = New System.Windows.Forms.Label()
        Me.LabelId = New System.Windows.Forms.Label()
        Me.CK_PVE = New System.Windows.Forms.CheckBox()
        Me.txtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.ckVincular = New System.Windows.Forms.CheckBox()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet_MovimientoCaja1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Calc_Monto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Enabled = False
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Enabled = False
        Me.ToolBarEliminar.Text = "Anular"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Enabled = False
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
        Me.ToolBar1.Location = New System.Drawing.Point(0, 332)
        Me.ToolBar1.Size = New System.Drawing.Size(634, 60)
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.Location = New System.Drawing.Point(267, 399)
        Me.DataNavigator.Size = New System.Drawing.Size(160, 24)
        Me.DataNavigator.Visible = False
        '
        'TituloModulo
        '
        Me.TituloModulo.Size = New System.Drawing.Size(634, 37)
        Me.TituloModulo.Text = " Módulo Movimiento Caja"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Option_Salida)
        Me.GroupBox1.Controls.Add(Me.Option_Entrada)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Location = New System.Drawing.Point(19, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(183, 46)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo Movimento"
        '
        'Option_Salida
        '
        Me.Option_Salida.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_MovimientoCaja1, "Movimiento_Caja.Salida", True))
        Me.Option_Salida.Location = New System.Drawing.Point(96, 18)
        Me.Option_Salida.Name = "Option_Salida"
        Me.Option_Salida.Size = New System.Drawing.Size(67, 19)
        Me.Option_Salida.TabIndex = 1
        Me.Option_Salida.Text = "Salida"
        '
        'DataSet_MovimientoCaja1
        '
        Me.DataSet_MovimientoCaja1.DataSetName = "DataSet_MovimientoCaja"
        Me.DataSet_MovimientoCaja1.Locale = New System.Globalization.CultureInfo("es-MX")
        Me.DataSet_MovimientoCaja1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Option_Entrada
        '
        Me.Option_Entrada.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_MovimientoCaja1, "Movimiento_Caja.Entrada", True))
        Me.Option_Entrada.Location = New System.Drawing.Point(10, 18)
        Me.Option_Entrada.Name = "Option_Entrada"
        Me.Option_Entrada.Size = New System.Drawing.Size(86, 19)
        Me.Option_Entrada.TabIndex = 0
        Me.Option_Entrada.Text = "Entrada"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.TxtNombreUsuario)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Location = New System.Drawing.Point(371, 370)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(349, 19)
        Me.Panel1.TabIndex = 71
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(-10, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 15)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Usuario->"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtNombreUsuario
        '
        Me.TxtNombreUsuario.BackColor = System.Drawing.Color.Silver
        Me.TxtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombreUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.TxtNombreUsuario.Location = New System.Drawing.Point(144, 0)
        Me.TxtNombreUsuario.Name = "TxtNombreUsuario"
        Me.TxtNombreUsuario.ReadOnly = True
        Me.TxtNombreUsuario.Size = New System.Drawing.Size(202, 16)
        Me.TxtNombreUsuario.TabIndex = 2
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(77, 0)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(67, 16)
        Me.txtUsuario.TabIndex = 1
        '
        'txtCedula
        '
        Me.txtCedula.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_MovimientoCaja1, "Movimiento_Caja.Usuario", True))
        Me.txtCedula.Location = New System.Drawing.Point(557, 352)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(144, 22)
        Me.txtCedula.TabIndex = 73
        '
        'Label_Fecha
        '
        Me.Label_Fecha.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_MovimientoCaja1, "Movimiento_Caja.Fecha", True))
        Me.Label_Fecha.Location = New System.Drawing.Point(211, 74)
        Me.Label_Fecha.Name = "Label_Fecha"
        Me.Label_Fecha.Size = New System.Drawing.Size(298, 18)
        Me.Label_Fecha.TabIndex = 74
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(211, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 19)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Fecha del Movimiento"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(19, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(346, 18)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Monto Movimiento"
        '
        'ComboBo_Moneda
        '
        Me.ComboBo_Moneda.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet_MovimientoCaja1, "Movimiento_Caja.CodMoneda", True))
        Me.ComboBo_Moneda.DataSource = Me.DataSet_MovimientoCaja1
        Me.ComboBo_Moneda.DisplayMember = "Moneda.MonedaNombre"
        Me.ComboBo_Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBo_Moneda.ForeColor = System.Drawing.SystemColors.Highlight
        Me.ComboBo_Moneda.Location = New System.Drawing.Point(518, 74)
        Me.ComboBo_Moneda.Name = "ComboBo_Moneda"
        Me.ComboBo_Moneda.Size = New System.Drawing.Size(144, 24)
        Me.ComboBo_Moneda.TabIndex = 77
        Me.ComboBo_Moneda.ValueMember = "Moneda.CodMoneda"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(518, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 19)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Moneda"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=HAZEL;packet size=4096;integrated security=SSPI;data source=""(loca" & _
    "l)"";persist security info=False;initial catalog=SEEPOS"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'Adapter_Moneda
        '
        Me.Adapter_Moneda.SelectCommand = Me.SqlSelectCommand1
        Me.Adapter_Moneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(19, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(701, 18)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Observaciones"
        '
        'Text_Observaciones
        '
        Me.Text_Observaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Text_Observaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_MovimientoCaja1, "Movimiento_Caja.Observaciones", True))
        Me.Text_Observaciones.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Text_Observaciones.Location = New System.Drawing.Point(19, 212)
        Me.Text_Observaciones.Multiline = True
        Me.Text_Observaciones.Name = "Text_Observaciones"
        Me.Text_Observaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Text_Observaciones.Size = New System.Drawing.Size(701, 56)
        Me.Text_Observaciones.TabIndex = 80
        '
        'Apertura_Caja
        '
        Me.Apertura_Caja.SelectCommand = Me.SqlSelectCommand2
        Me.Apertura_Caja.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "aperturacaja", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NApertura", "NApertura"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Estado", "Estado"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("Cedula", "Cedula")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT NApertura, Fecha, Nombre, Estado, Observaciones, Anulado, Cedula FROM aper" & _
    "turacaja"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'Adapter_MovimientoCaja
        '
        Me.Adapter_MovimientoCaja.DeleteCommand = Me.SqlDeleteCommand1
        Me.Adapter_MovimientoCaja.InsertCommand = Me.SqlInsertCommand1
        Me.Adapter_MovimientoCaja.SelectCommand = Me.SqlSelectCommand3
        Me.Adapter_MovimientoCaja.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Movimiento_Caja", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Entrada", "Entrada"), New System.Data.Common.DataColumnMapping("Salida", "Salida"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("Usuario", "Usuario"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("NumApertura", "NumApertura"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio")})})
        Me.Adapter_MovimientoCaja.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Entrada", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Entrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumApertura", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumApertura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Salida", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salida", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Entrada", System.Data.SqlDbType.Bit, 1, "Entrada"), New System.Data.SqlClient.SqlParameter("@Salida", System.Data.SqlDbType.Bit, 1, "Salida"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 50, "Usuario"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 300, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@NumApertura", System.Data.SqlDbType.BigInt, 8, "NumApertura"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Id, Entrada, Salida, Monto, CodMoneda, Usuario, Fecha, Observaciones, Anul" & _
    "ado, NumApertura, TipoCambio FROM Movimiento_Caja"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Entrada", System.Data.SqlDbType.Bit, 1, "Entrada"), New System.Data.SqlClient.SqlParameter("@Salida", System.Data.SqlDbType.Bit, 1, "Salida"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 50, "Usuario"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 300, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@NumApertura", System.Data.SqlDbType.BigInt, 8, "NumApertura"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Entrada", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Entrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumApertura", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumApertura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Salida", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salida", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'Label_TipoCambio
        '
        Me.Label_TipoCambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_MovimientoCaja1, "Moneda.ValorCompra", True))
        Me.Label_TipoCambio.Location = New System.Drawing.Point(518, 148)
        Me.Label_TipoCambio.Name = "Label_TipoCambio"
        Me.Label_TipoCambio.Size = New System.Drawing.Size(144, 18)
        Me.Label_TipoCambio.TabIndex = 81
        Me.Label_TipoCambio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(518, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 19)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Tipo Cambio"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Calc_Monto
        '
        Me.Calc_Monto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_MovimientoCaja1, "Movimiento_Caja.Monto", True))
        Me.Calc_Monto.Location = New System.Drawing.Point(19, 135)
        Me.Calc_Monto.Name = "Calc_Monto"
        '
        '
        '
        Me.Calc_Monto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Calc_Monto.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.Calc_Monto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Calc_Monto.Properties.EditFormat.FormatString = "#,#0.00"
        Me.Calc_Monto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Calc_Monto.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.Highlight)
        Me.Calc_Monto.Size = New System.Drawing.Size(346, 43)
        Me.Calc_Monto.TabIndex = 83
        '
        'Tipo_Cambio
        '
        Me.Tipo_Cambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_MovimientoCaja1, "Movimiento_Caja.TipoCambio", True))
        Me.Tipo_Cambio.Location = New System.Drawing.Point(701, 352)
        Me.Tipo_Cambio.Name = "Tipo_Cambio"
        Me.Tipo_Cambio.Size = New System.Drawing.Size(67, 22)
        Me.Tipo_Cambio.TabIndex = 84
        '
        'Check_Anulado
        '
        Me.Check_Anulado.BackColor = System.Drawing.Color.Transparent
        Me.Check_Anulado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_MovimientoCaja1, "Movimiento_Caja.Anulado", True))
        Me.Check_Anulado.Enabled = False
        Me.Check_Anulado.Location = New System.Drawing.Point(672, 83)
        Me.Check_Anulado.Name = "Check_Anulado"
        Me.Check_Anulado.Size = New System.Drawing.Size(86, 19)
        Me.Check_Anulado.TabIndex = 85
        Me.Check_Anulado.Text = "Anulado"
        Me.Check_Anulado.UseVisualStyleBackColor = False
        '
        'Label_Anulado
        '
        Me.Label_Anulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Anulado.ForeColor = System.Drawing.Color.Red
        Me.Label_Anulado.Location = New System.Drawing.Point(259, 166)
        Me.Label_Anulado.Name = "Label_Anulado"
        Me.Label_Anulado.Size = New System.Drawing.Size(240, 74)
        Me.Label_Anulado.TabIndex = 86
        Me.Label_Anulado.Text = "Anulado"
        Me.Label_Anulado.Visible = False
        '
        'LabelId
        '
        Me.LabelId.AccessibleRole = System.Windows.Forms.AccessibleRole.Border
        Me.LabelId.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_MovimientoCaja1, "Movimiento_Caja.Id", True))
        Me.LabelId.Location = New System.Drawing.Point(19, 18)
        Me.LabelId.Name = "LabelId"
        Me.LabelId.Size = New System.Drawing.Size(58, 19)
        Me.LabelId.TabIndex = 87
        '
        'CK_PVE
        '
        Me.CK_PVE.BackColor = System.Drawing.Color.Transparent
        Me.CK_PVE.Location = New System.Drawing.Point(701, 37)
        Me.CK_PVE.Name = "CK_PVE"
        Me.CK_PVE.Size = New System.Drawing.Size(57, 28)
        Me.CK_PVE.TabIndex = 88
        Me.CK_PVE.Text = "PVE"
        Me.CK_PVE.UseVisualStyleBackColor = False
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoCliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_MovimientoCaja1, "Movimiento_Caja.Observaciones", True))
        Me.txtCodigoCliente.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtCodigoCliente.Location = New System.Drawing.Point(44, 294)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.ReadOnly = True
        Me.txtCodigoCliente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCodigoCliente.Size = New System.Drawing.Size(158, 22)
        Me.txtCodigoCliente.TabIndex = 90
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(19, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(701, 22)
        Me.Label5.TabIndex = 89
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreCliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_MovimientoCaja1, "Movimiento_Caja.Observaciones", True))
        Me.txtNombreCliente.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtNombreCliente.Location = New System.Drawing.Point(204, 294)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.ReadOnly = True
        Me.txtNombreCliente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNombreCliente.Size = New System.Drawing.Size(516, 22)
        Me.txtNombreCliente.TabIndex = 91
        '
        'ckVincular
        '
        Me.ckVincular.AutoSize = True
        Me.ckVincular.ForeColor = System.Drawing.SystemColors.Highlight
        Me.ckVincular.Location = New System.Drawing.Point(23, 273)
        Me.ckVincular.Name = "ckVincular"
        Me.ckVincular.Size = New System.Drawing.Size(160, 21)
        Me.ckVincular.TabIndex = 92
        Me.ckVincular.Text = "Vincular a un Cliente"
        Me.ckVincular.UseVisualStyleBackColor = True
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Location = New System.Drawing.Point(18, 294)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(25, 24)
        Me.btnBuscarCliente.TabIndex = 93
        Me.btnBuscarCliente.Text = "..."
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'MovimientoCaja
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(634, 392)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.ckVincular)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.txtCodigoCliente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CK_PVE)
        Me.Controls.Add(Me.LabelId)
        Me.Controls.Add(Me.Label_Anulado)
        Me.Controls.Add(Me.Check_Anulado)
        Me.Controls.Add(Me.Calc_Monto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label_TipoCambio)
        Me.Controls.Add(Me.Text_Observaciones)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBo_Moneda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label_Fecha)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Tipo_Cambio)
        Me.Controls.Add(Me.txtCedula)
        Me.Name = "MovimientoCaja"
        Me.Text = "Movimiento de Caja"
        Me.Controls.SetChildIndex(Me.txtCedula, 0)
        Me.Controls.SetChildIndex(Me.Tipo_Cambio, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.Label_Fecha, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.ComboBo_Moneda, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Text_Observaciones, 0)
        Me.Controls.SetChildIndex(Me.Label_TipoCambio, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Calc_Monto, 0)
        Me.Controls.SetChildIndex(Me.Check_Anulado, 0)
        Me.Controls.SetChildIndex(Me.Label_Anulado, 0)
        Me.Controls.SetChildIndex(Me.LabelId, 0)
        Me.Controls.SetChildIndex(Me.CK_PVE, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txtCodigoCliente, 0)
        Me.Controls.SetChildIndex(Me.txtNombreCliente, 0)
        Me.Controls.SetChildIndex(Me.ckVincular, 0)
        Me.Controls.SetChildIndex(Me.btnBuscarCliente, 0)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet_MovimientoCaja1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Calc_Monto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Load"
    Private Sub MovimientoCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = CadenaConexionSeePOS()
            Me.DataSet_MovimientoCaja1.Movimiento_Caja.IdColumn.AutoIncrement = True
            Me.DataSet_MovimientoCaja1.Movimiento_Caja.IdColumn.AutoIncrementSeed = -1
            Me.DataSet_MovimientoCaja1.Movimiento_Caja.IdColumn.AutoIncrementStep = -1

            '-----------------------------------------------------------------------
            'VERIFICA FORMATO DE IMPRESION - ORA
            Dim PVE As Boolean
            Try
                PVE = CBool(GetSetting("SeeSOFT", "SeePos", "MovimientoCaja"))
            Catch ex As Exception
                SaveSetting("SeeSOFT", "SeePos", "MovimientoCaja", "True")
                PVE = True
            Finally
                CK_PVE.Checked = PVE
            End Try
            '-----------------------------------------------------------------------

            Me.txtUsuario.Text = usua.Cedula
            Me.TxtNombreUsuario.Text = usua.Nombre
            Me.cedu = usua.Cedula
            Me.nombre = usua.Nombre

            Me.DataSet_MovimientoCaja1.Clear()
            Me.Adapter_Moneda.Fill(Me.DataSet_MovimientoCaja1, "Moneda")

            If Not Me.Buscar_Apertura(usua.Cedula) Then
                Me.txtUsuario.Focus()
                Me.txtUsuario.Text = ""
                Me.TxtNombreUsuario.Text = ""
            Else
                inicializar()
                Me.Option_Entrada.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub defaultvalue()
        Try
            Me.DataSet_MovimientoCaja1.Movimiento_Caja.FechaColumn.DefaultValue = Now
            Me.DataSet_MovimientoCaja1.Movimiento_Caja.UsuarioColumn.DefaultValue = cedu
            Me.DataSet_MovimientoCaja1.Movimiento_Caja.EntradaColumn.DefaultValue = False
            Me.DataSet_MovimientoCaja1.Movimiento_Caja.SalidaColumn.DefaultValue = True
            Me.DataSet_MovimientoCaja1.Movimiento_Caja.MontoColumn.DefaultValue = 0
            Me.DataSet_MovimientoCaja1.Movimiento_Caja.AnuladoColumn.DefaultValue = False
            Me.DataSet_MovimientoCaja1.Movimiento_Caja.NumAperturaColumn.DefaultValue = Me.NApertura
            Me.DataSet_MovimientoCaja1.Movimiento_Caja.ObservacionesColumn.DefaultValue = ""
            Me.DataSet_MovimientoCaja1.Movimiento_Caja.CodMonedaColumn.DefaultValue = 1
            Me.DataSet_MovimientoCaja1.Movimiento_Caja.TipoCambioColumn.DefaultValue = Me.Label_TipoCambio.Text

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "ToolBar"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0
                If Me.ToolBar1.Buttons(0).Text = "Cancelar" Then 'Si se está editando un 
                    Me.BindingContext(Me.DataSet_MovimientoCaja1, "Movimiento_Caja").CancelCurrentEdit()
                    Me.DataSet_MovimientoCaja1.Movimiento_Caja.Clear()
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    Me.ToolBar1.Buttons(0).Text = "Nuevo"
                    GroupBox1.Enabled = False
                    ComboBo_Moneda.Enabled = False
                    Calc_Monto.Enabled = False
                    Text_Observaciones.Enabled = False
                Else

                    Me.txtUsuario.Text = usua.Cedula 'Se inicia un nuevo movimiento
                    Me.TxtNombreUsuario.Text = usua.Nombre
                    Me.cedu = usua.Cedula
                    Me.nombre = usua.Nombre

                    If Not Me.Buscar_Apertura(usua.Cedula) Then
                        Me.txtUsuario.Focus()
                        Me.txtUsuario.Text = ""
                        Me.TxtNombreUsuario.Text = ""
                    Else
                        inicializar()
                        Me.Option_Entrada.Focus()
                    End If
                End If

            Case 1 : Me.Buscar()
            Case 2 : Me.Registrar()
            Case 3 : Me.Anular()
            Case 4 : Me.imprimir()
            Case 6 : If MsgBox("Desea Cerrar el Módulo de Movimiento de Caja", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then Me.Close()
        End Select
    End Sub
#End Region

#Region "Nuevo"
    Private Sub inicializar()
        Try
            cargando = True
            Me.DataSet_MovimientoCaja1.Clear()
            Me.Adapter_Moneda.Fill(Me.DataSet_MovimientoCaja1, "Moneda")
            defaultvalue()
            Nuevo()
            Me.cargando = True
            Calc_Monto.Text = "0"
            registra = False
            Me.Calc_Monto.Enabled = True
            Me.cargando = False
            Me.txtUsuario.Enabled = False
            Me.TxtNombreUsuario.Enabled = False
            Calc_Monto.Focus()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Nuevo()
        Try
            GroupBox1.Enabled = True
            ComboBo_Moneda.Enabled = True
            Calc_Monto.Enabled = True
            Text_Observaciones.Enabled = True
            Me.BindingContext(Me.DataSet_MovimientoCaja1, "Movimiento_Caja").EndCurrentEdit()
            Me.BindingContext(Me.DataSet_MovimientoCaja1, "Movimiento_Caja").AddNew()
            Me.ToolBar1.Buttons(0).Text = "Cancelar"
            Me.ToolBar1.Buttons(0).ImageIndex = 8
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub CargarCliente(_Identificacion As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * from Clientes where Identificacion = '" & _Identificacion & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.Identificacion = _Identificacion
            Me.txtCodigoCliente.Text = dt.Rows(0).Item("cedula")
            Me.txtNombreCliente.Text = dt.Rows(0).Item("nombre")
        End If
    End Sub

    Private Sub BuscarCliente()
        Dim frmBuscarCliente As New frm_buscar_cliente
        frmBuscarCliente.txt_nombre.Focus()
        If frmBuscarCliente.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.CargarCliente(frmBuscarCliente.id)
        End If
    End Sub

#Region "Registrar"
    Sub Registrar()
        Try

            If Me.ckVincular.Checked = True Then
                If Me.Identificacion = "0" Then
                    MsgBox("Debe seleccionar el cliente a vincular.")
                    Exit Sub
                End If
            End If

            If MsgBox("¿Desea Registrar el Movimiento de Caja?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.BindingContext(Me.DataSet_MovimientoCaja1, "Movimiento_Caja").EndCurrentEdit()
                Me.Adapter_MovimientoCaja.Update(Me.DataSet_MovimientoCaja1, "Movimiento_Caja")
                MsgBox("Datos Ingresados Satisfactoriamente", MsgBoxStyle.Information)

                LabelId.Text = IdMovimiento()

                If Me.ckVincular.Checked = True Then
                    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                    db.Ejecutar("update Movimiento_Caja set Identificacion = '" & Me.Identificacion & "' where id = " & Me.LabelId.Text, Data.CommandType.Text)
                End If

                'open_cashdrawer()
                If MsgBox("¿Desea imprimir el Movimiento de Caja?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Me.imprimir()
                End If
                Me.DataSet_MovimientoCaja1.Movimiento_Caja.Clear()
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0

                GroupBox1.Enabled = False
                ComboBo_Moneda.Enabled = False
                Calc_Monto.Enabled = False
                Text_Observaciones.Enabled = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error al Ingresar Los datos, intentelo de nuevo", MsgBoxStyle.Critical)
        End Try
    End Sub

#Region "Abrir Caja"
    Public Sub open_cashdrawer()
        Dim Puerto As String
        Dim intFileNo As Integer = FreeFile()

        FileOpen(1, "c:\escapes.txt", OpenMode.Output)
        PrintLine(1, Chr(27) & "p" & Chr(0) & Chr(25) & Chr(250))
        FileClose(1)

        '------------------------------------------------------------------------------
        'VALIDA EL PUERTO DE LA IMPRESORA - ORA
        Try
            Puerto = GetSetting("SeeSoft", "SeePos", "PuertoImp")
            If Puerto = "" Then
                SaveSetting("SeeSoft", "SeePos", "PuertoImp", "COM1")
                Puerto = "COM1"
            End If
        Catch ex As Exception
            SaveSetting("SeeSoft", "SeePos", "PuertoImp", "COM1")
            Puerto = "COM1"
        End Try
        '------------------------------------------------------------------------------

        Shell("print /d:" & Puerto & " c:\escapes.txt", AppWinStyle.NormalFocus)
    End Sub
#End Region

#End Region

#Region "Buscar"
    Sub Buscar()
        Dim Fx As New cFunciones
        Dim identificador As Double
        Dim buscando As Boolean

        Try
            If Me.BindingContext(Me.DataSet_MovimientoCaja1, "Movimiento_Caja").Count > 0 Then
                If (MsgBox("Actualmente se está realizando un Movimiento de caja, si continúa se perderan los datos del mismo, ¿desea continuar?", MsgBoxStyle.YesNo)) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

            Me.DataSet_MovimientoCaja1.Movimiento_Caja.Clear()
            identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("SELECT Id, Monto, Observaciones, Fecha FROM Movimiento_Caja Order by Fecha Desc ", "Observaciones", "Fecha", "Buscar Movimiento de Caja"))
            buscando = True
            If identificador = 0.0 Then ' si se dio en el boton de cancelar
                buscando = False
                Exit Sub
            End If
            Fx.Cargar_Tabla_Generico(Me.Adapter_MovimientoCaja, "SELECT * FROM Movimiento_Caja WHERE (Id =" & identificador & " )")
            Me.Adapter_MovimientoCaja.Fill(Me.DataSet_MovimientoCaja1, "Movimiento_Caja")

            'si esta venta aun no ha sido anulada
            If Me.BindingContext(Me.DataSet_MovimientoCaja1, "Movimiento_Caja").Current("Anulado") = False Then Me.ToolBar1.Buttons(3).Enabled = True

            GroupBox1.Enabled = False
            ComboBo_Moneda.Enabled = False
            Calc_Monto.Enabled = False
            Text_Observaciones.Enabled = False

            Me.ToolBar1.Buttons(2).Enabled = False
            Me.ToolBar1.Buttons(4).Enabled = True
            Me.ToolBar1.Buttons(0).Enabled = True
            Me.ToolBar1.Buttons(0).ImageIndex = 0
            Me.ToolBar1.Buttons(0).Text = "Nuevo"

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Imprimir"
    Function imprimir()
        Try
            Me.ToolBar1.Buttons(4).Enabled = False

            If CK_PVE.Checked Then
                Dim Impresora As Integer = 3
                Dim opcaja As New frmOpcionCaja
                opcaja.Text = "Elija a la caja que desea mandar la impresión"
                opcaja.ShowDialog()
                If opcaja.Caja = 1 Then
                    Impresora = 3
                Else
                    Impresora = 5
                End If

                'solo para guanavet
                Impresora = 3

                Dim Reporte As New Reporte_Movimiento__Caja_PVE
                CrystalReportsConexion.LoadReportViewer(Nothing, Reporte, True)
                Reporte.PrintOptions.PrinterName = Automatic_Printer_Dialog(Impresora) 'PV
                Reporte.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
                Reporte.SetParameterValue(0, CInt(Me.LabelId.Text))
                Reporte.PrintToPrinter(1, True, 0, 0)
            Else
                Dim Movimiento_Reporte As New Reporte_Movimiento__Caja
                Movimiento_Reporte.SetParameterValue(0, CInt(Me.LabelId.Text))
                CrystalReportsConexion.LoadShow(Movimiento_Reporte, MdiParent)
            End If

            Me.ToolBar1.Buttons(4).Enabled = True

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function

    Private Function Automatic_Printer_Dialog(ByVal PrinterToSelect As Byte) As String 'SAJ 01092006 
        Dim PrintDocument1 As New PrintDocument
        Dim DefaultPrinter As String = PrintDocument1.PrinterSettings.PrinterName
        Dim PrinterInstalled As String
        'BUSCA LA IMPRESORA PREDETERMINADA PARA EL SISTEMA
        For Each PrinterInstalled In PrinterSettings.InstalledPrinters
            Select Case Split(PrinterInstalled.ToUpper, "\").GetValue(Split(PrinterInstalled.ToUpper, "\").GetLength(0) - 1)
                Case "FACTURACION"
                    If PrinterToSelect = 0 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "PUNTOVENTA"
                    If PrinterToSelect = 3 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "PUNTOVENTA02"
                    If PrinterToSelect = 5 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
            End Select
        Next
        If MsgBox("No se ha encontrado las impresoras predeterminadas para el sistema..." & vbCrLf & "Desea proceder a selecionar una impresora....", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Atención...") = MsgBoxResult.Yes Then
            Dim PrinterDialog As New PrintDialog
            Dim DocPrint As New PrintDocument
            PrinterDialog.Document = DocPrint
            PrinterDialog.ShowDialog()
            If PrinterDialog.ShowDialog.Yes Then
                Return PrinterDialog.PrinterSettings.PrinterName 'DEVUELVE LA IMPRESORA  SELECCIONADA
            Else
                Return DefaultPrinter 'NO SE SELECCIONO IMPRESORA ALGUNA
            End If
        End If
    End Function
#End Region

#Region "Anular"
    Sub Anular()
        Try
            If MsgBox("Desea Anular este Movimiento de Caja", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Check_Anulado.Checked = True
                Me.BindingContext(Me.DataSet_MovimientoCaja1, "Movimiento_Caja").EndCurrentEdit()
                Me.Adapter_MovimientoCaja.Update(Me.DataSet_MovimientoCaja1, "Movimiento_Caja")
                MsgBox("Factura Anulada Satisfactoriamente", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Problemas al Anular la Factura, intentelo de nuevo", MsgBoxStyle.Critical)
        End Try
    End Sub
#End Region

#Region "Funciones"
    Function Buscar_Apertura(ByVal usuario As String) As Boolean
        Try
            Dim func As New cFunciones
            Dim i As Integer

            func.Cargar_Tabla_Generico(Me.Apertura_Caja, "SELECT * FROM AperturaCaja WHERE (Anulado = 0) AND (Estado = 'A') AND (Cedula = '" & usuario & "')")
            i = Me.Apertura_Caja.Fill(Me.DataSet_MovimientoCaja1.aperturacaja)

            Select Case i
                Case 1
                    NApertura = Me.DataSet_MovimientoCaja1.aperturacaja.Rows(0).Item("NApertura")
                    Me.TxtNombreUsuario.Text = Me.DataSet_MovimientoCaja1.aperturacaja.Rows(0).Item("Nombre")
                    Return True
                Case 0
                    MsgBox(usua.Nombre & " " & "No tiene una apertura de caja abierta, digite la constraseña de la caja", MsgBoxStyle.Exclamation)
                    Return False
                Case Else
                    MsgBox(usua.Nombre & " " & "tiene mas de una abierta, digite la constraseña de la caja", MsgBoxStyle.Exclamation)
                    Return False
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function IdMovimiento() As Integer
        Dim cConexion As New Conexion
        Try
            IdMovimiento = cConexion.SlqExecuteScalar(cConexion.Conectar("SeePos"), "SELECT ISNULL(MAX(Id),0) AS Id FROM Movimiento_Caja")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cConexion.DesConectar(cConexion.sQlconexion)
        End Try
    End Function
#End Region

#Region "Controles Funciones"
    Private Sub TxtMonto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub ComboBo_Moneda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBo_Moneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Calc_Monto.Focus()
        End If
    End Sub

    Private Sub Calc_Monto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Calc_Monto.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Text_Observaciones.Focus()
        End If
    End Sub

    Private Sub Calc_Monto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calc_Monto.EditValueChanged
        Try
            If Me.Calc_Monto.Text <> "" Then
                If CDbl(Me.Calc_Monto.Text) > 0 Then
                    Me.ToolBar1.Buttons(2).Enabled = True
                Else
                    Me.ToolBar1.Buttons(2).Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Calc_Monto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Calc_Monto.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "."
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "."c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub Option_Entrada_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Option_Entrada.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then Me.Option_Salida.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label_TipoCambio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label_TipoCambio.TextChanged
        Me.Tipo_Cambio.Text = Me.Label_TipoCambio.Text
    End Sub

    Private Sub Check_Anulado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check_Anulado.CheckedChanged
        If Me.Check_Anulado.Checked = True Then
            Me.Label_Anulado.Visible = True
        Else
            Me.Label_Anulado.Visible = False
        End If
    End Sub

    Private Sub CK_PVE_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CK_PVE.CheckedChanged
        SaveSetting("SeeSOFT", "SeePos", "MovimientoCaja", "" & CK_PVE.Checked & "")
    End Sub

    Private Sub Option_Entrada_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Option_Entrada.CheckedChanged, Option_Salida.CheckedChanged
        Calc_Monto.Focus()
    End Sub
#End Region

    Private Identificacion As String = "0"
    Private Sub ckVincular_CheckedChanged(sender As Object, e As EventArgs) Handles ckVincular.CheckedChanged
        Me.btnBuscarCliente.Enabled = Me.ckVincular.Checked
        If Me.ckVincular.Checked = False Then
            Me.txtCodigoCliente.Text = ""
            Me.txtNombreCliente.Text = ""
            Me.Identificacion = "0"
        End If
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Me.BuscarCliente()
    End Sub
End Class
