<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaAlbaran
    Inherits LcPymes_5._2.FrmPlantilla

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaAlbaran))
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMascota = New System.Windows.Forms.TextBox()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPedidoWeb = New System.Windows.Forms.Button()
        Me.ckFiltrarxFecha = New System.Windows.Forms.CheckBox()
        Me.ckExtranjero = New System.Windows.Forms.CheckBox()
        Me.btnArqueo = New System.Windows.Forms.Button()
        Me.btnApertura = New System.Windows.Forms.Button()
        Me.btnEstadoCuenta = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnDevoluciones = New System.Windows.Forms.Button()
        Me.btnOpcionesdePago = New System.Windows.Forms.Button()
        Me.ckTodos = New System.Windows.Forms.CheckBox()
        Me.ckSoloPendientes = New System.Windows.Forms.CheckBox()
        Me.btnSincronizacion = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnGenerarFacturas = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.ToolBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.Location = New System.Drawing.Point(-1, 447)
        Me.ToolBar1.Size = New System.Drawing.Size(779, 53)
        Me.ToolBar1.Visible = False
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.Location = New System.Drawing.Point(1232, 563)
        '
        'TituloModulo
        '
        Me.TituloModulo.Size = New System.Drawing.Size(1075, 32)
        Me.TituloModulo.Text = "Consulta Albaranes"
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
        Me.viewDatos.Location = New System.Drawing.Point(9, 136)
        Me.viewDatos.MultiSelect = False
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.RowTemplate.Height = 26
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(1051, 353)
        Me.viewDatos.TabIndex = 71
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(10, 50)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(311, 20)
        Me.txtCliente.TabIndex = 72
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(10, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(311, 16)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "Cliente"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(327, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 16)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Cedula"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMascota
        '
        Me.txtMascota.Location = New System.Drawing.Point(327, 50)
        Me.txtMascota.Name = "txtMascota"
        Me.txtMascota.Size = New System.Drawing.Size(334, 20)
        Me.txtMascota.TabIndex = 74
        '
        'dtpDesde
        '
        Me.dtpDesde.Enabled = False
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(10, 94)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(154, 20)
        Me.dtpDesde.TabIndex = 76
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 16)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Desde"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(167, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 16)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Hasta"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpHasta
        '
        Me.dtpHasta.Enabled = False
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(167, 94)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(154, 20)
        Me.dtpHasta.TabIndex = 79
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.btnPedidoWeb)
        Me.Panel1.Controls.Add(Me.ckFiltrarxFecha)
        Me.Panel1.Controls.Add(Me.ckExtranjero)
        Me.Panel1.Controls.Add(Me.btnArqueo)
        Me.Panel1.Controls.Add(Me.btnApertura)
        Me.Panel1.Controls.Add(Me.btnEstadoCuenta)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.btnDevoluciones)
        Me.Panel1.Controls.Add(Me.btnOpcionesdePago)
        Me.Panel1.Controls.Add(Me.ckTodos)
        Me.Panel1.Controls.Add(Me.ckSoloPendientes)
        Me.Panel1.Controls.Add(Me.btnSincronizacion)
        Me.Panel1.Controls.Add(Me.viewDatos)
        Me.Panel1.Controls.Add(Me.dtpHasta)
        Me.Panel1.Controls.Add(Me.txtCliente)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtMascota)
        Me.Panel1.Controls.Add(Me.dtpDesde)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(3, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1071, 492)
        Me.Panel1.TabIndex = 3
        '
        'btnPedidoWeb
        '
        Me.btnPedidoWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPedidoWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPedidoWeb.Location = New System.Drawing.Point(881, 3)
        Me.btnPedidoWeb.Name = "btnPedidoWeb"
        Me.btnPedidoWeb.Size = New System.Drawing.Size(104, 24)
        Me.btnPedidoWeb.TabIndex = 96
        Me.btnPedidoWeb.Text = "Pedido Web"
        Me.btnPedidoWeb.UseVisualStyleBackColor = True
        '
        'ckFiltrarxFecha
        '
        Me.ckFiltrarxFecha.AutoSize = True
        Me.ckFiltrarxFecha.Location = New System.Drawing.Point(327, 80)
        Me.ckFiltrarxFecha.Name = "ckFiltrarxFecha"
        Me.ckFiltrarxFecha.Size = New System.Drawing.Size(102, 17)
        Me.ckFiltrarxFecha.TabIndex = 95
        Me.ckFiltrarxFecha.Text = "Filtrar por Fecha"
        Me.ckFiltrarxFecha.UseVisualStyleBackColor = True
        '
        'ckExtranjero
        '
        Me.ckExtranjero.AutoSize = True
        Me.ckExtranjero.Location = New System.Drawing.Point(757, 115)
        Me.ckExtranjero.Name = "ckExtranjero"
        Me.ckExtranjero.Size = New System.Drawing.Size(73, 17)
        Me.ckExtranjero.TabIndex = 93
        Me.ckExtranjero.Text = "Extranjero"
        Me.ckExtranjero.UseVisualStyleBackColor = True
        '
        'btnArqueo
        '
        Me.btnArqueo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArqueo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArqueo.Location = New System.Drawing.Point(772, 3)
        Me.btnArqueo.Name = "btnArqueo"
        Me.btnArqueo.Size = New System.Drawing.Size(104, 24)
        Me.btnArqueo.TabIndex = 92
        Me.btnArqueo.Text = "Arqueo Caja"
        Me.btnArqueo.UseVisualStyleBackColor = True
        '
        'btnApertura
        '
        Me.btnApertura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApertura.Location = New System.Drawing.Point(666, 4)
        Me.btnApertura.Name = "btnApertura"
        Me.btnApertura.Size = New System.Drawing.Size(104, 24)
        Me.btnApertura.TabIndex = 91
        Me.btnApertura.Text = "Apertura Caja"
        Me.btnApertura.UseVisualStyleBackColor = True
        '
        'btnEstadoCuenta
        '
        Me.btnEstadoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEstadoCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEstadoCuenta.Location = New System.Drawing.Point(447, 4)
        Me.btnEstadoCuenta.Name = "btnEstadoCuenta"
        Me.btnEstadoCuenta.Size = New System.Drawing.Size(104, 24)
        Me.btnEstadoCuenta.TabIndex = 90
        Me.btnEstadoCuenta.Text = "Cuentas Albaran"
        Me.btnEstadoCuenta.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(228, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 24)
        Me.Button1.TabIndex = 89
        Me.Button1.Text = "Depositos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(338, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 24)
        Me.Button4.TabIndex = 88
        Me.Button4.Text = "Abonos CxC"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(556, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 24)
        Me.Button3.TabIndex = 87
        Me.Button3.Text = "Devoluciones"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnDevoluciones
        '
        Me.btnDevoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDevoluciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDevoluciones.Location = New System.Drawing.Point(118, 3)
        Me.btnDevoluciones.Name = "btnDevoluciones"
        Me.btnDevoluciones.Size = New System.Drawing.Size(104, 24)
        Me.btnDevoluciones.TabIndex = 86
        Me.btnDevoluciones.Text = "Anticipos Clientes"
        Me.btnDevoluciones.UseVisualStyleBackColor = True
        '
        'btnOpcionesdePago
        '
        Me.btnOpcionesdePago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpcionesdePago.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpcionesdePago.Location = New System.Drawing.Point(9, 3)
        Me.btnOpcionesdePago.Name = "btnOpcionesdePago"
        Me.btnOpcionesdePago.Size = New System.Drawing.Size(104, 24)
        Me.btnOpcionesdePago.TabIndex = 85
        Me.btnOpcionesdePago.Text = "Opciones de Pago"
        Me.btnOpcionesdePago.UseVisualStyleBackColor = True
        '
        'ckTodos
        '
        Me.ckTodos.AutoSize = True
        Me.ckTodos.Checked = True
        Me.ckTodos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckTodos.Location = New System.Drawing.Point(670, 115)
        Me.ckTodos.Name = "ckTodos"
        Me.ckTodos.Size = New System.Drawing.Size(92, 17)
        Me.ckTodos.TabIndex = 84
        Me.ckTodos.Text = "Marcar Todos"
        Me.ckTodos.UseVisualStyleBackColor = True
        '
        'ckSoloPendientes
        '
        Me.ckSoloPendientes.AutoSize = True
        Me.ckSoloPendientes.Checked = True
        Me.ckSoloPendientes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckSoloPendientes.Location = New System.Drawing.Point(327, 100)
        Me.ckSoloPendientes.Name = "ckSoloPendientes"
        Me.ckSoloPendientes.Size = New System.Drawing.Size(248, 17)
        Me.ckSoloPendientes.TabIndex = 82
        Me.ckSoloPendientes.Text = "Solo Mostrar Albaranes Pendientes de Facturar"
        Me.ckSoloPendientes.UseVisualStyleBackColor = True
        '
        'btnSincronizacion
        '
        Me.btnSincronizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSincronizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSincronizacion.Location = New System.Drawing.Point(670, 35)
        Me.btnSincronizacion.Name = "btnSincronizacion"
        Me.btnSincronizacion.Size = New System.Drawing.Size(176, 80)
        Me.btnSincronizacion.TabIndex = 81
        Me.btnSincronizacion.Text = "Obtener Datos"
        Me.btnSincronizacion.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Location = New System.Drawing.Point(886, 537)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(176, 36)
        Me.btnExportar.TabIndex = 94
        Me.btnExportar.Text = "Sin Facturar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'txtClave
        '
        Me.txtClave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtClave.Location = New System.Drawing.Point(13, 553)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(157, 20)
        Me.txtClave.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 537)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 16)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Ingrese la Contraseña"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNombreUsuario.Location = New System.Drawing.Point(176, 553)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(488, 20)
        Me.txtNombreUsuario.TabIndex = 2
        Me.txtNombreUsuario.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(176, 537)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(488, 16)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Usuario"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGenerarFacturas
        '
        Me.btnGenerarFacturas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerarFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerarFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarFacturas.Location = New System.Drawing.Point(669, 537)
        Me.btnGenerarFacturas.Name = "btnGenerarFacturas"
        Me.btnGenerarFacturas.Size = New System.Drawing.Size(197, 36)
        Me.btnGenerarFacturas.TabIndex = 83
        Me.btnGenerarFacturas.Text = "Generar Facturas"
        Me.btnGenerarFacturas.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'frmConsultaAlbaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 573)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnGenerarFacturas)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.MinimumSize = New System.Drawing.Size(839, 519)
        Me.Name = "frmConsultaAlbaran"
        Me.Text = "Consulta"
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.txtClave, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txtNombreUsuario, 0)
        Me.Controls.SetChildIndex(Me.btnGenerarFacturas, 0)
        Me.Controls.SetChildIndex(Me.btnExportar, 0)
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMascota As System.Windows.Forms.TextBox
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSincronizacion As System.Windows.Forms.Button
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ckSoloPendientes As System.Windows.Forms.CheckBox
    Friend WithEvents btnGenerarFacturas As System.Windows.Forms.Button
    Friend WithEvents ckTodos As CheckBox
    Friend WithEvents btnOpcionesdePago As System.Windows.Forms.Button
    Friend WithEvents btnDevoluciones As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnEstadoCuenta As System.Windows.Forms.Button
    Friend WithEvents btnArqueo As System.Windows.Forms.Button
    Friend WithEvents btnApertura As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ckExtranjero As System.Windows.Forms.CheckBox
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents ckFiltrarxFecha As System.Windows.Forms.CheckBox
    Friend WithEvents btnPedidoWeb As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
