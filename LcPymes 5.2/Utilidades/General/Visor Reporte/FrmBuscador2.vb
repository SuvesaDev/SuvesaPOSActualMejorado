Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class FrmBuscador2
    Inherits System.Windows.Forms.Form

#Region "Variables Globales"
    Dim DV As DataView 'Vista del contenedor y Busqueda 
    Public CampoFecha As String 'Nombre del campo que contiene la fecha para efectuar el Filtro
    Public CampoFiltro As String 'Nombre del campo que contiene cadena de texto para la busqueda 
    Public strNumeroDocumento As String 'Almacenara ek nombre del otro campo por el que se desea buscar

    Public SQLString As String ' Sentencia SQL para el llenado del buscador.
    Public CanColums As Byte '  Columnas a Mostrar.
    Public Codigo As String 'Codigo del registro a devolver
    Public Cancelado As Boolean 'Si la operacion fue cancelada por el Usuario.
    Public NuevaConexion As String
    Friend WithEvents btnAdelanto As System.Windows.Forms.Button
    Friend WithEvents btnPreVenta As System.Windows.Forms.Button
    Friend WithEvents btnVenta As System.Windows.Forms.Button
    Dim logeado As Boolean

#End Region

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()
        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        'CampoFiltro = "Nombre_Cliente"
        'CampoFecha = "Fecha"
        'SQLString = "Select Id, cast(num_factura as varchar) + '-' + TIPO, Nombre_Cliente,Fecha from Ventas Order by Nombre_Cliente"
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
    Friend WithEvents TxtCodigo As ValidText.ValidText
    Friend WithEvents TextBoxBuscar As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ButtonAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataView As System.Data.DataView
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SqlConnection As System.Data.SqlClient.SqlConnection
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlDataAdapter As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CkeckBuscaFecha As System.Windows.Forms.CheckBox
    Friend WithEvents Fecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblBuscarX As System.Windows.Forms.Label
    Friend WithEvents radbNombre As System.Windows.Forms.RadioButton
    Friend WithEvents radbNumeroFactura As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents cbxTipo As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.Panel
    Friend WithEvents Todas As System.Windows.Forms.RadioButton
    Friend WithEvents DelMes As System.Windows.Forms.RadioButton
    Friend WithEvents DelDia As System.Windows.Forms.RadioButton
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chk_Monto As System.Windows.Forms.CheckBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarxMonto As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ColumnFilterInfo16 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo17 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo18 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo19 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo20 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Me.TxtCodigo = New ValidText.ValidText()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.ButtonCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.ButtonAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Fecha2 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataView = New System.Data.DataView()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SqlConnection = New System.Data.SqlClient.SqlConnection()
        Me.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.CkeckBuscaFecha = New System.Windows.Forms.CheckBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblBuscarX = New System.Windows.Forms.Label()
        Me.radbNombre = New System.Windows.Forms.RadioButton()
        Me.radbNumeroFactura = New System.Windows.Forms.RadioButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cbxTipo = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.Panel()
        Me.Todas = New System.Windows.Forms.RadioButton()
        Me.DelMes = New System.Windows.Forms.RadioButton()
        Me.DelDia = New System.Windows.Forms.RadioButton()
        Me.chk_Monto = New System.Windows.Forms.CheckBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.btnBuscarxMonto = New System.Windows.Forms.Button()
        Me.btnVenta = New System.Windows.Forms.Button()
        Me.btnPreVenta = New System.Windows.Forms.Button()
        Me.btnAdelanto = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CheckBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCodigo.FieldReference = Nothing
        Me.TxtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.ForeColor = System.Drawing.Color.Blue
        Me.TxtCodigo.Location = New System.Drawing.Point(600, 326)
        Me.TxtCodigo.MaskEdit = ""
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TxtCodigo.Required = False
        Me.TxtCodigo.ShowErrorIcon = False
        Me.TxtCodigo.Size = New System.Drawing.Size(64, 13)
        Me.TxtCodigo.TabIndex = 81
        Me.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtCodigo.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.TxtCodigo.ValidText = "#0"
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxBuscar.Location = New System.Drawing.Point(186, 294)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(478, 13)
        Me.TextBoxBuscar.TabIndex = 78
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancelar.Location = New System.Drawing.Point(669, 319)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(64, 22)
        Me.ButtonCancelar.TabIndex = 83
        Me.ButtonCancelar.Text = "Cancelar"
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Location = New System.Drawing.Point(669, 294)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(64, 22)
        Me.ButtonAceptar.TabIndex = 82
        Me.ButtonAceptar.Text = "Aceptar"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Fecha2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Fecha1)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(186, 310)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(214, 24)
        Me.Panel1.TabIndex = 80
        '
        'Fecha2
        '
        Me.Fecha2.CustomFormat = "dd/MM/yyyy"
        Me.Fecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha2.Location = New System.Drawing.Point(121, -1)
        Me.Fecha2.Name = "Fecha2"
        Me.Fecha2.Size = New System.Drawing.Size(88, 20)
        Me.Fecha2.TabIndex = 84
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(91, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "<-->"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Fecha1
        '
        Me.Fecha1.CustomFormat = "dd/MM/yyyy"
        Me.Fecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha1.Location = New System.Drawing.Point(1, -1)
        Me.Fecha1.Name = "Fecha1"
        Me.Fecha1.Size = New System.Drawing.Size(88, 20)
        Me.Fecha1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 294)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 16)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Descripción de la Busqueda..."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(600, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 12)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Código"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridControl1
        '
        '
        '
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(8, 26)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(728, 263)
        Me.GridControl1.TabIndex = 86
        Me.GridControl1.Text = "GridControl"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn4, Me.GridColumn2, Me.GridColumn3, Me.GridColumn5})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFilterPanel = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowVertLines = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FilterInfo = ColumnFilterInfo16
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 83
        '
        'GridColumn4
        '
        Me.GridColumn4.FilterInfo = ColumnFilterInfo17
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.FixedWidth) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 92
        '
        'GridColumn2
        '
        Me.GridColumn2.FilterInfo = ColumnFilterInfo18
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 456
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Fecha"
        Me.GridColumn3.FilterInfo = ColumnFilterInfo19
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 83
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Monto"
        Me.GridColumn5.FilterInfo = ColumnFilterInfo20
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn5.VisibleIndex = 4
        '
        'SqlConnection
        '
        Me.SqlConnection.ConnectionString = "workstation id=SKULL;packet size=4096;integrated security=SSPI;data source=SEESER" & _
    "VER;persist security info=False;initial catalog=Seepos"
        Me.SqlConnection.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter
        '
        Me.SqlDataAdapter.SelectCommand = Me.SqlSelectCommand1
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.Connection = Me.SqlConnection
        '
        'CkeckBuscaFecha
        '
        Me.CkeckBuscaFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CkeckBuscaFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkeckBuscaFecha.ForeColor = System.Drawing.Color.White
        Me.CkeckBuscaFecha.Location = New System.Drawing.Point(8, 312)
        Me.CkeckBuscaFecha.Name = "CkeckBuscaFecha"
        Me.CkeckBuscaFecha.Size = New System.Drawing.Size(176, 16)
        Me.CkeckBuscaFecha.TabIndex = 88
        Me.CkeckBuscaFecha.Text = "Buscar entre las Fechas"
        Me.CkeckBuscaFecha.UseVisualStyleBackColor = False
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'lblBuscarX
        '
        Me.lblBuscarX.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lblBuscarX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarX.ForeColor = System.Drawing.Color.White
        Me.lblBuscarX.Location = New System.Drawing.Point(408, 310)
        Me.lblBuscarX.Name = "lblBuscarX"
        Me.lblBuscarX.Size = New System.Drawing.Size(176, 16)
        Me.lblBuscarX.TabIndex = 94
        Me.lblBuscarX.Text = "Criterios de busqueda"
        Me.lblBuscarX.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'radbNombre
        '
        Me.radbNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.radbNombre.Checked = True
        Me.radbNombre.ForeColor = System.Drawing.Color.Blue
        Me.radbNombre.Location = New System.Drawing.Point(408, 326)
        Me.radbNombre.Name = "radbNombre"
        Me.radbNombre.Size = New System.Drawing.Size(88, 16)
        Me.radbNombre.TabIndex = 93
        Me.radbNombre.TabStop = True
        Me.radbNombre.Text = "Descripción"
        Me.radbNombre.UseVisualStyleBackColor = False
        '
        'radbNumeroFactura
        '
        Me.radbNumeroFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.radbNumeroFactura.ForeColor = System.Drawing.Color.Blue
        Me.radbNumeroFactura.Location = New System.Drawing.Point(504, 326)
        Me.radbNumeroFactura.Name = "radbNumeroFactura"
        Me.radbNumeroFactura.Size = New System.Drawing.Size(80, 16)
        Me.radbNumeroFactura.TabIndex = 92
        Me.radbNumeroFactura.Text = "Documento"
        Me.radbNumeroFactura.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(8, 336)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(176, 16)
        Me.CheckBox1.TabIndex = 95
        Me.CheckBox1.Text = "Por número de factura"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'cbxTipo
        '
        Me.cbxTipo.DisplayMember = "CON"
        Me.cbxTipo.Enabled = False
        Me.cbxTipo.Items.AddRange(New Object() {"CON", "CRE", "PVE", "TCO", "TCR"})
        Me.cbxTipo.Location = New System.Drawing.Point(304, 336)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(88, 21)
        Me.cbxTipo.TabIndex = 99
        Me.cbxTipo.ValueMember = "CON"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(184, 336)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 100
        '
        'CheckBox2
        '
        Me.CheckBox2.Controls.Add(Me.Todas)
        Me.CheckBox2.Controls.Add(Me.DelMes)
        Me.CheckBox2.Controls.Add(Me.DelDia)
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(416, 344)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(312, 40)
        Me.CheckBox2.TabIndex = 101
        Me.CheckBox2.Visible = False
        '
        'Todas
        '
        Me.Todas.Location = New System.Drawing.Point(216, 8)
        Me.Todas.Name = "Todas"
        Me.Todas.Size = New System.Drawing.Size(64, 24)
        Me.Todas.TabIndex = 104
        Me.Todas.Text = "Todas"
        '
        'DelMes
        '
        Me.DelMes.Location = New System.Drawing.Point(112, 8)
        Me.DelMes.Name = "DelMes"
        Me.DelMes.Size = New System.Drawing.Size(84, 24)
        Me.DelMes.TabIndex = 103
        Me.DelMes.Text = "Del Mes"
        '
        'DelDia
        '
        Me.DelDia.Checked = True
        Me.DelDia.Location = New System.Drawing.Point(16, 8)
        Me.DelDia.Name = "DelDia"
        Me.DelDia.Size = New System.Drawing.Size(72, 24)
        Me.DelDia.TabIndex = 102
        Me.DelDia.TabStop = True
        Me.DelDia.Text = "Del Dia"
        '
        'chk_Monto
        '
        Me.chk_Monto.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chk_Monto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Monto.ForeColor = System.Drawing.Color.White
        Me.chk_Monto.Location = New System.Drawing.Point(8, 360)
        Me.chk_Monto.Name = "chk_Monto"
        Me.chk_Monto.Size = New System.Drawing.Size(176, 16)
        Me.chk_Monto.TabIndex = 102
        Me.chk_Monto.Text = "Por Monto Factura"
        Me.chk_Monto.UseVisualStyleBackColor = False
        '
        'txtMonto
        '
        Me.txtMonto.Enabled = False
        Me.txtMonto.Location = New System.Drawing.Point(184, 360)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMonto.Size = New System.Drawing.Size(120, 20)
        Me.txtMonto.TabIndex = 103
        Me.txtMonto.Text = "0"
        '
        'btnBuscarxMonto
        '
        Me.btnBuscarxMonto.Location = New System.Drawing.Point(304, 360)
        Me.btnBuscarxMonto.Name = "btnBuscarxMonto"
        Me.btnBuscarxMonto.Size = New System.Drawing.Size(88, 23)
        Me.btnBuscarxMonto.TabIndex = 104
        Me.btnBuscarxMonto.Text = "Buscar"
        '
        'btnVenta
        '
        Me.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVenta.Location = New System.Drawing.Point(8, 0)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(93, 23)
        Me.btnVenta.TabIndex = 105
        Me.btnVenta.Text = "Factura"
        Me.btnVenta.UseVisualStyleBackColor = True
        '
        'btnPreVenta
        '
        Me.btnPreVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreVenta.Location = New System.Drawing.Point(107, 0)
        Me.btnPreVenta.Name = "btnPreVenta"
        Me.btnPreVenta.Size = New System.Drawing.Size(93, 23)
        Me.btnPreVenta.TabIndex = 106
        Me.btnPreVenta.Text = "PreFactura"
        Me.btnPreVenta.UseVisualStyleBackColor = True
        '
        'btnAdelanto
        '
        Me.btnAdelanto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdelanto.Location = New System.Drawing.Point(211, 0)
        Me.btnAdelanto.Name = "btnAdelanto"
        Me.btnAdelanto.Size = New System.Drawing.Size(93, 23)
        Me.btnAdelanto.TabIndex = 107
        Me.btnAdelanto.Text = "Adelanto"
        Me.btnAdelanto.UseVisualStyleBackColor = True
        '
        'FrmBuscador2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(738, 391)
        Me.Controls.Add(Me.btnAdelanto)
        Me.Controls.Add(Me.btnPreVenta)
        Me.Controls.Add(Me.btnVenta)
        Me.Controls.Add(Me.btnBuscarxMonto)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.chk_Monto)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.TextBoxBuscar)
        Me.Controls.Add(Me.radbNombre)
        Me.Controls.Add(Me.cbxTipo)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lblBuscarX)
        Me.Controls.Add(Me.CkeckBuscaFecha)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.radbNumeroFactura)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(744, 416)
        Me.Name = "FrmBuscador2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CheckBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Load"
    Public BuscarRemplazaFactura As Boolean = False
    Private Sub FrmBuscador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim CambioCaja As Boolean
        If BuscarRemplazaFactura = False Then
            CambioCaja = Me.AplicaCambioenCaja
        Else

            CambioCaja = False
        End If

        Me.btnVenta.Visible = CambioCaja
        Me.btnPreVenta.Visible = CambioCaja
        Me.btnAdelanto.Visible = CambioCaja
        If CambioCaja = True Then
            Me.PoneColor(Me.btnPreVenta)
        End If

        Dim DataSet As New DataSet
        Me.SqlConnection.ConnectionString = IIf(NuevaConexion = "", CadenaConexionSeePOS, NuevaConexion)
        '-------------------------------------------------
        If SQLString = "" Then
            MsgBox("No se ha especificado la Sentencia  SQL base para la Busqueda" & vbCrLf & "Error de Programación....", MsgBoxStyle.Critical, "Alerta..")
            Exit Sub
        End If
        If CampoFiltro = "" Then
            MsgBox("No se ha especificado el nombre del campo de Busqueda por Decripción..." & vbCrLf & "Error de Programación....", MsgBoxStyle.Critical, "Alerta..")
            Exit Sub
        End If
        If CampoFecha = "" Then
            MsgBox("No se ha especificado el nombre del campo Fecha para la Busqueda" & vbCrLf & "Error de Programación....", MsgBoxStyle.Critical, "Alerta..")
            Exit Sub
        End If
        '-------------------------------------------------
        Try
            Dim myCommand1 As SqlDataAdapter = New SqlDataAdapter(SQLString, Me.SqlConnection)
            myCommand1.Fill(DataSet, SqlDataAdapter.DefaultSourceTableName.ToString)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

        If DataSet.Tables(0).Columns.Count() < 3 Then
            MsgBox("Cantidad de columnas definidas en la consulta es insuficiente" & vbCrLf & "Error de Programación....", MsgBoxStyle.Critical, "Alerta..")
            Exit Sub
        End If
        ''''''''''''''''''''''''''''

        Me.GridColumn1.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)


        Me.GridColumn2.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)

        Me.GridColumn3.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)

        Me.GridColumn4.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)

        Me.GridColumn5.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                   Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                   Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                   Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                   Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        '''''''''''''''''''''''''''''''''''''''''

        CanColums = DataSet.Tables(0).Columns.Count()
        Select Case CanColums
            Case 5 : Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn4, Me.GridColumn2, Me.GridColumn3})
                Me.GridColumn1.FieldName = DataSet.Tables(0).Columns(0).Caption()
                Me.GridColumn4.FieldName = DataSet.Tables(0).Columns(1).Caption()
                Me.GridColumn2.FieldName = DataSet.Tables(0).Columns(2).Caption()
                Me.GridColumn3.FieldName = DataSet.Tables(0).Columns(3).Caption()
                Me.GridColumn5.FieldName = DataSet.Tables(0).Columns(4).Caption()
                Me.radbNombre.Text = Me.GridColumn2.FieldName
                Me.radbNumeroFactura.Text = Me.GridColumn4.FieldName

                If Me.radbNumeroFactura.Text = "Column1" Then
                    Me.radbNumeroFactura.Visible = False
                End If

                Me.GridColumn1.Caption = DataSet.Tables(0).Columns(0).Caption()
                Me.GridColumn4.Caption = DataSet.Tables(0).Columns(1).Caption()
                Me.GridColumn2.Caption = DataSet.Tables(0).Columns(2).Caption()
                Me.GridColumn3.Caption = DataSet.Tables(0).Columns(3).Caption()

                strNumeroDocumento = DataSet.Tables(0).Columns(1).Caption()
            Case Else
                Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
                Me.GridColumn1.FieldName = DataSet.Tables(0).Columns(0).Caption()
                Me.GridColumn2.FieldName = DataSet.Tables(0).Columns(1).Caption()
                Me.GridColumn3.FieldName = DataSet.Tables(0).Columns(2).Caption()

                Me.GridColumn1.Caption = DataSet.Tables(0).Columns(0).Caption()
                Me.GridColumn2.Caption = DataSet.Tables(0).Columns(1).Caption()
                Me.GridColumn3.Caption = DataSet.Tables(0).Columns(2).Caption()
                Me.GridColumn4.MinWidth = 0
                Me.GridColumn4.Width = 0

                Me.radbNombre.Text = Me.GridColumn2.FieldName
                Me.radbNumeroFactura.Text = Me.GridColumn1.FieldName
                strNumeroDocumento = DataSet.Tables(0).Columns(0).Caption()
        End Select
        DV = DataSet.Tables(0).DefaultView
        DV.AllowDelete = False
        DV.AllowEdit = False
        DV.AllowNew = False

        'Si no se le ha asignado ningun valor a strNumeroDocumento anulo los radiobutton
        If strNumeroDocumento Is Nothing Then
            radbNumeroFactura.Visible = False
            radbNombre.Visible = False
            lblBuscarX.Visible = False

            Me.Width = 752
            Me.Height = 384

        Else

            Me.Width = 752
            Me.Height = 384

        End If

        Me.GridControl1.DataSource = DV
        Me.TxtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DV, DataSet.Tables(0).Columns(0).Caption()))
        DataSet = Nothing
        Fecha1.Value = "01/" & Date.Now.Month & "/" & Date.Now.Year
        Fecha2.Value = Now.Date
        'Me.CkeckBuscaFecha.Checked = True
    End Sub
#End Region

#Region "Buscar"
    Private Sub BuscarDatos(ByVal Descripcion As String)
        'Variable que almacenara el campo que por el que se va ha buscar
        Dim strCampoFiltro As String = ""
        'Evaluo si se desea realizar la busqueda por numero de documento
        If strNumeroDocumento Is Nothing Then '#1 'Si no se inicializo la variable numero documento buscara solo por CampoFiltro
            DV.RowFilter = CampoFiltro & " lIKE '%" & Descripcion & "%'" & IIf(Me.CkeckBuscaFecha.Checked = True, " AND " & CampoFecha & " >= '" & CType(Fecha1.Value, Date) & "' AND " & CampoFecha & " <= '" & DateAdd(DateInterval.Day, 1, Fecha2.Value) & "'", "")
        Else '#1 'Si se inicializo la variable strNumeroDocumento verifico el tipo de busqueda 
            If Me.radbNombre.Checked = True Then '#2
                strCampoFiltro = CampoFiltro
                DV.RowFilter = strCampoFiltro & " lIKE '%" & Descripcion & "%'" & IIf(Me.CkeckBuscaFecha.Checked = True, " AND " & CampoFecha & " >= '" & CType(Fecha1.Value, Date) & "' AND " & CampoFecha & " <= '" & DateAdd(DateInterval.Day, 1, Fecha2.Value) & "'", "")
            Else '#2
                If Me.radbNumeroFactura.Checked = True Then '#3
                    strCampoFiltro = strNumeroDocumento
                    DV.RowFilter = strCampoFiltro & " lIKE '%" & Descripcion & "%'" & IIf(Me.CkeckBuscaFecha.Checked = True, " AND " & CampoFecha & " >= '" & CType(Fecha1.Value, Date) & "' AND " & CampoFecha & " <= '" & DateAdd(DateInterval.Day, 1, Fecha2.Value) & "'", "")
                End If '#3
            End If '#2
        End If '#1
        If Me.CheckBox1.Checked = True Then
            strCampoFiltro = CampoFiltro
            Descripcion = ""
            DV.RowFilter = strCampoFiltro & " lIKE '%" & Descripcion & "%'" & IIf(Me.CheckBox1.Checked = True, " AND Factura ='" + Me.TextBox1.Text + "-" + Me.cbxTipo.Text + "'", "")
        End If
    End Sub
#End Region

#Region "Controles"
    Private Sub TextBoxBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxBuscar.TextChanged
        BuscarDatos(Me.TextBoxBuscar.Text)
    End Sub

    Private Sub ButtonAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAceptar.Click
        If GridView1.RowCount <> 0 Then
            Codigo = TxtCodigo.Text
            Cancelado = False
        Else
            Cancelado = True
        End If
        Close()
    End Sub

    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If GridView1.RowCount <> 0 Then
                Codigo = TxtCodigo.Text
                Cancelado = False
            Else
                Cancelado = True
            End If
            Close()
        End If
    End Sub

    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        If GridView1.RowCount <> 0 Then
            Codigo = TxtCodigo.Text
            Cancelado = False
        Else
            Cancelado = True
        End If
        Close()
    End Sub

    Private Sub CkeckBuscaFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CkeckBuscaFecha.CheckedChanged
        If CkeckBuscaFecha.Checked = True Then Panel1.Enabled = True Else Panel1.Enabled = False
        Me.CheckBox1.Checked = False
    End Sub

    Private Sub Fecha1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fecha1.ValueChanged, Fecha2.ValueChanged
        If Me.Validate() Then BuscarDatos(Me.TextBoxBuscar.Text)
    End Sub

    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        Cancelado = True
    End Sub

    Private Sub Fecha1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Fecha1.Validating
        If CType(Fecha1.Value, Date) > CType(Fecha2.Value, Date) Then
            ErrorProvider.SetError(sender, "La fecha Inicial no puede ser mayor que la fecha Final...")
            e.Cancel = True
        Else
            ErrorProvider.SetError(sender, "")
            e.Cancel = False
        End If
    End Sub

    Private Sub Fecha2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Fecha2.Validating
        If CType(Fecha2.Value, Date) < CType(Fecha1.Value, Date) Then
            ErrorProvider.SetError(sender, "La fecha Final no puede ser Menor que la fecha Inicial...")
            e.Cancel = True
        Else
            ErrorProvider.SetError(sender, "")
            e.Cancel = False
        End If
    End Sub

    Private Sub radbNombre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbNombre.CheckedChanged
        TextBoxBuscar.Focus()
    End Sub

    Private Sub radbNumeroFactura_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbNumeroFactura.CheckedChanged
        TextBoxBuscar.Focus()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            Me.TextBox1.Enabled = True
            Me.cbxTipo.Enabled = True
            Me.CkeckBuscaFecha.Checked = False
        Else
            Me.TextBox1.Enabled = False
            Me.cbxTipo.Enabled = False
        End If
    End Sub

    Private Sub cbxTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTipo.SelectedIndexChanged
        If Me.Validate() Then BuscarDatos(Me.cbxTipo.Text)
    End Sub

    Private Sub cbxTipo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbxTipo.KeyDown
        If Me.Validate() Then BuscarDatos(Me.cbxTipo.Text)
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.cbxTipo.Focus()
        End If
    End Sub

    Private Sub TextBoxBuscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridControl1.Focus()
        End If
    End Sub
#End Region

    Private Function AplicaCambioenCaja() As Boolean
        Dim dt As New DataTable
        Dim Modocaja As Boolean = False
        cFunciones.Llenar_Tabla_Generico("Select ModoCaja from Configuraciones", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Modocaja = dt.Rows(0).Item("ModoCaja")
        End If
        Return Modocaja
    End Function

    Private Sub CargarDatos(ByVal _Tabla As String)
        If Me.CheckBox2.Visible = True Then
            Try
                Dim DataSet As New DataSet
                If DelDia.Checked = True Then

                    If Me.AplicaCambioenCaja = True Then
                        If _Tabla = "PreVentas" Then
                            SQLString = "Select Id, convert(Varchar, convert(bigint,Num_Factura,0),1) + '-' + TIPO As Factura,Nombre_Cliente AS [Nombre del Cliente],Fecha, Total as Monto  from " & _Tabla & " where Estado = 'PreVenta' and dbo.dateonly(fecha) = dbo.dateonly(getdate()) Order by Id DESC"
                        Else
                            SQLString = "Select Id, convert(Varchar, convert(bigint,Num_Factura,0),1) + '-' + TIPO As Factura,Nombre_Cliente AS [Nombre del Cliente],Fecha, Total as Monto  from " & _Tabla & " where dbo.dateonly(fecha) = dbo.dateonly(getdate()) Order by Id DESC"
                        End If
                    Else
                        SQLString = "Select Id, convert(Varchar, convert(bigint,Num_Factura,0),1) + '-' + TIPO As Factura,Nombre_Cliente AS [Nombre del Cliente],Fecha, Total as Monto  from Ventas where dbo.dateonly(fecha) = dbo.dateonly(getdate()) Order by Id DESC"
                    End If

                    Dim myCommand1 As SqlDataAdapter = New SqlDataAdapter(SQLString, Me.SqlConnection)
                    myCommand1.Fill(DataSet, SqlDataAdapter.DefaultSourceTableName.ToString)
                    DV = DataSet.Tables(0).DefaultView
                    Me.GridControl1.DataSource = DV
                    Me.TxtCodigo.DataBindings.Clear()
                    Me.TxtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DV, DataSet.Tables(0).Columns(0).Caption()))
                End If
                If DelMes.Checked = True Then

                    If Me.AplicaCambioenCaja = True Then
                        If _Tabla = "PreVentas" Then
                            SQLString = "Select Id, convert(Varchar, convert(bigint,Num_Factura,0),1) + '-' + TIPO As Factura,Nombre_Cliente AS [Nombre del Cliente],Fecha, Total as Monto  from " & _Tabla & " where Estado = 'PreVenta' and dbo.dateonly(fecha) = dbo.dateonly(getdate()) Order by Id DESC"
                        Else
                            SQLString = "Select Id, convert(Varchar, convert(bigint,Num_Factura,0),1) + '-' + TIPO As Factura,Nombre_Cliente AS [Nombre del Cliente],Fecha, Total as Monto  from " & _Tabla & " where Month(fecha) = Month(getdate()) and Year(fecha) = year(getdate()) Order by Id DESC"
                        End If
                    Else
                        SQLString = "Select Id, convert(Varchar, convert(bigint,Num_Factura,0),1) + '-' + TIPO As Factura,Nombre_Cliente AS [Nombre del Cliente],Fecha, Total as Monto  from Ventas where MONTH(fecha) = MONTH(getdate()) and YEAR(Fecha) = YEAR(GETDATE()) Order by Id DESC"
                    End If

                    Dim myCommand1 As SqlDataAdapter = New SqlDataAdapter(SQLString, Me.SqlConnection)
                    myCommand1.Fill(DataSet, SqlDataAdapter.DefaultSourceTableName.ToString)
                    DV = DataSet.Tables(0).DefaultView
                    Me.GridControl1.DataSource = DV
                    Me.TxtCodigo.DataBindings.Clear()
                    Me.TxtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DV, DataSet.Tables(0).Columns(0).Caption()))
                End If
                If Todas.Checked = True Then

                    If Me.AplicaCambioenCaja = True Then
                        If _Tabla = "PreVentas" Then
                            SQLString = "Select Id, convert(Varchar, convert(bigint,Num_Factura,0),1) + '-' + TIPO As Factura,Nombre_Cliente AS [Nombre del Cliente],Fecha, Total as Monto  from " & _Tabla & " where Estado = 'PreVenta' Order by Id DESC"
                        Else
                            SQLString = "Select Id, convert(Varchar, convert(bigint,Num_Factura,0),1) + '-' + TIPO As Factura,Nombre_Cliente AS [Nombre del Cliente],Fecha, Total as Monto  from " & _Tabla & " Order by Id DESC"
                        End If
                    Else
                        SQLString = "Select Id, convert(Varchar, convert(bigint,Num_Factura,0),1) + '-' + TIPO As Factura,Nombre_Cliente AS [Nombre del Cliente],Fecha, Total as Monto  from Ventas Order by Id DESC"
                    End If

                    Dim myCommand1 As SqlDataAdapter = New SqlDataAdapter(SQLString, Me.SqlConnection)
                    myCommand1.Fill(DataSet, SqlDataAdapter.DefaultSourceTableName.ToString)
                    DV = DataSet.Tables(0).DefaultView
                    Me.GridControl1.DataSource = DV
                    Me.TxtCodigo.DataBindings.Clear()
                    Me.TxtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DV, DataSet.Tables(0).Columns(0).Caption()))
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub chk_Monto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Monto.CheckedChanged
        Me.txtMonto.Enabled = Me.chk_Monto.Checked
        Me.btnBuscarxMonto.Enabled = Me.chk_Monto.Checked
        If Me.chk_Monto.Checked = False Then
            Me.txtMonto.Text = "0"
            RadioButton1_CheckedChanged(DelDia, New System.EventArgs)
        Else
            Me.txtMonto.Focus()
        End If
    End Sub

    Private Sub btnBuscarxMonto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarxMonto.Click
        If IsNumeric(Me.txtMonto.Text) Then
            If CDec(Me.txtMonto.Text) > 0 Then
                Dim DataSet As New DataSet
                If DelDia.Checked = True Then
                    SQLString = "Select Id, convert(Varchar, convert(bigint,Num_Factura,0),1) + '-' + TIPO As Factura,Nombre_Cliente AS [Nombre del Cliente],Fecha, Total as Monto  from Ventas where dbo.dateonly(fecha) = dbo.dateonly(getdate()) and total = " & CDec(Me.txtMonto.Text) & " Order by Id DESC"
                    Dim myCommand1 As SqlDataAdapter = New SqlDataAdapter(SQLString, Me.SqlConnection)
                    myCommand1.Fill(DataSet, SqlDataAdapter.DefaultSourceTableName.ToString)
                    DV = DataSet.Tables(0).DefaultView
                    Me.GridControl1.DataSource = DV
                    Me.TxtCodigo.DataBindings.Clear()
                    Me.TxtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DV, DataSet.Tables(0).Columns(0).Caption()))
                End If
                If DelMes.Checked = True Then
                    SQLString = "Select Id, convert(Varchar, convert(bigint,Num_Factura,0),1) + '-' + TIPO As Factura,Nombre_Cliente AS [Nombre del Cliente],Fecha, Total as Monto  from Ventas where MONTH(fecha) = MONTH(getdate()) and YEAR(Fecha) = YEAR(GETDATE()) and total = " & CDec(Me.txtMonto.Text) & " Order by Id DESC"
                    Dim myCommand1 As SqlDataAdapter = New SqlDataAdapter(SQLString, Me.SqlConnection)
                    myCommand1.Fill(DataSet, SqlDataAdapter.DefaultSourceTableName.ToString)
                    DV = DataSet.Tables(0).DefaultView
                    Me.GridControl1.DataSource = DV
                    Me.TxtCodigo.DataBindings.Clear()
                    Me.TxtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DV, DataSet.Tables(0).Columns(0).Caption()))
                End If
                If Todas.Checked = True Then
                    SQLString = "Select Id, convert(Varchar, convert(bigint,Num_Factura,0),1) + '-' + TIPO As Factura,Nombre_Cliente AS [Nombre del Cliente],Fecha, Total as Monto  from Ventas where total = " & CDec(Me.txtMonto.Text) & " Order by Id DESC"
                    Dim myCommand1 As SqlDataAdapter = New SqlDataAdapter(SQLString, Me.SqlConnection)
                    myCommand1.Fill(DataSet, SqlDataAdapter.DefaultSourceTableName.ToString)
                    DV = DataSet.Tables(0).DefaultView
                    Me.GridControl1.DataSource = DV
                    Me.TxtCodigo.DataBindings.Clear()
                    Me.TxtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DV, DataSet.Tables(0).Columns(0).Caption()))
                End If
            End If
        End If
    End Sub

    Private Sub txtMonto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMonto.KeyDown
        If e.KeyCode = Keys.Enter Then
            If IsNumeric(Me.txtMonto.Text) Then
                If CDec(Me.txtMonto.Text) > 0 Then
                    Me.btnBuscarxMonto.Focus()
                End If
            End If
        End If

    End Sub

    Private Sub PoneColor(ByRef _btn As Button)
        Me.btnVenta.BackColor = System.Drawing.SystemColors.Control
        Me.btnPreVenta.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdelanto.BackColor = System.Drawing.SystemColors.Control
        _btn.BackColor = Drawing.Color.CornflowerBlue
    End Sub

    Private Sub btnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        Me.CargarDatos("Ventas")
        Me.PoneColor(sender)
    End Sub

    Private Sub btnPreVenta_Click(sender As Object, e As EventArgs) Handles btnPreVenta.Click
        Me.CargarDatos("PreVentas")
        Me.PoneColor(sender)
    End Sub

    Private Sub btnAdelanto_Click(sender As Object, e As EventArgs) Handles btnAdelanto.Click
        Me.CargarDatos("AdelantoVentas")
        Me.PoneColor(sender)
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelDia.CheckedChanged, DelMes.CheckedChanged, Todas.CheckedChanged
        Me.CargarDatos(GetTabla)
    End Sub

    Public Function GetTabla() As String
        Dim Tabla As String
        If Me.btnPreVenta.BackColor = Drawing.Color.CornflowerBlue Then
            Tabla = "PreVentas"
        End If
        If Me.btnVenta.BackColor = Drawing.Color.CornflowerBlue Then
            Tabla = "Ventas"
        End If
        If Me.btnAdelanto.BackColor = Drawing.Color.CornflowerBlue Then
            Tabla = "AdelantoVentas"
        End If
        If Tabla = "" Then
            If Me.BuscarRemplazaFactura = True Then
                Tabla = "Ventas"
            End If
        End If
        Return Tabla
    End Function

End Class
