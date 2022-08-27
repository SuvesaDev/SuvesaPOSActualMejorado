<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultasComprobantesReceptor
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
        Me.ckFiltrarxFecha = New System.Windows.Forms.CheckBox()
        Me.gbFiltrarxFecha = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.ckFiltrarxEstado = New System.Windows.Forms.CheckBox()
        Me.gbFiltrarxEstado = New System.Windows.Forms.GroupBox()
        Me.ckRechazado = New System.Windows.Forms.CheckBox()
        Me.ckAceptado = New System.Windows.Forms.CheckBox()
        Me.ckPendiente = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ckTipos = New System.Windows.Forms.CheckBox()
        Me.gbFiltroxTipo = New System.Windows.Forms.GroupBox()
        Me.ckGasto = New System.Windows.Forms.CheckBox()
        Me.ckCompra = New System.Windows.Forms.CheckBox()
        Me.btnExportar = New System.Windows.Forms.Button()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFiltrarxFecha.SuspendLayout()
        Me.gbFiltrarxEstado.SuspendLayout()
        Me.gbFiltroxTipo.SuspendLayout()
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
        Me.viewDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.viewDatos.BackgroundColor = System.Drawing.Color.White
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Location = New System.Drawing.Point(12, 95)
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.ReadOnly = True
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(987, 308)
        Me.viewDatos.TabIndex = 0
        '
        'ckFiltrarxFecha
        '
        Me.ckFiltrarxFecha.AutoSize = True
        Me.ckFiltrarxFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckFiltrarxFecha.Location = New System.Drawing.Point(18, 8)
        Me.ckFiltrarxFecha.Name = "ckFiltrarxFecha"
        Me.ckFiltrarxFecha.Size = New System.Drawing.Size(124, 20)
        Me.ckFiltrarxFecha.TabIndex = 19
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
        Me.gbFiltrarxFecha.Location = New System.Drawing.Point(12, 12)
        Me.gbFiltrarxFecha.Name = "gbFiltrarxFecha"
        Me.gbFiltrarxFecha.Size = New System.Drawing.Size(307, 77)
        Me.gbFiltrarxFecha.TabIndex = 18
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
        Me.Label2.Location = New System.Drawing.Point(152, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Hasta"
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(6, 43)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(140, 20)
        Me.dtpDesde.TabIndex = 12
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(152, 43)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(140, 20)
        Me.dtpHasta.TabIndex = 14
        '
        'ckFiltrarxEstado
        '
        Me.ckFiltrarxEstado.AutoSize = True
        Me.ckFiltrarxEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckFiltrarxEstado.Location = New System.Drawing.Point(341, 8)
        Me.ckFiltrarxEstado.Name = "ckFiltrarxEstado"
        Me.ckFiltrarxEstado.Size = New System.Drawing.Size(138, 20)
        Me.ckFiltrarxEstado.TabIndex = 21
        Me.ckFiltrarxEstado.Text = "Filtrar por Mensaje"
        Me.ckFiltrarxEstado.UseVisualStyleBackColor = True
        '
        'gbFiltrarxEstado
        '
        Me.gbFiltrarxEstado.Controls.Add(Me.ckRechazado)
        Me.gbFiltrarxEstado.Controls.Add(Me.ckAceptado)
        Me.gbFiltrarxEstado.Controls.Add(Me.ckPendiente)
        Me.gbFiltrarxEstado.Enabled = False
        Me.gbFiltrarxEstado.Location = New System.Drawing.Point(335, 12)
        Me.gbFiltrarxEstado.Name = "gbFiltrarxEstado"
        Me.gbFiltrarxEstado.Size = New System.Drawing.Size(200, 77)
        Me.gbFiltrarxEstado.TabIndex = 20
        Me.gbFiltrarxEstado.TabStop = False
        '
        'ckRechazado
        '
        Me.ckRechazado.AutoSize = True
        Me.ckRechazado.Location = New System.Drawing.Point(91, 48)
        Me.ckRechazado.Name = "ckRechazado"
        Me.ckRechazado.Size = New System.Drawing.Size(86, 17)
        Me.ckRechazado.TabIndex = 2
        Me.ckRechazado.Text = "Rechazados"
        Me.ckRechazado.UseVisualStyleBackColor = True
        '
        'ckAceptado
        '
        Me.ckAceptado.AutoSize = True
        Me.ckAceptado.Location = New System.Drawing.Point(8, 48)
        Me.ckAceptado.Name = "ckAceptado"
        Me.ckAceptado.Size = New System.Drawing.Size(77, 17)
        Me.ckAceptado.TabIndex = 1
        Me.ckAceptado.Text = "Aceptados"
        Me.ckAceptado.UseVisualStyleBackColor = True
        '
        'ckPendiente
        '
        Me.ckPendiente.AutoSize = True
        Me.ckPendiente.Location = New System.Drawing.Point(6, 22)
        Me.ckPendiente.Name = "ckPendiente"
        Me.ckPendiente.Size = New System.Drawing.Size(79, 17)
        Me.ckPendiente.TabIndex = 0
        Me.ckPendiente.Text = "Pendientes"
        Me.ckPendiente.UseVisualStyleBackColor = True
        Me.ckPendiente.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(701, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 77)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Mostrar Datos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ckTipos
        '
        Me.ckTipos.AutoSize = True
        Me.ckTipos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckTipos.Location = New System.Drawing.Point(547, 8)
        Me.ckTipos.Name = "ckTipos"
        Me.ckTipos.Size = New System.Drawing.Size(114, 20)
        Me.ckTipos.TabIndex = 24
        Me.ckTipos.Text = "Filtrar por Tipo"
        Me.ckTipos.UseVisualStyleBackColor = True
        '
        'gbFiltroxTipo
        '
        Me.gbFiltroxTipo.Controls.Add(Me.ckGasto)
        Me.gbFiltroxTipo.Controls.Add(Me.ckCompra)
        Me.gbFiltroxTipo.Enabled = False
        Me.gbFiltroxTipo.Location = New System.Drawing.Point(541, 12)
        Me.gbFiltroxTipo.Name = "gbFiltroxTipo"
        Me.gbFiltroxTipo.Size = New System.Drawing.Size(154, 77)
        Me.gbFiltroxTipo.TabIndex = 23
        Me.gbFiltroxTipo.TabStop = False
        '
        'ckGasto
        '
        Me.ckGasto.AutoSize = True
        Me.ckGasto.Location = New System.Drawing.Point(74, 46)
        Me.ckGasto.Name = "ckGasto"
        Me.ckGasto.Size = New System.Drawing.Size(54, 17)
        Me.ckGasto.TabIndex = 1
        Me.ckGasto.Text = "Gasto"
        Me.ckGasto.UseVisualStyleBackColor = True
        '
        'ckCompra
        '
        Me.ckCompra.AutoSize = True
        Me.ckCompra.Location = New System.Drawing.Point(6, 46)
        Me.ckCompra.Name = "ckCompra"
        Me.ckCompra.Size = New System.Drawing.Size(62, 17)
        Me.ckCompra.TabIndex = 0
        Me.ckCompra.Text = "Compra"
        Me.ckCompra.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnExportar.Location = New System.Drawing.Point(851, 12)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(144, 77)
        Me.btnExportar.TabIndex = 25
        Me.btnExportar.Text = "Exportar Datos"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'frmConsultasComprobantesReceptor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 410)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.ckTipos)
        Me.Controls.Add(Me.gbFiltroxTipo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ckFiltrarxEstado)
        Me.Controls.Add(Me.gbFiltrarxEstado)
        Me.Controls.Add(Me.ckFiltrarxFecha)
        Me.Controls.Add(Me.gbFiltrarxFecha)
        Me.Controls.Add(Me.viewDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmConsultasComprobantesReceptor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas Comprobantes Receptor"
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFiltrarxFecha.ResumeLayout(False)
        Me.gbFiltrarxFecha.PerformLayout()
        Me.gbFiltrarxEstado.ResumeLayout(False)
        Me.gbFiltrarxEstado.PerformLayout()
        Me.gbFiltroxTipo.ResumeLayout(False)
        Me.gbFiltroxTipo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents ckFiltrarxFecha As System.Windows.Forms.CheckBox
    Friend WithEvents gbFiltrarxFecha As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents ckFiltrarxEstado As System.Windows.Forms.CheckBox
    Friend WithEvents gbFiltrarxEstado As System.Windows.Forms.GroupBox
    Friend WithEvents ckRechazado As System.Windows.Forms.CheckBox
    Friend WithEvents ckAceptado As System.Windows.Forms.CheckBox
    Friend WithEvents ckPendiente As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ckTipos As System.Windows.Forms.CheckBox
    Friend WithEvents gbFiltroxTipo As System.Windows.Forms.GroupBox
    Friend WithEvents ckGasto As System.Windows.Forms.CheckBox
    Friend WithEvents ckCompra As System.Windows.Forms.CheckBox
    Friend WithEvents btnExportar As System.Windows.Forms.Button
End Class
