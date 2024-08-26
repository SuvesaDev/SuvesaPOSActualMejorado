<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoPedido
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
        Me.dtpFechaSolicitud = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsuarioSolicita = New System.Windows.Forms.TextBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.cCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCodArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrecioUnid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboSolicitarA = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.NumericUpDown()
        Me.bt_agregar = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bt_nuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bt_guardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.bt_editar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.bt_buscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpFechaSolicitud
        '
        Me.dtpFechaSolicitud.CustomFormat = "dd/MM/yyyy hh:mm:ss tt"
        Me.dtpFechaSolicitud.Enabled = False
        Me.dtpFechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaSolicitud.Location = New System.Drawing.Point(11, 35)
        Me.dtpFechaSolicitud.Name = "dtpFechaSolicitud"
        Me.dtpFechaSolicitud.Size = New System.Drawing.Size(184, 20)
        Me.dtpFechaSolicitud.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha Solicitud"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(216, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Usuario Solicita"
        '
        'txtUsuarioSolicita
        '
        Me.txtUsuarioSolicita.Location = New System.Drawing.Point(219, 35)
        Me.txtUsuarioSolicita.Name = "txtUsuarioSolicita"
        Me.txtUsuarioSolicita.ReadOnly = True
        Me.txtUsuarioSolicita.Size = New System.Drawing.Size(191, 20)
        Me.txtUsuarioSolicita.TabIndex = 3
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(94, 78)
        Me.txt_descripcion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_descripcion.MaxLength = 20
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.ReadOnly = True
        Me.txt_descripcion.Size = New System.Drawing.Size(531, 20)
        Me.txt_descripcion.TabIndex = 9
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(14, 78)
        Me.txt_codigo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_codigo.MaxLength = 20
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(72, 20)
        Me.txt_codigo.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(92, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Descripción"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Codigo"
        '
        'viewDatos
        '
        Me.viewDatos.AllowDrop = True
        Me.viewDatos.AllowUserToAddRows = False
        Me.viewDatos.AllowUserToOrderColumns = True
        Me.viewDatos.AllowUserToResizeColumns = False
        Me.viewDatos.AllowUserToResizeRows = False
        Me.viewDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewDatos.BackgroundColor = System.Drawing.Color.White
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cCodigo, Me.cCodArticulo, Me.cDescripcion, Me.cCantidad, Me.cObservaciones, Me.cPrecioUnid})
        Me.viewDatos.Location = New System.Drawing.Point(15, 145)
        Me.viewDatos.MultiSelect = False
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.ReadOnly = True
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.RowTemplate.Height = 28
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(610, 374)
        Me.viewDatos.TabIndex = 10
        '
        'cCodigo
        '
        Me.cCodigo.HeaderText = "Codigo"
        Me.cCodigo.Name = "cCodigo"
        Me.cCodigo.ReadOnly = True
        Me.cCodigo.Visible = False
        Me.cCodigo.Width = 75
        '
        'cCodArticulo
        '
        Me.cCodArticulo.HeaderText = "Codigo"
        Me.cCodArticulo.Name = "cCodArticulo"
        Me.cCodArticulo.ReadOnly = True
        Me.cCodArticulo.Width = 75
        '
        'cDescripcion
        '
        Me.cDescripcion.HeaderText = "Descripcion"
        Me.cDescripcion.Name = "cDescripcion"
        Me.cDescripcion.ReadOnly = True
        Me.cDescripcion.Width = 235
        '
        'cCantidad
        '
        Me.cCantidad.HeaderText = "Cantidad"
        Me.cCantidad.Name = "cCantidad"
        Me.cCantidad.ReadOnly = True
        Me.cCantidad.Width = 75
        '
        'cObservaciones
        '
        Me.cObservaciones.HeaderText = "Observaciones"
        Me.cObservaciones.Name = "cObservaciones"
        Me.cObservaciones.ReadOnly = True
        Me.cObservaciones.Width = 200
        '
        'cPrecioUnid
        '
        Me.cPrecioUnid.HeaderText = "PrecioUnid"
        Me.cPrecioUnid.Name = "cPrecioUnid"
        Me.cPrecioUnid.ReadOnly = True
        Me.cPrecioUnid.Visible = False
        '
        'Label36
        '
        Me.Label36.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label36.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(193, 560)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 19)
        Me.Label36.TabIndex = 15
        Me.Label36.Text = "Usuario->"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(324, 560)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(331, 20)
        Me.txtNombreUsuario.TabIndex = 17
        '
        'txtUsuario
        '
        Me.txtUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(267, 560)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(56, 20)
        Me.txtUsuario.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cboSolicitarA)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_cantidad)
        Me.GroupBox1.Controls.Add(Me.bt_agregar)
        Me.GroupBox1.Controls.Add(Me.viewDatos)
        Me.GroupBox1.Controls.Add(Me.dtpFechaSolicitud)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtUsuarioSolicita)
        Me.GroupBox1.Controls.Add(Me.txt_descripcion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_codigo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(643, 525)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'cboSolicitarA
        '
        Me.cboSolicitarA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSolicitarA.FormattingEnabled = True
        Me.cboSolicitarA.Location = New System.Drawing.Point(418, 35)
        Me.cboSolicitarA.Name = "cboSolicitarA"
        Me.cboSolicitarA.Size = New System.Drawing.Size(206, 21)
        Me.cboSolicitarA.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(419, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Solicitar a "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(92, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(92, 117)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(452, 20)
        Me.txtObservaciones.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Cant Solicitar"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(15, 118)
        Me.txt_cantidad.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txt_cantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(71, 20)
        Me.txt_cantidad.TabIndex = 12
        Me.txt_cantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'bt_agregar
        '
        Me.bt_agregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_agregar.ForeColor = System.Drawing.Color.White
        Me.bt_agregar.Location = New System.Drawing.Point(550, 114)
        Me.bt_agregar.Name = "bt_agregar"
        Me.bt_agregar.Size = New System.Drawing.Size(75, 24)
        Me.bt_agregar.TabIndex = 11
        Me.bt_agregar.Text = "Agregar"
        Me.bt_agregar.UseVisualStyleBackColor = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Enabled = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bt_nuevo, Me.ToolStripSeparator1, Me.bt_guardar, Me.ToolStripSeparator2, Me.bt_editar, Me.ToolStripSeparator3, Me.bt_buscar, Me.ToolStripSeparator4, Me.ToolStripSeparator5, Me.ToolStripButton2, Me.ToolStripSeparator6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(669, 25)
        Me.ToolStrip1.TabIndex = 19
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
        Me.bt_editar.Enabled = False
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
        'frmNuevoPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 582)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.txtUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmNuevoPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Pedido a Bodega"
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFechaSolicitud As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUsuarioSolicita As System.Windows.Forms.TextBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bt_nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bt_guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bt_editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bt_buscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents bt_agregar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents cboSolicitarA As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCodArticulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPrecioUnid As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
