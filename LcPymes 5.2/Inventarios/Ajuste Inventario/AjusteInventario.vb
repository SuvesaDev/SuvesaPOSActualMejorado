Imports System.data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports System.Drawing.Printing

Public Class AjusteInventario
    Inherits System.Windows.Forms.Form
    Dim usua As Usuario_Logeado
    Dim PMU As New PerfilModulo_Class
    Friend WithEvents ckProductoActualizado As System.Windows.Forms.CheckBox
    Friend WithEvents btnKardex As System.Windows.Forms.Button   'Declara la variable Perfil Modulo Usuario
    Dim Lote As New DsAjusteInv

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        usua = Usuario_Parametro
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
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.Label
    Friend WithEvents grpBox_Inventario As System.Windows.Forms.GroupBox
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.Label
    Friend WithEvents txtExistencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents op_Salida As System.Windows.Forms.RadioButton
    Friend WithEvents op_Entrada As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCostoUnit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarEliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarExcel As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTotalEntrada As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalSalida As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSaldoAjuste As DevExpress.XtraEditors.TextEdit

    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtTotalEntradaD As System.Windows.Forms.Label
    Friend WithEvents txtTotalSalidaD As System.Windows.Forms.Label
    Friend WithEvents colCod_Articulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEntrada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colobservacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalEntrada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalSalida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesc_Articulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents adAjusteInv As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsAjusteInv2 As DsAjusteInv
    Friend WithEvents adAjusteInvDetalle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Check_Anulado As System.Windows.Forms.CheckBox
    Friend WithEvents txtCedulaUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents lbCuenta As System.Windows.Forms.Label
    Friend WithEvents colCuenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DTPVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents LVencimiento As System.Windows.Forms.Label
    Friend WithEvents txtNuevoLote As System.Windows.Forms.TextBox
    Friend WithEvents LNuevoLote As System.Windows.Forms.Label
    Friend WithEvents CBNuevo As System.Windows.Forms.CheckBox
    Friend WithEvents CbNumero As System.Windows.Forms.ComboBox
    Friend WithEvents LNumero As System.Windows.Forms.Label
    Friend WithEvents AdapterLotes As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents colLote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnectionLote As System.Data.SqlClient.SqlConnection
    Friend WithEvents txtCodArticulo As System.Windows.Forms.TextBox
    Friend WithEvents TXtExistenciaLote As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ExistenciaLote As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbo_gasto As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlConnection3 As System.Data.SqlClient.SqlConnection
    Friend WithEvents ck_muerte As System.Windows.Forms.CheckBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents colMuerte As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AjusteInventario))
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo4 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo6 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo7 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo8 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo9 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo10 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo11 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.Label()
        Me.DsAjusteInv2 = New LcPymes_5._2.DsAjusteInv()
        Me.grpBox_Inventario = New System.Windows.Forms.GroupBox()
        Me.ckProductoActualizado = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbo_gasto = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ExistenciaLote = New System.Windows.Forms.Label()
        Me.TXtExistenciaLote = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodArticulo = New System.Windows.Forms.TextBox()
        Me.DTPVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.LVencimiento = New System.Windows.Forms.Label()
        Me.txtNuevoLote = New System.Windows.Forms.TextBox()
        Me.LNuevoLote = New System.Windows.Forms.Label()
        Me.CBNuevo = New System.Windows.Forms.CheckBox()
        Me.CbNumero = New System.Windows.Forms.ComboBox()
        Me.LNumero = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbCuenta = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCostoUnit = New DevExpress.XtraEditors.TextEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.Label()
        Me.txtExistencia = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ck_muerte = New System.Windows.Forms.CheckBox()
        Me.txtTotalEntradaD = New System.Windows.Forms.Label()
        Me.txtTotalSalidaD = New System.Windows.Forms.Label()
        Me.op_Salida = New System.Windows.Forms.RadioButton()
        Me.op_Entrada = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Check_Anulado = New System.Windows.Forms.CheckBox()
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarEliminar = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarExcel = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCod_Articulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesc_Articulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMuerte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEntrada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalida = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colobservacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalEntrada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalSalida = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCuenta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotalEntrada = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalSalida = New DevExpress.XtraEditors.TextEdit()
        Me.txtSaldoAjuste = New DevExpress.XtraEditors.TextEdit()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.adAjusteInv = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.adAjusteInvDetalle = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.txtCedulaUsuario = New System.Windows.Forms.TextBox()
        Me.AdapterLotes = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnectionLote = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.SqlConnection3 = New System.Data.SqlClient.SqlConnection()
        Me.btnKardex = New System.Windows.Forms.Button()
        CType(Me.DsAjusteInv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBox_Inventario.SuspendLayout()
        CType(Me.TXtExistenciaLote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCostoUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExistencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txtTotalEntrada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalSalida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoAjuste.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Image = CType(resources.GetObject("Label15.Image"), System.Drawing.Image)
        Me.Label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(0, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(776, 32)
        Me.Label15.TabIndex = 104
        Me.Label15.Text = "Ajuste de Inventario"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.Color.White
        Me.txtNumero.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjusteInv2, "AjusteInventario.Consecutivo", True))
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(40, 16)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(80, 13)
        Me.txtNumero.TabIndex = 105
        '
        'DsAjusteInv2
        '
        Me.DsAjusteInv2.DataSetName = "DsAjusteInv"
        Me.DsAjusteInv2.Locale = New System.Globalization.CultureInfo("es-MX")
        Me.DsAjusteInv2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grpBox_Inventario
        '
        Me.grpBox_Inventario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpBox_Inventario.Controls.Add(Me.btnKardex)
        Me.grpBox_Inventario.Controls.Add(Me.ckProductoActualizado)
        Me.grpBox_Inventario.Controls.Add(Me.Label13)
        Me.grpBox_Inventario.Controls.Add(Me.cbo_gasto)
        Me.grpBox_Inventario.Controls.Add(Me.Label12)
        Me.grpBox_Inventario.Controls.Add(Me.ExistenciaLote)
        Me.grpBox_Inventario.Controls.Add(Me.TXtExistenciaLote)
        Me.grpBox_Inventario.Controls.Add(Me.txtCodArticulo)
        Me.grpBox_Inventario.Controls.Add(Me.DTPVencimiento)
        Me.grpBox_Inventario.Controls.Add(Me.LVencimiento)
        Me.grpBox_Inventario.Controls.Add(Me.txtNuevoLote)
        Me.grpBox_Inventario.Controls.Add(Me.LNuevoLote)
        Me.grpBox_Inventario.Controls.Add(Me.CBNuevo)
        Me.grpBox_Inventario.Controls.Add(Me.CbNumero)
        Me.grpBox_Inventario.Controls.Add(Me.LNumero)
        Me.grpBox_Inventario.Controls.Add(Me.Label11)
        Me.grpBox_Inventario.Controls.Add(Me.lbCuenta)
        Me.grpBox_Inventario.Controls.Add(Me.txtCuenta)
        Me.grpBox_Inventario.Controls.Add(Me.Label10)
        Me.grpBox_Inventario.Controls.Add(Me.txtCostoUnit)
        Me.grpBox_Inventario.Controls.Add(Me.Label7)
        Me.grpBox_Inventario.Controls.Add(Me.txtObservacion)
        Me.grpBox_Inventario.Controls.Add(Me.txtCantidad)
        Me.grpBox_Inventario.Controls.Add(Me.txtDescripcion)
        Me.grpBox_Inventario.Controls.Add(Me.txtExistencia)
        Me.grpBox_Inventario.Controls.Add(Me.txtCodigo)
        Me.grpBox_Inventario.Controls.Add(Me.Label6)
        Me.grpBox_Inventario.Controls.Add(Me.Label5)
        Me.grpBox_Inventario.Controls.Add(Me.GroupBox3)
        Me.grpBox_Inventario.Controls.Add(Me.Label4)
        Me.grpBox_Inventario.Controls.Add(Me.Label3)
        Me.grpBox_Inventario.Controls.Add(Me.Label1)
        Me.grpBox_Inventario.Enabled = False
        Me.grpBox_Inventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBox_Inventario.ForeColor = System.Drawing.SystemColors.Highlight
        Me.grpBox_Inventario.Location = New System.Drawing.Point(5, 32)
        Me.grpBox_Inventario.Name = "grpBox_Inventario"
        Me.grpBox_Inventario.Size = New System.Drawing.Size(763, 192)
        Me.grpBox_Inventario.TabIndex = 1
        Me.grpBox_Inventario.TabStop = False
        Me.grpBox_Inventario.Text = "Datos de Inventario"
        '
        'ckProductoActualizado
        '
        Me.ckProductoActualizado.AutoSize = True
        Me.ckProductoActualizado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle.Actualizado", True))
        Me.ckProductoActualizado.Location = New System.Drawing.Point(555, 136)
        Me.ckProductoActualizado.Name = "ckProductoActualizado"
        Me.ckProductoActualizado.Size = New System.Drawing.Size(147, 17)
        Me.ckProductoActualizado.TabIndex = 181
        Me.ckProductoActualizado.Text = "Producto Actualizado"
        Me.ckProductoActualizado.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(264, 160)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 23)
        Me.Label13.TabIndex = 180
        Me.Label13.Text = "Gasto:"
        '
        'cbo_gasto
        '
        Me.cbo_gasto.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DsAjusteInv2, "AjusteInventario_Detalle.gasto", True))
        Me.cbo_gasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_gasto.Enabled = False
        Me.cbo_gasto.Location = New System.Drawing.Point(328, 160)
        Me.cbo_gasto.Name = "cbo_gasto"
        Me.cbo_gasto.Size = New System.Drawing.Size(128, 21)
        Me.cbo_gasto.TabIndex = 179
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(472, 160)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(144, 16)
        Me.Label12.TabIndex = 178
        Me.Label12.Text = "v. 2"
        '
        'ExistenciaLote
        '
        Me.ExistenciaLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExistenciaLote.BackColor = System.Drawing.Color.Gainsboro
        Me.ExistenciaLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExistenciaLote.ForeColor = System.Drawing.SystemColors.Highlight
        Me.ExistenciaLote.Location = New System.Drawing.Point(512, 56)
        Me.ExistenciaLote.Name = "ExistenciaLote"
        Me.ExistenciaLote.Size = New System.Drawing.Size(96, 16)
        Me.ExistenciaLote.TabIndex = 177
        Me.ExistenciaLote.Text = "Existencia Lote"
        Me.ExistenciaLote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ExistenciaLote.Visible = False
        '
        'TXtExistenciaLote
        '
        Me.TXtExistenciaLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXtExistenciaLote.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle.Existencia", True))
        Me.TXtExistenciaLote.EditValue = ""
        Me.TXtExistenciaLote.Location = New System.Drawing.Point(512, 72)
        Me.TXtExistenciaLote.Name = "TXtExistenciaLote"
        '
        '
        '
        Me.TXtExistenciaLote.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TXtExistenciaLote.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TXtExistenciaLote.Properties.Enabled = False
        Me.TXtExistenciaLote.Properties.ReadOnly = True
        Me.TXtExistenciaLote.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.TXtExistenciaLote.Size = New System.Drawing.Size(64, 19)
        Me.TXtExistenciaLote.TabIndex = 176
        Me.TXtExistenciaLote.Visible = False
        '
        'txtCodArticulo
        '
        Me.txtCodArticulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle.CodArticulo", True))
        Me.txtCodArticulo.Enabled = False
        Me.txtCodArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodArticulo.Location = New System.Drawing.Point(8, 32)
        Me.txtCodArticulo.Name = "txtCodArticulo"
        Me.txtCodArticulo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodArticulo.TabIndex = 175
        '
        'DTPVencimiento
        '
        Me.DTPVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPVencimiento.Location = New System.Drawing.Point(648, 72)
        Me.DTPVencimiento.Name = "DTPVencimiento"
        Me.DTPVencimiento.Size = New System.Drawing.Size(104, 20)
        Me.DTPVencimiento.TabIndex = 174
        Me.DTPVencimiento.Visible = False
        '
        'LVencimiento
        '
        Me.LVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LVencimiento.Cursor = System.Windows.Forms.Cursors.Default
        Me.LVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVencimiento.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LVencimiento.Location = New System.Drawing.Point(648, 56)
        Me.LVencimiento.Name = "LVencimiento"
        Me.LVencimiento.Size = New System.Drawing.Size(104, 16)
        Me.LVencimiento.TabIndex = 173
        Me.LVencimiento.Text = "Vencimiento"
        Me.LVencimiento.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LVencimiento.Visible = False
        '
        'txtNuevoLote
        '
        Me.txtNuevoLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevoLote.Location = New System.Drawing.Point(488, 72)
        Me.txtNuevoLote.Name = "txtNuevoLote"
        Me.txtNuevoLote.Size = New System.Drawing.Size(144, 20)
        Me.txtNuevoLote.TabIndex = 172
        Me.txtNuevoLote.Visible = False
        '
        'LNuevoLote
        '
        Me.LNuevoLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LNuevoLote.Cursor = System.Windows.Forms.Cursors.Default
        Me.LNuevoLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNuevoLote.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LNuevoLote.Location = New System.Drawing.Point(488, 56)
        Me.LNuevoLote.Name = "LNuevoLote"
        Me.LNuevoLote.Size = New System.Drawing.Size(144, 16)
        Me.LNuevoLote.TabIndex = 171
        Me.LNuevoLote.Text = "Lote"
        Me.LNuevoLote.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LNuevoLote.Visible = False
        '
        'CBNuevo
        '
        Me.CBNuevo.Location = New System.Drawing.Point(416, 64)
        Me.CBNuevo.Name = "CBNuevo"
        Me.CBNuevo.Size = New System.Drawing.Size(64, 24)
        Me.CBNuevo.TabIndex = 170
        Me.CBNuevo.Text = "Nuevo"
        Me.CBNuevo.Visible = False
        '
        'CbNumero
        '
        Me.CbNumero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbNumero.Location = New System.Drawing.Point(208, 72)
        Me.CbNumero.Name = "CbNumero"
        Me.CbNumero.Size = New System.Drawing.Size(184, 21)
        Me.CbNumero.TabIndex = 169
        Me.CbNumero.Visible = False
        '
        'LNumero
        '
        Me.LNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LNumero.Cursor = System.Windows.Forms.Cursors.Default
        Me.LNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNumero.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LNumero.Location = New System.Drawing.Point(208, 56)
        Me.LNumero.Name = "LNumero"
        Me.LNumero.Size = New System.Drawing.Size(184, 16)
        Me.LNumero.TabIndex = 168
        Me.LNumero.Text = "Lote"
        Me.LNumero.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LNumero.Visible = False
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.BackColor = System.Drawing.Color.Gainsboro
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(472, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Descripción"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbCuenta
        '
        Me.lbCuenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbCuenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle.DESCRIPCIONCUENTACONTAB" & _
            "LE", True))
        Me.lbCuenta.Location = New System.Drawing.Point(552, 136)
        Me.lbCuenta.Name = "lbCuenta"
        Me.lbCuenta.Size = New System.Drawing.Size(200, 16)
        Me.lbCuenta.TabIndex = 15
        Me.lbCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCuenta
        '
        Me.txtCuenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCuenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle.CuentaContable", True))
        Me.txtCuenta.Enabled = False
        Me.txtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.Location = New System.Drawing.Point(328, 136)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(128, 20)
        Me.txtCuenta.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.Gainsboro
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(208, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 16)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Cuenta Contable"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCostoUnit
        '
        Me.txtCostoUnit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCostoUnit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle.CostoUnit", True))
        Me.txtCostoUnit.EditValue = ""
        Me.txtCostoUnit.Location = New System.Drawing.Point(688, 32)
        Me.txtCostoUnit.Name = "txtCostoUnit"
        '
        '
        '
        Me.txtCostoUnit.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtCostoUnit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCostoUnit.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtCostoUnit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCostoUnit.Properties.Enabled = False
        Me.txtCostoUnit.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.txtCostoUnit.Size = New System.Drawing.Size(67, 19)
        Me.txtCostoUnit.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.Gainsboro
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(688, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Costo Unit."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtObservacion
        '
        Me.txtObservacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle.observacion", True))
        Me.txtObservacion.Enabled = False
        Me.txtObservacion.Location = New System.Drawing.Point(208, 112)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(451, 20)
        Me.txtObservacion.TabIndex = 10
        '
        'txtCantidad
        '
        Me.txtCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCantidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle.Cantidad", True))
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(672, 112)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(82, 20)
        Me.txtCantidad.TabIndex = 12
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.BackColor = System.Drawing.Color.White
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle.Desc_Articulo", True))
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(120, 32)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(491, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'txtExistencia
        '
        Me.txtExistencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExistencia.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle.Existencia", True))
        Me.txtExistencia.EditValue = ""
        Me.txtExistencia.Location = New System.Drawing.Point(615, 32)
        Me.txtExistencia.Name = "txtExistencia"
        '
        '
        '
        Me.txtExistencia.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtExistencia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExistencia.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtExistencia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExistencia.Properties.Enabled = False
        Me.txtExistencia.Properties.ReadOnly = True
        Me.txtExistencia.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.txtExistencia.Size = New System.Drawing.Size(64, 19)
        Me.txtExistencia.TabIndex = 5
        '
        'txtCodigo
        '
        Me.txtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle.Cod_Articulo", True))
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(-120, 32)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(116, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.Gainsboro
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(208, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(451, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Observación"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Gainsboro
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(672, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Cantidad"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ck_muerte)
        Me.GroupBox3.Controls.Add(Me.txtTotalEntradaD)
        Me.GroupBox3.Controls.Add(Me.txtTotalSalidaD)
        Me.GroupBox3.Controls.Add(Me.op_Salida)
        Me.GroupBox3.Controls.Add(Me.op_Entrada)
        Me.GroupBox3.Location = New System.Drawing.Point(1, 56)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(192, 120)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Movimientos"
        '
        'ck_muerte
        '
        Me.ck_muerte.BackColor = System.Drawing.Color.Red
        Me.ck_muerte.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle.muerte", True))
        Me.ck_muerte.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_muerte.ForeColor = System.Drawing.Color.White
        Me.ErrorProvider1.SetIconAlignment(Me.ck_muerte, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.ck_muerte.Location = New System.Drawing.Point(8, 80)
        Me.ck_muerte.Name = "ck_muerte"
        Me.ck_muerte.Size = New System.Drawing.Size(176, 24)
        Me.ck_muerte.TabIndex = 15
        Me.ck_muerte.Text = "Muerte animales"
        Me.ck_muerte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ck_muerte.UseVisualStyleBackColor = False
        '
        'txtTotalEntradaD
        '
        Me.txtTotalEntradaD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle.TotalEntrada", True))
        Me.txtTotalEntradaD.Enabled = False
        Me.txtTotalEntradaD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalEntradaD.Location = New System.Drawing.Point(78, 16)
        Me.txtTotalEntradaD.Name = "txtTotalEntradaD"
        Me.txtTotalEntradaD.Size = New System.Drawing.Size(104, 16)
        Me.txtTotalEntradaD.TabIndex = 13
        Me.txtTotalEntradaD.Text = "0.00"
        Me.txtTotalEntradaD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalSalidaD
        '
        Me.txtTotalSalidaD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle.TotalSalida", True))
        Me.txtTotalSalidaD.Enabled = False
        Me.txtTotalSalidaD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalSalidaD.Location = New System.Drawing.Point(80, 48)
        Me.txtTotalSalidaD.Name = "txtTotalSalidaD"
        Me.txtTotalSalidaD.Size = New System.Drawing.Size(104, 16)
        Me.txtTotalSalidaD.TabIndex = 14
        Me.txtTotalSalidaD.Text = "0.00"
        Me.txtTotalSalidaD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'op_Salida
        '
        Me.op_Salida.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle.Salida", True))
        Me.op_Salida.Enabled = False
        Me.op_Salida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.op_Salida.ForeColor = System.Drawing.SystemColors.Highlight
        Me.op_Salida.Location = New System.Drawing.Point(8, 48)
        Me.op_Salida.Name = "op_Salida"
        Me.op_Salida.Size = New System.Drawing.Size(80, 16)
        Me.op_Salida.TabIndex = 1
        Me.op_Salida.Text = "&Salida"
        '
        'op_Entrada
        '
        Me.op_Entrada.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle.Entrada", True))
        Me.op_Entrada.Enabled = False
        Me.op_Entrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.op_Entrada.ForeColor = System.Drawing.SystemColors.Highlight
        Me.op_Entrada.Location = New System.Drawing.Point(8, 16)
        Me.op_Entrada.Name = "op_Entrada"
        Me.op_Entrada.Size = New System.Drawing.Size(80, 16)
        Me.op_Entrada.TabIndex = 0
        Me.op_Entrada.Text = "&Entrada"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Gainsboro
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(120, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(491, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Descripción"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(615, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Existencia"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Check_Anulado
        '
        Me.Check_Anulado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsAjusteInv2, "AjusteInventario.Anula", True))
        Me.Check_Anulado.Enabled = False
        Me.Check_Anulado.ForeColor = System.Drawing.Color.Red
        Me.Check_Anulado.Location = New System.Drawing.Point(32, 288)
        Me.Check_Anulado.Name = "Check_Anulado"
        Me.Check_Anulado.Size = New System.Drawing.Size(81, 16)
        Me.Check_Anulado.TabIndex = 15
        Me.Check_Anulado.Text = "Anulado"
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarRegistrar, Me.ToolBarEliminar, Me.ToolBarImprimir, Me.ToolBarExcel, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 445)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(776, 52)
        Me.ToolBar1.TabIndex = 2
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Name = "ToolBarNuevo"
        Me.ToolBarNuevo.Text = "Nuevo"
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Enabled = False
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
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Enabled = False
        Me.ToolBarEliminar.ImageIndex = 3
        Me.ToolBarEliminar.Name = "ToolBarEliminar"
        Me.ToolBarEliminar.Text = "Anular"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Enabled = False
        Me.ToolBarImprimir.ImageIndex = 7
        Me.ToolBarImprimir.Name = "ToolBarImprimir"
        Me.ToolBarImprimir.Text = "Imprimir"
        '
        'ToolBarExcel
        '
        Me.ToolBarExcel.Enabled = False
        Me.ToolBarExcel.ImageIndex = 5
        Me.ToolBarExcel.Name = "ToolBarExcel"
        Me.ToolBarExcel.Text = "Exportar"
        Me.ToolBarExcel.Visible = False
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Name = "ToolBarCerrar"
        Me.ToolBarCerrar.Text = "Cerrar"
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
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataMember = "AjusteInventario.AjusteInventarioAjusteInventario_Detalle"
        Me.GridControl1.DataSource = Me.DsAjusteInv2
        '
        '
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(8, 232)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(760, 168)
        Me.GridControl1.TabIndex = 109
        Me.GridControl1.Text = "GridControl1"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCod_Articulo, Me.colCantidad, Me.colDesc_Articulo, Me.colMuerte, Me.colLote, Me.colEntrada, Me.colSalida, Me.colobservacion, Me.colTotalEntrada, Me.colTotalSalida, Me.colCuenta})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colCod_Articulo
        '
        Me.colCod_Articulo.Caption = "Código"
        Me.colCod_Articulo.FieldName = "CodArticulo"
        Me.colCod_Articulo.FilterInfo = ColumnFilterInfo1
        Me.colCod_Articulo.Name = "colCod_Articulo"
        Me.colCod_Articulo.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCod_Articulo.VisibleIndex = 1
        Me.colCod_Articulo.Width = 55
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cantidad"
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.FilterInfo = ColumnFilterInfo2
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCantidad.VisibleIndex = 0
        Me.colCantidad.Width = 63
        '
        'colDesc_Articulo
        '
        Me.colDesc_Articulo.Caption = "Descripción"
        Me.colDesc_Articulo.FieldName = "Desc_Articulo"
        Me.colDesc_Articulo.FilterInfo = ColumnFilterInfo3
        Me.colDesc_Articulo.Name = "colDesc_Articulo"
        Me.colDesc_Articulo.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDesc_Articulo.VisibleIndex = 2
        Me.colDesc_Articulo.Width = 142
        '
        'colMuerte
        '
        Me.colMuerte.Caption = "Muerte"
        Me.colMuerte.FieldName = "muerte"
        Me.colMuerte.FilterInfo = ColumnFilterInfo4
        Me.colMuerte.Name = "colMuerte"
        Me.colMuerte.VisibleIndex = 3
        '
        'colLote
        '
        Me.colLote.Caption = "Lote"
        Me.colLote.FieldName = "Numero"
        Me.colLote.FilterInfo = ColumnFilterInfo5
        Me.colLote.Name = "colLote"
        Me.colLote.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colLote.VisibleIndex = 10
        '
        'colEntrada
        '
        Me.colEntrada.Caption = "Entrada"
        Me.colEntrada.FieldName = "Entrada"
        Me.colEntrada.FilterInfo = ColumnFilterInfo6
        Me.colEntrada.Name = "colEntrada"
        Me.colEntrada.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colEntrada.VisibleIndex = 4
        Me.colEntrada.Width = 71
        '
        'colSalida
        '
        Me.colSalida.Caption = "Salida"
        Me.colSalida.FieldName = "Salida"
        Me.colSalida.FilterInfo = ColumnFilterInfo7
        Me.colSalida.Name = "colSalida"
        Me.colSalida.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSalida.VisibleIndex = 5
        Me.colSalida.Width = 63
        '
        'colobservacion
        '
        Me.colobservacion.Caption = "Observaciones"
        Me.colobservacion.FieldName = "observacion"
        Me.colobservacion.FilterInfo = ColumnFilterInfo8
        Me.colobservacion.Name = "colobservacion"
        Me.colobservacion.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colobservacion.VisibleIndex = 6
        Me.colobservacion.Width = 71
        '
        'colTotalEntrada
        '
        Me.colTotalEntrada.Caption = "T. Entrada"
        Me.colTotalEntrada.DisplayFormat.FormatString = "#,#0.00"
        Me.colTotalEntrada.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalEntrada.FieldName = "TotalEntrada"
        Me.colTotalEntrada.FilterInfo = ColumnFilterInfo9
        Me.colTotalEntrada.Name = "colTotalEntrada"
        Me.colTotalEntrada.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colTotalEntrada.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colTotalEntrada.VisibleIndex = 7
        Me.colTotalEntrada.Width = 83
        '
        'colTotalSalida
        '
        Me.colTotalSalida.Caption = "T. Salida"
        Me.colTotalSalida.DisplayFormat.FormatString = "#,#0.00"
        Me.colTotalSalida.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalSalida.FieldName = "TotalSalida"
        Me.colTotalSalida.FilterInfo = ColumnFilterInfo10
        Me.colTotalSalida.Name = "colTotalSalida"
        Me.colTotalSalida.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colTotalSalida.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colTotalSalida.VisibleIndex = 8
        Me.colTotalSalida.Width = 67
        '
        'colCuenta
        '
        Me.colCuenta.Caption = "Cuenta"
        Me.colCuenta.FieldName = "CUENTACONTABLE"
        Me.colCuenta.FilterInfo = ColumnFilterInfo11
        Me.colCuenta.Name = "colCuenta"
        Me.colCuenta.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCuenta.VisibleIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label36)
        Me.Panel1.Controls.Add(Me.txtNombreUsuario)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Location = New System.Drawing.Point(488, 483)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(288, 16)
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
        Me.Label36.TabIndex = 0
        Me.Label36.Text = "Usuario->"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(120, 0)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(163, 13)
        Me.txtNombreUsuario.TabIndex = 2
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(64, 0)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(56, 13)
        Me.txtUsuario.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(392, 403)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Total Entrada"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.Gainsboro
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Location = New System.Drawing.Point(520, 403)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 16)
        Me.Label8.TabIndex = 114
        Me.Label8.Text = "Total Salida"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.Gainsboro
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Location = New System.Drawing.Point(648, 403)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 16)
        Me.Label9.TabIndex = 116
        Me.Label9.Text = "Saldo Ajuste"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalEntrada
        '
        Me.txtTotalEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalEntrada.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsAjusteInv2, "AjusteInventario.TotalEntrada", True))
        Me.txtTotalEntrada.EditValue = "0.00"
        Me.txtTotalEntrada.Location = New System.Drawing.Point(392, 419)
        Me.txtTotalEntrada.Name = "txtTotalEntrada"
        '
        '
        '
        Me.txtTotalEntrada.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtTotalEntrada.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalEntrada.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtTotalEntrada.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalEntrada.Properties.ReadOnly = True
        Me.txtTotalEntrada.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.txtTotalEntrada.Size = New System.Drawing.Size(120, 26)
        Me.txtTotalEntrada.TabIndex = 117
        '
        'txtTotalSalida
        '
        Me.txtTotalSalida.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalSalida.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsAjusteInv2, "AjusteInventario.TotalSalida", True))
        Me.txtTotalSalida.EditValue = "0.00"
        Me.txtTotalSalida.Location = New System.Drawing.Point(520, 419)
        Me.txtTotalSalida.Name = "txtTotalSalida"
        '
        '
        '
        Me.txtTotalSalida.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtTotalSalida.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalSalida.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtTotalSalida.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalSalida.Properties.ReadOnly = True
        Me.txtTotalSalida.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.txtTotalSalida.Size = New System.Drawing.Size(120, 26)
        Me.txtTotalSalida.TabIndex = 118
        '
        'txtSaldoAjuste
        '
        Me.txtSaldoAjuste.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSaldoAjuste.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsAjusteInv2, "AjusteInventario.SaldoAjuste", True))
        Me.txtSaldoAjuste.EditValue = "0.00"
        Me.txtSaldoAjuste.Location = New System.Drawing.Point(648, 419)
        Me.txtSaldoAjuste.Name = "txtSaldoAjuste"
        '
        '
        '
        Me.txtSaldoAjuste.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtSaldoAjuste.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoAjuste.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtSaldoAjuste.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSaldoAjuste.Properties.ReadOnly = True
        Me.txtSaldoAjuste.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.txtSaldoAjuste.Size = New System.Drawing.Size(120, 26)
        Me.txtSaldoAjuste.TabIndex = 119
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=192.168.0.2;Initial Catalog=Pruebas;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'adAjusteInv
        '
        Me.adAjusteInv.DeleteCommand = Me.SqlDeleteCommand1
        Me.adAjusteInv.InsertCommand = Me.SqlInsertCommand1
        Me.adAjusteInv.SelectCommand = Me.SqlSelectCommand1
        Me.adAjusteInv.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AjusteInventario", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Consecutivo", "Consecutivo"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Anula", "Anula"), New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("TotalEntrada", "TotalEntrada"), New System.Data.Common.DataColumnMapping("TotalSalida", "TotalSalida"), New System.Data.Common.DataColumnMapping("SaldoAjuste", "SaldoAjuste")})})
        Me.adAjusteInv.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.AjusteInventario WHERE (Consecutivo = @Original_Consecutivo)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Consecutivo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Consecutivo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 1, "Anula"), New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 150, "Cedula"), New System.Data.SqlClient.SqlParameter("@TotalEntrada", System.Data.SqlDbType.Float, 8, "TotalEntrada"), New System.Data.SqlClient.SqlParameter("@TotalSalida", System.Data.SqlDbType.Float, 8, "TotalSalida"), New System.Data.SqlClient.SqlParameter("@SaldoAjuste", System.Data.SqlDbType.Float, 8, "SaldoAjuste")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Consecutivo, Fecha, Anula, Cedula, TotalEntrada, TotalSalida, SaldoAjuste " & _
    "FROM dbo.AjusteInventario"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 1, "Anula"), New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 150, "Cedula"), New System.Data.SqlClient.SqlParameter("@TotalEntrada", System.Data.SqlDbType.Float, 8, "TotalEntrada"), New System.Data.SqlClient.SqlParameter("@TotalSalida", System.Data.SqlDbType.Float, 8, "TotalSalida"), New System.Data.SqlClient.SqlParameter("@SaldoAjuste", System.Data.SqlDbType.Float, 8, "SaldoAjuste"), New System.Data.SqlClient.SqlParameter("@Original_Consecutivo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Consecutivo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Consecutivo", System.Data.SqlDbType.BigInt, 8, "Consecutivo")})
        '
        'adAjusteInvDetalle
        '
        Me.adAjusteInvDetalle.DeleteCommand = Me.SqlDeleteCommand2
        Me.adAjusteInvDetalle.InsertCommand = Me.SqlInsertCommand2
        Me.adAjusteInvDetalle.SelectCommand = Me.SqlSelectCommand2
        Me.adAjusteInvDetalle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AjusteInventario_Detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Consecutivo", "Consecutivo"), New System.Data.Common.DataColumnMapping("Cons_Ajuste", "Cons_Ajuste"), New System.Data.Common.DataColumnMapping("Cod_Articulo", "Cod_Articulo"), New System.Data.Common.DataColumnMapping("Desc_Articulo", "Desc_Articulo"), New System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"), New System.Data.Common.DataColumnMapping("Entrada", "Entrada"), New System.Data.Common.DataColumnMapping("Salida", "Salida"), New System.Data.Common.DataColumnMapping("observacion", "observacion"), New System.Data.Common.DataColumnMapping("cuenta_contable", "cuenta_contable"), New System.Data.Common.DataColumnMapping("TotalEntrada", "TotalEntrada"), New System.Data.Common.DataColumnMapping("TotalSalida", "TotalSalida"), New System.Data.Common.DataColumnMapping("Existencia", "Existencia"), New System.Data.Common.DataColumnMapping("CostoUnit", "CostoUnit"), New System.Data.Common.DataColumnMapping("CUENTACONTABLE", "CUENTACONTABLE"), New System.Data.Common.DataColumnMapping("DESCRIPCIONCUENTACONTABLE", "DESCRIPCIONCUENTACONTABLE"), New System.Data.Common.DataColumnMapping("Numero", "Numero"), New System.Data.Common.DataColumnMapping("CodArticulo", "CodArticulo"), New System.Data.Common.DataColumnMapping("gasto", "gasto"), New System.Data.Common.DataColumnMapping("muerte", "muerte"), New System.Data.Common.DataColumnMapping("Actualizado", "Actualizado")})})
        Me.adAjusteInvDetalle.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM [AjusteInventario_Detalle] WHERE (([Consecutivo] = @Original_Consecut" & _
    "ivo))"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Consecutivo", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Consecutivo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cons_Ajuste", System.Data.SqlDbType.BigInt, 0, "Cons_Ajuste"), New System.Data.SqlClient.SqlParameter("@Cod_Articulo", System.Data.SqlDbType.BigInt, 0, "Cod_Articulo"), New System.Data.SqlClient.SqlParameter("@Desc_Articulo", System.Data.SqlDbType.VarChar, 0, "Desc_Articulo"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 0, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Entrada", System.Data.SqlDbType.Bit, 0, "Entrada"), New System.Data.SqlClient.SqlParameter("@Salida", System.Data.SqlDbType.Bit, 0, "Salida"), New System.Data.SqlClient.SqlParameter("@observacion", System.Data.SqlDbType.VarChar, 0, "observacion"), New System.Data.SqlClient.SqlParameter("@cuenta_contable", System.Data.SqlDbType.VarChar, 0, "cuenta_contable"), New System.Data.SqlClient.SqlParameter("@TotalEntrada", System.Data.SqlDbType.Float, 0, "TotalEntrada"), New System.Data.SqlClient.SqlParameter("@TotalSalida", System.Data.SqlDbType.Float, 0, "TotalSalida"), New System.Data.SqlClient.SqlParameter("@Existencia", System.Data.SqlDbType.Float, 0, "Existencia"), New System.Data.SqlClient.SqlParameter("@CostoUnit", System.Data.SqlDbType.Float, 0, "CostoUnit"), New System.Data.SqlClient.SqlParameter("@CUENTACONTABLE", System.Data.SqlDbType.VarChar, 0, "CUENTACONTABLE"), New System.Data.SqlClient.SqlParameter("@DESCRIPCIONCUENTACONTABLE", System.Data.SqlDbType.VarChar, 0, "DESCRIPCIONCUENTACONTABLE"), New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.VarChar, 0, "Numero"), New System.Data.SqlClient.SqlParameter("@CodArticulo", System.Data.SqlDbType.VarChar, 0, "CodArticulo"), New System.Data.SqlClient.SqlParameter("@gasto", System.Data.SqlDbType.BigInt, 0, "gasto"), New System.Data.SqlClient.SqlParameter("@muerte", System.Data.SqlDbType.Bit, 0, "muerte"), New System.Data.SqlClient.SqlParameter("@Actualizado", System.Data.SqlDbType.Bit, 0, "Actualizado")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cons_Ajuste", System.Data.SqlDbType.BigInt, 0, "Cons_Ajuste"), New System.Data.SqlClient.SqlParameter("@Cod_Articulo", System.Data.SqlDbType.BigInt, 0, "Cod_Articulo"), New System.Data.SqlClient.SqlParameter("@Desc_Articulo", System.Data.SqlDbType.VarChar, 0, "Desc_Articulo"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 0, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Entrada", System.Data.SqlDbType.Bit, 0, "Entrada"), New System.Data.SqlClient.SqlParameter("@Salida", System.Data.SqlDbType.Bit, 0, "Salida"), New System.Data.SqlClient.SqlParameter("@observacion", System.Data.SqlDbType.VarChar, 0, "observacion"), New System.Data.SqlClient.SqlParameter("@cuenta_contable", System.Data.SqlDbType.VarChar, 0, "cuenta_contable"), New System.Data.SqlClient.SqlParameter("@TotalEntrada", System.Data.SqlDbType.Float, 0, "TotalEntrada"), New System.Data.SqlClient.SqlParameter("@TotalSalida", System.Data.SqlDbType.Float, 0, "TotalSalida"), New System.Data.SqlClient.SqlParameter("@Existencia", System.Data.SqlDbType.Float, 0, "Existencia"), New System.Data.SqlClient.SqlParameter("@CostoUnit", System.Data.SqlDbType.Float, 0, "CostoUnit"), New System.Data.SqlClient.SqlParameter("@CUENTACONTABLE", System.Data.SqlDbType.VarChar, 0, "CUENTACONTABLE"), New System.Data.SqlClient.SqlParameter("@DESCRIPCIONCUENTACONTABLE", System.Data.SqlDbType.VarChar, 0, "DESCRIPCIONCUENTACONTABLE"), New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.VarChar, 0, "Numero"), New System.Data.SqlClient.SqlParameter("@CodArticulo", System.Data.SqlDbType.VarChar, 0, "CodArticulo"), New System.Data.SqlClient.SqlParameter("@gasto", System.Data.SqlDbType.BigInt, 0, "gasto"), New System.Data.SqlClient.SqlParameter("@muerte", System.Data.SqlDbType.Bit, 0, "muerte"), New System.Data.SqlClient.SqlParameter("@Actualizado", System.Data.SqlDbType.Bit, 0, "Actualizado"), New System.Data.SqlClient.SqlParameter("@Original_Consecutivo", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Consecutivo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Consecutivo", System.Data.SqlDbType.BigInt, 8, "Consecutivo")})
        '
        'txtCedulaUsuario
        '
        Me.txtCedulaUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCedulaUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjusteInv2, "AjusteInventario.Cedula", True))
        Me.txtCedulaUsuario.Location = New System.Drawing.Point(24, 467)
        Me.txtCedulaUsuario.Name = "txtCedulaUsuario"
        Me.txtCedulaUsuario.Size = New System.Drawing.Size(104, 20)
        Me.txtCedulaUsuario.TabIndex = 120
        '
        'AdapterLotes
        '
        Me.AdapterLotes.DeleteCommand = Me.SqlDeleteCommand3
        Me.AdapterLotes.InsertCommand = Me.SqlInsertCommand3
        Me.AdapterLotes.SelectCommand = Me.SqlSelectCommand3
        Me.AdapterLotes.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Lotes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Numero", "Numero"), New System.Data.Common.DataColumnMapping("Vencimiento", "Vencimiento"), New System.Data.Common.DataColumnMapping("Cant_Inicial", "Cant_Inicial"), New System.Data.Common.DataColumnMapping("Cant_Actual", "Cant_Actual"), New System.Data.Common.DataColumnMapping("Fecha_Entrada", "Fecha_Entrada"), New System.Data.Common.DataColumnMapping("Cod_Articulo", "Cod_Articulo"), New System.Data.Common.DataColumnMapping("Documento", "Documento"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo")})})
        Me.AdapterLotes.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.SqlConnectionLote
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cant_Actual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cant_Actual", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cant_Inicial", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cant_Inicial", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Articulo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Articulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha_Entrada", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Entrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Vencimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vencimiento", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlConnectionLote
        '
        Me.SqlConnectionLote.ConnectionString = "Data Source=192.168.0.2;Initial Catalog=Pruebas;Integrated Security=True"
        Me.SqlConnectionLote.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnectionLote
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.VarChar, 250, "Numero"), New System.Data.SqlClient.SqlParameter("@Vencimiento", System.Data.SqlDbType.DateTime, 8, "Vencimiento"), New System.Data.SqlClient.SqlParameter("@Cant_Inicial", System.Data.SqlDbType.Float, 8, "Cant_Inicial"), New System.Data.SqlClient.SqlParameter("@Cant_Actual", System.Data.SqlDbType.Float, 8, "Cant_Actual"), New System.Data.SqlClient.SqlParameter("@Fecha_Entrada", System.Data.SqlDbType.DateTime, 8, "Fecha_Entrada"), New System.Data.SqlClient.SqlParameter("@Cod_Articulo", System.Data.SqlDbType.BigInt, 8, "Cod_Articulo"), New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.BigInt, 8, "Documento"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Id, Numero, Vencimiento, Cant_Inicial, Cant_Actual, Fecha_Entrada, Cod_Art" & _
    "iculo, Documento, Tipo FROM Lotes"
        Me.SqlSelectCommand3.Connection = Me.SqlConnectionLote
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnectionLote
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.VarChar, 250, "Numero"), New System.Data.SqlClient.SqlParameter("@Vencimiento", System.Data.SqlDbType.DateTime, 8, "Vencimiento"), New System.Data.SqlClient.SqlParameter("@Cant_Inicial", System.Data.SqlDbType.Float, 8, "Cant_Inicial"), New System.Data.SqlClient.SqlParameter("@Cant_Actual", System.Data.SqlDbType.Float, 8, "Cant_Actual"), New System.Data.SqlClient.SqlParameter("@Fecha_Entrada", System.Data.SqlDbType.DateTime, 8, "Fecha_Entrada"), New System.Data.SqlClient.SqlParameter("@Cod_Articulo", System.Data.SqlDbType.BigInt, 8, "Cod_Articulo"), New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.BigInt, 8, "Documento"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cant_Actual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cant_Actual", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cant_Inicial", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cant_Inicial", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Articulo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Articulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha_Entrada", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Entrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Vencimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vencimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "Data Source=192.168.0.2;Initial Catalog=Pruebas;Integrated Security=True"
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'SqlConnection3
        '
        Me.SqlConnection3.ConnectionString = "Data Source=192.168.0.2;Initial Catalog=Pruebas;Integrated Security=True"
        Me.SqlConnection3.FireInfoMessageEventOnUserErrors = False
        '
        'btnKardex
        '
        Me.btnKardex.FlatAppearance.BorderSize = 0
        Me.btnKardex.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKardex.Location = New System.Drawing.Point(716, 160)
        Me.btnKardex.Name = "btnKardex"
        Me.btnKardex.Size = New System.Drawing.Size(38, 23)
        Me.btnKardex.TabIndex = 182
        Me.btnKardex.UseVisualStyleBackColor = True
        '
        'AjusteInventario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(776, 497)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.txtSaldoAjuste)
        Me.Controls.Add(Me.txtTotalSalida)
        Me.Controls.Add(Me.txtTotalEntrada)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.grpBox_Inventario)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Check_Anulado)
        Me.Controls.Add(Me.txtCedulaUsuario)
        Me.Name = "AjusteInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajuste de Inventario"
        CType(Me.DsAjusteInv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBox_Inventario.ResumeLayout(False)
        Me.grpBox_Inventario.PerformLayout()
        CType(Me.TXtExistenciaLote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCostoUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExistencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtTotalEntrada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalSalida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoAjuste.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Load"
    Private Sub AjusteInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = CadenaConexionSeePOS()
        SqlConnectionLote.ConnectionString = CadenaConexionSeePOS()
        AdapterLotes.Fill(Lote, "Lotes")

        If GetSetting("seesoft", "seepos", "EsVeterinaria") = 0 Then
            Dim dts As New DataTable
            cFunciones.Llenar_Tabla_Generico("select * from gasto", dts, CadenaConexionSeePOS)
            Me.cbo_gasto.DataSource = dts
            Me.cbo_gasto.DisplayMember = "descripcion"
            Me.cbo_gasto.ValueMember = "id"
            Me.cbo_gasto.Enabled = True
        End If

        ValoresDefecto()
        txtUsuario.Focus()
    End Sub

    Private Sub ValoresDefecto()
        'Establecer Valores por Defecto
        Me.DsAjusteInv2.AjusteInventario.FechaColumn.DefaultValue = Now
        Me.DsAjusteInv2.AjusteInventario.AnulaColumn.DefaultValue = False
        Me.DsAjusteInv2.AjusteInventario.TotalEntradaColumn.DefaultValue = 0
        Me.DsAjusteInv2.AjusteInventario.TotalSalidaColumn.DefaultValue = 0
        Me.DsAjusteInv2.AjusteInventario.SaldoAjusteColumn.DefaultValue = 0
        Me.DsAjusteInv2.AjusteInventario.ConsecutivoColumn.AutoIncrement = True
        Me.DsAjusteInv2.AjusteInventario.ConsecutivoColumn.AutoIncrementSeed = -1
        Me.DsAjusteInv2.AjusteInventario.ConsecutivoColumn.AutoIncrementStep = -1

        Me.DsAjusteInv2.AjusteInventario_Detalle.Cons_AjusteColumn.DefaultValue = 0
        Me.DsAjusteInv2.AjusteInventario_Detalle.Cod_ArticuloColumn.DefaultValue = 0
        Me.DsAjusteInv2.AjusteInventario_Detalle.CodArticuloColumn.DefaultValue = ""
        Me.DsAjusteInv2.AjusteInventario_Detalle.CantidadColumn.DefaultValue = 0
        Me.DsAjusteInv2.AjusteInventario_Detalle.EntradaColumn.DefaultValue = 1
        Me.DsAjusteInv2.AjusteInventario_Detalle.SalidaColumn.DefaultValue = 0
        Me.DsAjusteInv2.AjusteInventario_Detalle.muerteColumn.DefaultValue = 0
        Me.DsAjusteInv2.AjusteInventario_Detalle.observacionColumn.DefaultValue = ""
        Me.DsAjusteInv2.AjusteInventario_Detalle.cuenta_contableColumn.DefaultValue = ""
        Me.DsAjusteInv2.AjusteInventario_Detalle.cuenta_contableColumn.DefaultValue = ""
        Me.DsAjusteInv2.AjusteInventario_Detalle.DESCRIPCIONCUENTACONTABLEColumn.DefaultValue = ""
        Me.DsAjusteInv2.AjusteInventario_Detalle.TotalEntradaColumn.DefaultValue = 0
        Me.DsAjusteInv2.AjusteInventario_Detalle.TotalSalidaColumn.DefaultValue = 0
        Me.DsAjusteInv2.AjusteInventario_Detalle.Desc_ArticuloColumn.DefaultValue = ""
        Me.DsAjusteInv2.AjusteInventario_Detalle.NumeroColumn.DefaultValue = 0

        Me.DsAjusteInv2.AjusteInventario_Detalle.gastoColumn.DefaultValue = 0

        Me.DsAjusteInv2.AjusteInventario_Detalle.ConsecutivoColumn.AutoIncrement = True
        Me.DsAjusteInv2.AjusteInventario_Detalle.ConsecutivoColumn.AutoIncrementSeed = -1
        Me.DsAjusteInv2.AjusteInventario_Detalle.ConsecutivoColumn.AutoIncrementStep = -1
        Me.DsAjusteInv2.AjusteInventario_Detalle.ActualizadoColumn.DefaultValue = False

        'VALORES POR DEFECTO PARA LA TABLA ARTICULOS LOTES
        Me.Lote.Lotes.IdColumn.AutoIncrement = True
        Me.Lote.Lotes.IdColumn.AutoIncrementStep = 1
        Me.Lote.Lotes.NumeroColumn.DefaultValue = 0
        Me.Lote.Lotes.VencimientoColumn.DefaultValue = Now.Date
        Me.Lote.Lotes.Fecha_EntradaColumn.DefaultValue = Date.Now
        Me.Lote.Lotes.Cant_InicialColumn.DefaultValue = 0
        Me.Lote.Lotes.Cant_ActualColumn.DefaultValue = 0
        Me.Lote.Lotes.Cod_ArticuloColumn.DefaultValue = 0
        Me.Lote.Lotes.DocumentoColumn.DefaultValue = 0
        Me.Lote.Lotes.TipoColumn.DefaultValue = "AIN"
    End Sub

    Private Sub AjusteInventario_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Tiempo As Integer
        For Tiempo = 100 To 0 Step -1
            Me.Opacity = Tiempo
            Application.DoEvents()
        Next
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

#Region "Validacion Usuario"
    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown

        If e.KeyCode = Keys.Enter Then
            Dim cConexion As New Conexion
            Dim rs As SqlDataReader
            If e.KeyCode = Keys.Enter Then
                If txtUsuario.Text <> "" Then
                    rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT Cedula, Nombre from Usuarios where Clave_Interna ='" & txtUsuario.Text & "'")
                    If rs.HasRows = False Then
                        MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
                        txtUsuario.Focus()
                    End If
                    While rs.Read
                        Try
                            PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo
                            If PMU.Execute Then  Else MsgBox("No tiene permiso ejecutar el módulo " & Me.Text, MsgBoxStyle.Information, "Atención...") : Exit Sub

                            txtNombreUsuario.Text = rs("Nombre")
                            txtCedulaUsuario.Text = rs("Cedula")
                            Me.DsAjusteInv2.AjusteInventario.CedulaColumn.DefaultValue = rs("Cedula")
                            Me.ToolBar1.Buttons(0).Enabled = True
                            Me.ToolBar1.Buttons(1).Enabled = True
                            Me.ToolBar1.Buttons(2).Enabled = True
                            Me.NuevoAjuste()
                            txtCodArticulo.Focus()

                        Catch ex As SystemException
                            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
                        End Try
                    End While
                    rs.Close()
                    cConexion.DesConectar(cConexion.sQlconexion)
                Else
                    MsgBox("Debe de digitar la clave de usuario", MsgBoxStyle.Exclamation)
                    txtUsuario.Focus()
                End If
            End If
        End If
    End Sub
#End Region

#Region "Toolbar"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        ' EL PMU se carga al momento de indicarse que usuario esta en el sistema
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1
                If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then
                    NuevoAjuste()
                Else
                    If MessageBox.Show("Desea Guardar este Ajuste de Inventario", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                        If PMU.Update Then Me.Registrar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub ' se guarda en la base de datos
                    Else
                        Me.DsAjusteInv2.AjusteInventario_Detalle.Clear()
                        Me.DsAjusteInv2.AjusteInventario.Clear()
                        Me.ToolBar1.Buttons(0).Text = "Nuevo"
                        Me.ToolBar1.Buttons(0).ImageIndex = 0
                        Me.ToolBar1.Buttons(0).Enabled = True
                        Me.ToolBar1.Buttons(1).Enabled = False
                        Me.ToolBar1.Buttons(2).Enabled = False
                        Me.ToolBar1.Buttons(3).Enabled = False
                        Me.ToolBar1.Buttons(4).Enabled = False
                        grpBox_Inventario.Enabled = False
                        txtUsuario.Enabled = True
                        txtUsuario.Text = ""
                        txtNombreUsuario.Text = ""
                        txtCedulaUsuario.Text = ""
                        txtUsuario.Focus()
                    End If

                End If

            Case 2 : If PMU.Find Then Me.BuscarAjuste() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 3 : If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 4 : If PMU.Delete Then Anular() Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 5 : If PMU.Print Then Me.imprimir() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 7 : Me.Close()
        End Select
    End Sub
#End Region

#Region "Nuevo"
    Private Sub NuevoAjuste()
        Dim Fx As New cFunciones
        Dim Valor As Boolean

        If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then 'no hay un registro pendiente
            Me.ToolBar1.Buttons(0).Text = "Cancelar"
            Me.ToolBar1.Buttons(0).ImageIndex = 8
            Me.ToolBar1.Buttons(3).Enabled = False

            Valor = Fx.VerificarBaseDatos("Contabilidad")
            If Valor Then
                Me.Label10.Visible = True
                Me.Label11.Visible = True
                Me.txtCuenta.Visible = True
                Me.lbCuenta.Visible = True
            Else
                Me.colCuenta.VisibleIndex = -1
                Me.Label10.Visible = False
                Me.Label11.Visible = False
                Me.txtCuenta.Visible = False
                Me.lbCuenta.Visible = False
            End If

            If txtNombreUsuario.Text = "" Then
                grpBox_Inventario.Enabled = False
                txtUsuario.Enabled = True
                txtUsuario.Text = ""
                txtNombreUsuario.Text = ""
                txtCedulaUsuario.Text = ""
                txtUsuario.Focus()
            Else
                Me.BindingContext(Me.DsAjusteInv2, "AjusteInventario").EndCurrentEdit()
                Me.BindingContext(Me.DsAjusteInv2, "AjusteInventario").AddNew()
                Me.BindingContext(Me.DsAjusteInv2, "AjusteInventario").EndCurrentEdit()
                txtUsuario.Enabled = False ' se inabilita el campo de la contraseña
                Me.grpBox_Inventario.Enabled = True
                Me.txtCodigo.Enabled = True
                txtCodArticulo.Enabled = True
                Me.op_Entrada.Enabled = True
                Me.op_Salida.Enabled = True
                Me.txtObservacion.Enabled = True
                Me.txtCantidad.Enabled = True
                Me.txtCuenta.Enabled = True

            End If
            txtCodigo.Text = "" : txtCodArticulo.Text = "" : txtDescripcion.Text = ""
            txtCodArticulo.Focus()
        Else
            Try
                If MessageBox.Show("Desea Guardar los Cambios del Ajuste de Inventario", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Me.Registrar()
                Else
                    Me.BindingContext(Me.DsAjusteInv2, "AjusteInventario").CancelCurrentEdit()
                    Me.ToolBar1.Buttons(0).Text = "Nuevo"
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    Me.ToolBar1.Buttons(3).Enabled = True
                    Me.txtCodigo.Enabled = False
                    txtCodArticulo.Enabled = False
                    Me.txtDescripcion.Enabled = False
                    Me.txtExistencia.Enabled = False
                    Me.txtCostoUnit.Enabled = False
                    Me.op_Entrada.Enabled = False
                    Me.op_Salida.Enabled = False
                    Me.txtObservacion.Enabled = False
                    Me.txtCantidad.Enabled = False
                    Me.txtCuenta.Enabled = False
                    Me.txtUsuario.Text = ""
                    Me.txtNombreUsuario.Text = ""
                    Me.txtCedulaUsuario.Text = ""
                End If
            Catch ex As SystemException
                MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            End Try
        End If
    End Sub
#End Region

#Region "Anular"
    Function Anular()
        Try
            Dim resp As Integer
            If Me.BindingContext(Me.DsAjusteInv2, "AjusteInventario").Count > 0 Then

                resp = MessageBox.Show("¿Desea Anular este Ajuste?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If resp = 6 Then
                    Check_Anulado.Checked = True
                    Me.BindingContext(Me.DsAjusteInv2, "AjusteInventario").EndCurrentEdit()

                    If Me.insertar_bitacora() And Registrar_Anulacion_Ajuste() Then
                        Me.DsAjusteInv2.AcceptChanges()
                        MsgBox("El ajuste ha sido anulado correctamente", MsgBoxStyle.Information)
                        Me.DsAjusteInv2.AjusteInventario_Detalle.Clear()
                        Me.DsAjusteInv2.AjusteInventario.Clear()
                        Me.ToolBar1.Buttons(4).Enabled = True
                        Me.ToolBar1.Buttons(1).Enabled = True
                        Me.ToolBar1.Buttons(0).Text = "Nuevo"
                        Me.ToolBar1.Buttons(0).ImageIndex = 0

                        Me.ToolBar1.Buttons(0).Enabled = True
                        Me.ToolBar1.Buttons(1).Enabled = False
                        Me.ToolBar1.Buttons(2).Enabled = False
                        Me.ToolBar1.Buttons(3).Enabled = False
                        Me.ToolBar1.Buttons(4).Enabled = False
                        grpBox_Inventario.Enabled = False
                        txtUsuario.Enabled = True
                        txtUsuario.Text = ""
                        txtNombreUsuario.Text = ""
                        txtCedulaUsuario.Text = ""
                        txtUsuario.Focus()
                        Me.ToolBar1.Buttons(3).Enabled = False
                        Me.ToolBar1.Buttons(4).Enabled = False
                    End If
                Else : Exit Function
                End If
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Function

    Function insertar_bitacora() As Boolean
        Dim funciones As New Conexion
        Dim datos As String
        datos = "'AJUSTE INVENTARIO','" & Me.txtNumero.Text & "','AJUSTE INVENTARIO','AJUSTE INVENATARIO ANULADO','" & usua.Nombre & "'," & 0 & "," & 0 & "," & 0 & "," & 0 & "," & 0
        If funciones.AddNewRecord("Bitacora", "Tabla,Campo_Clave,DescripcionCampo,Accion,Usuario,Costo,VentaA,VentaB,VentaC,VentaD", datos) <> "" Then
            MsgBox("Problemas al Anular el ajuste", MsgBoxStyle.Critical)
            Return False
        Else
            Return True
        End If
    End Function

    Function Registrar_Anulacion_Ajuste() As Boolean

        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try

            Me.adAjusteInv.UpdateCommand.Transaction = Trans


            Me.adAjusteInv.Update(Me.DsAjusteInv2, "AjusteInventario")

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

    Function imprimir()
        Try
            Me.ToolBar1.Buttons(4).Enabled = False
            Dim Ajuste_Reporte As New Reporte_Ajuste_Inventario
            Dim Ajuste_ReportePVE As New rpAjustesPVE

            If MessageBox.Show("¿Desea Imprimir en Grande?", "Impresión", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                Ajuste_Reporte.SetParameterValue("ajuste", CDbl(txtNumero.Text))
                CrystalReportsConexion.LoadShow(Ajuste_Reporte, MdiParent)
            Else
                Ajuste_ReportePVE.PrintOptions.PrinterName = Automatic_Printer_Dialog(3)
                Ajuste_ReportePVE.SetParameterValue("ajuste", CDbl(txtNumero.Text))
                CrystalReportsConexion.LoadReportViewer(Nothing, Ajuste_ReportePVE, True, CadenaConexionSeePOS)
                Ajuste_ReportePVE.PrintToPrinter(1, True, 0, 0)
            End If
            Me.ToolBar1.Buttons(4).Enabled = True
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Function

    Private Function Automatic_Printer_Dialog(ByVal PrinterToSelect As Byte) As String 'SAJ 01092006 
        Dim PrintDocument1 As New PrintDocument
        Dim DefaultPrinter As String = PrintDocument1.PrinterSettings.PrinterName
        Dim PrinterInstalled As String
        'BUSCA LA IMPRESORA PREDETERMINADA PARA EL SISTEMA
        For Each PrinterInstalled In PrinterSettings.InstalledPrinters
            Select Case Split(PrinterInstalled.ToUpper, "\").GetValue(Split(PrinterInstalled.ToUpper, "\").GetLength(0) - 1)
                Case "FACTURACION" 'FACTURACION
                    If PrinterToSelect = 0 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "CONTADO"
                    If PrinterToSelect = 1 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "CREDITO"
                    If PrinterToSelect = 2 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "PUNTOVENTA"
                    If PrinterToSelect = 3 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "FAX"
                    If PrinterToSelect = 4 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "PUNTOVENTA02"
                    If PrinterToSelect = 5 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "FACTURACION02" 'FACTURACION
                    If PrinterToSelect = 6 Then
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
        Else
            Return ""
        End If
    End Function
#End Region


#Region "Cargar Articulo"
    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodArticulo.KeyDown
        Try
            Dim Cuenta As String = Me.txtCuenta.Text
            Select Case e.KeyCode
                Case Keys.F1
                    Dim BuscarArt As New FrmBuscarArticulo2
                    Me.BindingContext(Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").CancelCurrentEdit()
                    Me.BindingContext(Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").EndCurrentEdit()
                    Me.BindingContext(Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").AddNew()
                    BuscarArt.StartPosition = FormStartPosition.CenterParent
                    BuscarArt.Cod_Articulo = True
                    BuscarArt.ShowDialog()

                    If BuscarArt.Cancelado Then
                        Me.BindingContext(Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").CancelCurrentEdit()
                        Me.BindingContext(Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").AddNew()
                        Exit Sub
                    End If
                    txtCodArticulo.Text = BuscarArt.Codigo
                    BuscarArt.Dispose()
                    CargarInformacionArticulo(txtCodArticulo.Text)

                Case Keys.Enter
                    Dim cod_art As String
                    cod_art = Me.txtCodArticulo.Text
                    If cod_art.Contains("%") = True Then
                        'es codigo de barras + lote
                        Dim barras() As String = cod_art.Split("%")
                        cod_art = barras(0)
                    End If
                    Me.BindingContext(Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").CancelCurrentEdit()
                    Me.BindingContext(Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").EndCurrentEdit()
                    Me.BindingContext(Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").AddNew()
                    CargarInformacionArticulo(cod_art)
                    Me.txtCuenta.Text = Cuenta
                Case Keys.F2
                    Me.Registrar()
            End Select

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Function AjustesUltimoMes(_Cod As String) As Integer
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select dbo.fnObtenerNumeroAjustesRealizados(" & _Cod & ");", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function

    Private Sub CargarInformacionArticulo(ByVal codigo As String)
        Dim Conexion2 As New Conexion
        Dim Conexion3 As New Conexion
        Dim rs As SqlDataReader
        Dim tipocambio As Double
        Dim Encontrado As Boolean
        If codigo <> Nothing Then
            rs = Conexion2.GetRecorset(Conexion2.Conectar, "SELECT Codigo, Cod_Articulo, Descripcion, Existencia, Costo, MonedaCosto, Lote from Inventario where (Inhabilitado = 0) and  Cod_Articulo ='" & codigo & "' or Barras = '" & codigo & "'")
            Encontrado = False
            While rs.Read
                Try
                    Encontrado = True
                    txtCodigo.Text = rs("Codigo")
                    txtCodArticulo.Text = rs("Cod_Articulo")
                    txtDescripcion.Text = rs("Descripcion")
                    tipocambio = Conexion3.SlqExecuteScalar(Conexion3.Conectar, "Select ValorCompra from Moneda where CodMoneda =" & rs("MonedaCosto"))
                    Me.txtCostoUnit.Text = Format(rs("Costo") * tipocambio, "#,#0.00")
                    Conexion3.DesConectar(Conexion3.sQlconexion)
                    Me.txtExistencia.Text = rs("Existencia")

                    If rs("Lote") = True Then
                        ActivaLote()
                        CbNumero.Focus()
                    Else
                        ActivaNinguno()
                        txtObservacion.Focus()
                    End If
                    Dim Veces As Integer = Me.AjustesUltimoMes(rs("Codigo"))
                    If Veces > 1 Then
                        MsgBox("Este producto tiene " & Veces.ToString & " Ajustes los ultimos 30 dias.", vbExclamation, "Advertencia!!!")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Conexion2.DesConectar(Conexion2.sQlconexion)
                End Try
            End While
            rs.Close()
            If Not Encontrado Then
                MsgBox("No existe un artìculo con este código", MsgBoxStyle.Exclamation)
                BindingContext(Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").CancelCurrentEdit()
                Me.BindingContext(Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").AddNew()
                txtCodArticulo.Focus()
                Conexion2.DesConectar(Conexion2.sQlconexion)
                Exit Sub
            End If
        End If
    End Sub
#End Region

#Region "Buscar"
    Private Sub BuscarAjuste()
        Dim Fx As New cFunciones
        Dim identificador As Double
        Dim buscando As Boolean

        Try
            If Me.BindingContext(Me.DsAjusteInv2, "AjusteInventario").Count > 0 Then
                If (MsgBox("Actualmente se está realizando un Ajuste de Inventario, si continúa se perderan los datos del mismo, ¿desea continuar?", MsgBoxStyle.YesNo)) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

            CbNumero.Items.Clear()
            CbNumero.Visible = False
            LNumero.Visible = False
            Me.DsAjusteInv2.AjusteInventario_Detalle.Clear()
            Me.DsAjusteInv2.AjusteInventario.Clear()

            identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("SELECT AjusteInventario.Consecutivo, AjusteInventario_Detalle.Desc_Articulo AS Articulo, AjusteInventario.Fecha FROM AjusteInventario INNER JOIN AjusteInventario_Detalle ON AjusteInventario.Consecutivo = AjusteInventario_Detalle.Cons_Ajuste Order by AjusteInventario.Fecha DESC", "Articulo", "Fecha", "Buscar Ajuste de Inventario"))
            buscando = True
            If identificador = 0.0 Then ' si se dio en el boton de cancelar
                buscando = False
                Exit Sub
            End If

            Fx.Llenar_Tabla_Generico("SELECT * FROM AjusteInventario WHERE (Consecutivo =" & identificador & " )", Me.DsAjusteInv2.AjusteInventario)
            Fx.Llenar_Tabla_Generico("SELECT * FROM AjusteInventario_Detalle WHERE (Cons_Ajuste =" & identificador & " )", Me.DsAjusteInv2.AjusteInventario_Detalle)

            grpBox_Inventario.Enabled = False
            Me.ToolBar1.Buttons(2).Enabled = False
            Me.ToolBar1.Buttons(3).Enabled = True
            Me.ToolBar1.Buttons(4).Enabled = True
            Me.ToolBar1.Buttons(0).Enabled = True

            'si esta venta aun no ha sido anulada
            If Me.BindingContext(Me.DsAjusteInv2, "AjusteInventario").Current("Anula") = True Then Me.ToolBar1.Buttons(3).Enabled = False
            Calcular(True)

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
#End Region

#Region "Funciones"


    Private Function Consecutivo() As Integer

        Dim SQL As New GestioDatos
        Dim sentencia As String = ("SELECT isnull(MAX(Consecutivo),0) AS Consecutivo FROM  dbo.AjusteInventario")
        Dim Boleta As Integer = SQL.Ejecuta(sentencia).Rows(0).Item(0)
        Return Boleta

    End Function

    Public Sub insertar_PermisoAjuste(ByVal ced As String, ByVal fecha As Date, ByVal descrip As String, ByVal id_Mov As Integer, ByVal _CedAdmin As String)
        Dim sentencia = "INSERT INTO registro_Permisoajuste (cedula_usuario, fecha, descripcion,id_Movimiento,Administrador)VALUES('" & ced & "','" & fecha & "','" & descrip & "'," & id_Mov & ",'" & _CedAdmin & "')"
        Dim SQL As New GestioDatos
        SQL.Ejecuta(sentencia)
    End Sub

    Function Agregar()
        Try
            Dim resp As Integer
            If Me.txtCantidad.Text = "" Or Me.txtCantidad.Text = "0" Then
                MsgBox("La Cantidad de artículos no es válida", MsgBoxStyle.Exclamation)
                Me.txtCantidad.Text = "1"
                Exit Function
            End If
            resp = MessageBox.Show("¿Desea agregar este artículo al ajuste?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

            If resp <> 6 Then
                Me.BindingContext(Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").CancelCurrentEdit()
                Me.BindingContext(Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").AddNew()
                txtCodArticulo.Focus()
                Exit Function
            End If

            If op_Entrada.Checked = True Then
                txtTotalEntradaD.Text = Format(txtCostoUnit.Text * txtCantidad.Text, "#,#0.00")
                txtTotalSalidaD.Text = 0
            Else
                txtTotalSalidaD.Text = Format(txtCostoUnit.Text * txtCantidad.Text, "#,#0.00")
                txtTotalEntradaD.Text = 0
            End If

            Calcular()
            BindingContext(Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").EndCurrentEdit()
            BindingContext(Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").CancelCurrentEdit()
            BindingContext(Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").AddNew()
            txtCodArticulo.Focus()

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Function

    Sub Calcular(Optional ByVal Buscar As Boolean = False)
        Try
            If BindingContext(DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").Count > 0 Then
                If Buscar = False Then
                    If CbNumero.Visible = True Then
                        BindingContext(DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").Current("Numero") = CbNumero.Text
                    ElseIf CBNuevo.Checked = True Then
                        BindingContext(DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").Current("Numero") = txtNuevoLote.Text
                        AgregaLote()
                        CBNuevo.Checked = False
                    Else
                        BindingContext(DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").Current("Numero") = "0"
                    End If
                End If

                BindingContext(DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").EndCurrentEdit()
                txtTotalEntrada.Text = Format(colTotalEntrada.SummaryItem.SummaryValue, "#,#0.00")
                txtTotalSalida.Text = Format(colTotalSalida.SummaryItem.SummaryValue, "#,#0.00")
                txtSaldoAjuste.Text = Format(CDbl(txtTotalEntrada.Text) - CDbl(txtTotalSalida.Text), "#,#0.00")

            Else
                txtTotalEntrada.Text = "0.00"
                txtTotalSalida.Text = "0.00"
                txtSaldoAjuste.Text = "0.00"
            End If

            CBNuevo.Checked = False
            CBNuevo.Visible = False
            CbNumero.Items.Clear()
            CbNumero.Visible = False
            LNumero.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Function Ceros() As Boolean  'JCGA 13042007
        If txtTotalEntrada.Text = "0.00" And txtTotalSalida.Text = "0.00" And txtSaldoAjuste.Text = "0.00" Then
            Return False
        Else
            Return True
        End If
    End Function
#End Region

#Region "Guardar"
    Function Registrar()
        Dim Funciones As New Conexion
        Try
            If Ceros() Then
            Else
                MsgBox("Ajustes en cero no se pueden almacenar!!")
                Exit Function
            End If



            If MessageBox.Show("¿Desea guardar el ajuste de inventario?", "SeePos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then


                Dim fr As New FrmPermisoAjusteB
                fr.ShowDialog()
                If fr.resultado = False Then
                    Exit Function
                Else


                    Dim id = Consecutivo()
                    'Dim id = Me.BindingContext(Me.DsAjusteInv2, "AjusteInventario").Current("Consecutivo")
                    id = id + 1
                    insertar_PermisoAjuste(fr.cedu_usuario, Date.Now.ToShortDateString, fr.txt_observacion.Text, id, fr.Cedu_Admin)

                End If
                Me.BindingContext(DsAjusteInv2, "AjusteInventario").EndCurrentEdit()
                BindingContext(DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").CancelCurrentEdit()
                BindingContext(DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").EndCurrentEdit()

                If Not (RegistraLote()) Then    'REGISTRA LOTES NUEVOS
                    Exit Function
                End If

                If Me.Registrar_Ajuste() Then

                    Me.ToolBar1.Buttons(4).Enabled = True
                    Me.ToolBar1.Buttons(1).Enabled = True
                    Me.ToolBar1.Buttons(0).Text = "Nuevo"
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    Me.ToolBar1.Buttons(3).Enabled = True
                    MsgBox("El Ajuste de Inventario se guardo Satisfactoriamente", MsgBoxStyle.Information)
                    Funciones.UpdateRecords("Lotes", "Documento = " & BindingContext(DsAjusteInv2, "AjusteInventario").Current("Consecutivo"), "Tipo = 'AIN' AND Documento = 0")
                    If MsgBox("Desea Imprimir el ajuste!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then Me.imprimir()
                    Me.DsAjusteInv2.AjusteInventario_Detalle.Clear()
                    Me.DsAjusteInv2.AjusteInventario.Clear()
                    grpBox_Inventario.Enabled = False
                    txtUsuario.Enabled = True
                    txtUsuario.Text = ""
                    txtNombreUsuario.Text = ""
                    txtCedulaUsuario.Text = ""
                    txtUsuario.Focus()
                Else
                    MsgBox("Error al Guardar el ajuste de inventario", MsgBoxStyle.Critical)
                End If
            Else
                Exit Function
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Function

    Private Sub Guarda_a_Pata()

        Dim sql As GestioDatos

    End Sub

    Function Registrar_Ajuste() As Boolean
        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try
            Me.adAjusteInv.InsertCommand.Transaction = Trans
            Me.adAjusteInv.DeleteCommand.Transaction = Trans
            Me.adAjusteInv.UpdateCommand.Transaction = Trans
            Me.adAjusteInv.SelectCommand.Transaction = Trans

            Me.adAjusteInvDetalle.InsertCommand.Transaction = Trans
            Me.adAjusteInvDetalle.DeleteCommand.Transaction = Trans
            Me.adAjusteInvDetalle.UpdateCommand.Transaction = Trans
            Me.adAjusteInvDetalle.SelectCommand.Transaction = Trans

            Dim Cx As New Conexion
            Dim cantidad As Integer
            Dim codigo As Integer
            Dim MAxActual As Integer
            Dim rs As SqlDataReader
            If op_Entrada.Checked = True Then
                'se guarda la cantidad maxima ajustada , esta cantidad es el tope para las devoluciones
                For cont As Integer = 0 To BindingContext(Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").Count - 1

                    cantidad = DsAjusteInv2.AjusteInventario_Detalle.Item(cont).Cantidad
                    codigo = DsAjusteInv2.AjusteInventario_Detalle.Item(cont).Cod_Articulo()
                    rs = Cx.GetRecorset(Cx.Conectar, "SELECT MAX_Inventario FROM Inventario WHERE Codigo='" & codigo & "'")
                    If rs.Read Then
                        MAxActual = rs("MAX_Inventario")
                    End If
                    rs.Close()
                    Cx.UpdateRecords("Inventario", "MAX_Inventario=" & MAxActual + CInt(cantidad), "Codigo='" & CInt(codigo) & "'")
                Next

            ElseIf op_Salida.Checked = True Then
                'se guarda la cantidad maxima ajustada , esta cantidad es el tope para las devoluciones
                For cont As Integer = 0 To BindingContext(Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").Count - 1

                    cantidad = DsAjusteInv2.AjusteInventario_Detalle.Item(cont).Cantidad
                    codigo = DsAjusteInv2.AjusteInventario_Detalle.Item(cont).Cod_Articulo()
                    rs = Cx.GetRecorset(Cx.Conectar, "SELECT MAX_Inventario FROM Inventario WHERE Codigo='" & codigo & "'")
                    If rs.Read Then
                        MAxActual = rs("MAX_Inventario")
                    End If
                    rs.Close()
                    Cx.UpdateRecords("Inventario", "MAX_Inventario=" & MAxActual - CInt(cantidad), "Codigo='" & CInt(codigo) & "'")
                Next
            End If


            Me.adAjusteInv.Update(Me.DsAjusteInv2, "AjusteInventario")
            Me.adAjusteInvDetalle.Update(Me.DsAjusteInv2, "AjusteInventario_Detalle")

            Trans.Commit()
            Return True


        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            Me.ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try
    End Function

#End Region

#Region "Eliminar Detalle"
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Delete And Me.ToolBarRegistrar.Enabled = True Then Eliminar_Ariculo_Detalle()
    End Sub

    Private Sub Eliminar_Ariculo_Detalle()
        Dim resp As Integer
        Try 'se intenta hacer
            If Me.BindingContext(DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").Count > 0 Then   ' si hay ubicaciones
                resp = MessageBox.Show("¿Desea eliminar este artículo del Ajuste?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

                If resp = 6 Then
                    Me.BindingContext(DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").RemoveAt(Me.BindingContext(DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").Position)
                    Me.BindingContext(DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").EndCurrentEdit()
                    Me.Calcular()
                    Me.BindingContext(DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").EndCurrentEdit()
                Else
                    Me.BindingContext(DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").CancelCurrentEdit()
                End If
            Else
                MsgBox("No Existen Artìculos para eliminar de este ajuste", MsgBoxStyle.Information)
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
#End Region

#Region "Controles Funciones"
    Private Sub txtCuenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuenta.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim codcue As String
            Dim buscar As New cFunciones
            codcue = buscar.BuscarDatos("Select CuentaContable,Descripcion From CuentaContable where Movimiento=1", "Descripcion", "Buscar Cuenta Contable .....", GetSetting("Seesoft", "Contabilidad", "Conexion"))
            txtCuenta.Text = codcue
            lbCuenta.Text = cFunciones.Descripcion
            'BuscarCuentaCont(codcue)
        End If

        If e.KeyCode = Keys.Enter Then
            Try


                Dim Cx As New Conexion

                Dim valida As String
                Dim num_cuenta As String = Me.txtCuenta.Text
                'se guarda la cantidad maxima ajustada , esta cantidad es el tope para las devoluciones
                ''Cx.UpdateRecords("Inventario", "MAX_Inventario=" & CInt(txtCantidad.Text), "Cod_Articulo='" & CInt(txtCodArticulo.Text) & "'")

                valida = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT CuentaContable FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
                Cx.DesConectar(Cx.sQlconexion)
                If valida = "" Then
                    MessageBox.Show("La cuenta contable digitada no esta registrada..", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.txtCuenta.Focus()
                    Exit Sub
                Else
                    Dim nombre As String
                    nombre = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT Descripcion FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
                    Cx.DesConectar(Cx.sQlconexion)
                    Me.lbCuenta.Text = nombre
                End If
                Agregar()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            End Try
        End If
    End Sub

    Private Sub txtUsuario_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuario.GotFocus
        txtUsuario.SelectAll()
    End Sub

    Private Sub op_Entrada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles op_Entrada.CheckedChanged
        CBNuevo.Visible = op_Entrada.Checked
        CBNuevo.Checked = False
        If Me.op_Entrada.Checked = True Then : ck_muerte.Checked = False
        End If
        txtObservacion.Focus()
    End Sub

    Private Sub op_Salida_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles op_Salida.CheckedChanged
        txtObservacion.Focus()
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub txtCantidad_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCantidad.Validating
        Try
            If Me.txtCantidad.Text = "" Then 'si el campo está vacío
                ErrorProvider1.SetError(sender, "Debes ajustar al menos un artículo")
                'e.Cancel = True
            Else
                ErrorProvider1.SetError(sender, "")
            End If
            If CDbl(Me.txtCantidad.Text) = 0 Then 'si el campo está vacío
                ErrorProvider1.SetError(sender, "Debes ajustar al menos un artículo")
                'e.Cancel = True
            Else
                ErrorProvider1.SetError(sender, "")
            End If
        Catch ex As SystemException
            txtCantidad.Text = 1
            ErrorProvider1.SetError(sender, "")
        End Try
    End Sub

    Private Sub txtCantidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidad.GotFocus
        txtCantidad.SelectAll()
    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Not IsNumeric(sender.text & e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub txtCantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCantidad.KeyDown
        If e.KeyCode = Keys.Enter Then ' se guarda la cotización en el dataset
            If Me.txtCuenta.Visible = True Then
                Me.txtCuenta.Focus()
            Else
                Agregar()
            End If
        End If
    End Sub

    Private Sub txtObservacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtObservacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCantidad.Focus()
        End If
    End Sub

    Private Sub GridControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.GotFocus
        BindingContext(DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").CancelCurrentEdit()
    End Sub
#End Region

#Region "Lotes - Serie"

#Region "Controles Lotes"
    Private Sub ActivaLote()
        Me.LNumero.Visible = True
        Me.LNumero.Text = "Lote"
        Me.CbNumero.Visible = True
        Me.TXtExistenciaLote.Visible = True
        Me.ExistenciaLote.Visible = True
        CargarCbNumero()
        CBNuevo.Visible = op_Entrada.Checked
    End Sub

    Private Sub ActivaNinguno()
        Me.LNumero.Visible = False
        Me.CbNumero.Visible = False
        Me.CbNumero.Items.Clear()
        CBNuevo.Visible = False
    End Sub

    Private Sub NuevoLote(ByVal Estado As Boolean)
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
            If txtCodigo.Text <> Nothing Then
                rss = Me.Lote.Lotes.Select("Cod_Articulo = " & CInt(Me.txtCodigo.Text) & " AND Vencimiento >= '" & Now.Date & "'")

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
                    If op_Entrada.Checked = False Then
                        txtCodArticulo.Focus()
                    Else
                        LNumero.Visible = False
                        CbNumero.Visible = False
                        CBNuevo.Visible = True
                        CBNuevo.Checked = True
                    End If
                End If
            Else
                MsgBox("Debe escribir el Código del Artículo", MsgBoxStyle.Critical)
                txtCodArticulo.Focus()
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
                rss = Me.Lote.Lotes.Select("Cod_Articulo = " & CInt(Me.txtCodigo.Text) & " And Numero = '" & CbNumero.Text & "'")

                If rss.Length <> 0 Then ' si existe lote con cantidad disponible
                    For i As Integer = 0 To rss.Length - 1
                        rs = rss(i)
                        Me.TXtExistenciaLote.Text = rs("Cant_Actual")
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
        BindingContext(Lote, "Lotes").Current("Cant_Inicial") = txtCantidad.Text
        BindingContext(Lote, "Lotes").Current("Cant_Actual") = 0
        BindingContext(Lote, "Lotes").Current("Fecha_Entrada") = Now
        BindingContext(Lote, "Lotes").Current("Cod_Articulo") = txtCodigo.Text
        BindingContext(Lote, "Lotes").Current("Documento") = 0
        BindingContext(Lote, "Lotes").Current("Tipo") = "AIN"
        BindingContext(Lote, "Lotes").EndCurrentEdit()
    End Sub


    Public Function ValidaLote() As Boolean
        Dim DrNum() As System.Data.DataRow
        Dim DrNumero As System.Data.DataRow
        ValidaLote = False

        Try
            If Me.Lote.Lotes.Count > 0 Then
                DrNum = Lote.Lotes.Select("Cod_Articulo = " & CInt(Me.txtCodigo.Text) & "AND Numero = '" & txtNuevoLote.Text & "'")

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
            txtObservacion.Focus()
        End If
    End Sub


    Private Sub CBNumero_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbNumero.SelectedIndexChanged
        If CbNumero.Items.Count > 0 Then
            CargarExistenciaLote()
        End If
    End Sub


    Private Sub CBNuevo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBNuevo.CheckedChanged
        If CBNuevo.Checked = True Then
            Me.ExistenciaLote.Visible = False
            Me.TXtExistenciaLote.Visible = False
        Else
            Me.CargarExistenciaLote()
            Me.ExistenciaLote.Visible = True
            Me.TXtExistenciaLote.Visible = True
        End If
        NuevoLote(CBNuevo.Checked)
    End Sub


    Private Sub txtNuevoLote_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNuevoLote.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not (ValidaLote()) Then
                DTPVencimiento.Focus()
            Else
                MsgBox("El Número de " & LNumero.Text & " ya existe", MsgBoxStyle.Critical)
                txtNumero.Focus()
            End If
        End If
    End Sub


    Private Sub DTPVencimiento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DTPVencimiento.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtObservacion.Focus()
        End If
    End Sub
#End Region

#End Region

    Private Sub cbo_gasto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_gasto.SelectedIndexChanged
        Me.op_Salida.Checked = True
    End Sub

    Private Sub ck_muerte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ck_muerte.CheckedChanged
        If ck_muerte.Checked = True Then
            Me.op_Salida.Checked = True
        Else
            Me.op_Salida.Checked = False
        End If
    End Sub

    Private Sub btnKardex_Click(sender As Object, e As EventArgs) Handles btnKardex.Click
        Dim frm As New FrmKardex
        frm.txtCodigo.Text = Me.txtCodigo.Text
        frm.FechaInicio.Value = CDate("01/" & Date.Now.Month & "/" & Date.Now.Year)
        frm.FechaFinal.Value = Date.Now
        frm.ShowDialog()
    End Sub

End Class
