<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrasladosDepartamentos
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
        Me.gp_2 = New System.Windows.Forms.GroupBox()
        Me.lblAnulado = New System.Windows.Forms.Label()
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_prestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_prestamo = New System.Windows.Forms.TextBox()
        Me.bt_agregar = New System.Windows.Forms.Button()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_existencia_act = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboPuntoVentaOrigen = New System.Windows.Forms.ComboBox()
        Me.cboPuntoVentaDestino = New System.Windows.Forms.ComboBox()
        Me.dt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bt_guardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.bt_buscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.bt_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.lb_id = New System.Windows.Forms.Label()
        Me.gp_2.SuspendLayout()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gp_2
        '
        Me.gp_2.Controls.Add(Me.lblAnulado)
        Me.gp_2.Controls.Add(Me.viewDatos)
        Me.gp_2.Controls.Add(Me.Label4)
        Me.gp_2.Controls.Add(Me.txt_cantidad)
        Me.gp_2.Controls.Add(Me.Label11)
        Me.gp_2.Controls.Add(Me.txt_prestamo)
        Me.gp_2.Controls.Add(Me.bt_agregar)
        Me.gp_2.Controls.Add(Me.txt_precio)
        Me.gp_2.Controls.Add(Me.txt_observaciones)
        Me.gp_2.Controls.Add(Me.Label12)
        Me.gp_2.Controls.Add(Me.txt_existencia_act)
        Me.gp_2.Controls.Add(Me.Label10)
        Me.gp_2.Controls.Add(Me.txt_descripcion)
        Me.gp_2.Controls.Add(Me.txt_codigo)
        Me.gp_2.Controls.Add(Me.Label7)
        Me.gp_2.Controls.Add(Me.Label9)
        Me.gp_2.Controls.Add(Me.Label5)
        Me.gp_2.Enabled = False
        Me.gp_2.Location = New System.Drawing.Point(2, 98)
        Me.gp_2.Name = "gp_2"
        Me.gp_2.Size = New System.Drawing.Size(659, 360)
        Me.gp_2.TabIndex = 2
        Me.gp_2.TabStop = False
        Me.gp_2.Text = "Datos de los productos"
        '
        'lblAnulado
        '
        Me.lblAnulado.AutoSize = True
        Me.lblAnulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnulado.ForeColor = System.Drawing.Color.Red
        Me.lblAnulado.Location = New System.Drawing.Point(246, 221)
        Me.lblAnulado.Name = "lblAnulado"
        Me.lblAnulado.Size = New System.Drawing.Size(143, 39)
        Me.lblAnulado.TabIndex = 19
        Me.lblAnulado.Text = "Anulado"
        Me.lblAnulado.Visible = False
        '
        'viewDatos
        '
        Me.viewDatos.AllowDrop = True
        Me.viewDatos.AllowUserToAddRows = False
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.id_prestamo, Me.descripcion, Me.cantidad, Me.precio, Me.id})
        Me.viewDatos.Location = New System.Drawing.Point(18, 63)
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(629, 197)
        Me.viewDatos.TabIndex = 2
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
        Me.descripcion.Width = 390
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
        Me.precio.Visible = False
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Observaciones :"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(481, 37)
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
        Me.Label11.Location = New System.Drawing.Point(483, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Prestamos"
        Me.Label11.Visible = False
        '
        'txt_prestamo
        '
        Me.txt_prestamo.Location = New System.Drawing.Point(475, 86)
        Me.txt_prestamo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_prestamo.MaxLength = 20
        Me.txt_prestamo.Name = "txt_prestamo"
        Me.txt_prestamo.ReadOnly = True
        Me.txt_prestamo.Size = New System.Drawing.Size(78, 20)
        Me.txt_prestamo.TabIndex = 9
        Me.txt_prestamo.Visible = False
        '
        'bt_agregar
        '
        Me.bt_agregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_agregar.ForeColor = System.Drawing.Color.White
        Me.bt_agregar.Location = New System.Drawing.Point(560, 35)
        Me.bt_agregar.Name = "bt_agregar"
        Me.bt_agregar.Size = New System.Drawing.Size(75, 23)
        Me.bt_agregar.TabIndex = 8
        Me.bt_agregar.Text = "Agregar"
        Me.bt_agregar.UseVisualStyleBackColor = False
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(562, 86)
        Me.txt_precio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_precio.MaxLength = 20
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.ReadOnly = True
        Me.txt_precio.Size = New System.Drawing.Size(78, 20)
        Me.txt_precio.TabIndex = 7
        Me.txt_precio.Visible = False
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Location = New System.Drawing.Point(19, 282)
        Me.txt_observaciones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_observaciones.MaxLength = 350
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(628, 68)
        Me.txt_observaciones.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(559, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Precio"
        Me.Label12.Visible = False
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(384, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Existencia actual"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(98, 36)
        Me.txt_descripcion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_descripcion.MaxLength = 20
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.ReadOnly = True
        Me.txt_descripcion.Size = New System.Drawing.Size(279, 20)
        Me.txt_descripcion.TabIndex = 5
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(18, 36)
        Me.txt_codigo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_codigo.MaxLength = 20
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(72, 20)
        Me.txt_codigo.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(478, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Cantidad para prestamo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(96, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Descripción"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Codigo"
        '
        'cboPuntoVentaOrigen
        '
        Me.cboPuntoVentaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPuntoVentaOrigen.FormattingEnabled = True
        Me.cboPuntoVentaOrigen.Location = New System.Drawing.Point(19, 66)
        Me.cboPuntoVentaOrigen.Name = "cboPuntoVentaOrigen"
        Me.cboPuntoVentaOrigen.Size = New System.Drawing.Size(194, 21)
        Me.cboPuntoVentaOrigen.TabIndex = 10
        '
        'cboPuntoVentaDestino
        '
        Me.cboPuntoVentaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPuntoVentaDestino.FormattingEnabled = True
        Me.cboPuntoVentaDestino.Location = New System.Drawing.Point(231, 66)
        Me.cboPuntoVentaDestino.Name = "cboPuntoVentaDestino"
        Me.cboPuntoVentaDestino.Size = New System.Drawing.Size(194, 21)
        Me.cboPuntoVentaDestino.TabIndex = 11
        '
        'dt_fecha
        '
        Me.dt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fecha.Location = New System.Drawing.Point(451, 67)
        Me.dt_fecha.Name = "dt_fecha"
        Me.dt_fecha.Size = New System.Drawing.Size(194, 20)
        Me.dt_fecha.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Punto de Venta Origen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(452, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(228, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Punto de Venta Destino"
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(276, 9)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 13)
        Me.Label36.TabIndex = 15
        Me.Label36.Text = "Usuario->"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(348, 9)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(56, 13)
        Me.txtUsuario.TabIndex = 16
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Enabled = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bt_guardar, Me.ToolStripSeparator2, Me.bt_buscar, Me.ToolStripSeparator4, Me.bt_eliminar, Me.ToolStripSeparator5, Me.btnImprimir, Me.ToolStripSeparator6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(663, 25)
        Me.ToolStrip1.TabIndex = 14
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'btnImprimir
        '
        Me.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImprimir.Image = Global.LcPymes_5._2.My.Resources.Resources.business
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(23, 22)
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.ToolTipText = "Reporte"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(410, 9)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(235, 13)
        Me.txtNombreUsuario.TabIndex = 17
        '
        'lb_id
        '
        Me.lb_id.AutoSize = True
        Me.lb_id.Location = New System.Drawing.Point(632, 34)
        Me.lb_id.Name = "lb_id"
        Me.lb_id.Size = New System.Drawing.Size(13, 13)
        Me.lb_id.TabIndex = 18
        Me.lb_id.Text = "0"
        '
        'frmTrasladosDepartamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 460)
        Me.Controls.Add(Me.lb_id)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.cboPuntoVentaOrigen)
        Me.Controls.Add(Me.cboPuntoVentaDestino)
        Me.Controls.Add(Me.dt_fecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gp_2)
        Me.Name = "frmTrasladosDepartamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traslados entre Puntos de Venta"
        Me.gp_2.ResumeLayout(False)
        Me.gp_2.PerformLayout()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gp_2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_cantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_prestamo As System.Windows.Forms.TextBox
    Friend WithEvents bt_agregar As System.Windows.Forms.Button
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_existencia_act As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboPuntoVentaOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents cboPuntoVentaDestino As System.Windows.Forms.ComboBox
    Friend WithEvents dt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bt_guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bt_buscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bt_eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lb_id As System.Windows.Forms.Label
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_prestamo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblAnulado As System.Windows.Forms.Label
End Class
