<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPretomaProveedor
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
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
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
        Me.dt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gp_2 = New System.Windows.Forms.GroupBox()
        Me.lblAnulado = New System.Windows.Forms.Label()
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_prestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_cantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_prestamo = New System.Windows.Forms.TextBox()
        Me.bt_agregar = New System.Windows.Forms.Button()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_existencia_act = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodigoProv = New System.Windows.Forms.TextBox()
        Me.txtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.btnBuscarProveedor = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.gp_2.SuspendLayout()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(165, 40)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(297, 20)
        Me.txtNombreUsuario.TabIndex = 21
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(19, 40)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(84, 20)
        Me.Label36.TabIndex = 19
        Me.Label36.Text = "Usuario :"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(108, 40)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(56, 20)
        Me.txtUsuario.TabIndex = 20
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Enabled = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bt_guardar, Me.ToolStripSeparator2, Me.bt_buscar, Me.ToolStripSeparator4, Me.bt_eliminar, Me.ToolStripSeparator5, Me.btnImprimir, Me.ToolStripSeparator6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(692, 25)
        Me.ToolStrip1.TabIndex = 18
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
        'dt_fecha
        '
        Me.dt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fecha.Location = New System.Drawing.Point(542, 40)
        Me.dt_fecha.Name = "dt_fecha"
        Me.dt_fecha.Size = New System.Drawing.Size(124, 20)
        Me.dt_fecha.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(468, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Fecha :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Proveedor"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gp_2
        '
        Me.gp_2.Controls.Add(Me.lblAnulado)
        Me.gp_2.Controls.Add(Me.viewDatos)
        Me.gp_2.Controls.Add(Me.txt_cantidad)
        Me.gp_2.Controls.Add(Me.Label11)
        Me.gp_2.Controls.Add(Me.txt_prestamo)
        Me.gp_2.Controls.Add(Me.bt_agregar)
        Me.gp_2.Controls.Add(Me.txt_precio)
        Me.gp_2.Controls.Add(Me.Label12)
        Me.gp_2.Controls.Add(Me.txt_existencia_act)
        Me.gp_2.Controls.Add(Me.Label10)
        Me.gp_2.Controls.Add(Me.txt_descripcion)
        Me.gp_2.Controls.Add(Me.txt_codigo)
        Me.gp_2.Controls.Add(Me.Label7)
        Me.gp_2.Controls.Add(Me.Label9)
        Me.gp_2.Controls.Add(Me.Label5)
        Me.gp_2.Enabled = False
        Me.gp_2.Location = New System.Drawing.Point(19, 92)
        Me.gp_2.Name = "gp_2"
        Me.gp_2.Size = New System.Drawing.Size(659, 442)
        Me.gp_2.TabIndex = 27
        Me.gp_2.TabStop = False
        Me.gp_2.Text = "Datos de los productos"
        '
        'lblAnulado
        '
        Me.lblAnulado.AutoSize = True
        Me.lblAnulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnulado.ForeColor = System.Drawing.Color.Red
        Me.lblAnulado.Location = New System.Drawing.Point(246, 250)
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
        Me.viewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.cCodigo, Me.id_prestamo, Me.descripcion, Me.cantidad, Me.id})
        Me.viewDatos.Location = New System.Drawing.Point(15, 63)
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(629, 373)
        Me.viewDatos.TabIndex = 2
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.Visible = False
        '
        'cCodigo
        '
        Me.cCodigo.DataPropertyName = "cCodigo"
        Me.cCodigo.HeaderText = "Codigo"
        Me.cCodigo.Name = "cCodigo"
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
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(478, 37)
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
        Me.Label11.Location = New System.Drawing.Point(480, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Prestamos"
        Me.Label11.Visible = False
        '
        'txt_prestamo
        '
        Me.txt_prestamo.Location = New System.Drawing.Point(472, 86)
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
        Me.bt_agregar.Location = New System.Drawing.Point(557, 35)
        Me.bt_agregar.Name = "bt_agregar"
        Me.bt_agregar.Size = New System.Drawing.Size(75, 23)
        Me.bt_agregar.TabIndex = 8
        Me.bt_agregar.Text = "Agregar"
        Me.bt_agregar.UseVisualStyleBackColor = False
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(559, 86)
        Me.txt_precio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_precio.MaxLength = 20
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.ReadOnly = True
        Me.txt_precio.Size = New System.Drawing.Size(78, 20)
        Me.txt_precio.TabIndex = 7
        Me.txt_precio.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(556, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Precio"
        Me.Label12.Visible = False
        '
        'txt_existencia_act
        '
        Me.txt_existencia_act.Location = New System.Drawing.Point(390, 36)
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
        Me.Label10.Location = New System.Drawing.Point(381, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Existencia actual"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(95, 36)
        Me.txt_descripcion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_descripcion.MaxLength = 20
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.ReadOnly = True
        Me.txt_descripcion.Size = New System.Drawing.Size(279, 20)
        Me.txt_descripcion.TabIndex = 5
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(15, 36)
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
        Me.Label7.Location = New System.Drawing.Point(475, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Cantidad para prestamo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(93, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Descripción"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Codigo"
        '
        'txtCodigoProv
        '
        Me.txtCodigoProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoProv.ForeColor = System.Drawing.Color.Blue
        Me.txtCodigoProv.Location = New System.Drawing.Point(128, 64)
        Me.txtCodigoProv.Name = "txtCodigoProv"
        Me.txtCodigoProv.ReadOnly = True
        Me.txtCodigoProv.Size = New System.Drawing.Size(36, 20)
        Me.txtCodigoProv.TabIndex = 28
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.BackColor = System.Drawing.SystemColors.Control
        Me.txtNombreProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreProveedor.Enabled = False
        Me.txtNombreProveedor.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreProveedor.Location = New System.Drawing.Point(165, 64)
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.ReadOnly = True
        Me.txtNombreProveedor.Size = New System.Drawing.Size(501, 20)
        Me.txtNombreProveedor.TabIndex = 29
        '
        'btnBuscarProveedor
        '
        Me.btnBuscarProveedor.Location = New System.Drawing.Point(108, 62)
        Me.btnBuscarProveedor.Name = "btnBuscarProveedor"
        Me.btnBuscarProveedor.Size = New System.Drawing.Size(19, 23)
        Me.btnBuscarProveedor.TabIndex = 30
        Me.btnBuscarProveedor.Text = "Button1"
        Me.btnBuscarProveedor.UseVisualStyleBackColor = True
        '
        'frmPretomaProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 546)
        Me.Controls.Add(Me.btnBuscarProveedor)
        Me.Controls.Add(Me.txtNombreProveedor)
        Me.Controls.Add(Me.txtCodigoProv)
        Me.Controls.Add(Me.gp_2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dt_fecha)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(708, 585)
        Me.Name = "frmPretomaProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar pretoma"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gp_2.ResumeLayout(False)
        Me.gp_2.PerformLayout()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
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
    Friend WithEvents dt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gp_2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblAnulado As System.Windows.Forms.Label
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents txt_cantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_prestamo As System.Windows.Forms.TextBox
    Friend WithEvents bt_agregar As System.Windows.Forms.Button
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_existencia_act As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoProv As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreProveedor As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarProveedor As System.Windows.Forms.Button
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_prestamo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
