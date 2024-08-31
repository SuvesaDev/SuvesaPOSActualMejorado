Imports System.Data
Imports System.Windows.Forms
Imports System.data.SqlClient

Public Class FrmAjusteBodega
    Inherits FrmPlantilla

#Region "Variables"
    Dim Usua As Object
    Dim EXISTENCIABODEGA As Integer = 0
    Dim PMU As PerfilModulo_Class
    Dim info As Boolean = True
    Dim Lote As New DataSet_Movimiento_Bodega
    Dim DatTableCambioss As New DataTable
    Dim modificacionforzada As Boolean = False
    Dim txtExistenciaForzada As Double = 0.0
    Dim eliminador(30) As String
#End Region

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Usuario As Object)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Usua = Usuario
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents txtCedulaUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmAjusteBodega))
    Friend WithEvents SqlConnection As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapterBodegas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSet_Movimiento_Bodega As DataSet_Movimiento_Bodega
    Friend WithEvents SqlDataAdapterMovimiento_Bodega As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDataAdapter_MovimientDetalle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents ComboBoxBodegas As System.Windows.Forms.ComboBox
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo_Entrada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo_Salida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents RadioButtonSalida As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonEntrada As System.Windows.Forms.RadioButton
    Friend WithEvents TextBoxCodigo As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCantidad As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxId As System.Windows.Forms.Label
    Friend WithEvents TextBoxDescripcion As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Check_Anulado As System.Windows.Forms.CheckBox
    Friend WithEvents Dt_FechaEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents txtExistencia As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTPVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNuevoLote As System.Windows.Forms.TextBox
    Friend WithEvents CBNuevo As System.Windows.Forms.CheckBox
    Friend WithEvents CbNumero As System.Windows.Forms.ComboBox
    Friend WithEvents LNumero As System.Windows.Forms.Label
    Friend WithEvents LVencimiento As System.Windows.Forms.Label
    Friend WithEvents LNuevoLote As System.Windows.Forms.Label
    Friend WithEvents AdapterLotes As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnectionLote As System.Data.SqlClient.SqlConnection
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxReferencia As System.Windows.Forms.TextBox
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents lblCantVet As System.Windows.Forms.Label
    Friend WithEvents txtCantVet As System.Windows.Forms.TextBox
    Friend WithEvents ExistenciaForzada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents lbanulado As System.Windows.Forms.Label
    Friend WithEvents lista As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAjusteBodega))
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo4 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo6 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet_Movimiento_Bodega = New LcPymes_5._2.DataSet_Movimiento_Bodega()
        Me.TextBoxId = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtNombreUsuario = New System.Windows.Forms.Label()
        Me.txtCedulaUsuario = New System.Windows.Forms.TextBox()
        Me.ComboBoxBodegas = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButtonSalida = New System.Windows.Forms.RadioButton()
        Me.RadioButtonEntrada = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxCodigo = New System.Windows.Forms.TextBox()
        Me.TextBoxDescripcion = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colTipo_Entrada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipo_Salida = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ExistenciaForzada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection = New System.Data.SqlClient.SqlConnection()
        Me.SqlDataAdapterBodegas = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.TextBoxCantidad = New System.Windows.Forms.TextBox()
        Me.SqlDataAdapterMovimiento_Bodega = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter_MovimientDetalle = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Check_Anulado = New System.Windows.Forms.CheckBox()
        Me.TextBoxReferencia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtCantVet = New System.Windows.Forms.TextBox()
        Me.lblCantVet = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.LVencimiento = New System.Windows.Forms.Label()
        Me.LNumero = New System.Windows.Forms.Label()
        Me.LNuevoLote = New System.Windows.Forms.Label()
        Me.DTPVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtNuevoLote = New System.Windows.Forms.TextBox()
        Me.CBNuevo = New System.Windows.Forms.CheckBox()
        Me.CbNumero = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtExistencia = New System.Windows.Forms.TextBox()
        Me.lbanulado = New System.Windows.Forms.Label()
        Me.Dt_FechaEntrada = New System.Windows.Forms.DateTimePicker()
        Me.AdapterLotes = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnectionLote = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.lista = New System.Windows.Forms.ListBox()
        CType(Me.DataSet_Movimiento_Bodega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Enabled = False
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
        Me.ToolBar1.Location = New System.Drawing.Point(0, 445)
        Me.ToolBar1.Size = New System.Drawing.Size(584, 52)
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.Location = New System.Drawing.Point(665, 598)
        Me.DataNavigator.Visible = False
        '
        'TituloModulo
        '
        Me.TituloModulo.Size = New System.Drawing.Size(584, 32)
        Me.TituloModulo.Text = "Ajuste Bodega Inventario"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(5, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(480, 13)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Nombre de la Casa consignante o Bodega"
        '
        'DataSet_Movimiento_Bodega
        '
        Me.DataSet_Movimiento_Bodega.DataSetName = "DataSet_Movimiento_Bodega"
        Me.DataSet_Movimiento_Bodega.Locale = New System.Globalization.CultureInfo("es")
        Me.DataSet_Movimiento_Bodega.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBoxId
        '
        Me.TextBoxId.BackColor = System.Drawing.Color.White
        Me.TextBoxId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Movimiento_Bodega, "MovimientosBodega.Boleta_Movimiento", True))
        Me.TextBoxId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxId.ForeColor = System.Drawing.Color.Blue
        Me.TextBoxId.Location = New System.Drawing.Point(1, 16)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(79, 13)
        Me.TextBoxId.TabIndex = 93
        Me.TextBoxId.Text = "00000"
        Me.TextBoxId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label36)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Controls.Add(Me.txtNombreUsuario)
        Me.Panel1.Controls.Add(Me.txtCedulaUsuario)
        Me.Panel1.Location = New System.Drawing.Point(304, 488)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(291, 14)
        Me.Panel1.TabIndex = 0
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
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(56, 13)
        Me.txtUsuario.TabIndex = 0
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
        Me.txtCedulaUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Movimiento_Bodega, "MovimientosBodega.Usuario", True))
        Me.txtCedulaUsuario.Enabled = False
        Me.txtCedulaUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtCedulaUsuario.Location = New System.Drawing.Point(211, 16)
        Me.txtCedulaUsuario.Name = "txtCedulaUsuario"
        Me.txtCedulaUsuario.Size = New System.Drawing.Size(72, 13)
        Me.txtCedulaUsuario.TabIndex = 170
        '
        'ComboBoxBodegas
        '
        Me.ComboBoxBodegas.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet_Movimiento_Bodega, "MovimientosBodega.Bodega", True))
        Me.ComboBoxBodegas.DataSource = Me.DataSet_Movimiento_Bodega
        Me.ComboBoxBodegas.DisplayMember = "Bodegas.Nombre_Bodega"
        Me.ComboBoxBodegas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBodegas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxBodegas.ForeColor = System.Drawing.Color.Blue
        Me.ComboBoxBodegas.Location = New System.Drawing.Point(5, 26)
        Me.ComboBoxBodegas.Name = "ComboBoxBodegas"
        Me.ComboBoxBodegas.Size = New System.Drawing.Size(483, 21)
        Me.ComboBoxBodegas.TabIndex = 1
        Me.ComboBoxBodegas.ValueMember = "Bodegas.ID_Bodega"
        '
        'DateTimePicker
        '
        Me.DateTimePicker.CalendarForeColor = System.Drawing.Color.Blue
        Me.DateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Movimiento_Bodega, "MovimientosBodega.Fecha", True))
        Me.DateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker.Location = New System.Drawing.Point(448, 40)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(144, 20)
        Me.DateTimePicker.TabIndex = 2
        Me.DateTimePicker.Value = New Date(2006, 7, 29, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(384, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 24)
        Me.Label3.TabIndex = 178
        Me.Label3.Text = "Fecha"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButtonSalida
        '
        Me.RadioButtonSalida.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonSalida.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle.Tipo_Salida", True))
        Me.RadioButtonSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonSalida.ForeColor = System.Drawing.Color.Blue
        Me.RadioButtonSalida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadioButtonSalida.Location = New System.Drawing.Point(368, 24)
        Me.RadioButtonSalida.Name = "RadioButtonSalida"
        Me.RadioButtonSalida.Size = New System.Drawing.Size(58, 16)
        Me.RadioButtonSalida.TabIndex = 1
        Me.RadioButtonSalida.Text = "&Salida"
        Me.RadioButtonSalida.UseVisualStyleBackColor = False
        '
        'RadioButtonEntrada
        '
        Me.RadioButtonEntrada.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonEntrada.Checked = True
        Me.RadioButtonEntrada.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle.Tipo_Entrada", True))
        Me.RadioButtonEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonEntrada.ForeColor = System.Drawing.Color.Blue
        Me.RadioButtonEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadioButtonEntrada.Location = New System.Drawing.Point(296, 24)
        Me.RadioButtonEntrada.Name = "RadioButtonEntrada"
        Me.RadioButtonEntrada.Size = New System.Drawing.Size(69, 16)
        Me.RadioButtonEntrada.TabIndex = 0
        Me.RadioButtonEntrada.TabStop = True
        Me.RadioButtonEntrada.Text = "&Entrada"
        Me.RadioButtonEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButtonEntrada.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(264, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 180
        Me.Label4.Text = "Tipo:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(8, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(584, 13)
        Me.Label6.TabIndex = 182
        Me.Label6.Text = "Detalle de Ajuste"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(7, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 184
        Me.Label7.Text = "Código"
        '
        'TextBoxCodigo
        '
        Me.TextBoxCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle.Codigo", True))
        Me.TextBoxCodigo.ForeColor = System.Drawing.Color.Blue
        Me.TextBoxCodigo.Location = New System.Drawing.Point(-80, 22)
        Me.TextBoxCodigo.Name = "TextBoxCodigo"
        Me.TextBoxCodigo.Size = New System.Drawing.Size(80, 13)
        Me.TextBoxCodigo.TabIndex = 4
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle.Descripcion", True))
        Me.TextBoxDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDescripcion.ForeColor = System.Drawing.Color.Blue
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(71, 6)
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(505, 13)
        Me.TextBoxDescripcion.TabIndex = 185
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(424, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 188
        Me.Label10.Text = "Cantidad"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle"
        Me.GridControl1.DataSource = Me.DataSet_Movimiento_Bodega
        '
        '
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.ForeColor = System.Drawing.Color.Blue
        Me.GridControl1.Location = New System.Drawing.Point(8, 248)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(584, 200)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.Text = "GridControl"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDescripcion, Me.colCantidad, Me.colTipo_Entrada, Me.colTipo_Salida, Me.ExistenciaForzada})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFilterPanel = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowVertLines = False
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.FieldName = "CodArticulo"
        Me.colCodigo.FilterInfo = ColumnFilterInfo1
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 62
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.FilterInfo = ColumnFilterInfo2
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 331
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cantidad"
        Me.colCantidad.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colCantidad.DisplayFormat.FormatString = "#,#0.00"
        Me.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.FilterInfo = ColumnFilterInfo3
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCantidad.VisibleIndex = 2
        Me.colCantidad.Width = 63
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colTipo_Entrada
        '
        Me.colTipo_Entrada.Caption = "Entrada"
        Me.colTipo_Entrada.FieldName = "Tipo_Entrada"
        Me.colTipo_Entrada.FilterInfo = ColumnFilterInfo4
        Me.colTipo_Entrada.Name = "colTipo_Entrada"
        Me.colTipo_Entrada.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colTipo_Entrada.VisibleIndex = 3
        Me.colTipo_Entrada.Width = 56
        '
        'colTipo_Salida
        '
        Me.colTipo_Salida.Caption = "Salida"
        Me.colTipo_Salida.FieldName = "Tipo_Salida"
        Me.colTipo_Salida.FilterInfo = ColumnFilterInfo5
        Me.colTipo_Salida.Name = "colTipo_Salida"
        Me.colTipo_Salida.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colTipo_Salida.VisibleIndex = 4
        Me.colTipo_Salida.Width = 58
        '
        'ExistenciaForzada
        '
        Me.ExistenciaForzada.Caption = "Existencia Forzada"
        Me.ExistenciaForzada.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ExistenciaForzada.FilterInfo = ColumnFilterInfo6
        Me.ExistenciaForzada.Name = "ExistenciaForzada"
        Me.ExistenciaForzada.VisibleIndex = 5
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT ID_Bodega, Nombre_Bodega, Observaciones FROM Bodegas"
        '
        'SqlConnection
        '
        Me.SqlConnection.ConnectionString = "workstation id=""SEESOFT-PC"";packet size=4096;integrated security=SSPI;data source" & _
    "=""192.168.1.2"";persist security info=False;initial catalog=seepos"
        Me.SqlConnection.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapterBodegas
        '
        Me.SqlDataAdapterBodegas.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapterBodegas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Bodegas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Bodega", "ID_Bodega"), New System.Data.Common.DataColumnMapping("Nombre_Bodega", "Nombre_Bodega"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT ID_Bodega, Nombre_Bodega, Observaciones FROM Bodegas where Inactiva = 0 and Consignacion = 1 ORDER BY Nombre_Bodega"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection
        '
        'TextBoxCantidad
        '
        Me.TextBoxCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxCantidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle.Cantidad", True))
        Me.TextBoxCantidad.ForeColor = System.Drawing.Color.Blue
        Me.TextBoxCantidad.Location = New System.Drawing.Point(496, 24)
        Me.TextBoxCantidad.Name = "TextBoxCantidad"
        Me.TextBoxCantidad.Size = New System.Drawing.Size(80, 13)
        Me.TextBoxCantidad.TabIndex = 6
        '
        'SqlDataAdapterMovimiento_Bodega
        '
        Me.SqlDataAdapterMovimiento_Bodega.DeleteCommand = Me.SqlDeleteCommand2
        Me.SqlDataAdapterMovimiento_Bodega.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapterMovimiento_Bodega.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapterMovimiento_Bodega.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "MovimientosBodega", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Boleta_Movimiento", "Boleta_Movimiento"), New System.Data.Common.DataColumnMapping("Bodega", "Bodega"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Referencia", "Referencia"), New System.Data.Common.DataColumnMapping("Usuario", "Usuario"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("FechaEntrada", "FechaEntrada"), New System.Data.Common.DataColumnMapping("Cliente", "Cliente")})})
        Me.SqlDataAdapterMovimiento_Bodega.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM MovimientosBodega WHERE (Boleta_Movimiento = @Original_Boleta_Movimie" & _
    "nto)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Boleta_Movimiento", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Boleta_Movimiento", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Bodega", System.Data.SqlDbType.Int, 4, "Bodega"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Referencia", System.Data.SqlDbType.VarChar, 255, "Referencia"), New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 255, "Usuario"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 8, "FechaEntrada"), New System.Data.SqlClient.SqlParameter("@Cliente", System.Data.SqlDbType.VarChar, 250, "Cliente")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Boleta_Movimiento, Bodega, Fecha, Referencia, Usuario, Anulado, FechaEntra" & _
    "da, Cliente FROM MovimientosBodega"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Bodega", System.Data.SqlDbType.Int, 4, "Bodega"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Referencia", System.Data.SqlDbType.VarChar, 255, "Referencia"), New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 255, "Usuario"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 8, "FechaEntrada"), New System.Data.SqlClient.SqlParameter("@Cliente", System.Data.SqlDbType.VarChar, 250, "Cliente"), New System.Data.SqlClient.SqlParameter("@Original_Boleta_Movimiento", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Boleta_Movimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Boleta_Movimiento", System.Data.SqlDbType.BigInt, 8, "Boleta_Movimiento")})
        '
        'SqlDataAdapter_MovimientDetalle
        '
        Me.SqlDataAdapter_MovimientDetalle.DeleteCommand = Me.SqlDeleteCommand3
        Me.SqlDataAdapter_MovimientDetalle.InsertCommand = Me.SqlInsertCommand3
        Me.SqlDataAdapter_MovimientDetalle.SelectCommand = Me.SqlSelectCommand4
        Me.SqlDataAdapter_MovimientDetalle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "MovimientosBodega_Detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Detalle", "Id_Detalle"), New System.Data.Common.DataColumnMapping("Boleta_Movimiento", "Boleta_Movimiento"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"), New System.Data.Common.DataColumnMapping("Tipo_Entrada", "Tipo_Entrada"), New System.Data.Common.DataColumnMapping("Tipo_Salida", "Tipo_Salida"), New System.Data.Common.DataColumnMapping("Numero", "Numero"), New System.Data.Common.DataColumnMapping("CodArticulo", "CodArticulo"), New System.Data.Common.DataColumnMapping("ExistenciaForzada", "ExistenciaForzada"), New System.Data.Common.DataColumnMapping("ExistVeteForzada", "ExistVeteForzada")})})
        Me.SqlDataAdapter_MovimientDetalle.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM MovimientosBodega_Detalle WHERE (Id_Detalle = @Original_Id_Detalle)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_Detalle", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Detalle", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnection
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Boleta_Movimiento", System.Data.SqlDbType.BigInt, 8, "Boleta_Movimiento"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 255, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 255, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Tipo_Entrada", System.Data.SqlDbType.Bit, 1, "Tipo_Entrada"), New System.Data.SqlClient.SqlParameter("@Tipo_Salida", System.Data.SqlDbType.Bit, 1, "Tipo_Salida"), New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.VarChar, 250, "Numero"), New System.Data.SqlClient.SqlParameter("@CodArticulo", System.Data.SqlDbType.VarChar, 250, "CodArticulo"), New System.Data.SqlClient.SqlParameter("@ExistenciaForzada", System.Data.SqlDbType.BigInt, 8, "ExistenciaForzada"), New System.Data.SqlClient.SqlParameter("@ExistVeteForzada", System.Data.SqlDbType.BigInt, 8, "ExistVeteForzada")})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Id_Detalle, Boleta_Movimiento, Codigo, Descripcion, Cantidad, Tipo_Entrada" & _
    ", Tipo_Salida, Numero, CodArticulo, ExistenciaForzada, ExistVeteForzada FROM Mov" & _
    "imientosBodega_Detalle"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Boleta_Movimiento", System.Data.SqlDbType.BigInt, 8, "Boleta_Movimiento"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 255, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 255, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Tipo_Entrada", System.Data.SqlDbType.Bit, 1, "Tipo_Entrada"), New System.Data.SqlClient.SqlParameter("@Tipo_Salida", System.Data.SqlDbType.Bit, 1, "Tipo_Salida"), New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.VarChar, 250, "Numero"), New System.Data.SqlClient.SqlParameter("@CodArticulo", System.Data.SqlDbType.VarChar, 250, "CodArticulo"), New System.Data.SqlClient.SqlParameter("@ExistenciaForzada", System.Data.SqlDbType.BigInt, 8, "ExistenciaForzada"), New System.Data.SqlClient.SqlParameter("@ExistVeteForzada", System.Data.SqlDbType.BigInt, 8, "ExistVeteForzada"), New System.Data.SqlClient.SqlParameter("@Original_Id_Detalle", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_Detalle", System.Data.SqlDbType.Int, 4, "Id_Detalle")})
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.txtCliente)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Check_Anulado)
        Me.Panel2.Controls.Add(Me.TextBoxReferencia)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.ComboBoxBodegas)
        Me.Panel2.Enabled = False
        Me.Panel2.Location = New System.Drawing.Point(8, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(584, 72)
        Me.Panel2.TabIndex = 189
        '
        'txtCliente
        '
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Movimiento_Bodega, "MovimientosBodega.Cliente", True))
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.ForeColor = System.Drawing.Color.Blue
        Me.txtCliente.Location = New System.Drawing.Point(64, 48)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(248, 13)
        Me.txtCliente.TabIndex = 193
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(8, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 192
        Me.Label8.Text = "Cliente"
        '
        'Check_Anulado
        '
        Me.Check_Anulado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_Movimiento_Bodega, "MovimientosBodega.Anulado", True))
        Me.Check_Anulado.Enabled = False
        Me.Check_Anulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_Anulado.ForeColor = System.Drawing.Color.Red
        Me.Check_Anulado.Location = New System.Drawing.Point(496, 32)
        Me.Check_Anulado.Name = "Check_Anulado"
        Me.Check_Anulado.Size = New System.Drawing.Size(81, 16)
        Me.Check_Anulado.TabIndex = 191
        Me.Check_Anulado.Text = "Anulado"
        '
        'TextBoxReferencia
        '
        Me.TextBoxReferencia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxReferencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Movimiento_Bodega, "MovimientosBodega.Referencia", True))
        Me.TextBoxReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxReferencia.ForeColor = System.Drawing.Color.Blue
        Me.TextBoxReferencia.Location = New System.Drawing.Point(392, 50)
        Me.TextBoxReferencia.Name = "TextBoxReferencia"
        Me.TextBoxReferencia.Size = New System.Drawing.Size(184, 13)
        Me.TextBoxReferencia.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(312, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 181
        Me.Label5.Text = "Referencia"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.txtCantVet)
        Me.Panel3.Controls.Add(Me.lblCantVet)
        Me.Panel3.Controls.Add(Me.txtCodigo)
        Me.Panel3.Controls.Add(Me.LVencimiento)
        Me.Panel3.Controls.Add(Me.LNumero)
        Me.Panel3.Controls.Add(Me.LNuevoLote)
        Me.Panel3.Controls.Add(Me.DTPVencimiento)
        Me.Panel3.Controls.Add(Me.txtNuevoLote)
        Me.Panel3.Controls.Add(Me.CBNuevo)
        Me.Panel3.Controls.Add(Me.CbNumero)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtExistencia)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.TextBoxCantidad)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.TextBoxCodigo)
        Me.Panel3.Controls.Add(Me.RadioButtonEntrada)
        Me.Panel3.Controls.Add(Me.RadioButtonSalida)
        Me.Panel3.Controls.Add(Me.TextBoxDescripcion)
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(8, 160)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(584, 81)
        Me.Panel3.TabIndex = 190
        '
        'txtCantVet
        '
        Me.txtCantVet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantVet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCantVet.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle.ExistenciaVete", True))
        Me.txtCantVet.ForeColor = System.Drawing.Color.Blue
        Me.txtCantVet.Location = New System.Drawing.Point(216, 24)
        Me.txtCantVet.Name = "txtCantVet"
        Me.txtCantVet.Size = New System.Drawing.Size(40, 13)
        Me.txtCantVet.TabIndex = 203
        Me.txtCantVet.Visible = False
        '
        'lblCantVet
        '
        Me.lblCantVet.BackColor = System.Drawing.Color.Transparent
        Me.lblCantVet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantVet.ForeColor = System.Drawing.Color.Blue
        Me.lblCantVet.Location = New System.Drawing.Point(176, 24)
        Me.lblCantVet.Name = "lblCantVet"
        Me.lblCantVet.Size = New System.Drawing.Size(24, 13)
        Me.lblCantVet.TabIndex = 202
        Me.lblCantVet.Text = "Veterinaria"
        Me.lblCantVet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle.CodArticulo", True))
        Me.txtCodigo.ForeColor = System.Drawing.Color.Blue
        Me.txtCodigo.Location = New System.Drawing.Point(8, 24)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(57, 13)
        Me.txtCodigo.TabIndex = 201
        '
        'LVencimiento
        '
        Me.LVencimiento.BackColor = System.Drawing.Color.Transparent
        Me.LVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVencimiento.ForeColor = System.Drawing.Color.Blue
        Me.LVencimiento.Location = New System.Drawing.Point(328, 48)
        Me.LVencimiento.Name = "LVencimiento"
        Me.LVencimiento.Size = New System.Drawing.Size(40, 13)
        Me.LVencimiento.TabIndex = 200
        Me.LVencimiento.Text = "Vence"
        Me.LVencimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LVencimiento.Visible = False
        '
        'LNumero
        '
        Me.LNumero.BackColor = System.Drawing.Color.Transparent
        Me.LNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNumero.ForeColor = System.Drawing.Color.Blue
        Me.LNumero.Location = New System.Drawing.Point(8, 48)
        Me.LNumero.Name = "LNumero"
        Me.LNumero.Size = New System.Drawing.Size(40, 13)
        Me.LNumero.TabIndex = 199
        Me.LNumero.Text = "Lote :"
        Me.LNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LNumero.Visible = False
        '
        'LNuevoLote
        '
        Me.LNuevoLote.BackColor = System.Drawing.Color.Transparent
        Me.LNuevoLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNuevoLote.ForeColor = System.Drawing.Color.Blue
        Me.LNuevoLote.Location = New System.Drawing.Point(200, 48)
        Me.LNuevoLote.Name = "LNuevoLote"
        Me.LNuevoLote.Size = New System.Drawing.Size(40, 13)
        Me.LNuevoLote.TabIndex = 198
        Me.LNuevoLote.Text = "Lote"
        Me.LNuevoLote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LNuevoLote.Visible = False
        '
        'DTPVencimiento
        '
        Me.DTPVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPVencimiento.Location = New System.Drawing.Point(376, 48)
        Me.DTPVencimiento.Name = "DTPVencimiento"
        Me.DTPVencimiento.Size = New System.Drawing.Size(88, 20)
        Me.DTPVencimiento.TabIndex = 197
        Me.DTPVencimiento.Visible = False
        '
        'txtNuevoLote
        '
        Me.txtNuevoLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevoLote.Location = New System.Drawing.Point(248, 48)
        Me.txtNuevoLote.Name = "txtNuevoLote"
        Me.txtNuevoLote.Size = New System.Drawing.Size(72, 20)
        Me.txtNuevoLote.TabIndex = 195
        Me.txtNuevoLote.Visible = False
        '
        'CBNuevo
        '
        Me.CBNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBNuevo.ForeColor = System.Drawing.Color.Blue
        Me.CBNuevo.Location = New System.Drawing.Point(136, 48)
        Me.CBNuevo.Name = "CBNuevo"
        Me.CBNuevo.Size = New System.Drawing.Size(64, 16)
        Me.CBNuevo.TabIndex = 193
        Me.CBNuevo.Text = "Nuevo"
        Me.CBNuevo.Visible = False
        '
        'CbNumero
        '
        Me.CbNumero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbNumero.Location = New System.Drawing.Point(48, 48)
        Me.CbNumero.Name = "CbNumero"
        Me.CbNumero.Size = New System.Drawing.Size(88, 21)
        Me.CbNumero.TabIndex = 192
        Me.CbNumero.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(72, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 190
        Me.Label2.Text = "Bod."
        '
        'txtExistencia
        '
        Me.txtExistencia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtExistencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtExistencia.Enabled = False
        Me.txtExistencia.ForeColor = System.Drawing.Color.Blue
        Me.txtExistencia.Location = New System.Drawing.Point(120, 24)
        Me.txtExistencia.Name = "txtExistencia"
        Me.txtExistencia.Size = New System.Drawing.Size(48, 13)
        Me.txtExistencia.TabIndex = 189
        '
        'lbanulado
        '
        Me.lbanulado.BackColor = System.Drawing.Color.Transparent
        Me.lbanulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbanulado.ForeColor = System.Drawing.Color.Red
        Me.lbanulado.Location = New System.Drawing.Point(160, 328)
        Me.lbanulado.Name = "lbanulado"
        Me.lbanulado.Size = New System.Drawing.Size(264, 64)
        Me.lbanulado.TabIndex = 204
        Me.lbanulado.Text = "Anulado"
        Me.lbanulado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbanulado.Visible = False
        '
        'Dt_FechaEntrada
        '
        Me.Dt_FechaEntrada.CalendarForeColor = System.Drawing.Color.Blue
        Me.Dt_FechaEntrada.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Movimiento_Bodega, "MovimientosBodega.FechaEntrada", True))
        Me.Dt_FechaEntrada.Enabled = False
        Me.Dt_FechaEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dt_FechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dt_FechaEntrada.Location = New System.Drawing.Point(496, 464)
        Me.Dt_FechaEntrada.Name = "Dt_FechaEntrada"
        Me.Dt_FechaEntrada.Size = New System.Drawing.Size(96, 20)
        Me.Dt_FechaEntrada.TabIndex = 192
        Me.Dt_FechaEntrada.Value = New Date(2006, 7, 29, 0, 0, 0, 0)
        '
        'AdapterLotes
        '
        Me.AdapterLotes.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterLotes.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterLotes.SelectCommand = Me.SqlSelectCommand5
        Me.AdapterLotes.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Lotes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Numero", "Numero"), New System.Data.Common.DataColumnMapping("Vencimiento", "Vencimiento"), New System.Data.Common.DataColumnMapping("Cant_Inicial", "Cant_Inicial"), New System.Data.Common.DataColumnMapping("Cant_Actual", "Cant_Actual"), New System.Data.Common.DataColumnMapping("Fecha_Entrada", "Fecha_Entrada"), New System.Data.Common.DataColumnMapping("Cod_Articulo", "Cod_Articulo"), New System.Data.Common.DataColumnMapping("Documento", "Documento"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo")})})
        Me.AdapterLotes.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnectionLote
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cant_Actual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cant_Actual", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cant_Inicial", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cant_Inicial", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Articulo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Articulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha_Entrada", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Entrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Vencimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vencimiento", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlConnectionLote
        '
        Me.SqlConnectionLote.ConnectionString = "workstation id=DIEGOGAMBOA;packet size=4096;integrated security=SSPI;data source=" & _
    """."";persist security info=False;initial catalog=SeePos"
        Me.SqlConnectionLote.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnectionLote
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.VarChar, 250, "Numero"), New System.Data.SqlClient.SqlParameter("@Vencimiento", System.Data.SqlDbType.DateTime, 8, "Vencimiento"), New System.Data.SqlClient.SqlParameter("@Cant_Inicial", System.Data.SqlDbType.Float, 8, "Cant_Inicial"), New System.Data.SqlClient.SqlParameter("@Cant_Actual", System.Data.SqlDbType.Float, 8, "Cant_Actual"), New System.Data.SqlClient.SqlParameter("@Fecha_Entrada", System.Data.SqlDbType.DateTime, 8, "Fecha_Entrada"), New System.Data.SqlClient.SqlParameter("@Cod_Articulo", System.Data.SqlDbType.BigInt, 8, "Cod_Articulo"), New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.BigInt, 8, "Documento"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo")})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT Id, Numero, Vencimiento, Cant_Inicial, Cant_Actual, Fecha_Entrada, Cod_Art" & _
    "iculo, Documento, Tipo FROM Lotes"
        Me.SqlSelectCommand5.Connection = Me.SqlConnectionLote
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnectionLote
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.VarChar, 250, "Numero"), New System.Data.SqlClient.SqlParameter("@Vencimiento", System.Data.SqlDbType.DateTime, 8, "Vencimiento"), New System.Data.SqlClient.SqlParameter("@Cant_Inicial", System.Data.SqlDbType.Float, 8, "Cant_Inicial"), New System.Data.SqlClient.SqlParameter("@Cant_Actual", System.Data.SqlDbType.Float, 8, "Cant_Actual"), New System.Data.SqlClient.SqlParameter("@Fecha_Entrada", System.Data.SqlDbType.DateTime, 8, "Fecha_Entrada"), New System.Data.SqlClient.SqlParameter("@Cod_Articulo", System.Data.SqlDbType.BigInt, 8, "Cod_Articulo"), New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.BigInt, 8, "Documento"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cant_Actual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cant_Actual", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cant_Inicial", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cant_Inicial", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Articulo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Articulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha_Entrada", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Entrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Vencimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vencimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'lista
        '
        Me.lista.Location = New System.Drawing.Point(64, 304)
        Me.lista.Name = "lista"
        Me.lista.Size = New System.Drawing.Size(120, 95)
        Me.lista.TabIndex = 204
        '
        'FrmAjusteBodega
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(584, 497)
        Me.Controls.Add(Me.lbanulado)
        Me.Controls.Add(Me.Dt_FechaEntrada)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBoxId)
        Me.Controls.Add(Me.lista)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker)
        Me.MaximumSize = New System.Drawing.Size(600, 536)
        Me.Name = "FrmAjusteBodega"
        Me.Text = "Ajuste Bodega Inventario"
        Me.Controls.SetChildIndex(Me.DateTimePicker, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.lista, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.TextBoxId, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Panel3, 0)
        Me.Controls.SetChildIndex(Me.Dt_FechaEntrada, 0)
        Me.Controls.SetChildIndex(Me.lbanulado, 0)
        CType(Me.DataSet_Movimiento_Bodega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Load"
    Private Sub FrmAjusteBodega_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SqlConnection.ConnectionString = CadenaConexionSeePOS
        SqlConnectionLote.ConnectionString = CadenaConexionSeePOS
        Me.SqlDataAdapterBodegas.Fill(Me.DataSet_Movimiento_Bodega, "Bodegas")
        AdapterLotes.Fill(Lote, "Lotes")

        Me.DataSet_Movimiento_Bodega.MovimientosBodega.Boleta_MovimientoColumn.AutoIncrement = True
        Me.DataSet_Movimiento_Bodega.MovimientosBodega.Boleta_MovimientoColumn.AutoIncrementSeed = -1
        Me.DataSet_Movimiento_Bodega.MovimientosBodega.Boleta_MovimientoColumn.AutoIncrementStep = -1
        Me.DataSet_Movimiento_Bodega.MovimientosBodega.BodegaColumn.DefaultValue = 0
        Me.DataSet_Movimiento_Bodega.MovimientosBodega.FechaColumn.DefaultValue = Now.Date
        Me.DataSet_Movimiento_Bodega.MovimientosBodega.ReferenciaColumn.DefaultValue = ""
        Me.DataSet_Movimiento_Bodega.MovimientosBodega.AnuladoColumn.DefaultValue = False
        Me.DataSet_Movimiento_Bodega.MovimientosBodega.FechaEntradaColumn.DefaultValue = Now
        Me.DataSet_Movimiento_Bodega.MovimientosBodega.ClienteColumn.DefaultValue = ""

        Me.DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Id_DetalleColumn.AutoIncrement = True
        Me.DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Id_DetalleColumn.AutoIncrementSeed = -1
        Me.DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Id_DetalleColumn.AutoIncrementStep = -1
        Me.DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.CodigoColumn.DefaultValue = 0
        Me.DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.CodArticuloColumn.DefaultValue = ""
        Me.DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.DescripcionColumn.DefaultValue = ""
        Me.DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Tipo_EntradaColumn.DefaultValue = True
        Me.DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Tipo_SalidaColumn.DefaultValue = False
        Me.DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.CantidadColumn.DefaultValue = 0
        Me.DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.NumeroColumn.DefaultValue = 0
        Me.DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.ExistVeteForzadaColumn.DefaultValue = 0
        Me.DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.ExistVeteForzadaColumn.DefaultValue = 0

        'VALORES POR DEFECTO PARA LA TABLA ARTICULOS LOTES
        Me.Lote.Lotes.IdColumn.AutoIncrement = True
        Me.Lote.Lotes.IdColumn.AutoIncrementStep = -1
        Me.Lote.Lotes.IdColumn.AutoIncrementSeed = -1
        Me.Lote.Lotes.NumeroColumn.DefaultValue = 0
        Me.Lote.Lotes.VencimientoColumn.DefaultValue = Now.Date
        Me.Lote.Lotes.Fecha_EntradaColumn.DefaultValue = Date.Now
        Me.Lote.Lotes.Cant_InicialColumn.DefaultValue = 0
        Me.Lote.Lotes.Cant_ActualColumn.DefaultValue = 0
        Me.Lote.Lotes.Cod_ArticuloColumn.DefaultValue = 0
        Me.Lote.Lotes.DocumentoColumn.DefaultValue = 0
        Me.Lote.Lotes.TipoColumn.DefaultValue = "AIB"

        Me.ToolBar1.Buttons(0).Enabled = False
    End Sub
#End Region

#Region "Toolbar"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Try
            Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
                Case 1 : Nuevo_o_Cancelar()
                Case 2 : If PMU.Find Then Me.CargarAjuste() Else MsgBox("No tiene permiso para buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                Case 3 : If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para registrar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                Case 4 : If PMU.Delete Then Eliminar() Else MsgBox("No tiene permiso para eliminar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                Case 5 : If PMU.Print Then Imprimir(Me.TextBoxId.Text) Else MsgBox("No tiene permiso para imprimir datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                Case 7 : If MessageBox.Show("¿Desea Cerrar el modulo actual..?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then Me.Close()
            End Select
        Catch ex As Exception
            If Err.Number <> 91 Then
                MsgBox(ex.Message & " numero : " & Err.Number)
            Else
                MsgBox("Debe introducir su codigo")
            End If
        End Try
    End Sub
#End Region

#Region "Nuevo"
    Private Sub Nuevo_o_Cancelar()
        NuevaEntrada()
        If ToolBar1.Buttons(0).Text = "Cancelar" Then
            Me.ToolBar1.Buttons(0).Enabled = False
            Me.ToolBar1.Buttons(2).Enabled = False
            Me.ToolBar1.Buttons(3).Enabled = False
            Me.ToolBar1.Buttons(4).Enabled = False
        Else ' cuando es Nuevo

            Me.ToolBar1.Buttons(0).Enabled = False
            Me.ToolBar1.Buttons(2).Enabled = False
            Me.Panel2.Enabled = False
            Me.Panel3.Enabled = False
            GridControl1.Enabled = False
            Me.txtUsuario.Text = ""
            Me.txtNombreUsuario.Text = ""
            Me.txtCedulaUsuario.Text = ""
            Me.ComboBoxBodegas.SelectedIndex = -1
            ComboBoxBodegas.Focus()
        End If
    End Sub

    Private Sub NuevaEntrada()
        Me.DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Clear()
        Me.DataSet_Movimiento_Bodega.MovimientosBodega.Clear()
        Me.NuevosDatos(Me.DataSet_Movimiento_Bodega, Me.DataSet_Movimiento_Bodega.MovimientosBodega.ToString)
        If ToolBar1.Buttons(0).Text = "Cancelar" Then ComboBoxBodegas.Focus()
    End Sub
#End Region

#Region "Buscar"
    Private Sub CargarAjuste()
        Try
            If ToolBar1.Buttons(0).Text = "Cancelar" Then
                If MsgBox("Esta realizando un ajuste nuevo, si continua perdera los datos.., ¿Desea continuar con el movimiento?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

            Dim Cx As New Conexion
            Dim Fx As New cFunciones
            Dim Buscar As New FrmBuscador
            Buscar.SQLString = "SELECT MovimientosBodega.Boleta_Movimiento AS Movimiento, MovimientosBodega.Referencia, Bodegas.Nombre_Bodega AS Bodega, MovimientosBodega.Fecha FROM MovimientosBodega INNER JOIN  Bodegas ON MovimientosBodega.Bodega = Bodegas.ID_Bodega ORDER BY Boleta_Movimiento DESC"
            Buscar.Text = "Buscar Ajuste de Bodega"
            Buscar.CampoFiltro = "Bodega"
            Buscar.CampoFecha = "Fecha"
            Buscar.ShowDialog()

            If Buscar.Cancelado Or Buscar.Codigo = "" Then
                Exit Sub
            Else
                If ToolBar1.Buttons(0).Text = "Cancelar" Then
                    Nuevo_o_Cancelar()
                End If

                Me.BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega").CancelCurrentEdit()
                Me.DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Clear()
                Me.DataSet_Movimiento_Bodega.MovimientosBodega.Clear()

                'Me.ToolBar1.Buttons(0).Enabled = False
                Me.ToolBar1.Buttons(2).Enabled = True
                'Me.ToolBar1.Buttons(3).Enabled = False
                'Me.ToolBar1.Buttons(4).Enabled = False

                Panel3.Enabled = True
                Me.DateTimePicker.Enabled = True

                GridControl1.Enabled = True
                txtCantVet.Visible = False
                txtExistencia.Enabled = False
                'txtCodigo.Enabled = False

                Fx.Cargar_Tabla_Generico(Me.SqlDataAdapterMovimiento_Bodega, "SELECT * FROM MovimientosBodega WHERE (Boleta_Movimiento = " & Buscar.Codigo & ")")
                Me.SqlDataAdapterMovimiento_Bodega.Fill(Me.DataSet_Movimiento_Bodega, "MovimientosBodega")

                Fx.Cargar_Tabla_Generico(Me.SqlDataAdapter_MovimientDetalle, "SELECT * FROM MovimientosBodega_Detalle WHERE (Boleta_Movimiento = " & Buscar.Codigo & ")")
                Me.SqlDataAdapter_MovimientDetalle.Fill(Me.DataSet_Movimiento_Bodega, "MovimientosBodega_Detalle")

                If Me.BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega").Current("Anulado") = False Then
                    Me.ToolBar1.Buttons(3).Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Me.ToolBar1.Buttons(4).Enabled = True
    End Sub
#End Region

#Region "Registrar"

    Private Function Tiene_Salidas() As Boolean
        For i As Integer = 0 To Me.DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Count - 1
            If Not Me.DataSet_Movimiento_Bodega.MovimientosBodega_Detalle(i).RowState = DataRowState.Deleted Then
                If Me.DataSet_Movimiento_Bodega.MovimientosBodega_Detalle(i).Tipo_Salida = True Then
                    Return True
                End If
            End If
        Next
        Return False
    End Function

    Private Sub Registrar()
        Try

            If Tiene_Salidas() = True Then
                Dim frm As New frmValidaRegistrarSalida
                frm.ShowDialog()
                If frm.Resultado = False Then
                    Exit Sub
                End If
            End If


            Dim funciones As New Conexion
            If Not (RegistraLote()) Then    'REGISTRA LOTES NUEVOS
                Exit Sub
            End If
            Dim Cx As New Conexion
            Dim cantidad As Integer
            Dim codigo As Integer
            Dim Existencia As Double
            Dim MAxActual As Integer
            Dim MAxActualAux As Integer
            Dim rs As SqlDataReader
            Dim VarRadioButtonEntrada As Boolean = RadioButtonEntrada.Checked
            Dim VarRadioButtonSalida As Boolean = RadioButtonSalida.Checked

            If RadioButtonEntrada.Checked = True Then

                'se guarda la cantidad maxima ajustada , esta cantidad es el tope para las devoluciones
                For cont As Integer = 0 To BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").Count - 2

                    If DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Item(cont).RowState = DataRowState.Deleted Then
                        'no procesa el registro eliminado
                    Else

                        cantidad = DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Item(cont).Cantidad
                        codigo = DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Item(cont).Codigo
                        Existencia = DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Item(cont).ExistVeteForzada
                        txtExistenciaForzada = DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Item(cont).ExistenciaForzada

                        rs = Cx.GetRecorset(Cx.Conectar, "SELECT MAX_Bodega FROM Inventario WHERE Codigo= " & codigo & "")
                        If rs.Read Then
                            MAxActual = rs("MAX_Bodega")
                            MAxActualAux = rs("MAX_Bodega")
                        End If
                        rs.Close()

                        cantidad = DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Item(cont).Cantidad
                        codigo = DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Item(cont).Codigo
                        Cx.UpdateRecords("Inventario", "MAX_Bodega=" & MAxActual + CInt(cantidad), "Codigo= " & CInt(codigo) & "")

                    End If

                Next

            ElseIf RadioButtonSalida.Checked = True Then

                'se guarda la cantidad maxima ajustada , esta cantidad es el tope para las devoluciones
                For cont As Integer = 0 To BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").Count - 2

                    If DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Item(cont).RowState = DataRowState.Deleted Then
                        'no procesa el registro eliminado
                    Else
                        cantidad = DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Item(cont).Cantidad
                        codigo = DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Item(cont).Codigo

                        Existencia = DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Item(cont).ExistVeteForzada
                        txtExistenciaForzada = DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Item(cont).ExistenciaForzada

                        rs = Cx.GetRecorset(Cx.Conectar, "SELECT MAX_Bodega FROM Inventario WHERE Codigo=" & codigo & "")
                        If rs.Read Then
                            MAxActual = rs("MAX_Bodega")
                        End If
                        rs.Close()

                        cantidad = DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Item(cont).Cantidad
                        codigo = DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Item(cont).Codigo()
                        Cx.UpdateRecords("Inventario", "MAX_Bodega=" & MAxActual - CInt(cantidad), "Codigo = " & CInt(codigo) & "")

                        'If txtCedulaUsuario.Text = "502250594" Then

                        'End If
                        '    If (MAxActual = txtExistenciaForzada) Then
                        '        Cx.UpdateRecords("Inventario", "MAX_Bodega=" & MAxActual - CInt(cantidad), "Codigo = " & CInt(codigo) & "")
                        '    End If

                        '    'If (txtExistenciaForzada > MAxActual) Then
                        '    '    Dim NuevaCantidad As Double = 0.0
                        '    '    NuevaCantidad = txtExistenciaForzada - MAxActual
                        '    '    ' DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Item(cont).cantidad = NuevaCantidad
                        '    '    cantidad = DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Item(cont).cantidad
                        '    '    DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Item(cont).Tipo_Entrada = True
                        '    '    DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Item(cont).Tipo_Salida = False
                        '    '    Cx.UpdateRecords("Inventario", "MAX_Bodega=" & MAxActual + CInt(cantidad) & ", Existencia=" & Existencia, "Codigo= " & CInt(codigo) & "")

                        '    'End If

                        '    'If (txtExistenciaForzada < MAxActual) Then
                        '    '    Dim NuevaCantidad As Double = 0.0
                        '    '    NuevaCantidad = MAxActual - txtExistenciaForzada
                        '    '    DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Item(cont).cantidad = NuevaCantidad

                        '    '    cantidad = DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Item(cont).cantidad
                        '    '    DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Item(cont).Tipo_Entrada = False
                        '    '    DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Item(cont).Tipo_Salida = True
                        '    '    Cx.UpdateRecords("Inventario", "MAX_Bodega=" & MAxActual - CInt(cantidad) & ", Existencia=" & Existencia, "Codigo= " & CInt(codigo) & "")
                        '    '    'Cx.UpdateRecords("Inventario", "ExistenciaBodega=" & MAxActual - CInt(cantidad) & ", MAX_Bodega=" & MAxActual - CInt(cantidad), "Codigo = " & CInt(codigo) & "")

                        '    'End If

                        'Else
                        'End If
                    End If
                Next
            End If

            Me.RegistrarDatos(Me.SqlDataAdapterMovimiento_Bodega, Me.DataSet_Movimiento_Bodega, Me.DataSet_Movimiento_Bodega.MovimientosBodega.ToString, True, False)
            Me.RegistrarDatos(Me.SqlDataAdapter_MovimientDetalle, Me.DataSet_Movimiento_Bodega, Me.DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.ToString, True)
            funciones.UpdateRecords("Lotes", "Documento = " & BindingContext(DataSet_Movimiento_Bodega, "MovimientosBodega").Current("Boleta_Movimiento"), "Tipo = 'AIB' AND Documento = 0")

            If Me.ListaSerieEntrada.Count > 0 Then
                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                For Each s As Serie In Me.ListaSerieEntrada
                    db.Ejecutar("insert into Serie(codigo, serie, vendido, factura) values(" & s.Codigo & ",'" & s.Serie & "',0,0)", CommandType.Text)
                Next
                Me.ListaSerieEntrada.Clear()
            End If

            If Me.ListaSerieSalida.Count > 0 Then
                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                For Each s As Serie In Me.ListaSerieSalida
                    db.Ejecutar("delete from Serie where serie = '" & s.Serie & "' and codigo = " & s.Codigo, CommandType.Text)
                Next
                Me.ListaSerieSalida.Clear()
            End If

            registrar_existencias()
            actualizar_eliminados()
            'Imprimir(TextBoxId.Text)

            Dim Reporte As New ReporteMovimientoBodega
            Reporte.SetParameterValue(0, TextBoxId.Text)
            Dim Visor As New frmVisorReportes
            Visor.IdCotizacion = "0"
            LoadReportViewer(Visor.rptViewer, Reporte, , CadenaConexionSeePOS)
            Visor.rptViewer.Visible = True
            Visor.ShowDialog()

            txtCodigo.Enabled = True

            If MsgBox("Desea agregar un nuevo ajuste de Bodega...", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim frm As New FrmAjusteBodega(Usua)
                frm.MdiParent = Me.MdiParent
                frm.Show()
                Me.Close()
            Else
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub actualizar_eliminados()

        Dim dts As New DataTable
        Dim codigo As String
        Dim bodega As String
        Dim funciones As New Conexion
        Dim exis_act As Double
        Dim Existenciabod As Double

        Try


            For i As Integer = 0 To lista.Items.Count - 1
                codigo = lista.Items(i)

                cFunciones.Llenar_Tabla_Generico("select codigo,id_bodega,ExistenciaBodega,Existencia,dbo.ReporteBodega_SaldoInicial(GETDATE(),codigo,Id_Bodega)as exisbod  from Inventario where Consignacion = 1 and codigo = '" & codigo & "'", dts, CadenaConexionSeePOS)
                If dts.Rows.Count > 0 Then

                    'existencia actual en bodega
                    Existenciabod = dts.Rows(0).Item("exisbod")

                    'existencia en bodega inventario
                    exis_act = dts.Rows(0).Item("existenciabodega")

                    If Existenciabod <> exis_act Then
                        funciones.UpdateRecords("inventario", "existenciaBodega = " & Existenciabod, "codigo = " & codigo, "SeePos")
                    End If
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub registrar_existencias()

        Dim dts As New DataTable
        Dim codigo As String
        Dim bodega As String
        Dim funciones As New Conexion
        Dim exis_act As Double
        Dim Existenciabod As Double

        Dim dts_movimiento As New DataTable
        Try
            cFunciones.Llenar_Tabla_Generico("select * from MovimientosBodega_Detalle where boleta_movimiento = " & Me.TextBoxId.Text, dts_movimiento, CadenaConexionSeePOS)

            With dts_movimiento

                For i As Integer = 0 To .Rows.Count - 1
                    codigo = .Rows(i).Item("codigo")

                    cFunciones.Llenar_Tabla_Generico("select codigo,id_bodega,ExistenciaBodega,Existencia,dbo.ReporteBodega_SaldoInicial(GETDATE(),codigo,Id_Bodega)as exisbod  from Inventario where Consignacion = 1 and codigo = '" & codigo & "'", dts, CadenaConexionSeePOS)
                    If dts.Rows.Count > 0 Then

                        'existencia actual en bodega
                        Existenciabod = dts.Rows(0).Item("exisbod")

                        'existencia en bodega inventario
                        exis_act = dts.Rows(0).Item("existenciabodega")

                        If Existenciabod <> exis_act Then
                            funciones.UpdateRecords("inventario", "existenciaBodega = " & Existenciabod, "codigo = " & codigo, "SeePos")
                        End If
                    End If
                Next

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Eliminar"
    Private Sub Eliminar()
        Try
            Dim resp As Integer
            If Me.BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega").Count > 0 Then
                resp = MessageBox.Show("¿Desea Anular este Ajuste de Bodega?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If resp = 6 Then
                    Check_Anulado.Checked = True
                    Me.BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega").EndCurrentEdit()

                    If Me.insertar_bitacora() And Registrar_Anulacion_Ajuste() Then

                        Me.DataSet_Movimiento_Bodega.AcceptChanges()
                        MsgBox("El ajuste ha sido anulado correctamente", MsgBoxStyle.Information)
                        Me.DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Clear()
                        Me.DataSet_Movimiento_Bodega.MovimientosBodega.Clear()
                        Me.ToolBar1.Buttons(4).Enabled = True
                        Me.ToolBar1.Buttons(1).Enabled = True
                        Me.ToolBar1.Buttons(0).Text = "Nuevo"
                        Me.ToolBar1.Buttons(0).ImageIndex = 0

                        Me.ToolBar1.Buttons(0).Enabled = False
                        Me.ToolBar1.Buttons(1).Enabled = True
                        Me.ToolBar1.Buttons(2).Enabled = False
                        Me.ToolBar1.Buttons(3).Enabled = False
                        Me.ToolBar1.Buttons(4).Enabled = False
                        txtUsuario.Enabled = True
                        txtUsuario.Text = ""
                        txtNombreUsuario.Text = ""
                        txtCedulaUsuario.Text = ""
                        txtUsuario.Focus()
                        Me.ToolBar1.Buttons(3).Enabled = False
                        Me.ToolBar1.Buttons(4).Enabled = False
                    End If
                Else : Exit Sub
                End If
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Function insertar_bitacora() As Boolean
        Dim funciones As New Conexion
        Dim datos As String
        datos = "'AJUSTE BODEGA','" & Me.TextBoxId.Text & "','AJUSTE BODEGA','AJUSTE BODEGA ANULADO','" & Format(Now, "dd/MM/yyyy H:mm:ss") & "','" & Usua.Nombre & "'," & 0 & "," & 0 & "," & 0 & "," & 0 & "," & 0
        If funciones.AddNewRecord("Bitacora", "Tabla,Campo_Clave,DescripcionCampo,Accion, Fecha,Usuario,Costo,VentaA,VentaB,VentaC,VentaD", datos) <> "" Then
            MsgBox("Problemas al Anular el ajuste", MsgBoxStyle.Critical)
            Return False
        Else
            Return True
        End If
    End Function

    Function Registrar_Anulacion_Ajuste() As Boolean
        If Me.SqlConnection.State <> Me.SqlConnection.State.Open Then Me.SqlConnection.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection.BeginTransaction
        Try

            Me.SqlDataAdapterMovimiento_Bodega.UpdateCommand.Transaction = Trans
            Me.SqlDataAdapterMovimiento_Bodega.Update(Me.DataSet_Movimiento_Bodega, "MovimientosBodega")

            Trans.Commit()
            Return True


        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            Me.ToolBar1.Buttons(3).Enabled = True
            Return False
        End Try
    End Function
#End Region

#Region "Imprimir"
    Private Sub Imprimir(ByVal Boleta As String)
        Try
            Dim Reporte As New ReporteMovimientoBodega
            Reporte.SetParameterValue(0, Boleta)
            CrystalReportsConexion.LoadShow(Reporte, MdiParent)
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Funciones Controles"

    Private ListaSerieEntrada As New System.Collections.Generic.List(Of Serie)
    Private ListaSerieSalida As New System.Collections.Generic.List(Of Serie)

    Private Function DebeIncluirSerie(_CodigoProv As String)
        Dim msg As String = "Los productos de este proveedor usan serie, favor incluirla."
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * from Proveedores Where CodigoProv = " & _CodigoProv, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            If dt.Rows(0).Item("serie") = True Or dt.Rows(0).Item("serie") = 1 Then
                MsgBox(msg, MsgBoxStyle.Exclamation, Text)
                Return True
            End If
        End If
        Return False
    End Function

    Private Sub TextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxBodegas.KeyDown, DateTimePicker.KeyDown, txtUsuario.KeyDown, TextBoxCantidad.KeyDown, txtCodigo.KeyDown, RadioButtonEntrada.KeyDown, RadioButtonSalida.KeyDown, TextBoxReferencia.KeyDown, txtCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            Select Case sender.NAME
                Case Me.txtUsuario.Name
                    If Not ValidarUsuario() Then Exit Sub
                    Me.ToolBar1.Buttons(0).Enabled = True
                    Me.ToolBar1.Buttons(2).Enabled = True
                    Me.ToolBar1.Buttons(3).Enabled = False
                    Me.ToolBar1.Buttons(4).Enabled = False
                    Me.Panel2.Enabled = True
                    ComboBoxBodegas.Focus()

                Case Me.ComboBoxBodegas.Name
                    DateTimePicker.Focus()

                Case Me.DateTimePicker.Name
                    txtCliente.Focus()

                Case txtCliente.Name
                    TextBoxReferencia.Focus()

                Case TextBoxReferencia.Name

                    If ValidaReferencia(Me.ComboBoxBodegas.SelectedValue, Me.TextBoxReferencia.Text) = False Then
                        BindingContext(DataSet_Movimiento_Bodega, "MovimientosBodega").EndCurrentEdit()
                        Panel3.Enabled = True
                        GridControl1.Enabled = True
                        txtCodigo.Focus()
                        txtCodigo.SelectAll()
                    End If

                Case Me.TextBoxCantidad.Name
                    Dim func As New Conexion
                    If CDbl(Me.TextBoxCantidad.Text) = 0 Then
                        If txtCedulaUsuario.Text = "502250594" Or txtCedulaUsuario.Text = "50323055" Then

                        Else
                            MsgBox("La cantidad no puede ser 0!!", MsgBoxStyle.Critical)
                            Exit Sub
                        End If

                    End If

                    If Me.RadioButtonSalida.Checked = True And func.SlqExecuteScalar(func.Conectar, "SELECT ExistenciaBodega FROM Inventario WHERE (Codigo = " & CInt(TextBoxCodigo.Text) & ")") < CDbl(Me.TextBoxCantidad.Text) Then
                        MsgBox("La cantidad en consignación es menor a la que usted desea sacar de Existencia!!" & vbCrLf & "No se puede Continuar!!", MsgBoxStyle.Critical)
                        'If MsgBox("La cantidad en consignación es menor a la que usted desea sacar de Existencia.., ¿Desea continuar con el movimiento?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        Exit Sub
                        'End If
                    End If

                    If CbNumero.Visible = True Then
                        BindingContext(DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").Current("Numero") = CbNumero.Text
                    ElseIf CBNuevo.Checked = True Then
                        BindingContext(DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").Current("Numero") = txtNuevoLote.Text
                        AgregaLote()
                        CBNuevo.Checked = False
                    Else

                    End If



                    BindingContext(DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").Current("Numero") = "0"
                    If txtExistencia.Text = "" Or txtCantVet.Text = "" Then
                        Dim db As New GestioDatos
                        Dim dt As New DataTable
                        dt = db.Ejecuta("Select Existencia, ExistenciaBodega From Inventario Where Codigo = " & txtCodigo.Text)
                        If dt.Rows.Count > 0 Then
                            txtExistencia.Text = dt.Rows(0).Item("Existencia")
                            txtCantVet.Text = dt.Rows(0).Item("ExistenciaBodega")
                        End If
                    End If
                    BindingContext(DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").Current("ExistenciaForzada") = txtExistencia.Text
                    If txtExistencia.Text = "" Or txtCantVet.Text = "" Then
                        Dim db As New GestioDatos
                        Dim dt As New DataTable
                        dt = db.Ejecuta("Select Existencia, ExistenciaBodega From Inventario Where Codigo = " & txtCodigo.Text)
                        If dt.Rows.Count > 0 Then
                            txtExistencia.Text = dt.Rows(0).Item("Existencia")
                            txtCantVet.Text = dt.Rows(0).Item("ExistenciaBodega")
                        End If
                    End If
                    BindingContext(DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").Current("ExistVeteForzada") = txtCantVet.Text

                    Dim entrada As Boolean = RadioButtonEntrada.Checked
                    Dim salida As Boolean = RadioButtonSalida.Checked

                    Dim dtSeries As New DataTable
                    Dim CodigoInventario As String = TextBoxCodigo.Text
                    cFunciones.Llenar_Tabla_Generico("select serie, Proveedor from Inventario  where Codigo = " & CodigoInventario, dtSeries, CadenaConexionSeePOS)
                    If dtSeries.Rows.Count > 0 Then
                        If dtSeries.Rows(0).Item("Serie") = 1 Or dtSeries.Rows(0).Item("Serie") = True Then

                            If Me.RadioButtonSalida.Checked = False Then
                                'entrada
                                Dim frm As New frmAgregarSeries
                                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                                    For Each x As DataGridViewRow In frm.viewSerie.Rows
                                        Me.ListaSerieEntrada.Add(New Serie(CodigoInventario, x.Cells("cSerie").Value))
                                    Next
                                End If
                            Else
                                'salida
                                Dim frm As New frmSeleccinarSerie_Salida
                                frm.Codigo = CodigoInventario
                                frm.Cantidad = CDec(Me.TextBoxCantidad.Text)
                                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                                    For Each r As DataGridViewRow In frm.viewDatos.Rows
                                        If r.Cells("cSeleccionar").Value = True Then
                                            Me.ListaSerieSalida.Add(New Serie(CodigoInventario, r.Cells("cSerie").Value))
                                        End If
                                    Next                                    
                                Else
                                    Exit Sub
                                End If
                            End If
                        Else
                            If Me.DebeIncluirSerie(dtSeries.Rows(0).Item("Proveedor")) = True Then
                                If MsgBox("Desea continuar sin incluir la serie", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Accion") = MsgBoxResult.No Then
                                    Exit Sub
                                End If
                            End If
                        End If
                    End If

                    BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").EndCurrentEdit()
                    BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").CancelCurrentEdit()
                    BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").AddNew()
                    If entrada = True Then
                        RadioButtonEntrada.Checked = True
                    Else
                        RadioButtonSalida.Checked = True
                    End If

                    CBNuevo.Checked = False
                    CBNuevo.Visible = False
                    CbNumero.Items.Clear()
                    CbNumero.Visible = False
                    LNumero.Visible = False
                    Me.txtCodigo.Focus()
                    Me.txtCodigo.SelectAll()
                    Exit Sub

                Case Me.txtCodigo.Name
                    'zoe
                    If txtCodigo.Text <> "" And txtCodigo.Text <> "0" Then
                        Dim strCodigo As String = Me.txtCodigo.Text
                        Me.BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").CancelCurrentEdit()
                        Me.BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").EndCurrentEdit()
                        Me.BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").AddNew()
                        CargarInformacionArticulo(strCodigo)
                        If info = False Then
                            Me.BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").CancelCurrentEdit()
                            Me.BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").AddNew()
                            txtCodigo.Focus()
                            Me.txtCodigo.SelectAll()
                            Exit Sub
                        End If
                    End If
                    Exit Sub
            End Select
        End If

        If e.KeyCode = Keys.F1 Then
            '=================================
            ' JCGA 25 DE JUNIO 2007
            Select Case sender.NAME
                Case Me.txtCodigo.Name

                    Dim BuscarArt As New FrmBuscarArticulo2
                    Try
                        Me.BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").CancelCurrentEdit()
                        Me.BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").EndCurrentEdit()
                        Me.BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").AddNew()
                        BuscarArt.StartPosition = FormStartPosition.CenterParent
                        BuscarArt.Cod_Articulo = True
                        BuscarArt.ShowDialog()
                        If BuscarArt.Cancelado Then
                            BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").CancelCurrentEdit()
                            BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").AddNew()
                            Exit Sub
                        End If
                        Me.txtCodigo.Text = BuscarArt.Codigo
                        BuscarArt.Dispose()

                        CargarInformacionArticulo(Me.txtCodigo.Text)
                        If info = False Then
                            Me.BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").CancelCurrentEdit()
                            Me.BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").AddNew()
                            txtCodigo.Focus()
                            Me.txtCodigo.SelectAll()
                            Exit Sub
                        End If

                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
                    End Try

            End Select
            '=========================================
        End If

        If e.KeyCode = Keys.F2 Then
            '==========================================
            Dim resp As Integer
            If Me.BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").Count > 0 Then  ' si hay detalles
                resp = MessageBox.Show("¿Desea guardar este Ajuste?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If resp = 6 Then
                    Me.BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").CancelCurrentEdit()
                    Registrar()
                End If
            Else
                MsgBox("No Existen Artìculos para guardar del ajuste!!", MsgBoxStyle.Information)
            End If
            '====================================================================================
        End If
    End Sub

    Private Sub RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonEntrada.CheckedChanged, RadioButtonSalida.CheckedChanged
        If lblCantVet.Visible = False Then
            Me.TextBoxCantidad.Focus()
            Me.TextBoxCantidad.SelectAll()
        Else
            txtCantVet.Focus()
            txtCantVet.SelectAll()
        End If
    End Sub

    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Delete Then
            Eliminar_Articulo_Detalle()
        End If
    End Sub

    Private Sub GridControl1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.GotFocus
        BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").CancelCurrentEdit()
    End Sub
#End Region

#Region "Funciones y Procedimientos"
    Dim existActualVet As Double
    Dim existActualBod As Double

    Private Sub CargarInformacionArticulo(ByVal Codigo As String)
        Dim Registros As SqlClient.SqlDataReader
        Dim Conexion As New Conexion
        Dim Func As New Conexion

        Registros = Conexion.GetRecorset(Conexion.Conectar, "SELECT Existencia, Inventario.Codigo, Inventario.Cod_Articulo, Inventario.Descripcion + ' (' + Cast(dbo.Inventario.PresentaCant AS VARCHAR) + ' ' + ISNULL(Presentaciones.Presentaciones, '') + ')' AS DescripcionArticulo, Inventario.ExistenciaBodega, Inventario.Lote FROM Inventario INNER JOIN  Presentaciones ON Inventario.CodPresentacion = Presentaciones.CodPres WHERE (Inventario.inhabilitado = 0) AND (Inventario.Consignacion = 1) AND (Inventario.Id_Bodega = " & ComboBoxBodegas.SelectedValue & ") AND (Inventario.Cod_Articulo = '" & Codigo & "') OR  (Inventario.Barras = '" & Codigo & "')")
        Try

            '==================================================
            'JCGA 25 JUN 2007
            info = False
            '==================================================

            While Registros.Read
                TextBoxCodigo.Text = Registros!Codigo
                txtCodigo.Text = Registros!Cod_Articulo
                TextBoxDescripcion.Text = Registros!DescripcionArticulo
                txtExistencia.Text = Registros!ExistenciaBodega
                EXISTENCIABODEGA = Registros!ExistenciaBodega
                txtCantVet.Text = Registros!Existencia

                Me.existActualBod = EXISTENCIABODEGA
                Me.existActualVet = txtCantVet.Text
                If txtExistencia.Text = "" Then
                    txtExistencia.Text = 0
                End If

                If Registros!Lote Then
                    ActivaLote()
                    CbNumero.Focus()
                Else
                    ActivaNinguno()
                    If lblCantVet.Visible = False Then
                        TextBoxCantidad.Focus()
                    Else
                        ''txtCantVet.Focus()
                        txtExistencia.Focus()
                    End If

                End If

                info = True
            End While

            '==================================================
            If info <> True Then
                info = False
                MsgBox("El artículo no existe, esta deshabilitado o no se encuentra en la Bodega seleccionada!!", MsgBoxStyle.Exclamation)
            End If
            '==================================================

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención..")
        Finally
            Conexion.DesConectar(Conexion.sQlconexion)
            Func.DesConectar(Func.sQlconexion)
        End Try
    End Sub

    Private Function ValidaReferencia(ByVal _CodBodega As Integer, ByVal _Referencia As String) As Boolean

        Dim SQL As New GestioDatos
        Dim Sentencia As String = "SELECT *  FROM MovimientosBodega WHERE Bodega = " & _CodBodega & " AND referencia = '" & _Referencia & "' and anulado = 0"
        Dim dtsReferencia As New DataTable
        dtsReferencia = SQL.Ejecuta(Sentencia)
        If dtsReferencia.Rows.Count > 0 Then
            MsgBox("La Referencia " & _Referencia & " ya existe para el Proveedor " & Me.ComboBoxBodegas.Text & ", por favor revise de nuevo!", MsgBoxStyle.OKOnly, "Atención la Referencia ya Existe")
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub Eliminar_Articulo_Detalle()
        Dim resp As Integer
        Try 'se intenta hacer
            If Me.BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").Count > 0 Then  ' si hay detalles

                resp = MessageBox.Show("¿Desea eliminar este artículo del Ajuste?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

                If resp = 6 Then
                    agregar_eliminador(Me.BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").Current("codigo"))
                    Me.BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").RemoveAt(Me.BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").Position)
                    Me.BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").EndCurrentEdit()
                Else
                    BindingContext(Me.DataSet_Movimiento_Bodega, "MovimientosBodega.MovimientosBodegaMovimientosBodega_Detalle").CancelCurrentEdit()
                    txtCodigo.Focus()
                    txtCodigo.SelectAll()
                End If

            Else
                MsgBox("No Existen Artìculos para eliminar del ajuste!!", MsgBoxStyle.Information)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Sub agregar_eliminador(ByVal codigo As String)
        Me.lista.Items.Add(codigo)
    End Sub
    Private Sub Limpiar()
        DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.Clear()
        DataSet_Movimiento_Bodega.MovimientosBodega.Clear()
        Me.lista.Items.Clear()
        Panel2.Enabled = False
        Panel3.Enabled = False
        GridControl1.Enabled = False
        Me.ToolBar1.Buttons(0).Enabled = False
        Me.ToolBar1.Buttons(2).Enabled = False
        Me.ToolBar1.Buttons(3).Enabled = False
        Me.ToolBar1.Buttons(4).Enabled = False
    End Sub
#End Region

#Region "Validacion de Usuarios"
    Private Function ValidarUsuario()
        Dim Registros As SqlClient.SqlDataReader
        Dim Conexiones As New Conexion
        Registros = Conexiones.GetRecorset(Conexiones.Conectar, "SELECT Cedula, Nombre  from Usuarios where Clave_Interna ='" & txtUsuario.Text & "'")
        If Registros.HasRows = False Then
            MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
            txtUsuario.Text = ""
            txtUsuario.Focus()
            Return False
        End If
        Try
            While Registros.Read
                NuevaEntrada()
                Me.DataSet_Movimiento_Bodega.MovimientosBodega.UsuarioColumn.DefaultValue = Registros!cedula
                Me.txtCedulaUsuario.Text = Registros!cedula
                Me.txtNombreUsuario.Text = Registros!Nombre
                PMU = VSM(Usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo 
                '50323055
                If Registros!Cedula = "502250594" Or Registros!Cedula = "50323055" Then
                    lblCantVet.Visible = True
                    txtCantVet.Visible = True
                    txtExistencia.Enabled = True
                Else
                    lblCantVet.Visible = False
                    txtCantVet.Visible = False
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
        End Try

        Return True
    End Function
#End Region

#Region "Lotes - Serie"

#Region "Controles Lotes"
    Private Sub ActivaLote()
        Me.LNumero.Visible = True
        Me.LNumero.Text = "Lote"
        Me.CbNumero.Visible = True
        CargarCbNumero()
        CBNuevo.Visible = RadioButtonEntrada.Checked
    End Sub

    Private Sub ActivaNinguno()
        Me.LNumero.Visible = False
        Me.CbNumero.Visible = False
        Me.CbNumero.Items.Clear()
        CBNuevo.Visible = False
    End Sub

    Private Sub NuevoLote(ByVal Estado As Boolean)
        Me.txtExistencia.Text = EXISTENCIABODEGA
        LNuevoLote.Visible = Estado
        txtNuevoLote.Visible = Estado
        LVencimiento.Visible = Estado
        DTPVencimiento.Visible = Estado
        txtNuevoLote.Text = ""
        CbNumero.Visible = Not (Estado)
        If Estado = True Then
            txtNuevoLote.Focus()
        Else
            CbNumero.Focus()
        End If
    End Sub
#End Region

#Region "Funciones"
    Private Sub CargarCbNumero()
        Dim rss() As System.Data.DataRow
        Dim rs As System.Data.DataRow
        Dim i As Integer
        CbNumero.Items.Clear() ' limpia el combo

        Try
            If TextBoxCodigo.Text <> Nothing Then
                rss = Me.Lote.Lotes.Select("Cod_Articulo = " & CInt(Me.TextBoxCodigo.Text) & " AND Vencimiento >= '" & Now.Date & "'")

                If rss.Length <> 0 Then ' si existe lote con cantidad disponible
                    For i = 0 To rss.Length - 1
                        rs = rss(i)
                        CbNumero.Items.Add(rs("Numero"))
                    Next i

                    If Me.CbNumero.SelectedIndex = -1 Then
                        Me.CbNumero.SelectedIndex = 0
                    End If
                    CbNumero.Enabled = True

                Else
                    MsgBox("No hay lotes disponibles!" & vbCrLf & "Solo Puede Hacer entrada al Inventario", MsgBoxStyle.Information)
                    If RadioButtonEntrada.Checked = False Then
                        txtCodigo.Focus()
                    Else
                        LNumero.Visible = False
                        CbNumero.Visible = False
                        CBNuevo.Visible = True
                        CBNuevo.Checked = True
                    End If
                End If
            Else
                MsgBox("Debe escribir el Código del Artículo", MsgBoxStyle.Critical)
                txtCodigo.Focus()
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Private Sub CargarExistenciaLote()
        Dim rss() As System.Data.DataRow
        Dim rs As System.Data.DataRow

        Try
            If CbNumero.Text <> Nothing Then
                rss = Me.Lote.Lotes.Select("Cod_Articulo = " & CInt(Me.TextBoxCodigo.Text) & " And Numero = '" & CbNumero.Text & "'")

                If rss.Length <> 0 Then ' si existe lote con cantidad disponible
                    For i As Integer = 0 To rss.Length - 1
                        rs = rss(i)
                        'txtExistencia.Text = rs("Cant_Actual")
                        txtExistencia.Text = EXISTENCIABODEGA
                    Next
                Else
                    MsgBox("No hay " & LNumero.Text & "s disponibles para este artículo", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Debe Seleccionar un Número de " & LNumero.Text & " Válido", MsgBoxStyle.Critical)
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Private Sub AgregaLote()
        BindingContext(Lote, "Lotes").EndCurrentEdit()
        BindingContext(Lote, "Lotes").AddNew()
        BindingContext(Lote, "Lotes").Current("Numero") = txtNuevoLote.Text
        BindingContext(Lote, "Lotes").Current("Vencimiento") = DTPVencimiento.Value.Date
        BindingContext(Lote, "Lotes").Current("Cant_Inicial") = TextBoxCantidad.Text
        BindingContext(Lote, "Lotes").Current("Cant_Actual") = 0
        BindingContext(Lote, "Lotes").Current("Fecha_Entrada") = Now
        BindingContext(Lote, "Lotes").Current("Cod_Articulo") = TextBoxCodigo.Text
        BindingContext(Lote, "Lotes").Current("Documento") = 0
        BindingContext(Lote, "Lotes").Current("Tipo") = "AIB"
        BindingContext(Lote, "Lotes").EndCurrentEdit()
    End Sub


    Public Function ValidaLote() As Boolean
        Dim DrNum() As System.Data.DataRow
        Dim DrNumero As System.Data.DataRow
        ValidaLote = False

        Try
            If Me.Lote.Lotes.Count > 0 Then
                DrNum = Lote.Lotes.Select("Cod_Articulo = " & CInt(Me.TextBoxCodigo.Text) & "AND Numero = '" & txtNuevoLote.Text & "'")

                If DrNum.Length <> 0 Then 'Si existe
                    ValidaLote = True
                End If
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Function

    Function RegistraLote() As Boolean
        Dim TransLote As SqlTransaction
        If SqlConnectionLote.State <> SqlConnectionLote.State.Open Then SqlConnectionLote.Open()
        TransLote = SqlConnectionLote.BeginTransaction

        Try
            AdapterLotes.InsertCommand.Transaction = TransLote
            AdapterLotes.DeleteCommand.Transaction = TransLote
            AdapterLotes.UpdateCommand.Transaction = TransLote

            AdapterLotes.Update(Lote, "Lotes")

            Lote.AcceptChanges()
            TransLote.Commit()
            SqlConnectionLote.Close()
            Return True

        Catch ex As SqlException
            TransLote.Rollback()
            MsgBox(ex.Message)
            ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try
    End Function
#End Region

#Region "Objetos"
    Private Sub CBNumero_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CbNumero.KeyDown
        If e.KeyCode = Keys.Enter Then
            If lblCantVet.Visible = False Then
                TextBoxCantidad.Focus()
            Else
                txtCantVet.Focus()
            End If

        End If
    End Sub


    Private Sub CBNumero_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbNumero.SelectedIndexChanged
        If CbNumero.Items.Count > 0 Then
            CargarExistenciaLote()
        End If
    End Sub


    Private Sub CBNuevo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBNuevo.CheckedChanged
        NuevoLote(CBNuevo.Checked)
    End Sub


    Private Sub txtNuevoLote_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNuevoLote.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not (ValidaLote()) Then
                DTPVencimiento.Focus()
            Else
                MsgBox("El Número de " & LNumero.Text & " ya existe", MsgBoxStyle.Critical)
                txtNuevoLote.Focus()
            End If
        End If
    End Sub


    Private Sub DTPVencimiento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DTPVencimiento.KeyDown
        If e.KeyCode = Keys.Enter Then
            If lblCantVet.Visible = False Then
                TextBoxCantidad.Focus()
            Else
                txtCantVet.Focus()
            End If
        End If
    End Sub
#End Region

#End Region

    Private Sub txtCantVet_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCantVet.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TextBoxCantidad.Focus()
            Me.TextBoxCantidad.SelectAll()
        End If
    End Sub

    Private Sub txtExistencia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtExistencia.KeyDown

        If (e.KeyCode = Keys.Enter) Then
            txtCantVet.Focus()
        End If

    End Sub

    Private Sub txtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub TextBoxReferencia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxReferencia.TextChanged

    End Sub

    Private Sub TextBoxCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxCantidad.TextChanged

    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub Check_Anulado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check_Anulado.CheckedChanged
        If Me.Check_Anulado.Checked Then
            Me.lbanulado.Visible = True
            Me.Panel3.Enabled = False
        Else
            Me.lbanulado.Visible = False
        End If
    End Sub
End Class


Public Class Serie
    Public Property Codigo As String
    Public Property Serie As String
    Sub New(_cod As String, _ser As String)
        Me.Codigo = _cod
        Me.Serie = _ser
    End Sub
End Class
