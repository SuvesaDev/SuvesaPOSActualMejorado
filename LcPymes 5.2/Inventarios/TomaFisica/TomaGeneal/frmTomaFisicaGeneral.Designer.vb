<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTomaFisicaGeneral
    Inherits System.Windows.Forms.Form

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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAnular = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAjustar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnArticulosSinContar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnCargarPretoma = New System.Windows.Forms.Button()
        Me.txtDescripcionProducto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCantidadSistema = New System.Windows.Forms.TextBox()
        Me.txtDiferencia = New System.Windows.Forms.TextBox()
        Me.txtCantidadContada = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnIncluirLinea = New System.Windows.Forms.Button()
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.txtTotalArticulos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtArticulosContados = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtArticulosnoContados = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSaldoAjuste = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAjusteSalida = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAjusteEntrada = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblAnulada = New System.Windows.Forms.Label()
        Me.lblAjustado = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.ToolStripSeparator1, Me.btnGuardar, Me.ToolStripSeparator2, Me.btnBuscar, Me.ToolStripSeparator3, Me.btnAnular, Me.ToolStripSeparator5, Me.btnImprimir, Me.ToolStripSeparator6, Me.btnAjustar, Me.ToolStripSeparator4, Me.btnArticulosSinContar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(809, 54)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.LcPymes_5._2.My.Resources.Resources.page
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(78, 51)
        Me.btnNuevo.Text = "Nueva Toma"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 54)
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.LcPymes_5._2.My.Resources.Resources.page_save
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(86, 51)
        Me.btnGuardar.Text = "Guardar Toma"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 54)
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.LcPymes_5._2.My.Resources.Resources.page_find1
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(79, 51)
        Me.btnBuscar.Text = "Buscar Toma"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 54)
        '
        'btnAnular
        '
        Me.btnAnular.Image = Global.LcPymes_5._2.My.Resources.Resources.page_delete
        Me.btnAnular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(79, 51)
        Me.btnAnular.Text = "Anular Toma"
        Me.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 54)
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.LcPymes_5._2.My.Resources.Resources.printer
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(90, 51)
        Me.btnImprimir.Text = "Imprimir Toma"
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 54)
        '
        'btnAjustar
        '
        Me.btnAjustar.Image = Global.LcPymes_5._2.My.Resources.Resources.page_refresh
        Me.btnAjustar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAjustar.Name = "btnAjustar"
        Me.btnAjustar.Size = New System.Drawing.Size(81, 51)
        Me.btnAjustar.Text = "Ajustar Toma"
        Me.btnAjustar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 54)
        '
        'btnArticulosSinContar
        '
        Me.btnArticulosSinContar.Image = Global.LcPymes_5._2.My.Resources.Resources.report_magnify
        Me.btnArticulosSinContar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnArticulosSinContar.Name = "btnArticulosSinContar"
        Me.btnArticulosSinContar.Size = New System.Drawing.Size(115, 51)
        Me.btnArticulosSinContar.Text = "Articulos sin Contar"
        Me.btnArticulosSinContar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.btnCargarPretoma)
        Me.GroupBox1.Controls.Add(Me.txtDescripcionProducto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnBuscarProducto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCantidadSistema)
        Me.GroupBox1.Controls.Add(Me.txtDiferencia)
        Me.GroupBox1.Controls.Add(Me.txtCantidadContada)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnIncluirLinea)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(801, 105)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(15, 75)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(173, 23)
        Me.txtCodigo.TabIndex = 1
        '
        'btnCargarPretoma
        '
        Me.btnCargarPretoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargarPretoma.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarPretoma.Location = New System.Drawing.Point(683, 14)
        Me.btnCargarPretoma.Name = "btnCargarPretoma"
        Me.btnCargarPretoma.Size = New System.Drawing.Size(113, 87)
        Me.btnCargarPretoma.TabIndex = 12
        Me.btnCargarPretoma.Text = "Cargar PreToma"
        Me.btnCargarPretoma.UseVisualStyleBackColor = True
        '
        'txtDescripcionProducto
        '
        Me.txtDescripcionProducto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionProducto.Location = New System.Drawing.Point(15, 31)
        Me.txtDescripcionProducto.Name = "txtDescripcionProducto"
        Me.txtDescripcionProducto.ReadOnly = True
        Me.txtDescripcionProducto.Size = New System.Drawing.Size(537, 23)
        Me.txtDescripcionProducto.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo del Producto :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(334, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cantidad Sistema :"
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.Image = Global.LcPymes_5._2.My.Resources.Resources.page_find
        Me.btnBuscarProducto.Location = New System.Drawing.Point(190, 75)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(28, 24)
        Me.btnBuscarProducto.TabIndex = 10
        Me.btnBuscarProducto.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Descripcion del Producto :"
        '
        'txtCantidadSistema
        '
        Me.txtCantidadSistema.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadSistema.Location = New System.Drawing.Point(337, 76)
        Me.txtCantidadSistema.Name = "txtCantidadSistema"
        Me.txtCantidadSistema.ReadOnly = True
        Me.txtCantidadSistema.Size = New System.Drawing.Size(100, 23)
        Me.txtCantidadSistema.TabIndex = 7
        Me.txtCantidadSistema.Text = "0"
        Me.txtCantidadSistema.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDiferencia
        '
        Me.txtDiferencia.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferencia.Location = New System.Drawing.Point(452, 75)
        Me.txtDiferencia.Name = "txtDiferencia"
        Me.txtDiferencia.ReadOnly = True
        Me.txtDiferencia.Size = New System.Drawing.Size(100, 23)
        Me.txtDiferencia.TabIndex = 9
        Me.txtDiferencia.Text = "0"
        Me.txtDiferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCantidadContada
        '
        Me.txtCantidadContada.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadContada.Location = New System.Drawing.Point(224, 76)
        Me.txtCantidadContada.Name = "txtCantidadContada"
        Me.txtCantidadContada.Size = New System.Drawing.Size(100, 23)
        Me.txtCantidadContada.TabIndex = 4
        Me.txtCantidadContada.Text = "0"
        Me.txtCantidadContada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cantidad Contada :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(449, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Diferencia :"
        '
        'btnIncluirLinea
        '
        Me.btnIncluirLinea.Enabled = False
        Me.btnIncluirLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncluirLinea.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncluirLinea.Location = New System.Drawing.Point(557, 14)
        Me.btnIncluirLinea.Name = "btnIncluirLinea"
        Me.btnIncluirLinea.Size = New System.Drawing.Size(121, 87)
        Me.btnIncluirLinea.TabIndex = 11
        Me.btnIncluirLinea.Text = "Contar"
        Me.btnIncluirLinea.UseVisualStyleBackColor = True
        '
        'viewDatos
        '
        Me.viewDatos.AllowUserToAddRows = False
        Me.viewDatos.AllowUserToDeleteRows = False
        Me.viewDatos.AllowUserToResizeColumns = False
        Me.viewDatos.AllowUserToResizeRows = False
        Me.viewDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.viewDatos.BackgroundColor = System.Drawing.Color.White
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Location = New System.Drawing.Point(4, 164)
        Me.viewDatos.MultiSelect = False
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.ReadOnly = True
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(800, 276)
        Me.viewDatos.TabIndex = 2
        '
        'txtTotalArticulos
        '
        Me.txtTotalArticulos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalArticulos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalArticulos.Location = New System.Drawing.Point(4, 457)
        Me.txtTotalArticulos.Name = "txtTotalArticulos"
        Me.txtTotalArticulos.ReadOnly = True
        Me.txtTotalArticulos.Size = New System.Drawing.Size(115, 23)
        Me.txtTotalArticulos.TabIndex = 12
        Me.txtTotalArticulos.Text = "0"
        Me.txtTotalArticulos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1, 444)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Cantidad Articulos"
        '
        'txtArticulosContados
        '
        Me.txtArticulosContados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtArticulosContados.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArticulosContados.Location = New System.Drawing.Point(123, 457)
        Me.txtArticulosContados.Name = "txtArticulosContados"
        Me.txtArticulosContados.ReadOnly = True
        Me.txtArticulosContados.Size = New System.Drawing.Size(115, 23)
        Me.txtArticulosContados.TabIndex = 14
        Me.txtArticulosContados.Text = "0"
        Me.txtArticulosContados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(120, 444)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Articulos Contados"
        '
        'txtArticulosnoContados
        '
        Me.txtArticulosnoContados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtArticulosnoContados.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArticulosnoContados.Location = New System.Drawing.Point(239, 457)
        Me.txtArticulosnoContados.Name = "txtArticulosnoContados"
        Me.txtArticulosnoContados.ReadOnly = True
        Me.txtArticulosnoContados.Size = New System.Drawing.Size(115, 23)
        Me.txtArticulosnoContados.TabIndex = 16
        Me.txtArticulosnoContados.Text = "0"
        Me.txtArticulosnoContados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(236, 444)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Articulos no Contados"
        '
        'txtSaldoAjuste
        '
        Me.txtSaldoAjuste.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSaldoAjuste.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoAjuste.Location = New System.Drawing.Point(687, 457)
        Me.txtSaldoAjuste.Name = "txtSaldoAjuste"
        Me.txtSaldoAjuste.ReadOnly = True
        Me.txtSaldoAjuste.Size = New System.Drawing.Size(115, 23)
        Me.txtSaldoAjuste.TabIndex = 22
        Me.txtSaldoAjuste.Text = "0"
        Me.txtSaldoAjuste.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(684, 444)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Saldo Ajustes"
        '
        'txtAjusteSalida
        '
        Me.txtAjusteSalida.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAjusteSalida.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAjusteSalida.Location = New System.Drawing.Point(571, 457)
        Me.txtAjusteSalida.Name = "txtAjusteSalida"
        Me.txtAjusteSalida.ReadOnly = True
        Me.txtAjusteSalida.Size = New System.Drawing.Size(115, 23)
        Me.txtAjusteSalida.TabIndex = 20
        Me.txtAjusteSalida.Text = "0"
        Me.txtAjusteSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(568, 444)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Ajustes Salida"
        '
        'txtAjusteEntrada
        '
        Me.txtAjusteEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAjusteEntrada.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAjusteEntrada.Location = New System.Drawing.Point(452, 457)
        Me.txtAjusteEntrada.Name = "txtAjusteEntrada"
        Me.txtAjusteEntrada.ReadOnly = True
        Me.txtAjusteEntrada.Size = New System.Drawing.Size(115, 23)
        Me.txtAjusteEntrada.TabIndex = 18
        Me.txtAjusteEntrada.Text = "0"
        Me.txtAjusteEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(449, 444)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Ajustes Entrada"
        '
        'lblAnulada
        '
        Me.lblAnulada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAnulada.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnulada.ForeColor = System.Drawing.Color.Red
        Me.lblAnulada.Location = New System.Drawing.Point(11, 356)
        Me.lblAnulada.Name = "lblAnulada"
        Me.lblAnulada.Size = New System.Drawing.Size(786, 47)
        Me.lblAnulada.TabIndex = 23
        Me.lblAnulada.Text = "Toma Anulada"
        Me.lblAnulada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAnulada.Visible = False
        '
        'lblAjustado
        '
        Me.lblAjustado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAjustado.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAjustado.ForeColor = System.Drawing.Color.Green
        Me.lblAjustado.Location = New System.Drawing.Point(11, 309)
        Me.lblAjustado.Name = "lblAjustado"
        Me.lblAjustado.Size = New System.Drawing.Size(786, 47)
        Me.lblAjustado.TabIndex = 24
        Me.lblAjustado.Text = "Toma Ajustada"
        Me.lblAjustado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAjustado.Visible = False
        '
        'frmTomaFisicaGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 482)
        Me.Controls.Add(Me.lblAjustado)
        Me.Controls.Add(Me.lblAnulada)
        Me.Controls.Add(Me.txtSaldoAjuste)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtAjusteSalida)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtAjusteEntrada)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtArticulosnoContados)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtArticulosContados)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotalArticulos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.viewDatos)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmTomaFisicaGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Toma Fisica General"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAnular As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAjustar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCantidadContada As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionProducto As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidadSistema As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDiferencia As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarProducto As System.Windows.Forms.Button
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents txtTotalArticulos As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtArticulosContados As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtArticulosnoContados As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoAjuste As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAjusteSalida As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAjusteEntrada As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnIncluirLinea As System.Windows.Forms.Button
    Friend WithEvents btnCargarPretoma As System.Windows.Forms.Button
    Friend WithEvents lblAnulada As System.Windows.Forms.Label
    Friend WithEvents lblAjustado As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnArticulosSinContar As System.Windows.Forms.ToolStripButton
End Class
