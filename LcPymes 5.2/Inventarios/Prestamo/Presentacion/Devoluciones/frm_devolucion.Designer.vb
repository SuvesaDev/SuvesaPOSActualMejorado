Imports System.Windows.Forms
Namespace Prestamos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frm_devolucion
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
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.bt_nuevo = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.bt_guardar = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.bt_buscar = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
            Me.bt_eliminar = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
            Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.lb_entregado = New System.Windows.Forms.Label()
            Me.txt_boleta = New System.Windows.Forms.TextBox()
            Me.ck_estado = New System.Windows.Forms.CheckBox()
            Me.lblanulado = New System.Windows.Forms.Label()
            Me.lb_destinatario = New System.Windows.Forms.Label()
            Me.ck_anulado = New System.Windows.Forms.CheckBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.lb_destino = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.dt_fecha = New System.Windows.Forms.DateTimePicker()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.lb_id = New System.Windows.Forms.Label()
            Me.gb_devolucion = New System.Windows.Forms.GroupBox()
            Me.lb_producto = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txt_devueltos = New System.Windows.Forms.TextBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txt_prestamo = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txt_devolvieron = New System.Windows.Forms.NumericUpDown()
            Me.bt_guardar_dev = New System.Windows.Forms.Button()
            Me.datalistado = New System.Windows.Forms.DataGridView()
            Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.id_prestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.gp_detalles = New System.Windows.Forms.GroupBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.gp_devoluciones = New System.Windows.Forms.GroupBox()
            Me.datalistado2 = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.id_detalle_prestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Label36 = New System.Windows.Forms.Label()
            Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
            Me.txtUsuario = New System.Windows.Forms.TextBox()
            Me.ToolStrip1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.gb_devolucion.SuspendLayout()
            CType(Me.txt_devolvieron, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gp_detalles.SuspendLayout()
            Me.gp_devoluciones.SuspendLayout()
            CType(Me.datalistado2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ToolStrip1
            '
            Me.ToolStrip1.Enabled = False
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bt_nuevo, Me.ToolStripSeparator1, Me.bt_guardar, Me.ToolStripSeparator2, Me.bt_buscar, Me.ToolStripSeparator4, Me.bt_eliminar, Me.ToolStripSeparator5, Me.ToolStripButton2})
            Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(561, 25)
            Me.ToolStrip1.TabIndex = 5
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
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.lb_entregado)
            Me.GroupBox1.Controls.Add(Me.txt_boleta)
            Me.GroupBox1.Controls.Add(Me.ck_estado)
            Me.GroupBox1.Controls.Add(Me.lblanulado)
            Me.GroupBox1.Controls.Add(Me.lb_destinatario)
            Me.GroupBox1.Controls.Add(Me.ck_anulado)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.lb_destino)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.dt_fecha)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.lb_id)
            Me.GroupBox1.Enabled = False
            Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
            Me.GroupBox1.Location = New System.Drawing.Point(12, 29)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(541, 85)
            Me.GroupBox1.TabIndex = 6
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Datos del prestamo"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(124, 23)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(66, 13)
            Me.Label6.TabIndex = 18
            Me.Label6.Text = "N° Prestamo"
            '
            'lb_entregado
            '
            Me.lb_entregado.AutoSize = True
            Me.lb_entregado.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lb_entregado.ForeColor = System.Drawing.Color.ForestGreen
            Me.lb_entregado.Location = New System.Drawing.Point(409, 11)
            Me.lb_entregado.Name = "lb_entregado"
            Me.lb_entregado.Size = New System.Drawing.Size(128, 29)
            Me.lb_entregado.TabIndex = 17
            Me.lb_entregado.Text = "Entregado"
            Me.lb_entregado.Visible = False
            '
            'txt_boleta
            '
            Me.txt_boleta.Location = New System.Drawing.Point(51, 20)
            Me.txt_boleta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.txt_boleta.MaxLength = 10
            Me.txt_boleta.Name = "txt_boleta"
            Me.txt_boleta.Size = New System.Drawing.Size(73, 20)
            Me.txt_boleta.TabIndex = 3
            '
            'ck_estado
            '
            Me.ck_estado.AutoSize = True
            Me.ck_estado.Enabled = False
            Me.ck_estado.Location = New System.Drawing.Point(460, 43)
            Me.ck_estado.Name = "ck_estado"
            Me.ck_estado.Size = New System.Drawing.Size(75, 17)
            Me.ck_estado.TabIndex = 16
            Me.ck_estado.Text = "Entregado"
            Me.ck_estado.UseVisualStyleBackColor = True
            '
            'lblanulado
            '
            Me.lblanulado.AutoSize = True
            Me.lblanulado.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblanulado.ForeColor = System.Drawing.Color.Red
            Me.lblanulado.Location = New System.Drawing.Point(433, 11)
            Me.lblanulado.Name = "lblanulado"
            Me.lblanulado.Size = New System.Drawing.Size(104, 29)
            Me.lblanulado.TabIndex = 14
            Me.lblanulado.Text = "Anulado"
            Me.lblanulado.Visible = False
            '
            'lb_destinatario
            '
            Me.lb_destinatario.AutoSize = True
            Me.lb_destinatario.Location = New System.Drawing.Point(271, 57)
            Me.lb_destinatario.Name = "lb_destinatario"
            Me.lb_destinatario.Size = New System.Drawing.Size(10, 13)
            Me.lb_destinatario.TabIndex = 12
            Me.lb_destinatario.Text = "-"
            '
            'ck_anulado
            '
            Me.ck_anulado.AutoSize = True
            Me.ck_anulado.Enabled = False
            Me.ck_anulado.Location = New System.Drawing.Point(460, 62)
            Me.ck_anulado.Name = "ck_anulado"
            Me.ck_anulado.Size = New System.Drawing.Size(65, 17)
            Me.ck_anulado.TabIndex = 13
            Me.ck_anulado.Text = "Anulado"
            Me.ck_anulado.UseVisualStyleBackColor = True
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(202, 57)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(63, 13)
            Me.Label7.TabIndex = 11
            Me.Label7.Text = "Destinatario"
            '
            'lb_destino
            '
            Me.lb_destino.AutoSize = True
            Me.lb_destino.Location = New System.Drawing.Point(76, 57)
            Me.lb_destino.Name = "lb_destino"
            Me.lb_destino.Size = New System.Drawing.Size(10, 13)
            Me.lb_destino.TabIndex = 10
            Me.lb_destino.Text = "-"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(27, 57)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(43, 13)
            Me.Label5.TabIndex = 9
            Me.Label5.Text = "Destino"
            '
            'dt_fecha
            '
            Me.dt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dt_fecha.Location = New System.Drawing.Point(286, 20)
            Me.dt_fecha.Name = "dt_fecha"
            Me.dt_fecha.Size = New System.Drawing.Size(113, 20)
            Me.dt_fecha.TabIndex = 8
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(243, 23)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(37, 13)
            Me.Label3.TabIndex = 7
            Me.Label3.Text = "Fecha"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(8, 23)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(37, 13)
            Me.Label4.TabIndex = 2
            Me.Label4.Text = "Boleta"
            '
            'lb_id
            '
            Me.lb_id.AutoSize = True
            Me.lb_id.Location = New System.Drawing.Point(192, 24)
            Me.lb_id.Name = "lb_id"
            Me.lb_id.Size = New System.Drawing.Size(13, 13)
            Me.lb_id.TabIndex = 15
            Me.lb_id.Text = "0"
            '
            'gb_devolucion
            '
            Me.gb_devolucion.Controls.Add(Me.lb_producto)
            Me.gb_devolucion.Controls.Add(Me.Label2)
            Me.gb_devolucion.Controls.Add(Me.txt_devueltos)
            Me.gb_devolucion.Controls.Add(Me.Label11)
            Me.gb_devolucion.Controls.Add(Me.txt_prestamo)
            Me.gb_devolucion.Controls.Add(Me.Label8)
            Me.gb_devolucion.Controls.Add(Me.txt_devolvieron)
            Me.gb_devolucion.Controls.Add(Me.bt_guardar_dev)
            Me.gb_devolucion.Enabled = False
            Me.gb_devolucion.Location = New System.Drawing.Point(12, 289)
            Me.gb_devolucion.Name = "gb_devolucion"
            Me.gb_devolucion.Size = New System.Drawing.Size(541, 81)
            Me.gb_devolucion.TabIndex = 14
            Me.gb_devolucion.TabStop = False
            '
            'lb_producto
            '
            Me.lb_producto.BackColor = System.Drawing.Color.Green
            Me.lb_producto.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lb_producto.ForeColor = System.Drawing.Color.White
            Me.lb_producto.Location = New System.Drawing.Point(8, 16)
            Me.lb_producto.Name = "lb_producto"
            Me.lb_producto.Size = New System.Drawing.Size(522, 18)
            Me.lb_producto.TabIndex = 17
            Me.lb_producto.Text = "Producto"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(392, 53)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(55, 13)
            Me.Label2.TabIndex = 15
            Me.Label2.Text = "Devueltos"
            '
            'txt_devueltos
            '
            Me.txt_devueltos.Location = New System.Drawing.Point(454, 50)
            Me.txt_devueltos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.txt_devueltos.MaxLength = 20
            Me.txt_devueltos.Name = "txt_devueltos"
            Me.txt_devueltos.ReadOnly = True
            Me.txt_devueltos.Size = New System.Drawing.Size(78, 20)
            Me.txt_devueltos.TabIndex = 16
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(239, 53)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(56, 13)
            Me.Label11.TabIndex = 13
            Me.Label11.Text = "Prestamos"
            '
            'txt_prestamo
            '
            Me.txt_prestamo.Location = New System.Drawing.Point(301, 50)
            Me.txt_prestamo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.txt_prestamo.MaxLength = 20
            Me.txt_prestamo.Name = "txt_prestamo"
            Me.txt_prestamo.ReadOnly = True
            Me.txt_prestamo.Size = New System.Drawing.Size(78, 20)
            Me.txt_prestamo.TabIndex = 14
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(6, 49)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(76, 18)
            Me.Label8.TabIndex = 11
            Me.Label8.Text = "Devolvieron"
            '
            'txt_devolvieron
            '
            Me.txt_devolvieron.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.txt_devolvieron.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txt_devolvieron.Location = New System.Drawing.Point(88, 49)
            Me.txt_devolvieron.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.txt_devolvieron.Name = "txt_devolvieron"
            Me.txt_devolvieron.Size = New System.Drawing.Size(55, 21)
            Me.txt_devolvieron.TabIndex = 12
            Me.txt_devolvieron.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'bt_guardar_dev
            '
            Me.bt_guardar_dev.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.bt_guardar_dev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.bt_guardar_dev.ForeColor = System.Drawing.Color.White
            Me.bt_guardar_dev.Image = Global.LcPymes_5._2.My.Resources.Resources.add
            Me.bt_guardar_dev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.bt_guardar_dev.Location = New System.Drawing.Point(149, 47)
            Me.bt_guardar_dev.Name = "bt_guardar_dev"
            Me.bt_guardar_dev.Size = New System.Drawing.Size(70, 23)
            Me.bt_guardar_dev.TabIndex = 8
            Me.bt_guardar_dev.Text = "Agregar"
            Me.bt_guardar_dev.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.bt_guardar_dev.UseVisualStyleBackColor = False
            '
            'datalistado
            '
            Me.datalistado.AllowUserToAddRows = False
            Me.datalistado.AllowUserToDeleteRows = False
            Me.datalistado.BackgroundColor = System.Drawing.Color.White
            Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.id_prestamo, Me.descripcion, Me.cantidad, Me.id})
            Me.datalistado.GridColor = System.Drawing.SystemColors.ActiveCaption
            Me.datalistado.Location = New System.Drawing.Point(9, 19)
            Me.datalistado.Name = "datalistado"
            Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.datalistado.Size = New System.Drawing.Size(521, 125)
            Me.datalistado.TabIndex = 15
            '
            'codigo
            '
            Me.codigo.DataPropertyName = "codigo"
            Me.codigo.HeaderText = "codigo"
            Me.codigo.Name = "codigo"
            '
            'id_prestamo
            '
            Me.id_prestamo.DataPropertyName = "id_prestamo"
            Me.id_prestamo.HeaderText = "prestamo"
            Me.id_prestamo.Name = "id_prestamo"
            Me.id_prestamo.Visible = False
            '
            'descripcion
            '
            Me.descripcion.DataPropertyName = "descripcion"
            Me.descripcion.HeaderText = "descripcion"
            Me.descripcion.Name = "descripcion"
            Me.descripcion.Width = 300
            '
            'cantidad
            '
            Me.cantidad.DataPropertyName = "cantidad"
            Me.cantidad.HeaderText = "cantidad"
            Me.cantidad.Name = "cantidad"
            Me.cantidad.Width = 75
            '
            'id
            '
            Me.id.DataPropertyName = "id"
            Me.id.HeaderText = "id"
            Me.id.Name = "id"
            Me.id.Visible = False
            '
            'gp_detalles
            '
            Me.gp_detalles.Controls.Add(Me.Label1)
            Me.gp_detalles.Controls.Add(Me.datalistado)
            Me.gp_detalles.Enabled = False
            Me.gp_detalles.ForeColor = System.Drawing.SystemColors.ControlDarkDark
            Me.gp_detalles.Location = New System.Drawing.Point(12, 116)
            Me.gp_detalles.Name = "gp_detalles"
            Me.gp_detalles.Size = New System.Drawing.Size(541, 170)
            Me.gp_detalles.TabIndex = 16
            Me.gp_detalles.TabStop = False
            Me.gp_detalles.Text = "Detalle del prestamo"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
            Me.Label1.Location = New System.Drawing.Point(6, 151)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(360, 13)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "Doble click sobre la celda del producto para hacer la devolución del mismo"
            '
            'gp_devoluciones
            '
            Me.gp_devoluciones.Controls.Add(Me.datalistado2)
            Me.gp_devoluciones.Enabled = False
            Me.gp_devoluciones.ForeColor = System.Drawing.SystemColors.ControlDarkDark
            Me.gp_devoluciones.Location = New System.Drawing.Point(12, 372)
            Me.gp_devoluciones.Name = "gp_devoluciones"
            Me.gp_devoluciones.Size = New System.Drawing.Size(541, 171)
            Me.gp_devoluciones.TabIndex = 17
            Me.gp_devoluciones.TabStop = False
            Me.gp_devoluciones.Text = "Lista de Productos que se van a devolver"
            '
            'datalistado2
            '
            Me.datalistado2.AllowDrop = True
            Me.datalistado2.AllowUserToAddRows = False
            Me.datalistado2.BackgroundColor = System.Drawing.Color.White
            Me.datalistado2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.datalistado2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.id_detalle_prestamo})
            Me.datalistado2.GridColor = System.Drawing.SystemColors.ActiveCaption
            Me.datalistado2.Location = New System.Drawing.Point(11, 21)
            Me.datalistado2.Name = "datalistado2"
            Me.datalistado2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.datalistado2.Size = New System.Drawing.Size(521, 143)
            Me.datalistado2.TabIndex = 15
            '
            'DataGridViewTextBoxColumn2
            '
            Me.DataGridViewTextBoxColumn2.DataPropertyName = "id_boleta"
            Me.DataGridViewTextBoxColumn2.HeaderText = "Boleta"
            Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
            '
            'DataGridViewTextBoxColumn1
            '
            Me.DataGridViewTextBoxColumn1.DataPropertyName = "codigo"
            Me.DataGridViewTextBoxColumn1.HeaderText = "codigo"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            '
            'DataGridViewTextBoxColumn3
            '
            Me.DataGridViewTextBoxColumn3.DataPropertyName = "descripcion"
            Me.DataGridViewTextBoxColumn3.HeaderText = "descripcion"
            Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
            Me.DataGridViewTextBoxColumn3.Width = 250
            '
            'DataGridViewTextBoxColumn4
            '
            Me.DataGridViewTextBoxColumn4.DataPropertyName = "cantidad"
            Me.DataGridViewTextBoxColumn4.HeaderText = "cantidad"
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            Me.DataGridViewTextBoxColumn4.Width = 75
            '
            'id_detalle_prestamo
            '
            Me.id_detalle_prestamo.DataPropertyName = "id_detalle_prestamo"
            Me.id_detalle_prestamo.HeaderText = "Detalle prestamo"
            Me.id_detalle_prestamo.Name = "id_detalle_prestamo"
            Me.id_detalle_prestamo.Visible = False
            '
            'Label36
            '
            Me.Label36.BackColor = System.Drawing.Color.RoyalBlue
            Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label36.ForeColor = System.Drawing.Color.White
            Me.Label36.Location = New System.Drawing.Point(264, 8)
            Me.Label36.Name = "Label36"
            Me.Label36.Size = New System.Drawing.Size(72, 13)
            Me.Label36.TabIndex = 18
            Me.Label36.Text = "Usuario->"
            Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'txtNombreUsuario
            '
            Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.Control
            Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtNombreUsuario.Enabled = False
            Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
            Me.txtNombreUsuario.Location = New System.Drawing.Point(392, 8)
            Me.txtNombreUsuario.Name = "txtNombreUsuario"
            Me.txtNombreUsuario.ReadOnly = True
            Me.txtNombreUsuario.Size = New System.Drawing.Size(163, 13)
            Me.txtNombreUsuario.TabIndex = 20
            '
            'txtUsuario
            '
            Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
            Me.txtUsuario.Location = New System.Drawing.Point(336, 8)
            Me.txtUsuario.Name = "txtUsuario"
            Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtUsuario.Size = New System.Drawing.Size(56, 13)
            Me.txtUsuario.TabIndex = 19
            '
            'frm_devolucion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(561, 548)
            Me.Controls.Add(Me.Label36)
            Me.Controls.Add(Me.txtNombreUsuario)
            Me.Controls.Add(Me.txtUsuario)
            Me.Controls.Add(Me.gp_devoluciones)
            Me.Controls.Add(Me.gp_detalles)
            Me.Controls.Add(Me.gb_devolucion)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.ToolStrip1)
            Me.Name = "frm_devolucion"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Devolución de prestamos"
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.gb_devolucion.ResumeLayout(False)
            Me.gb_devolucion.PerformLayout()
            CType(Me.txt_devolvieron, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gp_detalles.ResumeLayout(False)
            Me.gp_detalles.PerformLayout()
            Me.gp_devoluciones.ResumeLayout(False)
            CType(Me.datalistado2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents ToolStrip1 As ToolStrip
        Friend WithEvents bt_nuevo As ToolStripButton
        Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
        Friend WithEvents bt_guardar As ToolStripButton
        Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
        Friend WithEvents bt_buscar As ToolStripButton
        Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
        Friend WithEvents bt_eliminar As ToolStripButton
        Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
        Friend WithEvents ToolStripButton2 As ToolStripButton
        Friend WithEvents GroupBox1 As GroupBox
        Friend WithEvents txt_boleta As TextBox
        Friend WithEvents Label4 As Label
        Friend WithEvents dt_fecha As DateTimePicker
        Friend WithEvents Label3 As Label
        Friend WithEvents gb_devolucion As GroupBox
        Friend WithEvents Label8 As Label
        Friend WithEvents txt_devolvieron As NumericUpDown
        Friend WithEvents bt_guardar_dev As Button
        Friend WithEvents datalistado As DataGridView
        Friend WithEvents gp_detalles As GroupBox
        Friend WithEvents Label1 As Label
        Friend WithEvents gp_devoluciones As GroupBox
        Friend WithEvents datalistado2 As DataGridView
        Friend WithEvents Label2 As Label
        Friend WithEvents txt_devueltos As TextBox
        Friend WithEvents Label11 As Label
        Friend WithEvents txt_prestamo As TextBox
        Friend WithEvents lb_destinatario As Label
        Friend WithEvents Label7 As Label
        Friend WithEvents lb_destino As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents lblanulado As Label
        Friend WithEvents ck_anulado As CheckBox
        Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
        Friend WithEvents id_detalle_prestamo As DataGridViewTextBoxColumn
        Friend WithEvents codigo As DataGridViewTextBoxColumn
        Friend WithEvents id_prestamo As DataGridViewTextBoxColumn
        Friend WithEvents descripcion As DataGridViewTextBoxColumn
        Friend WithEvents cantidad As DataGridViewTextBoxColumn
        Friend WithEvents id As DataGridViewTextBoxColumn
        Friend WithEvents lb_id As Label
        Friend WithEvents ck_estado As CheckBox
        Friend WithEvents lb_entregado As Label
        Friend WithEvents lb_producto As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents Label36 As System.Windows.Forms.Label
        Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
        Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    End Class

End Namespace
