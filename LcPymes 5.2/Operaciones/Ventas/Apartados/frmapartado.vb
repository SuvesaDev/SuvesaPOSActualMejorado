Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Drawing.Printing
Public Class frmapartado
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As ValidText.ValidText
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarAnular As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarImportar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarExportar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrecio_Unit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMonto_Descuento As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMonto_Impuesto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSubtotalGravado As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSubTotalExcento As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSubTotal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Adapter_Moneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Adapter_Usuarios As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtSubtotalT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents dt_actual As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_vence As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As ValidText.ValidText
    Friend WithEvents TxtCodArticulo As ValidText.ValidText
    Friend WithEvents txtPrecioUnit As ValidText.ValidText
    Friend WithEvents txtDescuento As ValidText.ValidText
    Friend WithEvents txtSubtotal As ValidText.ValidText
    Friend WithEvents txtExistencia As ValidText.ValidText
    Friend WithEvents txtTotalArt As ValidText.ValidText
    Friend WithEvents txtNombreArt As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As ValidText.ValidText
    Friend WithEvents txtImpVentaT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescuentoT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As System.Windows.Forms.Button
    Friend WithEvents lbconsecutivo As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Ad_Apartados As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo4 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo6 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo7 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo8 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo9 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmapartado))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigo = New ValidText.ValidText()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt_actual = New System.Windows.Forms.DateTimePicker()
        Me.dt_vence = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNombreArt = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTotalArt = New ValidText.ValidText()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtExistencia = New ValidText.ValidText()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New ValidText.ValidText()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDescuento = New ValidText.ValidText()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPrecioUnit = New ValidText.ValidText()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtCodArticulo = New ValidText.ValidText()
        Me.txtCantidad = New ValidText.ValidText()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarAnular = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarImportar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarExportar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colCodigo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPrecio_Unit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMonto_Descuento = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMonto_Impuesto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSubtotalGravado = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSubTotalExcento = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSubTotal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.TextBox1 = New ValidText.ValidText()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Adapter_Moneda = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.Adapter_Usuarios = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtImpVentaT = New DevExpress.XtraEditors.TextEdit()
        Me.txtSubtotalT = New DevExpress.XtraEditors.TextEdit()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtTotal = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescuentoT = New DevExpress.XtraEditors.TextEdit()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New System.Windows.Forms.Button()
        Me.lbconsecutivo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Ad_Apartados = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImpVentaT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubtotalT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuentoT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 72)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del cliente"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(80, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(456, 14)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nombre del Cliente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(16, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Código"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.FieldReference = Nothing
        Me.txtCodigo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtCodigo.Location = New System.Drawing.Point(16, 48)
        Me.txtCodigo.MaskEdit = ""
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.txtCodigo.Required = False
        Me.txtCodigo.ShowErrorIcon = True
        Me.txtCodigo.Size = New System.Drawing.Size(56, 16)
        Me.txtCodigo.TabIndex = 3
        Me.txtCodigo.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.txtCodigo.ValidText = "No se permiten caracteres"
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.ForeColor = System.Drawing.Color.Blue
        Me.txtNombre.Location = New System.Drawing.Point(80, 60)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(456, 16)
        Me.txtNombre.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(584, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 14)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fecha"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(584, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 14)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Fecha Vencimiento"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dt_actual
        '
        Me.dt_actual.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_actual.Location = New System.Drawing.Point(648, 40)
        Me.dt_actual.Name = "dt_actual"
        Me.dt_actual.Size = New System.Drawing.Size(104, 23)
        Me.dt_actual.TabIndex = 9
        '
        'dt_vence
        '
        Me.dt_vence.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_vence.Location = New System.Drawing.Point(704, 64)
        Me.dt_vence.Name = "dt_vence"
        Me.dt_vence.Size = New System.Drawing.Size(104, 23)
        Me.dt_vence.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(656, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 14)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Anulado"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(744, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 14)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cancelado"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label50.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label50.Location = New System.Drawing.Point(584, 104)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(60, 14)
        Me.Label50.TabIndex = 13
        Me.Label50.Text = "Estado"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNombreArt)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtTotalArt)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtExistencia)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtSubtotal)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtDescuento)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtPrecioUnit)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TxtCodArticulo)
        Me.GroupBox2.Controls.Add(Me.txtCantidad)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(616, 88)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Producto"
        '
        'txtNombreArt
        '
        Me.txtNombreArt.BackColor = System.Drawing.Color.Silver
        Me.txtNombreArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNombreArt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNombreArt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtNombreArt.Location = New System.Drawing.Point(24, 24)
        Me.txtNombreArt.Name = "txtNombreArt"
        Me.txtNombreArt.Size = New System.Drawing.Size(544, 14)
        Me.txtNombreArt.TabIndex = 21
        Me.txtNombreArt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(512, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 14)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Lineas"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalArt
        '
        Me.txtTotalArt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalArt.FieldReference = Nothing
        Me.txtTotalArt.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtTotalArt.Location = New System.Drawing.Point(512, 64)
        Me.txtTotalArt.MaskEdit = ""
        Me.txtTotalArt.Name = "txtTotalArt"
        Me.txtTotalArt.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.txtTotalArt.Required = False
        Me.txtTotalArt.ShowErrorIcon = True
        Me.txtTotalArt.Size = New System.Drawing.Size(56, 16)
        Me.txtTotalArt.TabIndex = 19
        Me.txtTotalArt.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.txtTotalArt.ValidText = "No se permiten caracteres"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(440, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 14)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Existencia"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtExistencia
        '
        Me.txtExistencia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtExistencia.FieldReference = Nothing
        Me.txtExistencia.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtExistencia.Location = New System.Drawing.Point(440, 64)
        Me.txtExistencia.MaskEdit = ""
        Me.txtExistencia.Name = "txtExistencia"
        Me.txtExistencia.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.txtExistencia.Required = False
        Me.txtExistencia.ShowErrorIcon = True
        Me.txtExistencia.Size = New System.Drawing.Size(56, 16)
        Me.txtExistencia.TabIndex = 17
        Me.txtExistencia.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.txtExistencia.ValidText = "No se permiten caracteres"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(360, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 14)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Monto"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSubtotal
        '
        Me.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSubtotal.FieldReference = Nothing
        Me.txtSubtotal.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtSubtotal.Location = New System.Drawing.Point(360, 64)
        Me.txtSubtotal.MaskEdit = ""
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.txtSubtotal.Required = False
        Me.txtSubtotal.ShowErrorIcon = True
        Me.txtSubtotal.Size = New System.Drawing.Size(56, 16)
        Me.txtSubtotal.TabIndex = 15
        Me.txtSubtotal.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.txtSubtotal.ValidText = "No se permiten caracteres"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(256, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 14)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Descuento(%)"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescuento
        '
        Me.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescuento.FieldReference = Nothing
        Me.txtDescuento.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtDescuento.Location = New System.Drawing.Point(272, 56)
        Me.txtDescuento.MaskEdit = ""
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.txtDescuento.Required = False
        Me.txtDescuento.ShowErrorIcon = True
        Me.txtDescuento.Size = New System.Drawing.Size(56, 16)
        Me.txtDescuento.TabIndex = 13
        Me.txtDescuento.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.txtDescuento.ValidText = "No se permiten caracteres"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(160, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 14)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "P. Unitario"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPrecioUnit
        '
        Me.txtPrecioUnit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrecioUnit.FieldReference = Nothing
        Me.txtPrecioUnit.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtPrecioUnit.Location = New System.Drawing.Point(160, 64)
        Me.txtPrecioUnit.MaskEdit = ""
        Me.txtPrecioUnit.Name = "txtPrecioUnit"
        Me.txtPrecioUnit.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.txtPrecioUnit.Required = False
        Me.txtPrecioUnit.ShowErrorIcon = True
        Me.txtPrecioUnit.Size = New System.Drawing.Size(56, 16)
        Me.txtPrecioUnit.TabIndex = 11
        Me.txtPrecioUnit.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.txtPrecioUnit.ValidText = "No se permiten caracteres"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(88, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 14)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Código"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtCodArticulo
        '
        Me.TxtCodArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCodArticulo.FieldReference = Nothing
        Me.TxtCodArticulo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtCodArticulo.Location = New System.Drawing.Point(88, 64)
        Me.TxtCodArticulo.MaskEdit = ""
        Me.TxtCodArticulo.Name = "TxtCodArticulo"
        Me.TxtCodArticulo.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TxtCodArticulo.Required = False
        Me.TxtCodArticulo.ShowErrorIcon = True
        Me.TxtCodArticulo.Size = New System.Drawing.Size(56, 16)
        Me.TxtCodArticulo.TabIndex = 9
        Me.TxtCodArticulo.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.TxtCodArticulo.ValidText = "No se permiten caracteres"
        '
        'txtCantidad
        '
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidad.FieldReference = Nothing
        Me.txtCantidad.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtCantidad.Location = New System.Drawing.Point(24, 64)
        Me.txtCantidad.MaskEdit = ""
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.txtCantidad.Required = False
        Me.txtCantidad.ShowErrorIcon = True
        Me.txtCantidad.Size = New System.Drawing.Size(56, 16)
        Me.txtCantidad.TabIndex = 7
        Me.txtCantidad.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.txtCantidad.ValidText = "No se permiten caracteres"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(24, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 14)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Cantidad"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarRegistrar, Me.ToolBarAnular, Me.ToolBarImprimir, Me.ToolBarImportar, Me.ToolBarExportar, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 35)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 474)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(896, 47)
        Me.ToolBar1.TabIndex = 15
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Enabled = False
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Name = "ToolBarNuevo"
        Me.ToolBarNuevo.Text = "Nuevo"
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.ImageIndex = 1
        Me.ToolBarBuscar.Name = "ToolBarBuscar"
        Me.ToolBarBuscar.Text = "Buscar"
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Enabled = False
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Name = "ToolBarRegistrar"
        Me.ToolBarRegistrar.Text = "Registrar"
        '
        'ToolBarAnular
        '
        Me.ToolBarAnular.Enabled = False
        Me.ToolBarAnular.ImageIndex = 3
        Me.ToolBarAnular.Name = "ToolBarAnular"
        Me.ToolBarAnular.Text = "Anular"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Enabled = False
        Me.ToolBarImprimir.ImageIndex = 7
        Me.ToolBarImprimir.Name = "ToolBarImprimir"
        Me.ToolBarImprimir.Text = "Imprimir"
        '
        'ToolBarImportar
        '
        Me.ToolBarImportar.Enabled = False
        Me.ToolBarImportar.ImageIndex = 9
        Me.ToolBarImportar.Name = "ToolBarImportar"
        Me.ToolBarImportar.Text = "Importar"
        '
        'ToolBarExportar
        '
        Me.ToolBarExportar.Enabled = False
        Me.ToolBarExportar.ImageIndex = 10
        Me.ToolBarExportar.Name = "ToolBarExportar"
        Me.ToolBarExportar.Text = "Exportar"
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Name = "ToolBarCerrar"
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(24, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 14)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Número de Apartado"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataMember = "Ventas.VentasVentas_Detalle"
        '
        '
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(16, 232)
        Me.GridControl1.MainView = Me.BandedGridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(616, 136)
        Me.GridControl1.TabIndex = 184
        Me.GridControl1.Text = "GridControl1"
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colCodigo, Me.colDescripcion, Me.colCantidad, Me.colPrecio_Unit, Me.colMonto_Descuento, Me.colMonto_Impuesto, Me.colSubtotalGravado, Me.colSubTotalExcento, Me.colSubTotal})
        Me.BandedGridView1.GroupPanelText = "Detalle de Cotización"
        Me.BandedGridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubtotalGravado", Nothing, "")})
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.BandedGridView1.OptionsView.ShowBands = False
        Me.BandedGridView1.OptionsView.ShowGroupedColumns = False
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Columns.Add(Me.colCodigo)
        Me.GridBand1.Columns.Add(Me.colDescripcion)
        Me.GridBand1.Columns.Add(Me.colCantidad)
        Me.GridBand1.Columns.Add(Me.colPrecio_Unit)
        Me.GridBand1.Columns.Add(Me.colMonto_Descuento)
        Me.GridBand1.Columns.Add(Me.colMonto_Impuesto)
        Me.GridBand1.Columns.Add(Me.colSubtotalGravado)
        Me.GridBand1.Columns.Add(Me.colSubTotalExcento)
        Me.GridBand1.Columns.Add(Me.colSubTotal)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 619
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "CodArticulo"
        Me.colCodigo.FilterInfo = ColumnFilterInfo1
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCodigo.Visible = True
        Me.colCodigo.Width = 63
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripcion"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.FilterInfo = ColumnFilterInfo2
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescripcion.Visible = True
        Me.colDescripcion.Width = 245
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cant."
        Me.colCantidad.DisplayFormat.FormatString = "#,#0.00"
        Me.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.FilterInfo = ColumnFilterInfo3
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCantidad.Visible = True
        Me.colCantidad.Width = 46
        '
        'colPrecio_Unit
        '
        Me.colPrecio_Unit.Caption = "P.Unit"
        Me.colPrecio_Unit.DisplayFormat.FormatString = "#,#0.00"
        Me.colPrecio_Unit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrecio_Unit.FieldName = "Precio_Unit"
        Me.colPrecio_Unit.FilterInfo = ColumnFilterInfo4
        Me.colPrecio_Unit.Name = "colPrecio_Unit"
        Me.colPrecio_Unit.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colPrecio_Unit.Visible = True
        Me.colPrecio_Unit.Width = 59
        '
        'colMonto_Descuento
        '
        Me.colMonto_Descuento.Caption = "% Desc"
        Me.colMonto_Descuento.DisplayFormat.FormatString = "#,#0.00"
        Me.colMonto_Descuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMonto_Descuento.FieldName = "Descuento"
        Me.colMonto_Descuento.FilterInfo = ColumnFilterInfo5
        Me.colMonto_Descuento.Name = "colMonto_Descuento"
        Me.colMonto_Descuento.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMonto_Descuento.SummaryItem.FieldName = "Monto_Descuento"
        Me.colMonto_Descuento.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colMonto_Descuento.Visible = True
        Me.colMonto_Descuento.Width = 59
        '
        'colMonto_Impuesto
        '
        Me.colMonto_Impuesto.Caption = "M. Imp."
        Me.colMonto_Impuesto.DisplayFormat.FormatString = "#,#0.00"
        Me.colMonto_Impuesto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMonto_Impuesto.FieldName = "Monto_Impuesto"
        Me.colMonto_Impuesto.FilterInfo = ColumnFilterInfo6
        Me.colMonto_Impuesto.Name = "colMonto_Impuesto"
        Me.colMonto_Impuesto.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMonto_Impuesto.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colMonto_Impuesto.Visible = True
        Me.colMonto_Impuesto.Width = 59
        '
        'colSubtotalGravado
        '
        Me.colSubtotalGravado.Caption = "S. Grav."
        Me.colSubtotalGravado.DisplayFormat.FormatString = "#,#0.00"
        Me.colSubtotalGravado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubtotalGravado.FieldName = "SubtotalGravado"
        Me.colSubtotalGravado.FilterInfo = ColumnFilterInfo7
        Me.colSubtotalGravado.Name = "colSubtotalGravado"
        Me.colSubtotalGravado.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSubtotalGravado.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSubtotalGravado.Width = 59
        '
        'colSubTotalExcento
        '
        Me.colSubTotalExcento.Caption = "S.Exc."
        Me.colSubTotalExcento.DisplayFormat.FormatString = "#,#0.00"
        Me.colSubTotalExcento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubTotalExcento.FieldName = "SubTotalExcento"
        Me.colSubTotalExcento.FilterInfo = ColumnFilterInfo8
        Me.colSubTotalExcento.Name = "colSubTotalExcento"
        Me.colSubTotalExcento.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSubTotalExcento.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSubTotalExcento.Width = 66
        '
        'colSubTotal
        '
        Me.colSubTotal.Caption = "SubTotal"
        Me.colSubTotal.DisplayFormat.FormatString = "#,#0.00"
        Me.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubTotal.FieldName = "SubTotal"
        Me.colSubTotal.FilterInfo = ColumnFilterInfo9
        Me.colSubTotal.Name = "colSubTotal"
        Me.colSubTotal.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSubTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSubTotal.Visible = True
        Me.colSubTotal.Width = 88
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.FieldReference = Nothing
        Me.TextBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TextBox1.Location = New System.Drawing.Point(24, 392)
        Me.TextBox1.MaskEdit = ""
        Me.TextBox1.MaxLength = 250
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TextBox1.Required = False
        Me.TextBox1.ShowErrorIcon = True
        Me.TextBox1.Size = New System.Drawing.Size(608, 48)
        Me.TextBox1.TabIndex = 22
        Me.TextBox1.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.TextBox1.ValidText = "No se permiten caracteres"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(24, 376)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 14)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Observaciones"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(8, 456)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(696, 14)
        Me.Label18.TabIndex = 185
        Me.Label18.Text = "F1:Buscar    |   F2: Registrar        |     F3: Buscar Apart.      |      F6:Modi" & _
    "ficar      |      F11:Abono   |    Supr: Eliminar  |  Insert: Agregar"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(208, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 186
        Me.Button1.Text = "cerrar"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(632, 176)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 14)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Moneda"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(696, 168)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 26)
        Me.ComboBox1.TabIndex = 187
        Me.ComboBox1.Text = "ComboBox1"
        '
        'Adapter_Moneda
        '
        Me.Adapter_Moneda.InsertCommand = Me.SqlInsertCommand1
        Me.Adapter_Moneda.SelectCommand = Me.SqlSelectCommand1
        Me.Adapter_Moneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""DESKTOP-T96OM6J"";packet size=4096;integrated security=SSPI;data s" & _
    "ource=""DESKTOP-T96OM6J\DESARROLLO"";persist security info=False;initial catalog=m" & _
    "ascotas"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'Adapter_Usuarios
        '
        Me.Adapter_Usuarios.InsertCommand = Me.SqlInsertCommand2
        Me.Adapter_Usuarios.SelectCommand = Me.SqlSelectCommand2
        Me.Adapter_Usuarios.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Entrada", "Clave_Entrada"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna"), New System.Data.Common.DataColumnMapping("CambiarPrecio", "CambiarPrecio"), New System.Data.Common.DataColumnMapping("Aplicar_Desc", "Aplicar_Desc"), New System.Data.Common.DataColumnMapping("Exist_Negativa", "Exist_Negativa"), New System.Data.Common.DataColumnMapping("Porc_Desc", "Porc_Desc"), New System.Data.Common.DataColumnMapping("Porc_Precio", "Porc_Precio")})})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 50, "Cedula"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"), New System.Data.SqlClient.SqlParameter("@Clave_Entrada", System.Data.SqlDbType.VarChar, 30, "Clave_Entrada"), New System.Data.SqlClient.SqlParameter("@Clave_Interna", System.Data.SqlDbType.VarChar, 30, "Clave_Interna"), New System.Data.SqlClient.SqlParameter("@CambiarPrecio", System.Data.SqlDbType.Bit, 1, "CambiarPrecio"), New System.Data.SqlClient.SqlParameter("@Aplicar_Desc", System.Data.SqlDbType.Bit, 1, "Aplicar_Desc"), New System.Data.SqlClient.SqlParameter("@Exist_Negativa", System.Data.SqlDbType.Bit, 1, "Exist_Negativa"), New System.Data.SqlClient.SqlParameter("@Porc_Desc", System.Data.SqlDbType.Float, 8, "Porc_Desc"), New System.Data.SqlClient.SqlParameter("@Porc_Precio", System.Data.SqlDbType.Float, 8, "Porc_Precio")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Cedula, Nombre, Clave_Entrada, Clave_Interna, CambiarPrecio, Aplicar_Desc," & _
    " Exist_Negativa, Porc_Desc, Porc_Precio FROM Usuarios"
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
        Me.ImageList1.Images.SetKeyName(10, "")
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(720, 232)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 188
        Me.Button2.Text = "Abonos"
        '
        'txtImpVentaT
        '
        Me.txtImpVentaT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImpVentaT.EditValue = "0.00"
        Me.txtImpVentaT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtImpVentaT.Location = New System.Drawing.Point(768, 352)
        Me.txtImpVentaT.Name = "txtImpVentaT"
        '
        '
        '
        Me.txtImpVentaT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtImpVentaT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtImpVentaT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtImpVentaT.Properties.ReadOnly = True
        Me.txtImpVentaT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.Red)
        Me.txtImpVentaT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtImpVentaT.Size = New System.Drawing.Size(80, 17)
        Me.txtImpVentaT.TabIndex = 192
        '
        'txtSubtotalT
        '
        Me.txtSubtotalT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubtotalT.EditValue = "0.00"
        Me.txtSubtotalT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSubtotalT.Location = New System.Drawing.Point(768, 288)
        Me.txtSubtotalT.Name = "txtSubtotalT"
        '
        '
        '
        Me.txtSubtotalT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtSubtotalT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSubtotalT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSubtotalT.Properties.ReadOnly = True
        Me.txtSubtotalT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.Red)
        Me.txtSubtotalT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSubtotalT.Size = New System.Drawing.Size(80, 17)
        Me.txtSubtotalT.TabIndex = 190
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(696, 288)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 14)
        Me.Label20.TabIndex = 193
        Me.Label20.Text = "Sub total"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(696, 320)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(60, 14)
        Me.Label21.TabIndex = 194
        Me.Label21.Text = "Descuento"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label22.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label22.Location = New System.Drawing.Point(656, 352)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(112, 14)
        Me.Label22.TabIndex = 195
        Me.Label22.Text = "Impuesto de venta"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtTotal
        '
        Me.TxtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTotal.EditValue = "0.00"
        Me.TxtTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtTotal.Location = New System.Drawing.Point(768, 432)
        Me.TxtTotal.Name = "TxtTotal"
        '
        '
        '
        Me.TxtTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtTotal.Properties.ReadOnly = True
        Me.TxtTotal.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.Red)
        Me.TxtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtTotal.Size = New System.Drawing.Size(80, 17)
        Me.TxtTotal.TabIndex = 196
        '
        'txtDescuentoT
        '
        Me.txtDescuentoT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescuentoT.EditValue = "0.00"
        Me.txtDescuentoT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDescuentoT.Location = New System.Drawing.Point(768, 320)
        Me.txtDescuentoT.Name = "txtDescuentoT"
        '
        '
        '
        Me.txtDescuentoT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtDescuentoT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDescuentoT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDescuentoT.Properties.ReadOnly = True
        Me.txtDescuentoT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.Red)
        Me.txtDescuentoT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDescuentoT.Size = New System.Drawing.Size(80, 17)
        Me.txtDescuentoT.TabIndex = 197
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label23.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label23.Location = New System.Drawing.Point(752, 408)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(112, 14)
        Me.Label23.TabIndex = 198
        Me.Label23.Text = "Total del apartado"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(288, 360)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 199
        Me.SimpleButton1.Text = "Button3"
        '
        'lbconsecutivo
        '
        Me.lbconsecutivo.BackColor = System.Drawing.Color.DarkGray
        Me.lbconsecutivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbconsecutivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbconsecutivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbconsecutivo.Location = New System.Drawing.Point(152, 8)
        Me.lbconsecutivo.Name = "lbconsecutivo"
        Me.lbconsecutivo.Size = New System.Drawing.Size(32, 14)
        Me.lbconsecutivo.TabIndex = 200
        Me.lbconsecutivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.DarkGray
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(192, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 14)
        Me.Label7.TabIndex = 201
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ad_Apartados
        '
        Me.Ad_Apartados.InsertCommand = Me.SqlInsertCommand3
        Me.Ad_Apartados.SelectCommand = Me.SqlSelectCommand3
        Me.Ad_Apartados.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Entrada", "Clave_Entrada"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna"), New System.Data.Common.DataColumnMapping("CambiarPrecio", "CambiarPrecio"), New System.Data.Common.DataColumnMapping("Aplicar_Desc", "Aplicar_Desc"), New System.Data.Common.DataColumnMapping("Exist_Negativa", "Exist_Negativa"), New System.Data.Common.DataColumnMapping("Porc_Desc", "Porc_Desc"), New System.Data.Common.DataColumnMapping("Porc_Precio", "Porc_Precio")})})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 50, "Cedula"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"), New System.Data.SqlClient.SqlParameter("@Clave_Entrada", System.Data.SqlDbType.VarChar, 30, "Clave_Entrada"), New System.Data.SqlClient.SqlParameter("@Clave_Interna", System.Data.SqlDbType.VarChar, 30, "Clave_Interna"), New System.Data.SqlClient.SqlParameter("@CambiarPrecio", System.Data.SqlDbType.Bit, 1, "CambiarPrecio"), New System.Data.SqlClient.SqlParameter("@Aplicar_Desc", System.Data.SqlDbType.Bit, 1, "Aplicar_Desc"), New System.Data.SqlClient.SqlParameter("@Exist_Negativa", System.Data.SqlDbType.Bit, 1, "Exist_Negativa"), New System.Data.SqlClient.SqlParameter("@Porc_Desc", System.Data.SqlDbType.Float, 8, "Porc_Desc"), New System.Data.SqlClient.SqlParameter("@Porc_Precio", System.Data.SqlDbType.Float, 8, "Porc_Precio")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Cedula, Nombre, Clave_Entrada, Clave_Interna, CambiarPrecio, Aplicar_Desc," & _
    " Exist_Negativa, Porc_Desc, Porc_Precio FROM Usuarios"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'frmapartado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.ClientSize = New System.Drawing.Size(896, 521)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbconsecutivo)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtDescuentoT)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtImpVentaT)
        Me.Controls.Add(Me.txtSubtotalT)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dt_vence)
        Me.Controls.Add(Me.dt_actual)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label19)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmapartado"
        Me.Text = "Modulo de apartados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImpVentaT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubtotalT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuentoT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
#Region "Variables"
    Dim FrmVuelto As New vuelto
    Dim iddebodega As Integer
    Dim clietencon As Boolean
    Dim logeado As Boolean
    Public Usua As Object
    Dim impuesto_cliente As Double = 100
    Dim PMU As New PerfilModulo_Class
    Public Cedula_usuario As Object
    Private sqlConexion As SqlConnection
    Dim CConexion As New Conexion
    Dim PrecioBase As Double
    Dim Max_Descuento_Articulo As Double
    Dim PrecioCosto As Double
    Dim Flete As Double
    Dim OtrosMontos As Double
    Dim Existencia As Integer
    Dim PrecioA As Double
    Dim PrecioB As Double
    Dim PrecioC As Double
    Dim PrecioD As Double
    Private tipoprecio As Integer
    Dim MonedaBase As Integer
    Dim precio_promo_valor As Double
    Dim MonedaCosto As Integer
    Dim ValorCosto As Double
    Dim ValorVenta As Double
    Dim MonedaVenta As Integer
    Dim ValorBase As Double
    Dim MontoImpuesto As Double
    Dim precio_unitario As Double
    Dim promo_activa_valor As Boolean
    Dim monto_Perdido As Double
    Dim Cambio_Cantidad As Boolean
    Dim vende_existecias_negativas As Boolean
    Dim mensaje As String ' almacena el mensaje de los descuentos
    Dim variacion_Punit As Double
    Private Exento As Double
    Private Gravado As Double
    'Dim reporte As New Repoteapartado
    'Descuento
    Private DescuentoCalc As Double
    Private descuento As Double
    Dim porcentaje_descuento As Double
    Dim max_aplicar As Double 'almacena el maximo porcentaje de descuento que se puede aplicar a determinado articulo
    Dim tempvuelto As Double = 0
#End Region

End Class
