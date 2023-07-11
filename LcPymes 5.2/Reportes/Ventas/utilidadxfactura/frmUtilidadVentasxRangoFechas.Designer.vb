<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilidadVentasxRangoFechas
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
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ckFiltrarAgente = New System.Windows.Forms.CheckBox()
        Me.rbMostrarAgente = New System.Windows.Forms.RadioButton()
        Me.rbExcluirAgente = New System.Windows.Forms.RadioButton()
        Me.viewAgentes = New System.Windows.Forms.DataGridView()
        Me.cIdAgente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMarcarAgente = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cAgente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnCargarVeterinarias = New System.Windows.Forms.Button()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.viewClientes = New System.Windows.Forms.DataGridView()
        Me.cIdCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMarcarCliente = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ckFiltrarCliente = New System.Windows.Forms.CheckBox()
        Me.rbMostrarCliente = New System.Windows.Forms.RadioButton()
        Me.rbExcluirCliente = New System.Windows.Forms.RadioButton()
        Me.btnAgente = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.ckSoloServicios = New System.Windows.Forms.CheckBox()
        CType(Me.viewAgentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.viewClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMostrar
        '
        Me.btnMostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.Location = New System.Drawing.Point(16, 562)
        Me.btnMostrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(269, 85)
        Me.btnMostrar.TabIndex = 12
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(301, 1)
        Me.CrystalReportViewer1.Margin = New System.Windows.Forms.Padding(4)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(750, 656)
        Me.CrystalReportViewer1.TabIndex = 11
        Me.CrystalReportViewer1.ToolPanelWidth = 267
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(80, 69)
        Me.dtpHasta.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(204, 22)
        Me.dtpHasta.TabIndex = 13
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(80, 17)
        Me.dtpDesde.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(204, 22)
        Me.dtpDesde.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Desde :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Hasta :"
        '
        'ckFiltrarAgente
        '
        Me.ckFiltrarAgente.AutoSize = True
        Me.ckFiltrarAgente.Location = New System.Drawing.Point(4, 7)
        Me.ckFiltrarAgente.Margin = New System.Windows.Forms.Padding(4)
        Me.ckFiltrarAgente.Name = "ckFiltrarAgente"
        Me.ckFiltrarAgente.Size = New System.Drawing.Size(115, 21)
        Me.ckFiltrarAgente.TabIndex = 17
        Me.ckFiltrarAgente.Text = "Filtrar Agente"
        Me.ckFiltrarAgente.UseVisualStyleBackColor = True
        '
        'rbMostrarAgente
        '
        Me.rbMostrarAgente.AutoSize = True
        Me.rbMostrarAgente.Checked = True
        Me.rbMostrarAgente.Enabled = False
        Me.rbMostrarAgente.Location = New System.Drawing.Point(63, 36)
        Me.rbMostrarAgente.Margin = New System.Windows.Forms.Padding(4)
        Me.rbMostrarAgente.Name = "rbMostrarAgente"
        Me.rbMostrarAgente.Size = New System.Drawing.Size(173, 21)
        Me.rbMostrarAgente.TabIndex = 18
        Me.rbMostrarAgente.TabStop = True
        Me.rbMostrarAgente.Text = "Mostrar Seleccionados"
        Me.rbMostrarAgente.UseVisualStyleBackColor = True
        '
        'rbExcluirAgente
        '
        Me.rbExcluirAgente.AutoSize = True
        Me.rbExcluirAgente.Enabled = False
        Me.rbExcluirAgente.Location = New System.Drawing.Point(63, 64)
        Me.rbExcluirAgente.Margin = New System.Windows.Forms.Padding(4)
        Me.rbExcluirAgente.Name = "rbExcluirAgente"
        Me.rbExcluirAgente.Size = New System.Drawing.Size(166, 21)
        Me.rbExcluirAgente.TabIndex = 19
        Me.rbExcluirAgente.Text = "Excluir Seleccionados"
        Me.rbExcluirAgente.UseVisualStyleBackColor = True
        '
        'viewAgentes
        '
        Me.viewAgentes.AllowUserToAddRows = False
        Me.viewAgentes.AllowUserToDeleteRows = False
        Me.viewAgentes.AllowUserToResizeColumns = False
        Me.viewAgentes.AllowUserToResizeRows = False
        Me.viewAgentes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.viewAgentes.BackgroundColor = System.Drawing.Color.White
        Me.viewAgentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewAgentes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cIdAgente, Me.cMarcarAgente, Me.cAgente})
        Me.viewAgentes.Location = New System.Drawing.Point(4, 89)
        Me.viewAgentes.Margin = New System.Windows.Forms.Padding(4)
        Me.viewAgentes.Name = "viewAgentes"
        Me.viewAgentes.RowHeadersVisible = False
        Me.viewAgentes.Size = New System.Drawing.Size(264, 44)
        Me.viewAgentes.TabIndex = 20
        '
        'cIdAgente
        '
        Me.cIdAgente.HeaderText = "Id"
        Me.cIdAgente.Name = "cIdAgente"
        Me.cIdAgente.Visible = False
        '
        'cMarcarAgente
        '
        Me.cMarcarAgente.HeaderText = ""
        Me.cMarcarAgente.Name = "cMarcarAgente"
        Me.cMarcarAgente.Width = 30
        '
        'cAgente
        '
        Me.cAgente.HeaderText = "Agente"
        Me.cAgente.Name = "cAgente"
        Me.cAgente.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cAgente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cAgente.Width = 160
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(21, 164)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.viewAgentes)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ckFiltrarAgente)
        Me.SplitContainer1.Panel1.Controls.Add(Me.rbExcluirAgente)
        Me.SplitContainer1.Panel1.Controls.Add(Me.rbMostrarAgente)
        Me.SplitContainer1.Panel1Collapsed = True
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCargarVeterinarias)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnBuscarCliente)
        Me.SplitContainer1.Panel2.Controls.Add(Me.viewClientes)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ckFiltrarCliente)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rbMostrarCliente)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rbExcluirCliente)
        Me.SplitContainer1.Size = New System.Drawing.Size(275, 395)
        Me.SplitContainer1.SplitterDistance = 112
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 21
        '
        'btnCargarVeterinarias
        '
        Me.btnCargarVeterinarias.Enabled = False
        Me.btnCargarVeterinarias.Location = New System.Drawing.Point(7, 91)
        Me.btnCargarVeterinarias.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCargarVeterinarias.Name = "btnCargarVeterinarias"
        Me.btnCargarVeterinarias.Size = New System.Drawing.Size(264, 28)
        Me.btnCargarVeterinarias.TabIndex = 26
        Me.btnCargarVeterinarias.Text = "Veterinarias"
        Me.btnCargarVeterinarias.UseVisualStyleBackColor = True
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Enabled = False
        Me.btnBuscarCliente.Location = New System.Drawing.Point(164, 4)
        Me.btnBuscarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(100, 28)
        Me.btnBuscarCliente.TabIndex = 25
        Me.btnBuscarCliente.Text = "Buscar"
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'viewClientes
        '
        Me.viewClientes.AllowUserToAddRows = False
        Me.viewClientes.AllowUserToResizeColumns = False
        Me.viewClientes.AllowUserToResizeRows = False
        Me.viewClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.viewClientes.BackgroundColor = System.Drawing.Color.White
        Me.viewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cIdCliente, Me.cMarcarCliente, Me.cCliente})
        Me.viewClientes.Location = New System.Drawing.Point(7, 121)
        Me.viewClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.viewClientes.MultiSelect = False
        Me.viewClientes.Name = "viewClientes"
        Me.viewClientes.RowHeadersVisible = False
        Me.viewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewClientes.Size = New System.Drawing.Size(264, 271)
        Me.viewClientes.TabIndex = 24
        '
        'cIdCliente
        '
        Me.cIdCliente.HeaderText = "Id"
        Me.cIdCliente.Name = "cIdCliente"
        Me.cIdCliente.Visible = False
        '
        'cMarcarCliente
        '
        Me.cMarcarCliente.HeaderText = ""
        Me.cMarcarCliente.Name = "cMarcarCliente"
        Me.cMarcarCliente.Width = 30
        '
        'cCliente
        '
        Me.cCliente.HeaderText = "Cliente"
        Me.cCliente.Name = "cCliente"
        Me.cCliente.ReadOnly = True
        Me.cCliente.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cCliente.Width = 160
        '
        'ckFiltrarCliente
        '
        Me.ckFiltrarCliente.AutoSize = True
        Me.ckFiltrarCliente.Location = New System.Drawing.Point(7, 9)
        Me.ckFiltrarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.ckFiltrarCliente.Name = "ckFiltrarCliente"
        Me.ckFiltrarCliente.Size = New System.Drawing.Size(113, 21)
        Me.ckFiltrarCliente.TabIndex = 21
        Me.ckFiltrarCliente.Text = "Filtrar Cliente"
        Me.ckFiltrarCliente.UseVisualStyleBackColor = True
        '
        'rbMostrarCliente
        '
        Me.rbMostrarCliente.AutoSize = True
        Me.rbMostrarCliente.Checked = True
        Me.rbMostrarCliente.Enabled = False
        Me.rbMostrarCliente.Location = New System.Drawing.Point(65, 37)
        Me.rbMostrarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.rbMostrarCliente.Name = "rbMostrarCliente"
        Me.rbMostrarCliente.Size = New System.Drawing.Size(173, 21)
        Me.rbMostrarCliente.TabIndex = 22
        Me.rbMostrarCliente.TabStop = True
        Me.rbMostrarCliente.Text = "Mostrar Seleccionados"
        Me.rbMostrarCliente.UseVisualStyleBackColor = True
        '
        'rbExcluirCliente
        '
        Me.rbExcluirCliente.AutoSize = True
        Me.rbExcluirCliente.Enabled = False
        Me.rbExcluirCliente.Location = New System.Drawing.Point(65, 65)
        Me.rbExcluirCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.rbExcluirCliente.Name = "rbExcluirCliente"
        Me.rbExcluirCliente.Size = New System.Drawing.Size(166, 21)
        Me.rbExcluirCliente.TabIndex = 23
        Me.rbExcluirCliente.Text = "Excluir Seleccionados"
        Me.rbExcluirCliente.UseVisualStyleBackColor = True
        '
        'btnAgente
        '
        Me.btnAgente.Location = New System.Drawing.Point(21, 129)
        Me.btnAgente.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgente.Name = "btnAgente"
        Me.btnAgente.Size = New System.Drawing.Size(132, 28)
        Me.btnAgente.TabIndex = 22
        Me.btnAgente.Text = "Filtrar Agente"
        Me.btnAgente.UseVisualStyleBackColor = True
        '
        'btnCliente
        '
        Me.btnCliente.Location = New System.Drawing.Point(153, 129)
        Me.btnCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(132, 28)
        Me.btnCliente.TabIndex = 23
        Me.btnCliente.Text = "Filtrar Cliente"
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'ckSoloServicios
        '
        Me.ckSoloServicios.AutoSize = True
        Me.ckSoloServicios.Location = New System.Drawing.Point(80, 98)
        Me.ckSoloServicios.Name = "ckSoloServicios"
        Me.ckSoloServicios.Size = New System.Drawing.Size(171, 21)
        Me.ckSoloServicios.TabIndex = 24
        Me.ckSoloServicios.Text = "Mostrar Solo Servicios"
        Me.ckSoloServicios.UseVisualStyleBackColor = True
        '
        'frmUtilidadVentasxRangoFechas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1212, 662)
        Me.Controls.Add(Me.ckSoloServicios)
        Me.Controls.Add(Me.btnCliente)
        Me.Controls.Add(Me.btnAgente)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDesde)
        Me.Controls.Add(Me.dtpHasta)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmUtilidadVentasxRangoFechas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Utilidad Ventas por Rango Fechas"
        CType(Me.viewAgentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.viewClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ckFiltrarAgente As System.Windows.Forms.CheckBox
    Friend WithEvents rbMostrarAgente As System.Windows.Forms.RadioButton
    Friend WithEvents rbExcluirAgente As System.Windows.Forms.RadioButton
    Friend WithEvents viewAgentes As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnAgente As System.Windows.Forms.Button
    Friend WithEvents btnCliente As System.Windows.Forms.Button
    Friend WithEvents viewClientes As System.Windows.Forms.DataGridView
    Friend WithEvents ckFiltrarCliente As System.Windows.Forms.CheckBox
    Friend WithEvents rbMostrarCliente As System.Windows.Forms.RadioButton
    Friend WithEvents rbExcluirCliente As System.Windows.Forms.RadioButton
    Friend WithEvents cIdAgente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMarcarAgente As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cAgente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnBuscarCliente As System.Windows.Forms.Button
    Friend WithEvents cIdCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMarcarCliente As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCargarVeterinarias As System.Windows.Forms.Button
    Friend WithEvents ckSoloServicios As System.Windows.Forms.CheckBox
End Class
