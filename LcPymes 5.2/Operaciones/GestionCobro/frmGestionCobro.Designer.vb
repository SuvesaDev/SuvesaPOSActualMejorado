<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionCobro
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
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.cEditar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cIdentificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCorreo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cContesto = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cDetalleLlamada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cEnviarCorreo = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cEnvioMensaje = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cEnviarCarta = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cEnvioCarta = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cListo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnCargarDatos = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEdiarCliente = New System.Windows.Forms.Button()
        Me.lblTotalFacturas = New System.Windows.Forms.Label()
        Me.btnCarta = New System.Windows.Forms.Button()
        Me.btnCorreo = New System.Windows.Forms.Button()
        Me.viewFacturas = New System.Windows.Forms.DataGridView()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.viewBitacora = New System.Windows.Forms.DataGridView()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.viewFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.viewBitacora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'viewDatos
        '
        Me.viewDatos.AllowUserToAddRows = False
        Me.viewDatos.AllowUserToDeleteRows = False
        Me.viewDatos.AllowUserToResizeColumns = False
        Me.viewDatos.AllowUserToResizeRows = False
        Me.viewDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.viewDatos.BackgroundColor = System.Drawing.Color.White
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cEditar, Me.cIdentificacion, Me.cCedula, Me.cNombre, Me.cTelefono, Me.cCorreo, Me.cContesto, Me.cDetalleLlamada, Me.cEnviarCorreo, Me.cEnvioMensaje, Me.cEnviarCarta, Me.cEnvioCarta, Me.cListo})
        Me.viewDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewDatos.Location = New System.Drawing.Point(3, 16)
        Me.viewDatos.MultiSelect = False
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.RowTemplate.Height = 29
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(577, 434)
        Me.viewDatos.TabIndex = 0
        '
        'cEditar
        '
        Me.cEditar.HeaderText = "Editar"
        Me.cEditar.Name = "cEditar"
        Me.cEditar.Visible = False
        Me.cEditar.Width = 40
        '
        'cIdentificacion
        '
        Me.cIdentificacion.HeaderText = "Identificacion"
        Me.cIdentificacion.Name = "cIdentificacion"
        Me.cIdentificacion.ReadOnly = True
        Me.cIdentificacion.Visible = False
        Me.cIdentificacion.Width = 76
        '
        'cCedula
        '
        Me.cCedula.HeaderText = "Cedula"
        Me.cCedula.Name = "cCedula"
        Me.cCedula.ReadOnly = True
        Me.cCedula.Width = 65
        '
        'cNombre
        '
        Me.cNombre.HeaderText = "Nombre"
        Me.cNombre.Name = "cNombre"
        Me.cNombre.ReadOnly = True
        Me.cNombre.Width = 69
        '
        'cTelefono
        '
        Me.cTelefono.HeaderText = "Telefono"
        Me.cTelefono.Name = "cTelefono"
        Me.cTelefono.ReadOnly = True
        Me.cTelefono.Width = 74
        '
        'cCorreo
        '
        Me.cCorreo.HeaderText = "Correo"
        Me.cCorreo.Name = "cCorreo"
        Me.cCorreo.Visible = False
        Me.cCorreo.Width = 63
        '
        'cContesto
        '
        Me.cContesto.HeaderText = "Contesto"
        Me.cContesto.Name = "cContesto"
        Me.cContesto.Width = 55
        '
        'cDetalleLlamada
        '
        Me.cDetalleLlamada.HeaderText = "Detalle Llamada"
        Me.cDetalleLlamada.Name = "cDetalleLlamada"
        Me.cDetalleLlamada.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cDetalleLlamada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cDetalleLlamada.Width = 80
        '
        'cEnviarCorreo
        '
        Me.cEnviarCorreo.HeaderText = "Email"
        Me.cEnviarCorreo.Name = "cEnviarCorreo"
        Me.cEnviarCorreo.Visible = False
        Me.cEnviarCorreo.Width = 38
        '
        'cEnvioMensaje
        '
        Me.cEnvioMensaje.HeaderText = "EnvioMensaje"
        Me.cEnvioMensaje.Name = "cEnvioMensaje"
        Me.cEnvioMensaje.Visible = False
        Me.cEnvioMensaje.Width = 80
        '
        'cEnviarCarta
        '
        Me.cEnviarCarta.HeaderText = "Carta"
        Me.cEnviarCarta.Name = "cEnviarCarta"
        Me.cEnviarCarta.Visible = False
        Me.cEnviarCarta.Width = 38
        '
        'cEnvioCarta
        '
        Me.cEnvioCarta.HeaderText = "EnvioCarta"
        Me.cEnvioCarta.Name = "cEnvioCarta"
        Me.cEnvioCarta.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cEnvioCarta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cEnvioCarta.Visible = False
        Me.cEnvioCarta.Width = 84
        '
        'cListo
        '
        Me.cListo.HeaderText = "Listo"
        Me.cListo.Name = "cListo"
        Me.cListo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cListo.Width = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario : "
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(70, 6)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(55, 20)
        Me.txtClave.TabIndex = 2
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Location = New System.Drawing.Point(131, 6)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(267, 20)
        Me.txtNombreUsuario.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.viewDatos)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(583, 453)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Clientes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(404, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(447, 6)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(157, 20)
        Me.dtpFecha.TabIndex = 6
        '
        'btnCargarDatos
        '
        Me.btnCargarDatos.Enabled = False
        Me.btnCargarDatos.Location = New System.Drawing.Point(610, 4)
        Me.btnCargarDatos.Name = "btnCargarDatos"
        Me.btnCargarDatos.Size = New System.Drawing.Size(118, 23)
        Me.btnCargarDatos.TabIndex = 7
        Me.btnCargarDatos.Text = "Cargar Datos"
        Me.btnCargarDatos.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Controls.Add(Me.btnEdiarCliente)
        Me.GroupBox2.Controls.Add(Me.btnCarta)
        Me.GroupBox2.Controls.Add(Me.btnCorreo)
        Me.GroupBox2.Location = New System.Drawing.Point(589, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(383, 453)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de Facturas"
        '
        'btnEdiarCliente
        '
        Me.btnEdiarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdiarCliente.Image = Global.LcPymes_5._2.My.Resources.Resources.user_edit
        Me.btnEdiarCliente.Location = New System.Drawing.Point(254, 16)
        Me.btnEdiarCliente.Name = "btnEdiarCliente"
        Me.btnEdiarCliente.Size = New System.Drawing.Size(124, 55)
        Me.btnEdiarCliente.TabIndex = 4
        Me.btnEdiarCliente.Text = "Editar Cliente"
        Me.btnEdiarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnEdiarCliente.UseVisualStyleBackColor = True
        '
        'lblTotalFacturas
        '
        Me.lblTotalFacturas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalFacturas.Location = New System.Drawing.Point(88, 323)
        Me.lblTotalFacturas.Name = "lblTotalFacturas"
        Me.lblTotalFacturas.Size = New System.Drawing.Size(278, 23)
        Me.lblTotalFacturas.TabIndex = 3
        Me.lblTotalFacturas.Text = "Total: 0.00"
        Me.lblTotalFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCarta
        '
        Me.btnCarta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCarta.Image = Global.LcPymes_5._2.My.Resources.Resources.new_email
        Me.btnCarta.Location = New System.Drawing.Point(128, 16)
        Me.btnCarta.Name = "btnCarta"
        Me.btnCarta.Size = New System.Drawing.Size(124, 55)
        Me.btnCarta.TabIndex = 2
        Me.btnCarta.Text = "Enviar Carta"
        Me.btnCarta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCarta.UseVisualStyleBackColor = True
        '
        'btnCorreo
        '
        Me.btnCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCorreo.Image = Global.LcPymes_5._2.My.Resources.Resources.at_sign
        Me.btnCorreo.Location = New System.Drawing.Point(3, 16)
        Me.btnCorreo.Name = "btnCorreo"
        Me.btnCorreo.Size = New System.Drawing.Size(124, 55)
        Me.btnCorreo.TabIndex = 1
        Me.btnCorreo.Text = "Enviar Correo"
        Me.btnCorreo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCorreo.UseVisualStyleBackColor = True
        '
        'viewFacturas
        '
        Me.viewFacturas.AllowUserToAddRows = False
        Me.viewFacturas.AllowUserToDeleteRows = False
        Me.viewFacturas.AllowUserToResizeColumns = False
        Me.viewFacturas.AllowUserToResizeRows = False
        Me.viewFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.viewFacturas.BackgroundColor = System.Drawing.Color.White
        Me.viewFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewFacturas.Location = New System.Drawing.Point(3, 6)
        Me.viewFacturas.MultiSelect = False
        Me.viewFacturas.Name = "viewFacturas"
        Me.viewFacturas.ReadOnly = True
        Me.viewFacturas.RowHeadersVisible = False
        Me.viewFacturas.RowTemplate.Height = 29
        Me.viewFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewFacturas.Size = New System.Drawing.Size(363, 314)
        Me.viewFacturas.TabIndex = 0
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(734, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(118, 23)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar Datos"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 74)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(377, 375)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblTotalFacturas)
        Me.TabPage1.Controls.Add(Me.viewFacturas)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(369, 349)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Facturas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.viewBitacora)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(369, 349)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Bitacora "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'viewBitacora
        '
        Me.viewBitacora.AllowUserToAddRows = False
        Me.viewBitacora.AllowUserToDeleteRows = False
        Me.viewBitacora.AllowUserToResizeColumns = False
        Me.viewBitacora.AllowUserToResizeRows = False
        Me.viewBitacora.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.viewBitacora.BackgroundColor = System.Drawing.Color.White
        Me.viewBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewBitacora.Location = New System.Drawing.Point(3, 0)
        Me.viewBitacora.MultiSelect = False
        Me.viewBitacora.Name = "viewBitacora"
        Me.viewBitacora.ReadOnly = True
        Me.viewBitacora.RowHeadersVisible = False
        Me.viewBitacora.RowTemplate.Height = 29
        Me.viewBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewBitacora.Size = New System.Drawing.Size(363, 314)
        Me.viewBitacora.TabIndex = 1
        '
        'frmGestionCobro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 488)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCargarDatos)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmGestionCobro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Cobros"
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.viewFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.viewBitacora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCargarDatos As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents viewFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCarta As System.Windows.Forms.Button
    Friend WithEvents btnCorreo As System.Windows.Forms.Button
    Friend WithEvents cEditar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cIdentificacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTelefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCorreo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cContesto As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cDetalleLlamada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cEnviarCorreo As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cEnvioMensaje As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cEnviarCarta As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cEnvioCarta As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cListo As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents lblTotalFacturas As System.Windows.Forms.Label
    Friend WithEvents btnEdiarCliente As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents viewBitacora As System.Windows.Forms.DataGridView
End Class
