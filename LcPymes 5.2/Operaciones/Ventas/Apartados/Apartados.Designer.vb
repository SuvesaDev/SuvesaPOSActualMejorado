<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Apartados
    Inherits FrmPlantilla

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Apartados))
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Dt_Vence = New System.Windows.Forms.DateTimePicker()
        Me.Ds_Apartado1 = New Ds_Apartado()
        Me.DT_actual = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrecio_Unit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonto_Descuento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonto_Impuesto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubtotalGravado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubTotalExcento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox3 = New System.Windows.Forms.Panel()
        Me.txt_articulo = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalArt = New DevExpress.XtraEditors.TextEdit()
        Me.txtExistencia = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPrecioUnit = New DevExpress.XtraEditors.TextEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New DevExpress.XtraEditors.TextEdit()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCantidad = New DevExpress.XtraEditors.TextEdit()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDescuento = New DevExpress.XtraEditors.TextEdit()
        Me.TxtCodArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.Ad_Apartados = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.ad_detalleapartado = New System.Data.SqlClient.SqlDataAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.Ad_usuarios = New System.Data.SqlClient.SqlDataAdapter()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtImpVentaT = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescuentoT = New DevExpress.XtraEditors.TextEdit()
        Me.txtSubtotalT = New DevExpress.XtraEditors.TextEdit()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TxtTotal = New DevExpress.XtraEditors.TextEdit()
        Me.Adapter_Moneda = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.GroupBox1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.GroupBox3_oLD = New System.Windows.Forms.GroupBox()
        Me.txtImpVenta = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.Combo_Encargado = New System.Windows.Forms.ComboBox()
        Me.Text_Ficticio = New System.Windows.Forms.TextBox()
        Me.fecha_vence = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TxtUtilidad = New DevExpress.XtraEditors.TextEdit()
        Me.txtFlete = New System.Windows.Forms.TextBox()
        Me.txtSGravado = New System.Windows.Forms.TextBox()
        Me.TxtMaxdescuento = New System.Windows.Forms.TextBox()
        Me.Label46 = New DevExpress.XtraEditors.TextEdit()
        Me.txtTelefono = New ValidText.ValidText()
        Me.Lb_SubExento = New DevExpress.XtraEditors.TextEdit()
        Me.Lb_Subgravado = New DevExpress.XtraEditors.TextEdit()
        Me.txtOtros = New System.Windows.Forms.TextBox()
        Me.TxtprecioCosto = New System.Windows.Forms.TextBox()
        Me.txtmontodescuento = New System.Windows.Forms.TextBox()
        Me.txtSubtotalGravado = New System.Windows.Forms.TextBox()
        Me.txtSubFamilia = New System.Windows.Forms.TextBox()
        Me.txtMontoImpuesto = New System.Windows.Forms.TextBox()
        Me.txtCostoBase = New System.Windows.Forms.TextBox()
        Me.CkEntregado = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Txtcodmoneda_Venta = New System.Windows.Forms.TextBox()
        Me.Txt_TipoCambio_Valor_Compra = New System.Windows.Forms.TextBox()
        Me.txtTipoCambio = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label_Anulada = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtSExcento = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDiasPlazo = New System.Windows.Forms.Label()
        Me.DtVence = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtFecha = New System.Windows.Forms.Label()
        Me.txtSubtotalExcento = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Txtdireccion = New System.Windows.Forms.TextBox()
        Me.GroupBox1_1 = New System.Windows.Forms.GroupBox()
        Me.txtNombreArt = New DevExpress.XtraEditors.TextEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbconsecutivo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCedulaUsuario = New System.Windows.Forms.Label()
        Me.ButtonCerrar = New System.Windows.Forms.Button()
        Me.LAnulado = New System.Windows.Forms.Label()
        Me.LCancelado = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.Ds_Apartado1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txt_articulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalArt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExistencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubtotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCodArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImpVentaT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuentoT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubtotalT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3_oLD.SuspendLayout()
        CType(Me.txtImpVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUtilidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label46.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lb_SubExento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lb_Subgravado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreArt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Text = "Anular"
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.Images.SetKeyName(0, "1456265011_file-empty.png")
        Me.ImageList.Images.SetKeyName(1, "1437535991_search.png")
        Me.ImageList.Images.SetKeyName(2, "1437535964_floppy.png")
        Me.ImageList.Images.SetKeyName(3, "1437535982_sign-error.png")
        Me.ImageList.Images.SetKeyName(4, "")
        Me.ImageList.Images.SetKeyName(5, "")
        Me.ImageList.Images.SetKeyName(6, "1456265147_Cancel.png")
        Me.ImageList.Images.SetKeyName(7, "1438571976_shine_9.png")
        Me.ImageList.Images.SetKeyName(8, "1456265434_player_stop.png")
        '
        'ToolBar1
        '
        Me.ToolBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 469)
        Me.ToolBar1.Size = New System.Drawing.Size(894, 57)
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.Location = New System.Drawing.Point(1043, 589)
        '
        'TituloModulo
        '
        Me.TituloModulo.Size = New System.Drawing.Size(894, 32)
        Me.TituloModulo.Text = "Apartados"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(666, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 16)
        Me.Label1.TabIndex = 175
        Me.Label1.Text = "Fecha:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(666, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 16)
        Me.Label3.TabIndex = 177
        Me.Label3.Text = "Fecha Vencimiento:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Dt_Vence
        '
        Me.Dt_Vence.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Ds_Apartado1, "Apartados.Vence", True))
        Me.Dt_Vence.Enabled = False
        Me.Dt_Vence.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dt_Vence.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dt_Vence.Location = New System.Drawing.Point(799, 65)
        Me.Dt_Vence.Name = "Dt_Vence"
        Me.Dt_Vence.Size = New System.Drawing.Size(90, 22)
        Me.Dt_Vence.TabIndex = 1
        Me.Dt_Vence.Value = New Date(2011, 1, 31, 0, 0, 0, 0)
        '
        'Ds_Apartado1
        '
        Me.Ds_Apartado1.DataSetName = "Ds_Apartado"
        Me.Ds_Apartado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DT_actual
        '
        Me.DT_actual.CalendarForeColor = System.Drawing.Color.Red
        Me.DT_actual.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Ds_Apartado1, "Apartados.Fecha", True))
        Me.DT_actual.Enabled = False
        Me.DT_actual.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_actual.Location = New System.Drawing.Point(799, 34)
        Me.DT_actual.Name = "DT_actual"
        Me.DT_actual.Size = New System.Drawing.Size(90, 20)
        Me.DT_actual.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.txtCodigo)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.txtNombre)
        Me.GroupBox6.Enabled = False
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox6.Location = New System.Drawing.Point(12, 33)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(641, 56)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds_Apartado1, "Apartados.Id_Cliente", True))
        Me.txtCodigo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtCodigo.Location = New System.Drawing.Point(13, 32)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(59, 13)
        Me.txtCodigo.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(80, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(301, 12)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nombre del Cliente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(12, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds_Apartado1, "Apartados.Nombrecliente", True))
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtNombre.Location = New System.Drawing.Point(80, 32)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(483, 13)
        Me.txtNombre.TabIndex = 1
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(220, 257)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(30, 27)
        Me.SimpleButton1.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.SimpleButton1.TabIndex = 189
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataMember = "Apartados.Apartados_Apartado_detalle"
        Me.GridControl1.DataSource = Me.Ds_Apartado1
        '
        '
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.EmbeddedNavigator.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.ControlText)
        Me.GridControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridControl1.Location = New System.Drawing.Point(12, 154)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(643, 238)
        Me.GridControl1.TabIndex = 184
        Me.GridControl1.Text = "GridControl1"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colCodArticulo, Me.colDescripcion, Me.colCantidad, Me.colPrecio_Unit, Me.colMonto_Descuento, Me.colMonto_Impuesto, Me.colSubtotalGravado, Me.colSubTotalExcento, Me.colSubTotal, Me.colTotal})
        Me.GridView1.GroupPanelText = "Detalle de Cotización"
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubtotalGravado", Nothing, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowVertLines = False
        Me.GridView1.ViewCaption = "Lista de Artículos Facturados"
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.FilterInfo = ColumnFilterInfo1
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCodigo.Width = 87
        '
        'colCodArticulo
        '
        Me.colCodArticulo.Caption = "Codigo"
        Me.colCodArticulo.FieldName = "cod_articulo"
        Me.colCodArticulo.FilterInfo = ColumnFilterInfo2
        Me.colCodArticulo.Name = "colCodArticulo"
        Me.colCodArticulo.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCodArticulo.VisibleIndex = 0
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripcion"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.FilterInfo = ColumnFilterInfo3
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescripcion.VisibleIndex = 2
        Me.colDescripcion.Width = 229
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cant."
        Me.colCantidad.DisplayFormat.FormatString = "#,#0.000"
        Me.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.FilterInfo = ColumnFilterInfo4
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCantidad.VisibleIndex = 1
        Me.colCantidad.Width = 69
        '
        'colPrecio_Unit
        '
        Me.colPrecio_Unit.Caption = "P.Unit"
        Me.colPrecio_Unit.DisplayFormat.FormatString = "#,#0.00"
        Me.colPrecio_Unit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrecio_Unit.FieldName = "Precio_Unit"
        Me.colPrecio_Unit.FilterInfo = ColumnFilterInfo5
        Me.colPrecio_Unit.Name = "colPrecio_Unit"
        Me.colPrecio_Unit.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colPrecio_Unit.VisibleIndex = 4
        Me.colPrecio_Unit.Width = 99
        '
        'colMonto_Descuento
        '
        Me.colMonto_Descuento.Caption = "M.Desc."
        Me.colMonto_Descuento.DisplayFormat.FormatString = "#,#0.00"
        Me.colMonto_Descuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMonto_Descuento.FieldName = "Monto_descuento"
        Me.colMonto_Descuento.FilterInfo = ColumnFilterInfo6
        Me.colMonto_Descuento.Name = "colMonto_Descuento"
        Me.colMonto_Descuento.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMonto_Descuento.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colMonto_Descuento.VisibleIndex = 3
        Me.colMonto_Descuento.Width = 67
        '
        'colMonto_Impuesto
        '
        Me.colMonto_Impuesto.Caption = "M. Imp."
        Me.colMonto_Impuesto.DisplayFormat.FormatString = "#,#0.00"
        Me.colMonto_Impuesto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMonto_Impuesto.FieldName = "Monto_Impuesto"
        Me.colMonto_Impuesto.FilterInfo = ColumnFilterInfo7
        Me.colMonto_Impuesto.Name = "colMonto_Impuesto"
        Me.colMonto_Impuesto.Options = CType((((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMonto_Impuesto.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colMonto_Impuesto.Width = 53
        '
        'colSubtotalGravado
        '
        Me.colSubtotalGravado.Caption = "S. Grav."
        Me.colSubtotalGravado.DisplayFormat.FormatString = "#,#0.00"
        Me.colSubtotalGravado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubtotalGravado.FieldName = "SubtotalGravado"
        Me.colSubtotalGravado.FilterInfo = ColumnFilterInfo8
        Me.colSubtotalGravado.Name = "colSubtotalGravado"
        Me.colSubtotalGravado.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSubtotalGravado.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSubtotalGravado.Width = 67
        '
        'colSubTotalExcento
        '
        Me.colSubTotalExcento.Caption = "S.Exc."
        Me.colSubTotalExcento.DisplayFormat.FormatString = "#,#0.00"
        Me.colSubTotalExcento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubTotalExcento.FieldName = "SubTotalExcento"
        Me.colSubTotalExcento.FilterInfo = ColumnFilterInfo9
        Me.colSubTotalExcento.MinWidth = 10
        Me.colSubTotalExcento.Name = "colSubTotalExcento"
        Me.colSubTotalExcento.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSubTotalExcento.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSubTotalExcento.Width = 67
        '
        'colSubTotal
        '
        Me.colSubTotal.Caption = "SubTotal"
        Me.colSubTotal.DisplayFormat.FormatString = "#,#0.00"
        Me.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubTotal.FieldName = "SubTotal"
        Me.colSubTotal.FilterInfo = ColumnFilterInfo10
        Me.colSubTotal.Name = "colSubTotal"
        Me.colSubTotal.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSubTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSubTotal.Width = 81
        '
        'colTotal
        '
        Me.colTotal.Caption = "Total"
        Me.colTotal.DisplayFormat.FormatString = "#,#0.00"
        Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal.FieldName = "Total_Ficticio"
        Me.colTotal.FilterInfo = ColumnFilterInfo11
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Options = CType(((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colTotal.VisibleIndex = 5
        Me.colTotal.Width = 108
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txt_articulo)
        Me.GroupBox3.Controls.Add(Me.txtTotalArt)
        Me.GroupBox3.Controls.Add(Me.txtExistencia)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtPrecioUnit)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.txtSubtotal)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.txtCantidad)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtDescuento)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Location = New System.Drawing.Point(12, 115)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(641, 40)
        Me.GroupBox3.TabIndex = 224
        '
        'txt_articulo
        '
        Me.txt_articulo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle.cod_articulo", True))
        Me.txt_articulo.EditValue = ""
        Me.txt_articulo.Location = New System.Drawing.Point(84, 15)
        Me.txt_articulo.Name = "txt_articulo"
        '
        '
        '
        Me.txt_articulo.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Green)
        Me.txt_articulo.Size = New System.Drawing.Size(80, 19)
        Me.txt_articulo.TabIndex = 32
        '
        'txtTotalArt
        '
        Me.txtTotalArt.EditValue = 0
        Me.txtTotalArt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtTotalArt.Location = New System.Drawing.Point(591, 16)
        Me.txtTotalArt.Name = "txtTotalArt"
        '
        '
        '
        Me.txtTotalArt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalArt.Properties.Enabled = False
        Me.txtTotalArt.Properties.ReadOnly = True
        Me.txtTotalArt.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Green)
        Me.txtTotalArt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalArt.Size = New System.Drawing.Size(44, 19)
        Me.txtTotalArt.TabIndex = 31
        '
        'txtExistencia
        '
        Me.txtExistencia.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle.Existencia", True))
        Me.txtExistencia.EditValue = 0
        Me.txtExistencia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtExistencia.Location = New System.Drawing.Point(543, 16)
        Me.txtExistencia.Name = "txtExistencia"
        '
        '
        '
        Me.txtExistencia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExistencia.Properties.Enabled = False
        Me.txtExistencia.Properties.ReadOnly = True
        Me.txtExistencia.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Green)
        Me.txtExistencia.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtExistencia.Size = New System.Drawing.Size(40, 19)
        Me.txtExistencia.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(539, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 14)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Exist."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(573, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 14)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Lineas"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(270, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 14)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Desc.(%)"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrecioUnit
        '
        Me.txtPrecioUnit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle.Precio_Unit", True))
        Me.txtPrecioUnit.EditValue = 0
        Me.txtPrecioUnit.Location = New System.Drawing.Point(190, 15)
        Me.txtPrecioUnit.Name = "txtPrecioUnit"
        '
        '
        '
        Me.txtPrecioUnit.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtPrecioUnit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPrecioUnit.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtPrecioUnit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPrecioUnit.Properties.MaxLength = 25
        Me.txtPrecioUnit.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Green)
        Me.txtPrecioUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPrecioUnit.Size = New System.Drawing.Size(85, 19)
        Me.txtPrecioUnit.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(158, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(115, 14)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Precio Unit."
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.White
        Me.Label31.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds_Apartado1, "Moneda.Simbolo", True))
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label31.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label31.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label31.Location = New System.Drawing.Point(169, 15)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(14, 21)
        Me.Label31.TabIndex = 23
        Me.Label31.Text = "M"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSubtotal
        '
        Me.txtSubtotal.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle.SubTotal", True))
        Me.txtSubtotal.EditValue = "0.00"
        Me.txtSubtotal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSubtotal.Location = New System.Drawing.Point(377, 16)
        Me.txtSubtotal.Name = "txtSubtotal"
        '
        '
        '
        Me.txtSubtotal.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtSubtotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSubtotal.Properties.Enabled = False
        Me.txtSubtotal.Properties.ReadOnly = True
        Me.txtSubtotal.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Green)
        Me.txtSubtotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSubtotal.Size = New System.Drawing.Size(154, 19)
        Me.txtSubtotal.TabIndex = 4
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.White
        Me.Label32.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds_Apartado1, "Moneda.Simbolo", True))
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label32.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label32.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label32.Location = New System.Drawing.Point(357, 15)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(14, 21)
        Me.Label32.TabIndex = 24
        Me.Label32.Text = "M"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(346, -1)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(197, 14)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "Monto"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCantidad
        '
        Me.txtCantidad.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle.Cantidad", True))
        Me.txtCantidad.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidad.Location = New System.Drawing.Point(3, 15)
        Me.txtCantidad.Name = "txtCantidad"
        '
        '
        '
        Me.txtCantidad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCantidad.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCantidad.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Green)
        Me.txtCantidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCantidad.Size = New System.Drawing.Size(72, 19)
        Me.txtCantidad.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(3, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 14)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Cantidad"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(82, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 14)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Código  "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescuento
        '
        Me.txtDescuento.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle.Descuento", True))
        Me.txtDescuento.EditValue = 0
        Me.txtDescuento.Location = New System.Drawing.Point(284, 16)
        Me.txtDescuento.Name = "txtDescuento"
        '
        '
        '
        Me.txtDescuento.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtDescuento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDescuento.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtDescuento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDescuento.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Green)
        Me.txtDescuento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDescuento.Size = New System.Drawing.Size(65, 19)
        Me.txtDescuento.TabIndex = 3
        '
        'TxtCodArticulo
        '
        Me.TxtCodArticulo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle.Codigo", True))
        Me.TxtCodArticulo.EditValue = ""
        Me.TxtCodArticulo.Location = New System.Drawing.Point(170, 155)
        Me.TxtCodArticulo.Name = "TxtCodArticulo"
        '
        '
        '
        Me.TxtCodArticulo.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Green)
        Me.TxtCodArticulo.Size = New System.Drawing.Size(80, 19)
        Me.TxtCodArticulo.TabIndex = 0
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT     Apartados.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         Apartados"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=DESKTOP-T96OM6J\DESARROLLO;Initial Catalog=seepos;Integrated Security" & _
            "=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Cliente", System.Data.SqlDbType.Int, 0, "Id_Cliente"), New System.Data.SqlClient.SqlParameter("@Nombrecliente", System.Data.SqlDbType.VarChar, 0, "Nombrecliente"), New System.Data.SqlClient.SqlParameter("@Cedulausuario", System.Data.SqlDbType.VarChar, 0, "Cedulausuario"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 0, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 0, "Imp_Venta"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 0, "Total"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 0, "Fecha"), New System.Data.SqlClient.SqlParameter("@Vence", System.Data.SqlDbType.DateTime, 0, "Vence"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 0, "Anulado"), New System.Data.SqlClient.SqlParameter("@Cancelado", System.Data.SqlDbType.Bit, 0, "Cancelado"), New System.Data.SqlClient.SqlParameter("@SubTotalGravada", System.Data.SqlDbType.Float, 0, "SubTotalGravada"), New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 0, "SubTotalExento"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 0, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 0, "Monto"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 0, "Descuento"), New System.Data.SqlClient.SqlParameter("@Tipo_Cambio", System.Data.SqlDbType.Float, 0, "Tipo_Cambio"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 0, "Cod_Moneda")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Cliente", System.Data.SqlDbType.Int, 0, "Id_Cliente"), New System.Data.SqlClient.SqlParameter("@Nombrecliente", System.Data.SqlDbType.VarChar, 0, "Nombrecliente"), New System.Data.SqlClient.SqlParameter("@Cedulausuario", System.Data.SqlDbType.VarChar, 0, "Cedulausuario"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 0, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 0, "Imp_Venta"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 0, "Total"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 0, "Fecha"), New System.Data.SqlClient.SqlParameter("@Vence", System.Data.SqlDbType.DateTime, 0, "Vence"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 0, "Anulado"), New System.Data.SqlClient.SqlParameter("@Cancelado", System.Data.SqlDbType.Bit, 0, "Cancelado"), New System.Data.SqlClient.SqlParameter("@SubTotalGravada", System.Data.SqlDbType.Float, 0, "SubTotalGravada"), New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 0, "SubTotalExento"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 0, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 0, "Monto"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 0, "Descuento"), New System.Data.SqlClient.SqlParameter("@Tipo_Cambio", System.Data.SqlDbType.Float, 0, "Tipo_Cambio"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 0, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Original_Id_Apartado", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Apartado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_Apartado", System.Data.SqlDbType.BigInt, 8, "Id_Apartado")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM [Apartados] WHERE (([Id_Apartado] = @Original_Id_Apartado))"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_Apartado", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Apartado", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Ad_Apartados
        '
        Me.Ad_Apartados.DeleteCommand = Me.SqlDeleteCommand1
        Me.Ad_Apartados.InsertCommand = Me.SqlInsertCommand1
        Me.Ad_Apartados.SelectCommand = Me.SqlSelectCommand1
        Me.Ad_Apartados.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Apartados", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Apartado", "Id_Apartado"), New System.Data.Common.DataColumnMapping("Id_Cliente", "Id_Cliente"), New System.Data.Common.DataColumnMapping("Nombrecliente", "Nombrecliente"), New System.Data.Common.DataColumnMapping("Cedulausuario", "Cedulausuario"), New System.Data.Common.DataColumnMapping("SubTotal", "SubTotal"), New System.Data.Common.DataColumnMapping("Imp_Venta", "Imp_Venta"), New System.Data.Common.DataColumnMapping("Total", "Total"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Vence", "Vence"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("Cancelado", "Cancelado"), New System.Data.Common.DataColumnMapping("SubTotalGravada", "SubTotalGravada"), New System.Data.Common.DataColumnMapping("SubTotalExento", "SubTotalExento"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Tipo_Cambio", "Tipo_Cambio"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda")})})
        Me.Ad_Apartados.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Apartado", System.Data.SqlDbType.BigInt, 0, "Id_Apartado"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 0, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Int, 0, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Precio_Costo", System.Data.SqlDbType.Float, 0, "Precio_Costo"), New System.Data.SqlClient.SqlParameter("@Precio_Base", System.Data.SqlDbType.Float, 0, "Precio_Base"), New System.Data.SqlClient.SqlParameter("@Precio_Flete", System.Data.SqlDbType.Float, 0, "Precio_Flete"), New System.Data.SqlClient.SqlParameter("@Precio_Otros", System.Data.SqlDbType.Float, 0, "Precio_Otros"), New System.Data.SqlClient.SqlParameter("@Precio_Unit", System.Data.SqlDbType.Float, 0, "Precio_Unit"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 0, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Monto_Impuesto", System.Data.SqlDbType.Float, 0, "Monto_Impuesto"), New System.Data.SqlClient.SqlParameter("@SubtotalGravado", System.Data.SqlDbType.Float, 0, "SubtotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExcento", System.Data.SqlDbType.Float, 0, "SubTotalExcento"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 0, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Monto_descuento", System.Data.SqlDbType.Float, 0, "Monto_descuento"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 0, "Descuento"), New System.Data.SqlClient.SqlParameter("@Max_Descuento", System.Data.SqlDbType.Float, 0, "Max_Descuento"), New System.Data.SqlClient.SqlParameter("@Tipo_Cambio_ValorCompra", System.Data.SqlDbType.Float, 0, "Tipo_Cambio_ValorCompra"), New System.Data.SqlClient.SqlParameter("@Cod_MonedaVenta", System.Data.SqlDbType.Int, 0, "Cod_MonedaVenta"), New System.Data.SqlClient.SqlParameter("@IdBodega", System.Data.SqlDbType.BigInt, 0, "IdBodega"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 0, "Codigo"), New System.Data.SqlClient.SqlParameter("@cod_articulo", System.Data.SqlDbType.VarChar, 0, "cod_articulo")})
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Apartado", System.Data.SqlDbType.BigInt, 0, "Id_Apartado"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 0, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Int, 0, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Precio_Costo", System.Data.SqlDbType.Float, 0, "Precio_Costo"), New System.Data.SqlClient.SqlParameter("@Precio_Base", System.Data.SqlDbType.Float, 0, "Precio_Base"), New System.Data.SqlClient.SqlParameter("@Precio_Flete", System.Data.SqlDbType.Float, 0, "Precio_Flete"), New System.Data.SqlClient.SqlParameter("@Precio_Otros", System.Data.SqlDbType.Float, 0, "Precio_Otros"), New System.Data.SqlClient.SqlParameter("@Precio_Unit", System.Data.SqlDbType.Float, 0, "Precio_Unit"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 0, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Monto_Impuesto", System.Data.SqlDbType.Float, 0, "Monto_Impuesto"), New System.Data.SqlClient.SqlParameter("@SubtotalGravado", System.Data.SqlDbType.Float, 0, "SubtotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExcento", System.Data.SqlDbType.Float, 0, "SubTotalExcento"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 0, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Monto_descuento", System.Data.SqlDbType.Float, 0, "Monto_descuento"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 0, "Descuento"), New System.Data.SqlClient.SqlParameter("@Max_Descuento", System.Data.SqlDbType.Float, 0, "Max_Descuento"), New System.Data.SqlClient.SqlParameter("@Tipo_Cambio_ValorCompra", System.Data.SqlDbType.Float, 0, "Tipo_Cambio_ValorCompra"), New System.Data.SqlClient.SqlParameter("@Cod_MonedaVenta", System.Data.SqlDbType.Int, 0, "Cod_MonedaVenta"), New System.Data.SqlClient.SqlParameter("@IdBodega", System.Data.SqlDbType.BigInt, 0, "IdBodega"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 0, "Codigo"), New System.Data.SqlClient.SqlParameter("@cod_articulo", System.Data.SqlDbType.VarChar, 0, "cod_articulo"), New System.Data.SqlClient.SqlParameter("@Original_Id_detalle", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_detalle", System.Data.SqlDbType.BigInt, 8, "Id_detalle")})
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM [Apartado_detalle] WHERE (([Id_detalle] = @Original_Id_detalle))"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_detalle", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_detalle", System.Data.DataRowVersion.Original, Nothing)})
        '
        'ad_detalleapartado
        '
        Me.ad_detalleapartado.DeleteCommand = Me.SqlDeleteCommand2
        Me.ad_detalleapartado.InsertCommand = Me.SqlInsertCommand2
        Me.ad_detalleapartado.SelectCommand = Me.SqlSelectCommand2
        Me.ad_detalleapartado.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Apartado_detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_detalle", "Id_detalle"), New System.Data.Common.DataColumnMapping("Id_Apartado", "Id_Apartado"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"), New System.Data.Common.DataColumnMapping("Precio_Costo", "Precio_Costo"), New System.Data.Common.DataColumnMapping("Precio_Base", "Precio_Base"), New System.Data.Common.DataColumnMapping("Precio_Flete", "Precio_Flete"), New System.Data.Common.DataColumnMapping("Precio_Otros", "Precio_Otros"), New System.Data.Common.DataColumnMapping("Precio_Unit", "Precio_Unit"), New System.Data.Common.DataColumnMapping("Impuesto", "Impuesto"), New System.Data.Common.DataColumnMapping("Monto_Impuesto", "Monto_Impuesto"), New System.Data.Common.DataColumnMapping("SubtotalGravado", "SubtotalGravado"), New System.Data.Common.DataColumnMapping("SubTotalExcento", "SubTotalExcento"), New System.Data.Common.DataColumnMapping("SubTotal", "SubTotal"), New System.Data.Common.DataColumnMapping("Monto_descuento", "Monto_descuento"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Max_Descuento", "Max_Descuento"), New System.Data.Common.DataColumnMapping("Tipo_Cambio_ValorCompra", "Tipo_Cambio_ValorCompra"), New System.Data.Common.DataColumnMapping("Cod_MonedaVenta", "Cod_MonedaVenta"), New System.Data.Common.DataColumnMapping("IdBodega", "IdBodega"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("cod_articulo", "cod_articulo")})})
        Me.ad_detalleapartado.UpdateCommand = Me.SqlUpdateCommand2
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds_Apartado1, "Apartados.Id_Apartado", True))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(164, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 12)
        Me.Label7.TabIndex = 159
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(18, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 27)
        Me.Label8.TabIndex = 225
        Me.Label8.Text = "Numero:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(732, 504)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(163, 13)
        Me.txtNombreUsuario.TabIndex = 227
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(673, 504)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(56, 13)
        Me.txtUsuario.TabIndex = 226
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label48.Location = New System.Drawing.Point(600, 504)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(72, 13)
        Me.Label48.TabIndex = 228
        Me.Label48.Text = "Usuario"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT     Usuarios.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         Usuarios"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'Ad_usuarios
        '
        Me.Ad_usuarios.SelectCommand = Me.SqlSelectCommand3
        Me.Ad_usuarios.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Id_Usuario", "Id_Usuario"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Entrada", "Clave_Entrada"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna"), New System.Data.Common.DataColumnMapping("Perfil", "Perfil"), New System.Data.Common.DataColumnMapping("Foto", "Foto"), New System.Data.Common.DataColumnMapping("Iniciales", "Iniciales"), New System.Data.Common.DataColumnMapping("CambiarPrecio", "CambiarPrecio"), New System.Data.Common.DataColumnMapping("Porc_Precio", "Porc_Precio"), New System.Data.Common.DataColumnMapping("Aplicar_Desc", "Aplicar_Desc"), New System.Data.Common.DataColumnMapping("Porc_Desc", "Porc_Desc"), New System.Data.Common.DataColumnMapping("Exist_Negativa", "Exist_Negativa")})})
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Enabled = False
        Me.SimpleButton2.Location = New System.Drawing.Point(824, 224)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(19, 22)
        Me.SimpleButton2.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer)))
        Me.SimpleButton2.TabIndex = 187
        Me.SimpleButton2.Text = "+"
        '
        'txtImpVentaT
        '
        Me.txtImpVentaT.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Ds_Apartado1, "Apartados.Imp_Venta", True))
        Me.txtImpVentaT.EditValue = "0.00"
        Me.txtImpVentaT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtImpVentaT.Location = New System.Drawing.Point(677, 306)
        Me.txtImpVentaT.Name = "txtImpVentaT"
        '
        '
        '
        Me.txtImpVentaT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtImpVentaT.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtImpVentaT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtImpVentaT.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtImpVentaT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtImpVentaT.Properties.ReadOnly = True
        Me.txtImpVentaT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.RoyalBlue)
        Me.txtImpVentaT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtImpVentaT.Size = New System.Drawing.Size(203, 19)
        Me.txtImpVentaT.TabIndex = 28
        '
        'txtDescuentoT
        '
        Me.txtDescuentoT.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Ds_Apartado1, "Apartados.Descuento", True))
        Me.txtDescuentoT.EditValue = "0.00"
        Me.txtDescuentoT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDescuentoT.Location = New System.Drawing.Point(677, 253)
        Me.txtDescuentoT.Name = "txtDescuentoT"
        '
        '
        '
        Me.txtDescuentoT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtDescuentoT.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtDescuentoT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDescuentoT.Properties.ReadOnly = True
        Me.txtDescuentoT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.RoyalBlue)
        Me.txtDescuentoT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDescuentoT.Size = New System.Drawing.Size(203, 19)
        Me.txtDescuentoT.TabIndex = 27
        '
        'txtSubtotalT
        '
        Me.txtSubtotalT.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Ds_Apartado1, "Apartados.SubTotal", True))
        Me.txtSubtotalT.EditValue = "0.00"
        Me.txtSubtotalT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSubtotalT.Location = New System.Drawing.Point(677, 194)
        Me.txtSubtotalT.Name = "txtSubtotalT"
        '
        '
        '
        Me.txtSubtotalT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtSubtotalT.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtSubtotalT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSubtotalT.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtSubtotalT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSubtotalT.Properties.ReadOnly = True
        Me.txtSubtotalT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.RoyalBlue)
        Me.txtSubtotalT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSubtotalT.Size = New System.Drawing.Size(203, 19)
        Me.txtSubtotalT.TabIndex = 26
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label24.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label24.Location = New System.Drawing.Point(749, 285)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(75, 15)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "Imp. Venta"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label23.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label23.Location = New System.Drawing.Point(749, 229)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(74, 15)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Descuento"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label22.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label22.Location = New System.Drawing.Point(749, 176)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(71, 15)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "SubTotal"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Red
        Me.Label25.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label25.Location = New System.Drawing.Point(672, 371)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(209, 24)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "Total del Apartado"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TxtTotal
        '
        Me.TxtTotal.BackgroundImage = CType(resources.GetObject("TxtTotal.BackgroundImage"), System.Drawing.Image)
        Me.TxtTotal.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Ds_Apartado1, "Apartados.Total", True))
        Me.TxtTotal.EditValue = "0.00"
        Me.TxtTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtTotal.Location = New System.Drawing.Point(673, 399)
        Me.TxtTotal.Name = "TxtTotal"
        '
        '
        '
        Me.TxtTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtTotal.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtTotal.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtTotal.Properties.ReadOnly = True
        Me.TxtTotal.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.Gray, System.Drawing.Color.Yellow)
        Me.TxtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtTotal.Size = New System.Drawing.Size(208, 44)
        Me.TxtTotal.TabIndex = 29
        '
        'Adapter_Moneda
        '
        Me.Adapter_Moneda.SelectCommand = Me.SqlCommand1
        Me.Adapter_Moneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlCommand1.Connection = Me.SqlConnection1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.SimpleButton3)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(96, 340)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 30)
        Me.GroupBox1.TabIndex = 230
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Ds_Apartado1, "Apartados.Cod_Moneda", True))
        Me.ComboBox1.DataSource = Me.Ds_Apartado1
        Me.ComboBox1.DisplayMember = "Moneda.MonedaNombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Blue
        Me.ComboBox1.ItemHeight = 13
        Me.ComboBox1.Location = New System.Drawing.Point(67, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(120, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "Moneda.ValorVenta"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Enabled = False
        Me.SimpleButton3.Location = New System.Drawing.Point(192, 6)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(24, 16)
        Me.SimpleButton3.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.SimpleButton3.TabIndex = 1
        Me.SimpleButton3.Text = "..."
        Me.SimpleButton3.ToolTip = "Cambio de la denominación de la moneda"
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label30.Location = New System.Drawing.Point(3, 5)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(56, 14)
        Me.Label30.TabIndex = 68
        Me.Label30.Text = "Moneda"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3_oLD
        '
        Me.GroupBox3_oLD.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3_oLD.Controls.Add(Me.txtImpVenta)
        Me.GroupBox3_oLD.Controls.Add(Me.SimpleButton4)
        Me.GroupBox3_oLD.Controls.Add(Me.Combo_Encargado)
        Me.GroupBox3_oLD.Controls.Add(Me.Text_Ficticio)
        Me.GroupBox3_oLD.Controls.Add(Me.fecha_vence)
        Me.GroupBox3_oLD.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3_oLD.Controls.Add(Me.TxtUtilidad)
        Me.GroupBox3_oLD.Controls.Add(Me.txtFlete)
        Me.GroupBox3_oLD.Controls.Add(Me.txtSGravado)
        Me.GroupBox3_oLD.Controls.Add(Me.TxtMaxdescuento)
        Me.GroupBox3_oLD.Controls.Add(Me.Label46)
        Me.GroupBox3_oLD.Controls.Add(Me.txtTelefono)
        Me.GroupBox3_oLD.Controls.Add(Me.Lb_SubExento)
        Me.GroupBox3_oLD.Controls.Add(Me.Lb_Subgravado)
        Me.GroupBox3_oLD.Controls.Add(Me.txtOtros)
        Me.GroupBox3_oLD.Controls.Add(Me.TxtprecioCosto)
        Me.GroupBox3_oLD.Controls.Add(Me.txtmontodescuento)
        Me.GroupBox3_oLD.Controls.Add(Me.txtSubtotalGravado)
        Me.GroupBox3_oLD.Controls.Add(Me.txtSubFamilia)
        Me.GroupBox3_oLD.Controls.Add(Me.txtMontoImpuesto)
        Me.GroupBox3_oLD.Controls.Add(Me.txtCostoBase)
        Me.GroupBox3_oLD.Controls.Add(Me.CkEntregado)
        Me.GroupBox3_oLD.Controls.Add(Me.CheckBox1)
        Me.GroupBox3_oLD.Controls.Add(Me.Txtcodmoneda_Venta)
        Me.GroupBox3_oLD.Controls.Add(Me.Txt_TipoCambio_Valor_Compra)
        Me.GroupBox3_oLD.Controls.Add(Me.txtTipoCambio)
        Me.GroupBox3_oLD.Controls.Add(Me.Label9)
        Me.GroupBox3_oLD.Controls.Add(Me.Label_Anulada)
        Me.GroupBox3_oLD.Controls.Add(Me.Label49)
        Me.GroupBox3_oLD.Controls.Add(Me.Label19)
        Me.GroupBox3_oLD.Controls.Add(Me.txtSExcento)
        Me.GroupBox3_oLD.Controls.Add(Me.Label10)
        Me.GroupBox3_oLD.Controls.Add(Me.txtDiasPlazo)
        Me.GroupBox3_oLD.Controls.Add(Me.DtVence)
        Me.GroupBox3_oLD.Controls.Add(Me.Label12)
        Me.GroupBox3_oLD.Controls.Add(Me.dtFecha)
        Me.GroupBox3_oLD.Controls.Add(Me.txtSubtotalExcento)
        Me.GroupBox3_oLD.Controls.Add(Me.Label43)
        Me.GroupBox3_oLD.Controls.Add(Me.Label26)
        Me.GroupBox3_oLD.Controls.Add(Me.Label29)
        Me.GroupBox3_oLD.Controls.Add(Me.Txtdireccion)
        Me.GroupBox3_oLD.Controls.Add(Me.GroupBox1_1)
        Me.GroupBox3_oLD.Enabled = False
        Me.GroupBox3_oLD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3_oLD.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox3_oLD.Location = New System.Drawing.Point(72, 205)
        Me.GroupBox3_oLD.Name = "GroupBox3_oLD"
        Me.GroupBox3_oLD.Size = New System.Drawing.Size(102, 57)
        Me.GroupBox3_oLD.TabIndex = 231
        Me.GroupBox3_oLD.TabStop = False
        '
        'txtImpVenta
        '
        Me.txtImpVenta.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle.Impuesto", True))
        Me.txtImpVenta.EditValue = "0.00"
        Me.txtImpVenta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtImpVenta.Location = New System.Drawing.Point(616, 48)
        Me.txtImpVenta.Name = "txtImpVenta"
        '
        '
        '
        Me.txtImpVenta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtImpVenta.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtImpVenta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtImpVenta.Properties.Enabled = False
        Me.txtImpVenta.Properties.ReadOnly = True
        Me.txtImpVenta.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtImpVenta.Size = New System.Drawing.Size(64, 17)
        Me.txtImpVenta.TabIndex = 233
        '
        'SimpleButton4
        '
        Me.SimpleButton4.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SimpleButton4.Enabled = False
        Me.SimpleButton4.Location = New System.Drawing.Point(80, 80)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(33, 18)
        Me.SimpleButton4.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.SimpleButton4.TabIndex = 191
        Me.SimpleButton4.Text = "T"
        '
        'Combo_Encargado
        '
        Me.Combo_Encargado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Encargado.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Combo_Encargado.Location = New System.Drawing.Point(384, 24)
        Me.Combo_Encargado.Name = "Combo_Encargado"
        Me.Combo_Encargado.Size = New System.Drawing.Size(208, 21)
        Me.Combo_Encargado.TabIndex = 160
        Me.Combo_Encargado.Visible = False
        '
        'Text_Ficticio
        '
        Me.Text_Ficticio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle.Total_Ficticio", True))
        Me.Text_Ficticio.Location = New System.Drawing.Point(536, 48)
        Me.Text_Ficticio.Name = "Text_Ficticio"
        Me.Text_Ficticio.Size = New System.Drawing.Size(48, 20)
        Me.Text_Ficticio.TabIndex = 221
        '
        'fecha_vence
        '
        Me.fecha_vence.Location = New System.Drawing.Point(528, 120)
        Me.fecha_vence.Name = "fecha_vence"
        Me.fecha_vence.Size = New System.Drawing.Size(88, 20)
        Me.fecha_vence.TabIndex = 187
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(528, 144)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker1.TabIndex = 186
        '
        'TxtUtilidad
        '
        Me.TxtUtilidad.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle.Monto_Impuesto", True))
        Me.TxtUtilidad.EditValue = ""
        Me.TxtUtilidad.Location = New System.Drawing.Point(552, 72)
        Me.TxtUtilidad.Name = "TxtUtilidad"
        '
        '
        '
        Me.TxtUtilidad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtUtilidad.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtUtilidad.Size = New System.Drawing.Size(32, 17)
        Me.TxtUtilidad.TabIndex = 192
        Me.TxtUtilidad.ToolTip = "Porcentaje de Utilidad."
        Me.TxtUtilidad.Visible = False
        '
        'txtFlete
        '
        Me.txtFlete.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFlete.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle.Precio_Flete", True))
        Me.txtFlete.ForeColor = System.Drawing.Color.Blue
        Me.txtFlete.Location = New System.Drawing.Point(456, 73)
        Me.txtFlete.Name = "txtFlete"
        Me.txtFlete.Size = New System.Drawing.Size(32, 13)
        Me.txtFlete.TabIndex = 169
        '
        'txtSGravado
        '
        Me.txtSGravado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSGravado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle.SubtotalGravado", True))
        Me.txtSGravado.ForeColor = System.Drawing.Color.Blue
        Me.txtSGravado.Location = New System.Drawing.Point(464, 128)
        Me.txtSGravado.Name = "txtSGravado"
        Me.txtSGravado.Size = New System.Drawing.Size(40, 13)
        Me.txtSGravado.TabIndex = 166
        '
        'TxtMaxdescuento
        '
        Me.TxtMaxdescuento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle.Max_Descuento", True))
        Me.TxtMaxdescuento.Location = New System.Drawing.Point(456, 96)
        Me.TxtMaxdescuento.Name = "TxtMaxdescuento"
        Me.TxtMaxdescuento.Size = New System.Drawing.Size(40, 20)
        Me.TxtMaxdescuento.TabIndex = 160
        '
        'Label46
        '
        Me.Label46.EditValue = "0.00"
        Me.Label46.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label46.Location = New System.Drawing.Point(616, 224)
        Me.Label46.Name = "Label46"
        '
        '
        '
        Me.Label46.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Label46.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.Label46.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Label46.Properties.EditFormat.FormatString = "#,#0.00"
        Me.Label46.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Label46.Properties.ReadOnly = True
        Me.Label46.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.InactiveCaptionText, System.Drawing.Color.RoyalBlue)
        Me.Label46.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label46.Size = New System.Drawing.Size(80, 17)
        Me.Label46.TabIndex = 189
        '
        'txtTelefono
        '
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTelefono.FieldReference = Nothing
        Me.txtTelefono.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtTelefono.Location = New System.Drawing.Point(592, 296)
        Me.txtTelefono.MaskEdit = ""
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.txtTelefono.Required = False
        Me.txtTelefono.ShowErrorIcon = True
        Me.txtTelefono.Size = New System.Drawing.Size(104, 13)
        Me.txtTelefono.TabIndex = 2
        Me.txtTelefono.ValidationMode = ValidText.ValidText.ValidationModes.None
        Me.txtTelefono.ValidText = ""
        '
        'Lb_SubExento
        '
        Me.Lb_SubExento.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Ds_Apartado1, "Apartados.SubTotalExento", True))
        Me.Lb_SubExento.EditValue = "0.00"
        Me.Lb_SubExento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lb_SubExento.Location = New System.Drawing.Point(232, 184)
        Me.Lb_SubExento.Name = "Lb_SubExento"
        '
        '
        '
        Me.Lb_SubExento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Lb_SubExento.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.Lb_SubExento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Lb_SubExento.Properties.EditFormat.FormatString = "#,#0.00"
        Me.Lb_SubExento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Lb_SubExento.Properties.ReadOnly = True
        Me.Lb_SubExento.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.RoyalBlue)
        Me.Lb_SubExento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lb_SubExento.Size = New System.Drawing.Size(80, 17)
        Me.Lb_SubExento.TabIndex = 35
        '
        'Lb_Subgravado
        '
        Me.Lb_Subgravado.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Ds_Apartado1, "Apartados.SubTotalGravada", True))
        Me.Lb_Subgravado.EditValue = "0.00"
        Me.Lb_Subgravado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lb_Subgravado.Location = New System.Drawing.Point(232, 168)
        Me.Lb_Subgravado.Name = "Lb_Subgravado"
        '
        '
        '
        Me.Lb_Subgravado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Lb_Subgravado.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.Lb_Subgravado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Lb_Subgravado.Properties.EditFormat.FormatString = "#,#0.00"
        Me.Lb_Subgravado.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Lb_Subgravado.Properties.ReadOnly = True
        Me.Lb_Subgravado.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.RoyalBlue)
        Me.Lb_Subgravado.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lb_Subgravado.Size = New System.Drawing.Size(80, 17)
        Me.Lb_Subgravado.TabIndex = 38
        '
        'txtOtros
        '
        Me.txtOtros.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOtros.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle.Precio_Otros", True))
        Me.txtOtros.ForeColor = System.Drawing.Color.Blue
        Me.txtOtros.Location = New System.Drawing.Point(664, 152)
        Me.txtOtros.Name = "txtOtros"
        Me.txtOtros.Size = New System.Drawing.Size(24, 13)
        Me.txtOtros.TabIndex = 170
        '
        'TxtprecioCosto
        '
        Me.TxtprecioCosto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle.Precio_Costo", True))
        Me.TxtprecioCosto.Location = New System.Drawing.Point(656, 176)
        Me.TxtprecioCosto.Name = "TxtprecioCosto"
        Me.TxtprecioCosto.Size = New System.Drawing.Size(32, 20)
        Me.TxtprecioCosto.TabIndex = 183
        Me.TxtprecioCosto.Text = "TextBox1"
        '
        'txtmontodescuento
        '
        Me.txtmontodescuento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmontodescuento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle.Monto_descuento", True))
        Me.txtmontodescuento.ForeColor = System.Drawing.Color.Blue
        Me.txtmontodescuento.Location = New System.Drawing.Point(592, 104)
        Me.txtmontodescuento.Name = "txtmontodescuento"
        Me.txtmontodescuento.Size = New System.Drawing.Size(96, 13)
        Me.txtmontodescuento.TabIndex = 181
        '
        'txtSubtotalGravado
        '
        Me.txtSubtotalGravado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSubtotalGravado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle.SubtotalGravado", True))
        Me.txtSubtotalGravado.Enabled = False
        Me.txtSubtotalGravado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotalGravado.ForeColor = System.Drawing.Color.Blue
        Me.txtSubtotalGravado.Location = New System.Drawing.Point(696, 104)
        Me.txtSubtotalGravado.Name = "txtSubtotalGravado"
        Me.txtSubtotalGravado.Size = New System.Drawing.Size(24, 13)
        Me.txtSubtotalGravado.TabIndex = 178
        Me.txtSubtotalGravado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubFamilia
        '
        Me.txtSubFamilia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSubFamilia.ForeColor = System.Drawing.Color.Blue
        Me.txtSubFamilia.Location = New System.Drawing.Point(664, 136)
        Me.txtSubFamilia.Name = "txtSubFamilia"
        Me.txtSubFamilia.Size = New System.Drawing.Size(24, 13)
        Me.txtSubFamilia.TabIndex = 167
        '
        'txtMontoImpuesto
        '
        Me.txtMontoImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMontoImpuesto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle.Monto_Impuesto", True))
        Me.txtMontoImpuesto.ForeColor = System.Drawing.Color.Blue
        Me.txtMontoImpuesto.Location = New System.Drawing.Point(664, 120)
        Me.txtMontoImpuesto.Name = "txtMontoImpuesto"
        Me.txtMontoImpuesto.Size = New System.Drawing.Size(24, 13)
        Me.txtMontoImpuesto.TabIndex = 165
        '
        'txtCostoBase
        '
        Me.txtCostoBase.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCostoBase.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle.Precio_Base", True))
        Me.txtCostoBase.Enabled = False
        Me.txtCostoBase.ForeColor = System.Drawing.Color.Blue
        Me.txtCostoBase.Location = New System.Drawing.Point(696, 120)
        Me.txtCostoBase.Name = "txtCostoBase"
        Me.txtCostoBase.Size = New System.Drawing.Size(32, 13)
        Me.txtCostoBase.TabIndex = 168
        '
        'CkEntregado
        '
        Me.CkEntregado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.Ds_Apartado1, "Apartados.Cancelado", True))
        Me.CkEntregado.Enabled = False
        Me.CkEntregado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkEntregado.ForeColor = System.Drawing.Color.Green
        Me.CkEntregado.Location = New System.Drawing.Point(304, 104)
        Me.CkEntregado.Name = "CkEntregado"
        Me.CkEntregado.Size = New System.Drawing.Size(80, 16)
        Me.CkEntregado.TabIndex = 156
        Me.CkEntregado.Text = "Entregado"
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.Ds_Apartado1, "Apartados.Anulado", True))
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Red
        Me.CheckBox1.Location = New System.Drawing.Point(304, 88)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox1.TabIndex = 155
        Me.CheckBox1.Text = "Anulada"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Txtcodmoneda_Venta
        '
        Me.Txtcodmoneda_Venta.Location = New System.Drawing.Point(384, 160)
        Me.Txtcodmoneda_Venta.Name = "Txtcodmoneda_Venta"
        Me.Txtcodmoneda_Venta.Size = New System.Drawing.Size(40, 20)
        Me.Txtcodmoneda_Venta.TabIndex = 188
        '
        'Txt_TipoCambio_Valor_Compra
        '
        Me.Txt_TipoCambio_Valor_Compra.Location = New System.Drawing.Point(432, 160)
        Me.Txt_TipoCambio_Valor_Compra.Name = "Txt_TipoCambio_Valor_Compra"
        Me.Txt_TipoCambio_Valor_Compra.Size = New System.Drawing.Size(32, 20)
        Me.Txt_TipoCambio_Valor_Compra.TabIndex = 189
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.BackColor = System.Drawing.Color.LightGray
        Me.txtTipoCambio.Enabled = False
        Me.txtTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCambio.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtTipoCambio.Location = New System.Drawing.Point(75, 38)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Size = New System.Drawing.Size(80, 16)
        Me.txtTipoCambio.TabIndex = 70
        Me.txtTipoCambio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(288, 232)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Fecha"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_Anulada
        '
        Me.Label_Anulada.BackColor = System.Drawing.Color.White
        Me.Label_Anulada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Anulada.ForeColor = System.Drawing.Color.Red
        Me.Label_Anulada.Location = New System.Drawing.Point(312, 128)
        Me.Label_Anulada.Name = "Label_Anulada"
        Me.Label_Anulada.Size = New System.Drawing.Size(96, 24)
        Me.Label_Anulada.TabIndex = 191
        Me.Label_Anulada.Text = "ANULADA"
        Me.Label_Anulada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_Anulada.Visible = False
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label49.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label49.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label49.Location = New System.Drawing.Point(272, 24)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(16, 17)
        Me.Label49.TabIndex = 191
        Me.Label49.Text = "%"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label49.Visible = False
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(192, 64)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(16, 17)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "%ç"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtSExcento
        '
        Me.txtSExcento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSExcento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle.SubTotalExcento", True))
        Me.txtSExcento.ForeColor = System.Drawing.Color.Blue
        Me.txtSExcento.Location = New System.Drawing.Point(168, 104)
        Me.txtSExcento.Name = "txtSExcento"
        Me.txtSExcento.Size = New System.Drawing.Size(48, 13)
        Me.txtSExcento.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(304, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 12)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "días"
        Me.Label10.Visible = False
        '
        'txtDiasPlazo
        '
        Me.txtDiasPlazo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDiasPlazo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDiasPlazo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtDiasPlazo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDiasPlazo.Location = New System.Drawing.Point(304, 72)
        Me.txtDiasPlazo.Name = "txtDiasPlazo"
        Me.txtDiasPlazo.Size = New System.Drawing.Size(32, 12)
        Me.txtDiasPlazo.TabIndex = 157
        Me.txtDiasPlazo.Text = "0"
        Me.txtDiasPlazo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.txtDiasPlazo.Visible = False
        '
        'DtVence
        '
        Me.DtVence.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.DtVence.ForeColor = System.Drawing.Color.RoyalBlue
        Me.DtVence.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DtVence.Location = New System.Drawing.Point(280, 280)
        Me.DtVence.Name = "DtVence"
        Me.DtVence.Size = New System.Drawing.Size(136, 12)
        Me.DtVence.TabIndex = 164
        Me.DtVence.Text = "fecha vence"
        Me.DtVence.Visible = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(432, 248)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 14)
        Me.Label12.TabIndex = 163
        Me.Label12.Text = "Tipo Cambio"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtFecha
        '
        Me.dtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dtFecha.ForeColor = System.Drawing.Color.RoyalBlue
        Me.dtFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtFecha.Location = New System.Drawing.Point(288, 248)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(136, 12)
        Me.dtFecha.TabIndex = 162
        Me.dtFecha.Text = "fecha factura"
        '
        'txtSubtotalExcento
        '
        Me.txtSubtotalExcento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle.SubTotalExcento", True))
        Me.txtSubtotalExcento.Location = New System.Drawing.Point(232, 72)
        Me.txtSubtotalExcento.Name = "txtSubtotalExcento"
        Me.txtSubtotalExcento.Size = New System.Drawing.Size(40, 20)
        Me.txtSubtotalExcento.TabIndex = 217
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.White
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label43.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label43.Location = New System.Drawing.Point(184, 176)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(16, 18)
        Me.Label43.TabIndex = 39
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label26.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label26.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label26.Location = New System.Drawing.Point(168, 264)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 16)
        Me.Label26.TabIndex = 76
        Me.Label26.Text = "Vence"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label26.Visible = False
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.White
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label29.Location = New System.Drawing.Point(143, 184)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(16, 18)
        Me.Label29.TabIndex = 36
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Txtdireccion
        '
        Me.Txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtdireccion.ForeColor = System.Drawing.Color.Blue
        Me.Txtdireccion.Location = New System.Drawing.Point(0, 240)
        Me.Txtdireccion.Name = "Txtdireccion"
        Me.Txtdireccion.Size = New System.Drawing.Size(304, 13)
        Me.Txtdireccion.TabIndex = 3
        '
        'GroupBox1_1
        '
        Me.GroupBox1_1.BackColor = System.Drawing.Color.White
        Me.GroupBox1_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1_1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1_1.Location = New System.Drawing.Point(40, 136)
        Me.GroupBox1_1.Name = "GroupBox1_1"
        Me.GroupBox1_1.Size = New System.Drawing.Size(138, 28)
        Me.GroupBox1_1.TabIndex = 0
        Me.GroupBox1_1.TabStop = False
        Me.GroupBox1_1.Text = "Condiciones de Factura"
        '
        'txtNombreArt
        '
        Me.txtNombreArt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle.Descripcion", True))
        Me.txtNombreArt.EditValue = ""
        Me.txtNombreArt.Location = New System.Drawing.Point(12, 94)
        Me.txtNombreArt.Name = "txtNombreArt"
        '
        '
        '
        Me.txtNombreArt.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.Silver, System.Drawing.Color.Blue)
        Me.txtNombreArt.Size = New System.Drawing.Size(641, 19)
        Me.txtNombreArt.TabIndex = 232
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(9, 397)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 12)
        Me.Label11.TabIndex = 234
        Me.Label11.Text = "Observaciones"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds_Apartado1, "Apartados.Observaciones", True))
        Me.TextBox1.ForeColor = System.Drawing.Color.Blue
        Me.TextBox1.Location = New System.Drawing.Point(12, 412)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(641, 29)
        Me.TextBox1.TabIndex = 233
        '
        'lbconsecutivo
        '
        Me.lbconsecutivo.BackColor = System.Drawing.Color.Transparent
        Me.lbconsecutivo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds_Apartado1, "Apartados.Id_Apartado", True))
        Me.lbconsecutivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbconsecutivo.ForeColor = System.Drawing.Color.Red
        Me.lbconsecutivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbconsecutivo.Location = New System.Drawing.Point(114, 12)
        Me.lbconsecutivo.Name = "lbconsecutivo"
        Me.lbconsecutivo.Size = New System.Drawing.Size(37, 20)
        Me.lbconsecutivo.TabIndex = 235
        Me.lbconsecutivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(728, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 48)
        Me.Button1.TabIndex = 236
        Me.Button1.Text = "Abonos"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Silver
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(1, 446)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(895, 14)
        Me.Label14.TabIndex = 237
        Me.Label14.Text = "F1:Buscar    |   F2: Registrar        |     F3: Buscar Apart.      |      F6:Modi" & _
            "ficar      |      F11:Abono   |    Supr: Eliminar  |  Insert: Agregar"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCedulaUsuario
        '
        Me.txtCedulaUsuario.BackColor = System.Drawing.Color.Transparent
        Me.txtCedulaUsuario.Enabled = False
        Me.txtCedulaUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtCedulaUsuario.Location = New System.Drawing.Point(456, 452)
        Me.txtCedulaUsuario.Name = "txtCedulaUsuario"
        Me.txtCedulaUsuario.Size = New System.Drawing.Size(72, 13)
        Me.txtCedulaUsuario.TabIndex = 238
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCerrar.Location = New System.Drawing.Point(15, 176)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(48, 23)
        Me.ButtonCerrar.TabIndex = 239
        Me.ButtonCerrar.Text = "Cerrar"
        Me.ButtonCerrar.UseVisualStyleBackColor = True
        Me.ButtonCerrar.Visible = False
        '
        'LAnulado
        '
        Me.LAnulado.AutoSize = True
        Me.LAnulado.BackColor = System.Drawing.Color.Transparent
        Me.LAnulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAnulado.ForeColor = System.Drawing.Color.Red
        Me.LAnulado.Location = New System.Drawing.Point(669, 94)
        Me.LAnulado.Name = "LAnulado"
        Me.LAnulado.Size = New System.Drawing.Size(94, 20)
        Me.LAnulado.TabIndex = 240
        Me.LAnulado.Text = "ANULADO"
        Me.LAnulado.Visible = False
        '
        'LCancelado
        '
        Me.LCancelado.AutoSize = True
        Me.LCancelado.BackColor = System.Drawing.Color.Transparent
        Me.LCancelado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCancelado.ForeColor = System.Drawing.Color.Red
        Me.LCancelado.Location = New System.Drawing.Point(772, 94)
        Me.LCancelado.Name = "LCancelado"
        Me.LCancelado.Size = New System.Drawing.Size(117, 20)
        Me.LCancelado.TabIndex = 241
        Me.LCancelado.Text = "CANCELADO"
        Me.LCancelado.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "1456265011_file-empty.png")
        Me.ImageList1.Images.SetKeyName(1, "1437535991_search.png")
        Me.ImageList1.Images.SetKeyName(2, "1437535964_floppy.png")
        Me.ImageList1.Images.SetKeyName(3, "1437535982_sign-error.png")
        Me.ImageList1.Images.SetKeyName(4, "1438571976_shine_9.png")
        Me.ImageList1.Images.SetKeyName(5, "edit_image-24.png")
        Me.ImageList1.Images.SetKeyName(6, "1456265147_Cancel.png")
        Me.ImageList1.Images.SetKeyName(7, "1438571976_shine_9.png")
        Me.ImageList1.Images.SetKeyName(8, "1456265434_player_stop.png")
        '
        'Apartados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonCerrar
        Me.ClientSize = New System.Drawing.Size(894, 526)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.LCancelado)
        Me.Controls.Add(Me.txtImpVentaT)
        Me.Controls.Add(Me.LAnulado)
        Me.Controls.Add(Me.txtDescuentoT)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtSubtotalT)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.lbconsecutivo)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.txtNombreArt)
        Me.Controls.Add(Me.GroupBox3_oLD)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.DT_actual)
        Me.Controls.Add(Me.Dt_Vence)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCedulaUsuario)
        Me.Controls.Add(Me.ButtonCerrar)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.TxtCodArticulo)
        Me.Name = "Apartados"
        Me.Text = "Apartados"
        Me.Controls.SetChildIndex(Me.TxtCodArticulo, 0)
        Me.Controls.SetChildIndex(Me.SimpleButton1, 0)
        Me.Controls.SetChildIndex(Me.ButtonCerrar, 0)
        Me.Controls.SetChildIndex(Me.txtCedulaUsuario, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Dt_Vence, 0)
        Me.Controls.SetChildIndex(Me.DT_actual, 0)
        Me.Controls.SetChildIndex(Me.GroupBox6, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Label48, 0)
        Me.Controls.SetChildIndex(Me.txtUsuario, 0)
        Me.Controls.SetChildIndex(Me.txtNombreUsuario, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3_oLD, 0)
        Me.Controls.SetChildIndex(Me.txtNombreArt, 0)
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        Me.Controls.SetChildIndex(Me.TxtTotal, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.Label25, 0)
        Me.Controls.SetChildIndex(Me.Label22, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.Label23, 0)
        Me.Controls.SetChildIndex(Me.lbconsecutivo, 0)
        Me.Controls.SetChildIndex(Me.Label24, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.txtSubtotalT, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.txtDescuentoT, 0)
        Me.Controls.SetChildIndex(Me.LAnulado, 0)
        Me.Controls.SetChildIndex(Me.txtImpVentaT, 0)
        Me.Controls.SetChildIndex(Me.LCancelado, 0)
        Me.Controls.SetChildIndex(Me.SimpleButton2, 0)
        CType(Me.Ds_Apartado1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.txt_articulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalArt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExistencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubtotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCodArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImpVentaT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuentoT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubtotalT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3_oLD.ResumeLayout(False)
        Me.GroupBox3_oLD.PerformLayout()
        CType(Me.txtImpVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUtilidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label46.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lb_SubExento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lb_Subgravado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreArt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Dt_Vence As System.Windows.Forms.DateTimePicker
    Friend WithEvents DT_actual As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto_Descuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto_Impuesto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubtotalGravado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubTotalExcento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.Panel
    Friend WithEvents txtTotalArt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtExistencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtPrecioUnit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtCodArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtSubtotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDescuento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Ad_Apartados As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ad_detalleapartado As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Ds_Apartado1 As Ds_Apartado
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Ad_usuarios As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtImpVentaT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescuentoT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSubtotalT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Adapter_Moneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GroupBox1 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3_oLD As System.Windows.Forms.GroupBox
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Combo_Encargado As System.Windows.Forms.ComboBox
    Friend WithEvents Text_Ficticio As System.Windows.Forms.TextBox
    Friend WithEvents fecha_vence As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtUtilidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFlete As System.Windows.Forms.TextBox
    Friend WithEvents txtSGravado As System.Windows.Forms.TextBox
    Friend WithEvents TxtMaxdescuento As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTelefono As ValidText.ValidText
    Friend WithEvents Lb_SubExento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Lb_Subgravado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOtros As System.Windows.Forms.TextBox
    Friend WithEvents TxtprecioCosto As System.Windows.Forms.TextBox
    Friend WithEvents txtmontodescuento As System.Windows.Forms.TextBox
    Friend WithEvents txtSubtotalGravado As System.Windows.Forms.TextBox
    Friend WithEvents txtSubFamilia As System.Windows.Forms.TextBox
    Friend WithEvents txtMontoImpuesto As System.Windows.Forms.TextBox
    Friend WithEvents txtCostoBase As System.Windows.Forms.TextBox
    Friend WithEvents CkEntregado As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Txtcodmoneda_Venta As System.Windows.Forms.TextBox
    Friend WithEvents Txt_TipoCambio_Valor_Compra As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoCambio As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label_Anulada As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtSExcento As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDiasPlazo As System.Windows.Forms.Label
    Friend WithEvents DtVence As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtFecha As System.Windows.Forms.Label
    Friend WithEvents txtSubtotalExcento As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1_1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombreArt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtImpVenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lbconsecutivo As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCedulaUsuario As System.Windows.Forms.Label
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ButtonCerrar As System.Windows.Forms.Button
    Friend WithEvents LAnulado As System.Windows.Forms.Label
    Friend WithEvents LCancelado As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txt_articulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colCodArticulo As DevExpress.XtraGrid.Columns.GridColumn
End Class
