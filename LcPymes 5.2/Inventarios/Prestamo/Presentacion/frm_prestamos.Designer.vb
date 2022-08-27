Imports System.Windows.Forms
Namespace Prestamos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frm_prestamos
        Inherits System.Windows.Forms.Form

        'Form reemplaza a Dispose para limpiar la lista de componentes.
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

        'Requerido por el Diseñador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        'Se puede modificar usando el Diseñador de Windows Forms.  
        'No lo modifique con el editor de código.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.gp_1 = New System.Windows.Forms.GroupBox()
            Me.txtBoletaProveedor = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.cbo_destinatario = New System.Windows.Forms.ComboBox()
            Me.cbo_destino = New System.Windows.Forms.ComboBox()
            Me.lb_id = New System.Windows.Forms.Label()
            Me.rb_salida = New System.Windows.Forms.RadioButton()
            Me.rb_entrada = New System.Windows.Forms.RadioButton()
            Me.dt_fecha = New System.Windows.Forms.DateTimePicker()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txt_boleta = New System.Windows.Forms.TextBox()
            Me.txt_transportista = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.gp_2 = New System.Windows.Forms.GroupBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.txtCodArticulo = New System.Windows.Forms.TextBox()
            Me.txt_cantidad = New System.Windows.Forms.NumericUpDown()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txt_prestamo = New System.Windows.Forms.TextBox()
            Me.bt_agregar = New System.Windows.Forms.Button()
            Me.txt_precio = New System.Windows.Forms.TextBox()
            Me.txt_observaciones = New System.Windows.Forms.TextBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.txt_existencia_act = New System.Windows.Forms.TextBox()
            Me.txt_descripcion = New System.Windows.Forms.TextBox()
            Me.ck_estado = New System.Windows.Forms.CheckBox()
            Me.ck_anulado = New System.Windows.Forms.CheckBox()
            Me.datalistado = New System.Windows.Forms.DataGridView()
            Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.id_prestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txt_codigo = New System.Windows.Forms.TextBox()
            Me.bt_devolucion = New System.Windows.Forms.Button()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.bt_nuevo = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.bt_guardar = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.bt_editar = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
            Me.bt_buscar = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
            Me.bt_eliminar = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
            Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
            Me.lblanulado = New System.Windows.Forms.Label()
            Me.lb_entregado = New System.Windows.Forms.Label()
            Me.Label36 = New System.Windows.Forms.Label()
            Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
            Me.txtUsuario = New System.Windows.Forms.TextBox()
            Me.btnAceptarSolicitud = New System.Windows.Forms.Button()
            Me.btnRechazarSolicitud = New System.Windows.Forms.Button()
            Me.gp_1.SuspendLayout()
            Me.gp_2.SuspendLayout()
            CType(Me.txt_cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ToolStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gp_1
            '
            Me.gp_1.Controls.Add(Me.txtBoletaProveedor)
            Me.gp_1.Controls.Add(Me.Label8)
            Me.gp_1.Controls.Add(Me.cbo_destinatario)
            Me.gp_1.Controls.Add(Me.cbo_destino)
            Me.gp_1.Controls.Add(Me.lb_id)
            Me.gp_1.Controls.Add(Me.rb_salida)
            Me.gp_1.Controls.Add(Me.rb_entrada)
            Me.gp_1.Controls.Add(Me.dt_fecha)
            Me.gp_1.Controls.Add(Me.Label2)
            Me.gp_1.Controls.Add(Me.txt_boleta)
            Me.gp_1.Controls.Add(Me.txt_transportista)
            Me.gp_1.Controls.Add(Me.Label4)
            Me.gp_1.Controls.Add(Me.Label6)
            Me.gp_1.Controls.Add(Me.Label3)
            Me.gp_1.Controls.Add(Me.Label1)
            Me.gp_1.Enabled = False
            Me.gp_1.Location = New System.Drawing.Point(4, 21)
            Me.gp_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.gp_1.Name = "gp_1"
            Me.gp_1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.gp_1.Size = New System.Drawing.Size(659, 124)
            Me.gp_1.TabIndex = 0
            Me.gp_1.TabStop = False
            Me.gp_1.Text = "Datos del traslado"
            '
            'txtBoletaProveedor
            '
            Me.txtBoletaProveedor.Location = New System.Drawing.Point(185, 32)
            Me.txtBoletaProveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.txtBoletaProveedor.MaxLength = 10
            Me.txtBoletaProveedor.Name = "txtBoletaProveedor"
            Me.txtBoletaProveedor.Size = New System.Drawing.Size(95, 20)
            Me.txtBoletaProveedor.TabIndex = 7
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(182, 16)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(93, 16)
            Me.Label8.TabIndex = 6
            Me.Label8.Text = "Boleta Proveedor"
            '
            'cbo_destinatario
            '
            Me.cbo_destinatario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbo_destinatario.FormattingEnabled = True
            Me.cbo_destinatario.Location = New System.Drawing.Point(429, 61)
            Me.cbo_destinatario.Name = "cbo_destinatario"
            Me.cbo_destinatario.Size = New System.Drawing.Size(194, 24)
            Me.cbo_destinatario.TabIndex = 5
            '
            'cbo_destino
            '
            Me.cbo_destino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbo_destino.FormattingEnabled = True
            Me.cbo_destino.Location = New System.Drawing.Point(87, 56)
            Me.cbo_destino.Name = "cbo_destino"
            Me.cbo_destino.Size = New System.Drawing.Size(194, 24)
            Me.cbo_destino.TabIndex = 5
            '
            'lb_id
            '
            Me.lb_id.AutoSize = True
            Me.lb_id.Location = New System.Drawing.Point(633, 17)
            Me.lb_id.Name = "lb_id"
            Me.lb_id.Size = New System.Drawing.Size(14, 16)
            Me.lb_id.TabIndex = 4
            Me.lb_id.Text = "0"
            '
            'rb_salida
            '
            Me.rb_salida.AutoSize = True
            Me.rb_salida.Enabled = False
            Me.rb_salida.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rb_salida.ForeColor = System.Drawing.Color.Red
            Me.rb_salida.Location = New System.Drawing.Point(546, 90)
            Me.rb_salida.Name = "rb_salida"
            Me.rb_salida.Size = New System.Drawing.Size(77, 24)
            Me.rb_salida.TabIndex = 3
            Me.rb_salida.TabStop = True
            Me.rb_salida.Text = "Prestar"
            Me.rb_salida.UseVisualStyleBackColor = True
            '
            'rb_entrada
            '
            Me.rb_entrada.AutoSize = True
            Me.rb_entrada.Enabled = False
            Me.rb_entrada.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rb_entrada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.rb_entrada.Location = New System.Drawing.Point(429, 90)
            Me.rb_entrada.Name = "rb_entrada"
            Me.rb_entrada.Size = New System.Drawing.Size(106, 24)
            Me.rb_entrada.TabIndex = 3
            Me.rb_entrada.TabStop = True
            Me.rb_entrada.Text = "Me prestan"
            Me.rb_entrada.UseVisualStyleBackColor = True
            '
            'dt_fecha
            '
            Me.dt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dt_fecha.Location = New System.Drawing.Point(428, 31)
            Me.dt_fecha.Name = "dt_fecha"
            Me.dt_fecha.Size = New System.Drawing.Size(113, 20)
            Me.dt_fecha.TabIndex = 2
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(380, 64)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(42, 16)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Origen"
            '
            'txt_boleta
            '
            Me.txt_boleta.Location = New System.Drawing.Point(87, 32)
            Me.txt_boleta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.txt_boleta.MaxLength = 10
            Me.txt_boleta.Name = "txt_boleta"
            Me.txt_boleta.ReadOnly = True
            Me.txt_boleta.Size = New System.Drawing.Size(95, 20)
            Me.txt_boleta.TabIndex = 1
            '
            'txt_transportista
            '
            Me.txt_transportista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txt_transportista.Location = New System.Drawing.Point(87, 87)
            Me.txt_transportista.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.txt_transportista.MaxLength = 50
            Me.txt_transportista.Name = "txt_transportista"
            Me.txt_transportista.Size = New System.Drawing.Size(194, 20)
            Me.txt_transportista.TabIndex = 1
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(86, 16)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(55, 16)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "N° Boleta"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(9, 90)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(76, 16)
            Me.Label6.TabIndex = 0
            Me.Label6.Text = "Transportista"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(384, 35)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(38, 16)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Fecha"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(38, 62)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(46, 16)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Destino"
            '
            'gp_2
            '
            Me.gp_2.Controls.Add(Me.btnRechazarSolicitud)
            Me.gp_2.Controls.Add(Me.btnAceptarSolicitud)
            Me.gp_2.Controls.Add(Me.Label10)
            Me.gp_2.Controls.Add(Me.txtCodArticulo)
            Me.gp_2.Controls.Add(Me.txt_cantidad)
            Me.gp_2.Controls.Add(Me.Label11)
            Me.gp_2.Controls.Add(Me.txt_prestamo)
            Me.gp_2.Controls.Add(Me.bt_agregar)
            Me.gp_2.Controls.Add(Me.txt_precio)
            Me.gp_2.Controls.Add(Me.txt_observaciones)
            Me.gp_2.Controls.Add(Me.Label12)
            Me.gp_2.Controls.Add(Me.txt_existencia_act)
            Me.gp_2.Controls.Add(Me.txt_descripcion)
            Me.gp_2.Controls.Add(Me.ck_estado)
            Me.gp_2.Controls.Add(Me.ck_anulado)
            Me.gp_2.Controls.Add(Me.datalistado)
            Me.gp_2.Controls.Add(Me.Label7)
            Me.gp_2.Controls.Add(Me.Label9)
            Me.gp_2.Controls.Add(Me.Label5)
            Me.gp_2.Controls.Add(Me.txt_codigo)
            Me.gp_2.Enabled = False
            Me.gp_2.Location = New System.Drawing.Point(4, 166)
            Me.gp_2.Name = "gp_2"
            Me.gp_2.Size = New System.Drawing.Size(659, 310)
            Me.gp_2.TabIndex = 1
            Me.gp_2.TabStop = False
            Me.gp_2.Text = "Datos de los productos"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(384, 18)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(94, 16)
            Me.Label10.TabIndex = 6
            Me.Label10.Text = "Existencia actual"
            '
            'txtCodArticulo
            '
            Me.txtCodArticulo.Location = New System.Drawing.Point(19, 36)
            Me.txtCodArticulo.Name = "txtCodArticulo"
            Me.txtCodArticulo.Size = New System.Drawing.Size(73, 20)
            Me.txtCodArticulo.TabIndex = 11
            '
            'txt_cantidad
            '
            Me.txt_cantidad.Location = New System.Drawing.Point(19, 85)
            Me.txt_cantidad.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.txt_cantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.txt_cantidad.Name = "txt_cantidad"
            Me.txt_cantidad.Size = New System.Drawing.Size(68, 20)
            Me.txt_cantidad.TabIndex = 10
            Me.txt_cantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(490, 18)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(59, 16)
            Me.Label11.TabIndex = 9
            Me.Label11.Text = "Prestamos"
            '
            'txt_prestamo
            '
            Me.txt_prestamo.Location = New System.Drawing.Point(482, 36)
            Me.txt_prestamo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.txt_prestamo.MaxLength = 20
            Me.txt_prestamo.Name = "txt_prestamo"
            Me.txt_prestamo.ReadOnly = True
            Me.txt_prestamo.Size = New System.Drawing.Size(78, 20)
            Me.txt_prestamo.TabIndex = 9
            '
            'bt_agregar
            '
            Me.bt_agregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.bt_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.bt_agregar.ForeColor = System.Drawing.Color.White
            Me.bt_agregar.Location = New System.Drawing.Point(98, 83)
            Me.bt_agregar.Name = "bt_agregar"
            Me.bt_agregar.Size = New System.Drawing.Size(75, 23)
            Me.bt_agregar.TabIndex = 8
            Me.bt_agregar.Text = "Agregar"
            Me.bt_agregar.UseVisualStyleBackColor = False
            '
            'txt_precio
            '
            Me.txt_precio.Location = New System.Drawing.Point(569, 36)
            Me.txt_precio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.txt_precio.MaxLength = 20
            Me.txt_precio.Name = "txt_precio"
            Me.txt_precio.ReadOnly = True
            Me.txt_precio.Size = New System.Drawing.Size(78, 20)
            Me.txt_precio.TabIndex = 7
            '
            'txt_observaciones
            '
            Me.txt_observaciones.Location = New System.Drawing.Point(18, 262)
            Me.txt_observaciones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.txt_observaciones.MaxLength = 350
            Me.txt_observaciones.Multiline = True
            Me.txt_observaciones.Name = "txt_observaciones"
            Me.txt_observaciones.Size = New System.Drawing.Size(473, 32)
            Me.txt_observaciones.TabIndex = 1
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(566, 18)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(39, 16)
            Me.Label12.TabIndex = 6
            Me.Label12.Text = "Precio"
            '
            'txt_existencia_act
            '
            Me.txt_existencia_act.Location = New System.Drawing.Point(393, 36)
            Me.txt_existencia_act.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.txt_existencia_act.MaxLength = 20
            Me.txt_existencia_act.Name = "txt_existencia_act"
            Me.txt_existencia_act.ReadOnly = True
            Me.txt_existencia_act.Size = New System.Drawing.Size(78, 20)
            Me.txt_existencia_act.TabIndex = 7
            '
            'txt_descripcion
            '
            Me.txt_descripcion.Location = New System.Drawing.Point(99, 36)
            Me.txt_descripcion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.txt_descripcion.MaxLength = 20
            Me.txt_descripcion.Name = "txt_descripcion"
            Me.txt_descripcion.ReadOnly = True
            Me.txt_descripcion.Size = New System.Drawing.Size(278, 20)
            Me.txt_descripcion.TabIndex = 5
            '
            'ck_estado
            '
            Me.ck_estado.AutoSize = True
            Me.ck_estado.Enabled = False
            Me.ck_estado.Location = New System.Drawing.Point(497, 274)
            Me.ck_estado.Name = "ck_estado"
            Me.ck_estado.Size = New System.Drawing.Size(79, 20)
            Me.ck_estado.TabIndex = 3
            Me.ck_estado.Text = "Entregado"
            Me.ck_estado.UseVisualStyleBackColor = True
            '
            'ck_anulado
            '
            Me.ck_anulado.AutoSize = True
            Me.ck_anulado.Enabled = False
            Me.ck_anulado.Location = New System.Drawing.Point(582, 274)
            Me.ck_anulado.Name = "ck_anulado"
            Me.ck_anulado.Size = New System.Drawing.Size(65, 20)
            Me.ck_anulado.TabIndex = 3
            Me.ck_anulado.Text = "Anulado"
            Me.ck_anulado.UseVisualStyleBackColor = True
            '
            'datalistado
            '
            Me.datalistado.AllowDrop = True
            Me.datalistado.AllowUserToAddRows = False
            Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.id_prestamo, Me.descripcion, Me.cantidad, Me.precio, Me.id})
            Me.datalistado.Location = New System.Drawing.Point(18, 117)
            Me.datalistado.Name = "datalistado"
            Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.datalistado.Size = New System.Drawing.Size(629, 143)
            Me.datalistado.TabIndex = 2
            '
            'codigo
            '
            Me.codigo.DataPropertyName = "codigo"
            Me.codigo.HeaderText = "codigo"
            Me.codigo.Name = "codigo"
            Me.codigo.ReadOnly = True
            Me.codigo.Visible = False
            '
            'id_prestamo
            '
            Me.id_prestamo.DataPropertyName = "id_prestamo"
            Me.id_prestamo.HeaderText = "prestamo"
            Me.id_prestamo.Name = "id_prestamo"
            Me.id_prestamo.ReadOnly = True
            Me.id_prestamo.Visible = False
            '
            'descripcion
            '
            Me.descripcion.DataPropertyName = "descripcion"
            Me.descripcion.HeaderText = "descripcion"
            Me.descripcion.Name = "descripcion"
            Me.descripcion.ReadOnly = True
            Me.descripcion.Width = 380
            '
            'cantidad
            '
            Me.cantidad.DataPropertyName = "cantidad"
            Me.cantidad.HeaderText = "cantidad"
            Me.cantidad.Name = "cantidad"
            Me.cantidad.Width = 75
            '
            'precio
            '
            Me.precio.DataPropertyName = "precio"
            Me.precio.HeaderText = "precio"
            Me.precio.Name = "precio"
            Me.precio.ReadOnly = True
            '
            'id
            '
            Me.id.DataPropertyName = "id"
            Me.id.HeaderText = "id"
            Me.id.Name = "id"
            Me.id.ReadOnly = True
            Me.id.Visible = False
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(16, 64)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(130, 16)
            Me.Label7.TabIndex = 0
            Me.Label7.Text = "Cantidad para prestamo"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(96, 18)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(67, 16)
            Me.Label9.TabIndex = 0
            Me.Label9.Text = "Descripción"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(16, 18)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(42, 16)
            Me.Label5.TabIndex = 0
            Me.Label5.Text = "Codigo"
            '
            'txt_codigo
            '
            Me.txt_codigo.Location = New System.Drawing.Point(158, 36)
            Me.txt_codigo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.txt_codigo.MaxLength = 20
            Me.txt_codigo.Name = "txt_codigo"
            Me.txt_codigo.ReadOnly = True
            Me.txt_codigo.Size = New System.Drawing.Size(45, 20)
            Me.txt_codigo.TabIndex = 1
            Me.txt_codigo.TabStop = False
            '
            'bt_devolucion
            '
            Me.bt_devolucion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.bt_devolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.bt_devolucion.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bt_devolucion.ForeColor = System.Drawing.Color.White
            Me.bt_devolucion.Location = New System.Drawing.Point(487, 237)
            Me.bt_devolucion.Name = "bt_devolucion"
            Me.bt_devolucion.Size = New System.Drawing.Size(165, 34)
            Me.bt_devolucion.TabIndex = 11
            Me.bt_devolucion.Text = "Realizar devolución"
            Me.bt_devolucion.UseVisualStyleBackColor = False
            Me.bt_devolucion.Visible = False
            '
            'ToolStrip1
            '
            Me.ToolStrip1.Enabled = False
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bt_nuevo, Me.ToolStripSeparator1, Me.bt_guardar, Me.ToolStripSeparator2, Me.bt_editar, Me.ToolStripSeparator3, Me.bt_buscar, Me.ToolStripSeparator4, Me.bt_eliminar, Me.ToolStripSeparator5, Me.ToolStripButton2, Me.ToolStripSeparator6})
            Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(670, 25)
            Me.ToolStrip1.TabIndex = 4
            Me.ToolStrip1.Text = "ToolStrip1"
            '
            'bt_nuevo
            '
            Me.bt_nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.bt_nuevo.Image = Global.LcPymes_5._2.My.Resources.Resources._001_file
            Me.bt_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.bt_nuevo.Name = "bt_nuevo"
            Me.bt_nuevo.Size = New System.Drawing.Size(23, 22)
            Me.bt_nuevo.Text = "ToolStripButton1"
            Me.bt_nuevo.ToolTipText = "Nuevo"
            '
            'ToolStripSeparator1
            '
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
            '
            'bt_guardar
            '
            Me.bt_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.bt_guardar.Image = Global.LcPymes_5._2.My.Resources.Resources._005_floppy_disk
            Me.bt_guardar.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.bt_guardar.Name = "bt_guardar"
            Me.bt_guardar.Size = New System.Drawing.Size(23, 22)
            Me.bt_guardar.Text = "ToolStripButton1"
            Me.bt_guardar.ToolTipText = "Guardar"
            '
            'ToolStripSeparator2
            '
            Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
            Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
            '
            'bt_editar
            '
            Me.bt_editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.bt_editar.Image = Global.LcPymes_5._2.My.Resources.Resources._002_pen
            Me.bt_editar.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.bt_editar.Name = "bt_editar"
            Me.bt_editar.Size = New System.Drawing.Size(23, 22)
            Me.bt_editar.Text = "Editar"
            '
            'ToolStripSeparator3
            '
            Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
            Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
            '
            'bt_buscar
            '
            Me.bt_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.bt_buscar.Image = Global.LcPymes_5._2.My.Resources.Resources._003_search_engine
            Me.bt_buscar.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.bt_buscar.Name = "bt_buscar"
            Me.bt_buscar.Size = New System.Drawing.Size(23, 22)
            Me.bt_buscar.Text = "Buscar"
            '
            'ToolStripSeparator4
            '
            Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
            Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
            '
            'bt_eliminar
            '
            Me.bt_eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.bt_eliminar.Image = Global.LcPymes_5._2.My.Resources.Resources._004_delete
            Me.bt_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.bt_eliminar.Name = "bt_eliminar"
            Me.bt_eliminar.Size = New System.Drawing.Size(23, 22)
            Me.bt_eliminar.Text = "Eliminar"
            '
            'ToolStripSeparator5
            '
            Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
            Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
            '
            'ToolStripButton2
            '
            Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButton2.Image = Global.LcPymes_5._2.My.Resources.Resources.business
            Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButton2.Name = "ToolStripButton2"
            Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButton2.Text = "ToolStripButton2"
            Me.ToolStripButton2.ToolTipText = "Reporte"
            '
            'ToolStripSeparator6
            '
            Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
            Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
            '
            'lblanulado
            '
            Me.lblanulado.AutoSize = True
            Me.lblanulado.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblanulado.ForeColor = System.Drawing.Color.Red
            Me.lblanulado.Location = New System.Drawing.Point(271, 140)
            Me.lblanulado.Name = "lblanulado"
            Me.lblanulado.Size = New System.Drawing.Size(138, 40)
            Me.lblanulado.TabIndex = 6
            Me.lblanulado.Text = "Anulado"
            Me.lblanulado.Visible = False
            '
            'lb_entregado
            '
            Me.lb_entregado.AutoSize = True
            Me.lb_entregado.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lb_entregado.ForeColor = System.Drawing.Color.ForestGreen
            Me.lb_entregado.Location = New System.Drawing.Point(261, 137)
            Me.lb_entregado.Name = "lb_entregado"
            Me.lb_entregado.Size = New System.Drawing.Size(169, 40)
            Me.lb_entregado.TabIndex = 7
            Me.lb_entregado.Text = "Entregado"
            Me.lb_entregado.Visible = False
            '
            'Label36
            '
            Me.Label36.BackColor = System.Drawing.Color.RoyalBlue
            Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label36.ForeColor = System.Drawing.Color.White
            Me.Label36.Location = New System.Drawing.Point(372, 9)
            Me.Label36.Name = "Label36"
            Me.Label36.Size = New System.Drawing.Size(72, 13)
            Me.Label36.TabIndex = 12
            Me.Label36.Text = "Usuario->"
            Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'txtNombreUsuario
            '
            Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.Control
            Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtNombreUsuario.Enabled = False
            Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
            Me.txtNombreUsuario.Location = New System.Drawing.Point(500, 9)
            Me.txtNombreUsuario.Name = "txtNombreUsuario"
            Me.txtNombreUsuario.ReadOnly = True
            Me.txtNombreUsuario.Size = New System.Drawing.Size(163, 13)
            Me.txtNombreUsuario.TabIndex = 14
            '
            'txtUsuario
            '
            Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
            Me.txtUsuario.Location = New System.Drawing.Point(444, 9)
            Me.txtUsuario.Name = "txtUsuario"
            Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtUsuario.Size = New System.Drawing.Size(56, 13)
            Me.txtUsuario.TabIndex = 13
            '
            'btnAceptarSolicitud
            '
            Me.btnAceptarSolicitud.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnAceptarSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAceptarSolicitud.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptarSolicitud.ForeColor = System.Drawing.Color.White
            Me.btnAceptarSolicitud.Location = New System.Drawing.Point(230, 72)
            Me.btnAceptarSolicitud.Name = "btnAceptarSolicitud"
            Me.btnAceptarSolicitud.Size = New System.Drawing.Size(153, 34)
            Me.btnAceptarSolicitud.TabIndex = 15
            Me.btnAceptarSolicitud.Text = "Aceptar Solicitud"
            Me.btnAceptarSolicitud.UseVisualStyleBackColor = False
            Me.btnAceptarSolicitud.Visible = False
            '
            'btnRechazarSolicitud
            '
            Me.btnRechazarSolicitud.BackColor = System.Drawing.Color.Red
            Me.btnRechazarSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRechazarSolicitud.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRechazarSolicitud.ForeColor = System.Drawing.Color.White
            Me.btnRechazarSolicitud.Location = New System.Drawing.Point(401, 71)
            Me.btnRechazarSolicitud.Name = "btnRechazarSolicitud"
            Me.btnRechazarSolicitud.Size = New System.Drawing.Size(153, 34)
            Me.btnRechazarSolicitud.TabIndex = 16
            Me.btnRechazarSolicitud.Text = "Rechazar Solicitud"
            Me.btnRechazarSolicitud.UseVisualStyleBackColor = False
            Me.btnRechazarSolicitud.Visible = False
            '
            'frm_prestamos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(670, 475)
            Me.Controls.Add(Me.Label36)
            Me.Controls.Add(Me.txtNombreUsuario)
            Me.Controls.Add(Me.txtUsuario)
            Me.Controls.Add(Me.lb_entregado)
            Me.Controls.Add(Me.lblanulado)
            Me.Controls.Add(Me.ToolStrip1)
            Me.Controls.Add(Me.gp_2)
            Me.Controls.Add(Me.gp_1)
            Me.Controls.Add(Me.bt_devolucion)
            Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "frm_prestamos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Prestamos de productos"
            Me.gp_1.ResumeLayout(False)
            Me.gp_1.PerformLayout()
            Me.gp_2.ResumeLayout(False)
            Me.gp_2.PerformLayout()
            CType(Me.txt_cantidad, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents gp_1 As GroupBox
        Friend WithEvents Label1 As Label
        Friend WithEvents dt_fecha As DateTimePicker
        Friend WithEvents Label2 As Label
        Friend WithEvents txt_boleta As TextBox
        Friend WithEvents Label4 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents gp_2 As GroupBox
        Friend WithEvents txt_codigo As TextBox
        Friend WithEvents Label5 As Label
        Friend WithEvents rb_salida As RadioButton
        Friend WithEvents rb_entrada As RadioButton
        Friend WithEvents txt_observaciones As TextBox
        Friend WithEvents txt_transportista As TextBox
        Friend WithEvents Label6 As Label
        Friend WithEvents datalistado As DataGridView
        Friend WithEvents lb_id As Label
        Friend WithEvents ck_anulado As CheckBox
        Friend WithEvents ck_estado As CheckBox
        Friend WithEvents Label7 As Label
        Friend WithEvents txt_existencia_act As TextBox
        Friend WithEvents Label10 As Label
        Friend WithEvents txt_descripcion As TextBox
        Friend WithEvents Label9 As Label
        Friend WithEvents bt_agregar As Button
        Friend WithEvents Label11 As Label
        Friend WithEvents txt_prestamo As TextBox
        Friend WithEvents txt_precio As TextBox
        Friend WithEvents Label12 As Label
        Friend WithEvents txt_cantidad As NumericUpDown
        Friend WithEvents cbo_destinatario As ComboBox
        Friend WithEvents cbo_destino As ComboBox
        Friend WithEvents ToolStrip1 As ToolStrip
        Friend WithEvents bt_guardar As ToolStripButton
        Friend WithEvents bt_nuevo As ToolStripButton
        Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
        Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
        Friend WithEvents bt_editar As ToolStripButton
        Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
        Friend WithEvents bt_buscar As ToolStripButton
        Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
        Friend WithEvents bt_eliminar As ToolStripButton
        Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
        Friend WithEvents lblanulado As Label
        Friend WithEvents ToolStripButton2 As ToolStripButton
        Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
        Friend WithEvents bt_devolucion As Button
        Friend WithEvents lb_entregado As Label
        Friend WithEvents Label36 As System.Windows.Forms.Label
        Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
        Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
        Friend WithEvents txtBoletaProveedor As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtCodArticulo As System.Windows.Forms.TextBox
        Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents id_prestamo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents btnRechazarSolicitud As System.Windows.Forms.Button
        Friend WithEvents btnAceptarSolicitud As System.Windows.Forms.Button
    End Class

End Namespace
