<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaPedidosBodega
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaPedidosBodega))
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.gbFiltrarxFecha = New System.Windows.Forms.GroupBox()
        Me.ckFiltrarxFecha = New System.Windows.Forms.CheckBox()
        Me.ckFiltrarxEstado = New System.Windows.Forms.CheckBox()
        Me.gbFiltrarxEstado = New System.Windows.Forms.GroupBox()
        Me.ckAgotado = New System.Windows.Forms.CheckBox()
        Me.ckAnulado = New System.Windows.Forms.CheckBox()
        Me.ckRecibido = New System.Windows.Forms.CheckBox()
        Me.ckPedido = New System.Windows.Forms.CheckBox()
        Me.ckSolicitado = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPedido = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnRecibido = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAnulado = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAgotado = New System.Windows.Forms.ToolStripButton()
        Me.btnPendientesSolicitud = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFiltrarxFecha.SuspendLayout()
        Me.gbFiltrarxEstado.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.viewDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.viewDatos.BackgroundColor = System.Drawing.Color.White
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Location = New System.Drawing.Point(4, 43)
        Me.viewDatos.MultiSelect = False
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.ReadOnly = True
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(1082, 195)
        Me.viewDatos.TabIndex = 11
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(50, 22)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(137, 20)
        Me.dtpDesde.TabIndex = 12
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
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(50, 48)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(137, 20)
        Me.dtpHasta.TabIndex = 14
        '
        'gbFiltrarxFecha
        '
        Me.gbFiltrarxFecha.Controls.Add(Me.Label1)
        Me.gbFiltrarxFecha.Controls.Add(Me.Label2)
        Me.gbFiltrarxFecha.Controls.Add(Me.dtpDesde)
        Me.gbFiltrarxFecha.Controls.Add(Me.dtpHasta)
        Me.gbFiltrarxFecha.Enabled = False
        Me.gbFiltrarxFecha.Location = New System.Drawing.Point(12, 12)
        Me.gbFiltrarxFecha.Name = "gbFiltrarxFecha"
        Me.gbFiltrarxFecha.Size = New System.Drawing.Size(210, 77)
        Me.gbFiltrarxFecha.TabIndex = 16
        Me.gbFiltrarxFecha.TabStop = False
        '
        'ckFiltrarxFecha
        '
        Me.ckFiltrarxFecha.AutoSize = True
        Me.ckFiltrarxFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckFiltrarxFecha.Location = New System.Drawing.Point(18, 8)
        Me.ckFiltrarxFecha.Name = "ckFiltrarxFecha"
        Me.ckFiltrarxFecha.Size = New System.Drawing.Size(124, 20)
        Me.ckFiltrarxFecha.TabIndex = 17
        Me.ckFiltrarxFecha.Text = "Filtrar por Fecha"
        Me.ckFiltrarxFecha.UseVisualStyleBackColor = True
        '
        'ckFiltrarxEstado
        '
        Me.ckFiltrarxEstado.AutoSize = True
        Me.ckFiltrarxEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckFiltrarxEstado.Location = New System.Drawing.Point(255, 8)
        Me.ckFiltrarxEstado.Name = "ckFiltrarxEstado"
        Me.ckFiltrarxEstado.Size = New System.Drawing.Size(129, 20)
        Me.ckFiltrarxEstado.TabIndex = 19
        Me.ckFiltrarxEstado.Text = "Filtrar por Estado"
        Me.ckFiltrarxEstado.UseVisualStyleBackColor = True
        '
        'gbFiltrarxEstado
        '
        Me.gbFiltrarxEstado.Controls.Add(Me.ckAgotado)
        Me.gbFiltrarxEstado.Controls.Add(Me.ckAnulado)
        Me.gbFiltrarxEstado.Controls.Add(Me.ckRecibido)
        Me.gbFiltrarxEstado.Controls.Add(Me.ckPedido)
        Me.gbFiltrarxEstado.Controls.Add(Me.ckSolicitado)
        Me.gbFiltrarxEstado.Enabled = False
        Me.gbFiltrarxEstado.Location = New System.Drawing.Point(249, 12)
        Me.gbFiltrarxEstado.Name = "gbFiltrarxEstado"
        Me.gbFiltrarxEstado.Size = New System.Drawing.Size(199, 77)
        Me.gbFiltrarxEstado.TabIndex = 18
        Me.gbFiltrarxEstado.TabStop = False
        '
        'ckAgotado
        '
        Me.ckAgotado.AutoSize = True
        Me.ckAgotado.Location = New System.Drawing.Point(26, 57)
        Me.ckAgotado.Name = "ckAgotado"
        Me.ckAgotado.Size = New System.Drawing.Size(66, 17)
        Me.ckAgotado.TabIndex = 4
        Me.ckAgotado.Text = "Agotado"
        Me.ckAgotado.UseVisualStyleBackColor = True
        '
        'ckAnulado
        '
        Me.ckAnulado.AutoSize = True
        Me.ckAnulado.Location = New System.Drawing.Point(104, 38)
        Me.ckAnulado.Name = "ckAnulado"
        Me.ckAnulado.Size = New System.Drawing.Size(65, 17)
        Me.ckAnulado.TabIndex = 3
        Me.ckAnulado.Text = "Anulado"
        Me.ckAnulado.UseVisualStyleBackColor = True
        '
        'ckRecibido
        '
        Me.ckRecibido.AutoSize = True
        Me.ckRecibido.Location = New System.Drawing.Point(26, 38)
        Me.ckRecibido.Name = "ckRecibido"
        Me.ckRecibido.Size = New System.Drawing.Size(68, 17)
        Me.ckRecibido.TabIndex = 2
        Me.ckRecibido.Text = "Recibido"
        Me.ckRecibido.UseVisualStyleBackColor = True
        '
        'ckPedido
        '
        Me.ckPedido.AutoSize = True
        Me.ckPedido.Location = New System.Drawing.Point(104, 19)
        Me.ckPedido.Name = "ckPedido"
        Me.ckPedido.Size = New System.Drawing.Size(59, 17)
        Me.ckPedido.TabIndex = 1
        Me.ckPedido.Text = "Pedido"
        Me.ckPedido.UseVisualStyleBackColor = True
        '
        'ckSolicitado
        '
        Me.ckSolicitado.AutoSize = True
        Me.ckSolicitado.Location = New System.Drawing.Point(26, 19)
        Me.ckSolicitado.Name = "ckSolicitado"
        Me.ckSolicitado.Size = New System.Drawing.Size(72, 17)
        Me.ckSolicitado.TabIndex = 0
        Me.ckSolicitado.Text = "Solicitado"
        Me.ckSolicitado.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(465, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 77)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Filtrar Pedidos a Bodega"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Controls.Add(Me.viewDatos)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(12, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1091, 244)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPedido, Me.ToolStripSeparator1, Me.btnRecibido, Me.ToolStripSeparator2, Me.btnAnulado, Me.ToolStripSeparator3, Me.btnAgotado})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1085, 25)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnPedido
        '
        Me.btnPedido.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnPedido.Image = CType(resources.GetObject("btnPedido.Image"), System.Drawing.Image)
        Me.btnPedido.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPedido.Name = "btnPedido"
        Me.btnPedido.Size = New System.Drawing.Size(97, 22)
        Me.btnPedido.Text = "Registrar Pedido"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnRecibido
        '
        Me.btnRecibido.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnRecibido.Image = CType(resources.GetObject("btnRecibido.Image"), System.Drawing.Image)
        Me.btnRecibido.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRecibido.Name = "btnRecibido"
        Me.btnRecibido.Size = New System.Drawing.Size(106, 22)
        Me.btnRecibido.Text = "Registrar Recibido"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnAnulado
        '
        Me.btnAnulado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAnulado.Image = CType(resources.GetObject("btnAnulado.Image"), System.Drawing.Image)
        Me.btnAnulado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAnulado.Name = "btnAnulado"
        Me.btnAnulado.Size = New System.Drawing.Size(86, 22)
        Me.btnAnulado.Text = "Anular Pedido"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnAgotado
        '
        Me.btnAgotado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAgotado.Image = CType(resources.GetObject("btnAgotado.Image"), System.Drawing.Image)
        Me.btnAgotado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgotado.Name = "btnAgotado"
        Me.btnAgotado.Size = New System.Drawing.Size(57, 22)
        Me.btnAgotado.Text = "Agotado"
        '
        'btnPendientesSolicitud
        '
        Me.btnPendientesSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPendientesSolicitud.Location = New System.Drawing.Point(629, 12)
        Me.btnPendientesSolicitud.Name = "btnPendientesSolicitud"
        Me.btnPendientesSolicitud.Size = New System.Drawing.Size(158, 77)
        Me.btnPendientesSolicitud.TabIndex = 22
        Me.btnPendientesSolicitud.Text = "Pendientes Solicitar"
        Me.btnPendientesSolicitud.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(793, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(158, 77)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Pendientes Recibir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Location = New System.Drawing.Point(957, 12)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(146, 77)
        Me.btnExportar.TabIndex = 24
        Me.btnExportar.Text = "Exportar A Excel"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUsuario.Location = New System.Drawing.Point(80, 343)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(87, 20)
        Me.txtUsuario.TabIndex = 25
        '
        'lblUsuario
        '
        Me.lblUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(178, 346)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(0, 13)
        Me.lblUsuario.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(557, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Usuario : "
        '
        'frmConsultaPedidosBodega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 366)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnPendientesSolicitud)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ckFiltrarxEstado)
        Me.Controls.Add(Me.gbFiltrarxEstado)
        Me.Controls.Add(Me.ckFiltrarxFecha)
        Me.Controls.Add(Me.gbFiltrarxFecha)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmConsultaPedidosBodega"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas Pedidos Bodega"
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFiltrarxFecha.ResumeLayout(False)
        Me.gbFiltrarxFecha.PerformLayout()
        Me.gbFiltrarxEstado.ResumeLayout(False)
        Me.gbFiltrarxEstado.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbFiltrarxFecha As System.Windows.Forms.GroupBox
    Friend WithEvents ckFiltrarxFecha As System.Windows.Forms.CheckBox
    Friend WithEvents ckFiltrarxEstado As System.Windows.Forms.CheckBox
    Friend WithEvents gbFiltrarxEstado As System.Windows.Forms.GroupBox
    Friend WithEvents ckAnulado As System.Windows.Forms.CheckBox
    Friend WithEvents ckRecibido As System.Windows.Forms.CheckBox
    Friend WithEvents ckPedido As System.Windows.Forms.CheckBox
    Friend WithEvents ckSolicitado As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPedido As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnRecibido As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAnulado As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPendientesSolicitud As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAgotado As System.Windows.Forms.ToolStripButton
    Friend WithEvents ckAgotado As System.Windows.Forms.CheckBox
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
