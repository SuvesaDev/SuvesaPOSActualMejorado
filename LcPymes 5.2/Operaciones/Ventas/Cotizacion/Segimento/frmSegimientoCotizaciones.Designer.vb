<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSegimientoCotizaciones
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
        Me.ckFiltrarxEstado = New System.Windows.Forms.CheckBox()
        Me.gbFiltrarxEstado = New System.Windows.Forms.GroupBox()
        Me.ckPerdida = New System.Windows.Forms.CheckBox()
        Me.ckConfirmado = New System.Windows.Forms.CheckBox()
        Me.ckGanada = New System.Windows.Forms.CheckBox()
        Me.ckEnviadosinConfirmar = New System.Windows.Forms.CheckBox()
        Me.ckRevision = New System.Windows.Forms.CheckBox()
        Me.ckPendienteEnvio = New System.Windows.Forms.CheckBox()
        Me.ckFiltrarxFecha = New System.Windows.Forms.CheckBox()
        Me.gbFiltrarxFecha = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTotalVenta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.Cotizacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Enviar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Llamar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ckInfoFactura = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAbrir = New System.Windows.Forms.ToolStripButton()
        Me.gbFiltrarxEstado.SuspendLayout()
        Me.gbFiltrarxFecha.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ckFiltrarxEstado
        '
        Me.ckFiltrarxEstado.AutoSize = True
        Me.ckFiltrarxEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckFiltrarxEstado.Location = New System.Drawing.Point(255, 11)
        Me.ckFiltrarxEstado.Name = "ckFiltrarxEstado"
        Me.ckFiltrarxEstado.Size = New System.Drawing.Size(129, 20)
        Me.ckFiltrarxEstado.TabIndex = 23
        Me.ckFiltrarxEstado.Text = "Filtrar por Estado"
        Me.ckFiltrarxEstado.UseVisualStyleBackColor = True
        '
        'gbFiltrarxEstado
        '
        Me.gbFiltrarxEstado.Controls.Add(Me.ckPerdida)
        Me.gbFiltrarxEstado.Controls.Add(Me.ckConfirmado)
        Me.gbFiltrarxEstado.Controls.Add(Me.ckGanada)
        Me.gbFiltrarxEstado.Controls.Add(Me.ckEnviadosinConfirmar)
        Me.gbFiltrarxEstado.Controls.Add(Me.ckRevision)
        Me.gbFiltrarxEstado.Controls.Add(Me.ckPendienteEnvio)
        Me.gbFiltrarxEstado.Enabled = False
        Me.gbFiltrarxEstado.Location = New System.Drawing.Point(249, 15)
        Me.gbFiltrarxEstado.Name = "gbFiltrarxEstado"
        Me.gbFiltrarxEstado.Size = New System.Drawing.Size(317, 77)
        Me.gbFiltrarxEstado.TabIndex = 22
        Me.gbFiltrarxEstado.TabStop = False
        '
        'ckPerdida
        '
        Me.ckPerdida.AutoSize = True
        Me.ckPerdida.BackColor = System.Drawing.Color.Purple
        Me.ckPerdida.ForeColor = System.Drawing.Color.White
        Me.ckPerdida.Location = New System.Drawing.Point(167, 57)
        Me.ckPerdida.Name = "ckPerdida"
        Me.ckPerdida.Size = New System.Drawing.Size(62, 17)
        Me.ckPerdida.TabIndex = 5
        Me.ckPerdida.Text = "Perdida"
        Me.ckPerdida.UseVisualStyleBackColor = False
        '
        'ckConfirmado
        '
        Me.ckConfirmado.AutoSize = True
        Me.ckConfirmado.BackColor = System.Drawing.Color.Yellow
        Me.ckConfirmado.Location = New System.Drawing.Point(26, 57)
        Me.ckConfirmado.Name = "ckConfirmado"
        Me.ckConfirmado.Size = New System.Drawing.Size(79, 17)
        Me.ckConfirmado.TabIndex = 4
        Me.ckConfirmado.Text = "Confirmada"
        Me.ckConfirmado.UseVisualStyleBackColor = False
        '
        'ckGanada
        '
        Me.ckGanada.AutoSize = True
        Me.ckGanada.BackColor = System.Drawing.Color.Green
        Me.ckGanada.ForeColor = System.Drawing.Color.White
        Me.ckGanada.Location = New System.Drawing.Point(167, 38)
        Me.ckGanada.Name = "ckGanada"
        Me.ckGanada.Size = New System.Drawing.Size(64, 17)
        Me.ckGanada.TabIndex = 3
        Me.ckGanada.Text = "Ganada"
        Me.ckGanada.UseVisualStyleBackColor = False
        '
        'ckEnviadosinConfirmar
        '
        Me.ckEnviadosinConfirmar.AutoSize = True
        Me.ckEnviadosinConfirmar.BackColor = System.Drawing.Color.Orange
        Me.ckEnviadosinConfirmar.ForeColor = System.Drawing.Color.White
        Me.ckEnviadosinConfirmar.Location = New System.Drawing.Point(26, 38)
        Me.ckEnviadosinConfirmar.Name = "ckEnviadosinConfirmar"
        Me.ckEnviadosinConfirmar.Size = New System.Drawing.Size(124, 17)
        Me.ckEnviadosinConfirmar.TabIndex = 2
        Me.ckEnviadosinConfirmar.Text = "Enviada sin confirma"
        Me.ckEnviadosinConfirmar.UseVisualStyleBackColor = False
        '
        'ckRevision
        '
        Me.ckRevision.AutoSize = True
        Me.ckRevision.Location = New System.Drawing.Point(167, 19)
        Me.ckRevision.Name = "ckRevision"
        Me.ckRevision.Size = New System.Drawing.Size(67, 17)
        Me.ckRevision.TabIndex = 1
        Me.ckRevision.Text = "Revision"
        Me.ckRevision.UseVisualStyleBackColor = True
        '
        'ckPendienteEnvio
        '
        Me.ckPendienteEnvio.AutoSize = True
        Me.ckPendienteEnvio.BackColor = System.Drawing.Color.Red
        Me.ckPendienteEnvio.ForeColor = System.Drawing.Color.White
        Me.ckPendienteEnvio.Location = New System.Drawing.Point(26, 19)
        Me.ckPendienteEnvio.Name = "ckPendienteEnvio"
        Me.ckPendienteEnvio.Size = New System.Drawing.Size(118, 17)
        Me.ckPendienteEnvio.TabIndex = 0
        Me.ckPendienteEnvio.Text = "Pendiente de envio"
        Me.ckPendienteEnvio.UseVisualStyleBackColor = False
        '
        'ckFiltrarxFecha
        '
        Me.ckFiltrarxFecha.AutoSize = True
        Me.ckFiltrarxFecha.Checked = True
        Me.ckFiltrarxFecha.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckFiltrarxFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckFiltrarxFecha.Location = New System.Drawing.Point(18, 11)
        Me.ckFiltrarxFecha.Name = "ckFiltrarxFecha"
        Me.ckFiltrarxFecha.Size = New System.Drawing.Size(124, 20)
        Me.ckFiltrarxFecha.TabIndex = 21
        Me.ckFiltrarxFecha.Text = "Filtrar por Fecha"
        Me.ckFiltrarxFecha.UseVisualStyleBackColor = True
        '
        'gbFiltrarxFecha
        '
        Me.gbFiltrarxFecha.Controls.Add(Me.Label1)
        Me.gbFiltrarxFecha.Controls.Add(Me.Label2)
        Me.gbFiltrarxFecha.Controls.Add(Me.dtpDesde)
        Me.gbFiltrarxFecha.Controls.Add(Me.dtpHasta)
        Me.gbFiltrarxFecha.Enabled = False
        Me.gbFiltrarxFecha.Location = New System.Drawing.Point(12, 15)
        Me.gbFiltrarxFecha.Name = "gbFiltrarxFecha"
        Me.gbFiltrarxFecha.Size = New System.Drawing.Size(210, 77)
        Me.gbFiltrarxFecha.TabIndex = 20
        Me.gbFiltrarxFecha.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Hasta"
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(50, 22)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(137, 20)
        Me.dtpDesde.TabIndex = 12
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(50, 48)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(137, 20)
        Me.dtpHasta.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtTotalVenta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Controls.Add(Me.viewDatos)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(917, 332)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'txtTotalVenta
        '
        Me.txtTotalVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalVenta.Location = New System.Drawing.Point(739, 309)
        Me.txtTotalVenta.Name = "txtTotalVenta"
        Me.txtTotalVenta.ReadOnly = True
        Me.txtTotalVenta.Size = New System.Drawing.Size(175, 20)
        Me.txtTotalVenta.TabIndex = 14
        Me.txtTotalVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(668, 312)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Total Ventas"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.ToolStripTextBox1, Me.btnAbrir})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(911, 39)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.LcPymes_5._2.My.Resources.Resources.arrow_refresh
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(126, 36)
        Me.ToolStripButton1.Text = "Cambiar Estado"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(48, 36)
        Me.ToolStripLabel1.Text = "Buscar :"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(226, 39)
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
        Me.viewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cotizacion, Me.Fecha, Me.Nombre_Cliente, Me.Total, Me.EstadoActual, Me.Contacto, Me.Telefono, Me.NumeroFactura, Me.MontoFactura, Me.Enviar, Me.Llamar})
        Me.viewDatos.Location = New System.Drawing.Point(4, 62)
        Me.viewDatos.MultiSelect = False
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.ReadOnly = True
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewDatos.RowTemplate.Height = 30
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(910, 237)
        Me.viewDatos.TabIndex = 11
        '
        'Cotizacion
        '
        Me.Cotizacion.HeaderText = "Cotizacion"
        Me.Cotizacion.Name = "Cotizacion"
        Me.Cotizacion.ReadOnly = True
        Me.Cotizacion.Width = 81
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 62
        '
        'Nombre_Cliente
        '
        Me.Nombre_Cliente.HeaderText = "Nombre_Cliente"
        Me.Nombre_Cliente.Name = "Nombre_Cliente"
        Me.Nombre_Cliente.ReadOnly = True
        Me.Nombre_Cliente.Width = 107
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 56
        '
        'EstadoActual
        '
        Me.EstadoActual.HeaderText = "EstadoActual"
        Me.EstadoActual.Name = "EstadoActual"
        Me.EstadoActual.ReadOnly = True
        Me.EstadoActual.Width = 95
        '
        'Contacto
        '
        Me.Contacto.HeaderText = "Contacto"
        Me.Contacto.Name = "Contacto"
        Me.Contacto.ReadOnly = True
        Me.Contacto.Width = 75
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        Me.Telefono.Width = 74
        '
        'NumeroFactura
        '
        Me.NumeroFactura.HeaderText = "NumeroFactura"
        Me.NumeroFactura.Name = "NumeroFactura"
        Me.NumeroFactura.ReadOnly = True
        Me.NumeroFactura.Width = 105
        '
        'MontoFactura
        '
        Me.MontoFactura.HeaderText = "MontoFactura"
        Me.MontoFactura.Name = "MontoFactura"
        Me.MontoFactura.ReadOnly = True
        Me.MontoFactura.Width = 98
        '
        'Enviar
        '
        Me.Enviar.HeaderText = "    "
        Me.Enviar.Name = "Enviar"
        Me.Enviar.ReadOnly = True
        Me.Enviar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Enviar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Enviar.Text = "   "
        Me.Enviar.UseColumnTextForButtonValue = True
        Me.Enviar.Width = 42
        '
        'Llamar
        '
        Me.Llamar.HeaderText = ""
        Me.Llamar.Name = "Llamar"
        Me.Llamar.ReadOnly = True
        Me.Llamar.Text = "    "
        Me.Llamar.UseColumnTextForButtonValue = True
        Me.Llamar.Width = 5
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(584, 37)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 53)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Cargar Filtros"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ckInfoFactura
        '
        Me.ckInfoFactura.AutoSize = True
        Me.ckInfoFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckInfoFactura.Location = New System.Drawing.Point(584, 15)
        Me.ckInfoFactura.Name = "ckInfoFactura"
        Me.ckInfoFactura.Size = New System.Drawing.Size(96, 20)
        Me.ckInfoFactura.TabIndex = 26
        Me.ckInfoFactura.Text = "Info Factura"
        Me.ckInfoFactura.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.LcPymes_5._2.My.Resources.Resources.phone_handset
        Me.Button2.Location = New System.Drawing.Point(686, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'btnAbrir
        '
        Me.btnAbrir.Image = Global.LcPymes_5._2.My.Resources.Resources.find
        Me.btnAbrir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(128, 36)
        Me.btnAbrir.Text = "Abrir Cotizacion"
        '
        'frmSegimientoCotizaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 440)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ckInfoFactura)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ckFiltrarxEstado)
        Me.Controls.Add(Me.gbFiltrarxEstado)
        Me.Controls.Add(Me.ckFiltrarxFecha)
        Me.Controls.Add(Me.gbFiltrarxFecha)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmSegimientoCotizaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Segimiento Cotizaciones"
        Me.gbFiltrarxEstado.ResumeLayout(False)
        Me.gbFiltrarxEstado.PerformLayout()
        Me.gbFiltrarxFecha.ResumeLayout(False)
        Me.gbFiltrarxFecha.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ckFiltrarxEstado As System.Windows.Forms.CheckBox
    Friend WithEvents gbFiltrarxEstado As System.Windows.Forms.GroupBox
    Friend WithEvents ckConfirmado As System.Windows.Forms.CheckBox
    Friend WithEvents ckGanada As System.Windows.Forms.CheckBox
    Friend WithEvents ckEnviadosinConfirmar As System.Windows.Forms.CheckBox
    Friend WithEvents ckRevision As System.Windows.Forms.CheckBox
    Friend WithEvents ckPendienteEnvio As System.Windows.Forms.CheckBox
    Friend WithEvents ckFiltrarxFecha As System.Windows.Forms.CheckBox
    Friend WithEvents gbFiltrarxFecha As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents ckPerdida As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ckInfoFactura As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Cotizacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoActual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contacto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Enviar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Llamar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents txtTotalVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAbrir As System.Windows.Forms.ToolStripButton
End Class
