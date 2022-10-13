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
        Me.btnEstadoCuenta = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnDevoluciones = New System.Windows.Forms.Button()
        Me.btnOpcionesdePago = New System.Windows.Forms.Button()
        Me.ckTodos = New System.Windows.Forms.CheckBox()
        Me.ckSoloPendientes = New System.Windows.Forms.CheckBox()
        Me.btnSincronizacion = New System.Windows.Forms.Button()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnGenerarFacturas = New System.Windows.Forms.Button()
        Me.btnApertura = New System.Windows.Forms.Button()
        Me.btnArqueo = New System.Windows.Forms.Button()
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
        Me.ToolBar1.Location = New System.Drawing.Point(-1, 551)
        Me.ToolBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ToolBar1.Size = New System.Drawing.Size(1039, 65)
        Me.ToolBar1.Visible = False
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.Location = New System.Drawing.Point(1393, 694)
        Me.DataNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.DataNavigator.Size = New System.Drawing.Size(179, 26)
        '
        'TituloModulo
        '
        Me.TituloModulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TituloModulo.Size = New System.Drawing.Size(1184, 39)
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
        Me.viewDatos.Location = New System.Drawing.Point(12, 167)
        Me.viewDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.viewDatos.MultiSelect = False
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.RowTemplate.Height = 27
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(1152, 436)
        Me.viewDatos.TabIndex = 71
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(13, 62)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(413, 22)
        Me.txtCliente.TabIndex = 72
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(13, 43)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(415, 20)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "Cliente"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(436, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(446, 20)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Mascota"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMascota
        '
        Me.txtMascota.Location = New System.Drawing.Point(436, 62)
        Me.txtMascota.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMascota.Name = "txtMascota"
        Me.txtMascota.Size = New System.Drawing.Size(444, 22)
        Me.txtMascota.TabIndex = 74
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(13, 116)
        Me.dtpDesde.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(204, 22)
        Me.dtpDesde.TabIndex = 76
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 20)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Desde"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(223, 97)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 20)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Hasta"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(223, 116)
        Me.dtpHasta.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(204, 22)
        Me.dtpHasta.TabIndex = 79
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Panel1.Location = New System.Drawing.Point(4, 52)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1179, 607)
        Me.Panel1.TabIndex = 3
        '
        'btnEstadoCuenta
        '
        Me.btnEstadoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEstadoCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEstadoCuenta.Location = New System.Drawing.Point(596, 5)
        Me.btnEstadoCuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEstadoCuenta.Name = "btnEstadoCuenta"
        Me.btnEstadoCuenta.Size = New System.Drawing.Size(138, 30)
        Me.btnEstadoCuenta.TabIndex = 90
        Me.btnEstadoCuenta.Text = "Cuentas Albaran"
        Me.btnEstadoCuenta.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(304, 4)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 30)
        Me.Button1.TabIndex = 89
        Me.Button1.Text = "Depositos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(450, 5)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(138, 30)
        Me.Button4.TabIndex = 88
        Me.Button4.Text = "Abonos CxC"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(742, 5)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 30)
        Me.Button3.TabIndex = 87
        Me.Button3.Text = "Devoluciones"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnDevoluciones
        '
        Me.btnDevoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDevoluciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDevoluciones.Location = New System.Drawing.Point(158, 4)
        Me.btnDevoluciones.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDevoluciones.Name = "btnDevoluciones"
        Me.btnDevoluciones.Size = New System.Drawing.Size(138, 30)
        Me.btnDevoluciones.TabIndex = 86
        Me.btnDevoluciones.Text = "Anticipos Clientes"
        Me.btnDevoluciones.UseVisualStyleBackColor = True
        '
        'btnOpcionesdePago
        '
        Me.btnOpcionesdePago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpcionesdePago.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpcionesdePago.Location = New System.Drawing.Point(12, 4)
        Me.btnOpcionesdePago.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOpcionesdePago.Name = "btnOpcionesdePago"
        Me.btnOpcionesdePago.Size = New System.Drawing.Size(138, 30)
        Me.btnOpcionesdePago.TabIndex = 85
        Me.btnOpcionesdePago.Text = "Opciones de Pago"
        Me.btnOpcionesdePago.UseVisualStyleBackColor = True
        '
        'ckTodos
        '
        Me.ckTodos.AutoSize = True
        Me.ckTodos.Checked = True
        Me.ckTodos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckTodos.Location = New System.Drawing.Point(893, 142)
        Me.ckTodos.Margin = New System.Windows.Forms.Padding(4)
        Me.ckTodos.Name = "ckTodos"
        Me.ckTodos.Size = New System.Drawing.Size(118, 21)
        Me.ckTodos.TabIndex = 84
        Me.ckTodos.Text = "Marcar Todos"
        Me.ckTodos.UseVisualStyleBackColor = True
        '
        'ckSoloPendientes
        '
        Me.ckSoloPendientes.AutoSize = True
        Me.ckSoloPendientes.Checked = True
        Me.ckSoloPendientes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckSoloPendientes.Location = New System.Drawing.Point(436, 116)
        Me.ckSoloPendientes.Margin = New System.Windows.Forms.Padding(4)
        Me.ckSoloPendientes.Name = "ckSoloPendientes"
        Me.ckSoloPendientes.Size = New System.Drawing.Size(330, 21)
        Me.ckSoloPendientes.TabIndex = 82
        Me.ckSoloPendientes.Text = "Solo Mostrar Albaranes Pendientes de Facturar"
        Me.ckSoloPendientes.UseVisualStyleBackColor = True
        '
        'btnSincronizacion
        '
        Me.btnSincronizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSincronizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSincronizacion.Location = New System.Drawing.Point(893, 43)
        Me.btnSincronizacion.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSincronizacion.Name = "btnSincronizacion"
        Me.btnSincronizacion.Size = New System.Drawing.Size(234, 98)
        Me.btnSincronizacion.TabIndex = 81
        Me.btnSincronizacion.Text = "Obtener Datos"
        Me.btnSincronizacion.UseVisualStyleBackColor = True
        '
        'txtClave
        '
        Me.txtClave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtClave.Location = New System.Drawing.Point(17, 682)
        Me.txtClave.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(208, 22)
        Me.txtClave.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(17, 662)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(209, 20)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Ingrese la Contraseña"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNombreUsuario.Location = New System.Drawing.Point(235, 682)
        Me.txtNombreUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(649, 22)
        Me.txtNombreUsuario.TabIndex = 2
        Me.txtNombreUsuario.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(235, 662)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(650, 20)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Usuario"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGenerarFacturas
        '
        Me.btnGenerarFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerarFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarFacturas.Location = New System.Drawing.Point(897, 662)
        Me.btnGenerarFacturas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGenerarFacturas.Name = "btnGenerarFacturas"
        Me.btnGenerarFacturas.Size = New System.Drawing.Size(263, 44)
        Me.btnGenerarFacturas.TabIndex = 83
        Me.btnGenerarFacturas.Text = "Generar Facturas"
        Me.btnGenerarFacturas.UseVisualStyleBackColor = True
        '
        'btnApertura
        '
        Me.btnApertura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApertura.Location = New System.Drawing.Point(888, 5)
        Me.btnApertura.Margin = New System.Windows.Forms.Padding(4)
        Me.btnApertura.Name = "btnApertura"
        Me.btnApertura.Size = New System.Drawing.Size(138, 30)
        Me.btnApertura.TabIndex = 91
        Me.btnApertura.Text = "Apertura Caja"
        Me.btnApertura.UseVisualStyleBackColor = True
        '
        'btnArqueo
        '
        Me.btnArqueo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArqueo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArqueo.Location = New System.Drawing.Point(1030, 4)
        Me.btnArqueo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnArqueo.Name = "btnArqueo"
        Me.btnArqueo.Size = New System.Drawing.Size(138, 30)
        Me.btnArqueo.TabIndex = 92
        Me.btnArqueo.Text = "Arqueo Caja"
        Me.btnArqueo.UseVisualStyleBackColor = True
        '
        'frmConsultaAlbaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 706)
        Me.Controls.Add(Me.btnGenerarFacturas)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = True
        Me.MinimumSize = New System.Drawing.Size(1113, 630)
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
End Class
