<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTomaProveedor
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bt_guardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.bt_buscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.bt_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.txtCodigoProv = New System.Windows.Forms.TextBox()
        Me.gp_2 = New System.Windows.Forms.GroupBox()
        Me.lblAnulado = New System.Windows.Forms.Label()
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.existencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDiferencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_prestamo = New System.Windows.Forms.TextBox()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.btnGenerarToma = New System.Windows.Forms.Button()
        Me.btnBuscarProveedor = New System.Windows.Forms.Button()
        Me.btnActualizarExistencia = New System.Windows.Forms.Button()
        Me.btnCargarPretoma = New System.Windows.Forms.Button()
        Me.btnAplicarAjustes = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.gp_2.SuspendLayout()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Enabled = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bt_guardar, Me.ToolStripSeparator2, Me.bt_buscar, Me.ToolStripSeparator4, Me.bt_eliminar, Me.ToolStripSeparator5, Me.btnImprimir, Me.ToolStripSeparator6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(692, 25)
        Me.ToolStrip1.TabIndex = 19
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
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.BackColor = System.Drawing.SystemColors.Control
        Me.txtNombreProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreProveedor.Enabled = False
        Me.txtNombreProveedor.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreProveedor.Location = New System.Drawing.Point(163, 61)
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.ReadOnly = True
        Me.txtNombreProveedor.Size = New System.Drawing.Size(501, 20)
        Me.txtNombreProveedor.TabIndex = 38
        '
        'txtCodigoProv
        '
        Me.txtCodigoProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoProv.ForeColor = System.Drawing.Color.Blue
        Me.txtCodigoProv.Location = New System.Drawing.Point(128, 61)
        Me.txtCodigoProv.Name = "txtCodigoProv"
        Me.txtCodigoProv.ReadOnly = True
        Me.txtCodigoProv.Size = New System.Drawing.Size(34, 20)
        Me.txtCodigoProv.TabIndex = 37
        '
        'gp_2
        '
        Me.gp_2.Controls.Add(Me.lblAnulado)
        Me.gp_2.Controls.Add(Me.viewDatos)
        Me.gp_2.Controls.Add(Me.Label11)
        Me.gp_2.Controls.Add(Me.txt_prestamo)
        Me.gp_2.Controls.Add(Me.txt_precio)
        Me.gp_2.Controls.Add(Me.Label12)
        Me.gp_2.Enabled = False
        Me.gp_2.Location = New System.Drawing.Point(17, 117)
        Me.gp_2.Name = "gp_2"
        Me.gp_2.Size = New System.Drawing.Size(659, 424)
        Me.gp_2.TabIndex = 36
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
        Me.viewDatos.AllowUserToAddRows = False
        Me.viewDatos.AllowUserToDeleteRows = False
        Me.viewDatos.AllowUserToResizeColumns = False
        Me.viewDatos.AllowUserToResizeRows = False
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.cCodigo, Me.descripcion, Me.existencia, Me.toma, Me.cDiferencia, Me.id})
        Me.viewDatos.Location = New System.Drawing.Point(10, 19)
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(637, 394)
        Me.viewDatos.TabIndex = 2
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "Codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Visible = False
        '
        'cCodigo
        '
        Me.cCodigo.DataPropertyName = "cCodigo"
        Me.cCodigo.HeaderText = "Codigo"
        Me.cCodigo.Name = "cCodigo"
        Me.cCodigo.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 285
        '
        'existencia
        '
        Me.existencia.DataPropertyName = "existencia"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        Me.existencia.DefaultCellStyle = DataGridViewCellStyle7
        Me.existencia.HeaderText = "Existencia"
        Me.existencia.Name = "existencia"
        Me.existencia.ReadOnly = True
        Me.existencia.Width = 75
        '
        'toma
        '
        Me.toma.DataPropertyName = "toma"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        Me.toma.DefaultCellStyle = DataGridViewCellStyle8
        Me.toma.HeaderText = "Toma"
        Me.toma.Name = "toma"
        Me.toma.Width = 75
        '
        'cDiferencia
        '
        Me.cDiferencia.DataPropertyName = "cDiferencia"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        Me.cDiferencia.DefaultCellStyle = DataGridViewCellStyle9
        Me.cDiferencia.HeaderText = "Diferencia"
        Me.cDiferencia.Name = "cDiferencia"
        Me.cDiferencia.ReadOnly = True
        Me.cDiferencia.Width = 75
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
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
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(27, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Proveedor :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(466, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Fecha :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dt_fecha
        '
        Me.dt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fecha.Location = New System.Drawing.Point(540, 37)
        Me.dt_fecha.Name = "dt_fecha"
        Me.dt_fecha.Size = New System.Drawing.Size(124, 20)
        Me.dt_fecha.TabIndex = 33
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(163, 37)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(297, 20)
        Me.txtNombreUsuario.TabIndex = 32
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(27, 37)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(77, 20)
        Me.Label36.TabIndex = 30
        Me.Label36.Text = "Usuario :"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(106, 37)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(56, 20)
        Me.txtUsuario.TabIndex = 31
        '
        'btnGenerarToma
        '
        Me.btnGenerarToma.Location = New System.Drawing.Point(27, 88)
        Me.btnGenerarToma.Name = "btnGenerarToma"
        Me.btnGenerarToma.Size = New System.Drawing.Size(99, 23)
        Me.btnGenerarToma.TabIndex = 39
        Me.btnGenerarToma.Text = "Generar Toma "
        Me.btnGenerarToma.UseVisualStyleBackColor = True
        '
        'btnBuscarProveedor
        '
        Me.btnBuscarProveedor.Location = New System.Drawing.Point(107, 60)
        Me.btnBuscarProveedor.Name = "btnBuscarProveedor"
        Me.btnBuscarProveedor.Size = New System.Drawing.Size(19, 22)
        Me.btnBuscarProveedor.TabIndex = 40
        Me.btnBuscarProveedor.Text = "Button1"
        Me.btnBuscarProveedor.UseVisualStyleBackColor = True
        '
        'btnActualizarExistencia
        '
        Me.btnActualizarExistencia.Location = New System.Drawing.Point(129, 88)
        Me.btnActualizarExistencia.Name = "btnActualizarExistencia"
        Me.btnActualizarExistencia.Size = New System.Drawing.Size(99, 23)
        Me.btnActualizarExistencia.TabIndex = 41
        Me.btnActualizarExistencia.Text = "Existencia Actual"
        Me.btnActualizarExistencia.UseVisualStyleBackColor = True
        '
        'btnCargarPretoma
        '
        Me.btnCargarPretoma.Location = New System.Drawing.Point(231, 88)
        Me.btnCargarPretoma.Name = "btnCargarPretoma"
        Me.btnCargarPretoma.Size = New System.Drawing.Size(99, 23)
        Me.btnCargarPretoma.TabIndex = 42
        Me.btnCargarPretoma.Text = "Cargar Pretoma"
        Me.btnCargarPretoma.UseVisualStyleBackColor = True
        '
        'btnAplicarAjustes
        '
        Me.btnAplicarAjustes.Enabled = False
        Me.btnAplicarAjustes.Location = New System.Drawing.Point(336, 88)
        Me.btnAplicarAjustes.Name = "btnAplicarAjustes"
        Me.btnAplicarAjustes.Size = New System.Drawing.Size(99, 23)
        Me.btnAplicarAjustes.TabIndex = 43
        Me.btnAplicarAjustes.Text = "Aplicar Ajustes"
        Me.btnAplicarAjustes.UseVisualStyleBackColor = True
        '
        'frmTomaProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 546)
        Me.Controls.Add(Me.btnAplicarAjustes)
        Me.Controls.Add(Me.btnCargarPretoma)
        Me.Controls.Add(Me.btnActualizarExistencia)
        Me.Controls.Add(Me.btnBuscarProveedor)
        Me.Controls.Add(Me.btnGenerarToma)
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
        Me.Name = "frmTomaProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Toma por Proveedor"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gp_2.ResumeLayout(False)
        Me.gp_2.PerformLayout()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bt_guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bt_buscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bt_eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtNombreProveedor As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoProv As System.Windows.Forms.TextBox
    Friend WithEvents gp_2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblAnulado As System.Windows.Forms.Label
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_prestamo As System.Windows.Forms.TextBox
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerarToma As System.Windows.Forms.Button
    Friend WithEvents btnBuscarProveedor As System.Windows.Forms.Button
    Friend WithEvents btnActualizarExistencia As System.Windows.Forms.Button
    Friend WithEvents btnCargarPretoma As System.Windows.Forms.Button
    Friend WithEvents btnAplicarAjustes As System.Windows.Forms.Button
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents existencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents toma As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDiferencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
