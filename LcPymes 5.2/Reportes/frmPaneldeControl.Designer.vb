<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaneldeControl
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.viewTopArticulos = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtTopProveedores = New System.Windows.Forms.NumericUpDown()
        Me.btnMes = New System.Windows.Forms.Button()
        Me.txtTopVendedores = New System.Windows.Forms.NumericUpDown()
        Me.btnSemana = New System.Windows.Forms.Button()
        Me.txtTopCliente = New System.Windows.Forms.NumericUpDown()
        Me.btnHoy = New System.Windows.Forms.Button()
        Me.txtTopArticulos = New System.Windows.Forms.NumericUpDown()
        Me.viewTopProveedores = New System.Windows.Forms.DataGridView()
        Me.viewTopClientes = New System.Windows.Forms.DataGridView()
        Me.viewTopVendedores = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.viewTopArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.txtTopProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTopVendedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTopCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTopArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewTopProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewTopClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewTopVendedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'viewTopArticulos
        '
        Me.viewTopArticulos.AllowUserToAddRows = False
        Me.viewTopArticulos.AllowUserToDeleteRows = False
        Me.viewTopArticulos.AllowUserToResizeColumns = False
        Me.viewTopArticulos.AllowUserToResizeRows = False
        Me.viewTopArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.viewTopArticulos.BackgroundColor = System.Drawing.Color.White
        Me.viewTopArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewTopArticulos.Location = New System.Drawing.Point(22, 63)
        Me.viewTopArticulos.MultiSelect = False
        Me.viewTopArticulos.Name = "viewTopArticulos"
        Me.viewTopArticulos.ReadOnly = True
        Me.viewTopArticulos.RowHeadersVisible = False
        Me.viewTopArticulos.RowTemplate.Height = 28
        Me.viewTopArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewTopArticulos.Size = New System.Drawing.Size(444, 197)
        Me.viewTopArticulos.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 536)
        Me.Panel1.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1008, 536)
        Me.TabControl1.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1000, 507)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tops"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.txtTopProveedores)
        Me.Panel2.Controls.Add(Me.btnMes)
        Me.Panel2.Controls.Add(Me.txtTopVendedores)
        Me.Panel2.Controls.Add(Me.btnSemana)
        Me.Panel2.Controls.Add(Me.txtTopCliente)
        Me.Panel2.Controls.Add(Me.btnHoy)
        Me.Panel2.Controls.Add(Me.txtTopArticulos)
        Me.Panel2.Controls.Add(Me.viewTopProveedores)
        Me.Panel2.Controls.Add(Me.viewTopArticulos)
        Me.Panel2.Controls.Add(Me.viewTopClientes)
        Me.Panel2.Controls.Add(Me.viewTopVendedores)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(6, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(986, 498)
        Me.Panel2.TabIndex = 13
        '
        'txtTopProveedores
        '
        Me.txtTopProveedores.Location = New System.Drawing.Point(664, 268)
        Me.txtTopProveedores.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.txtTopProveedores.Name = "txtTopProveedores"
        Me.txtTopProveedores.Size = New System.Drawing.Size(48, 20)
        Me.txtTopProveedores.TabIndex = 15
        Me.txtTopProveedores.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'btnMes
        '
        Me.btnMes.AutoSize = True
        Me.btnMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMes.Location = New System.Drawing.Point(121, 8)
        Me.btnMes.Name = "btnMes"
        Me.btnMes.Size = New System.Drawing.Size(39, 25)
        Me.btnMes.TabIndex = 12
        Me.btnMes.Text = "Mes"
        Me.btnMes.UseVisualStyleBackColor = True
        '
        'txtTopVendedores
        '
        Me.txtTopVendedores.Location = New System.Drawing.Point(132, 271)
        Me.txtTopVendedores.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.txtTopVendedores.Name = "txtTopVendedores"
        Me.txtTopVendedores.Size = New System.Drawing.Size(48, 20)
        Me.txtTopVendedores.TabIndex = 13
        Me.txtTopVendedores.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'btnSemana
        '
        Me.btnSemana.AutoSize = True
        Me.btnSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSemana.Location = New System.Drawing.Point(63, 8)
        Me.btnSemana.Name = "btnSemana"
        Me.btnSemana.Size = New System.Drawing.Size(59, 25)
        Me.btnSemana.TabIndex = 11
        Me.btnSemana.Text = "Semana"
        Me.btnSemana.UseVisualStyleBackColor = True
        '
        'txtTopCliente
        '
        Me.txtTopCliente.Location = New System.Drawing.Point(603, 41)
        Me.txtTopCliente.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.txtTopCliente.Name = "txtTopCliente"
        Me.txtTopCliente.Size = New System.Drawing.Size(48, 20)
        Me.txtTopCliente.TabIndex = 11
        Me.txtTopCliente.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'btnHoy
        '
        Me.btnHoy.AutoSize = True
        Me.btnHoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHoy.Location = New System.Drawing.Point(25, 8)
        Me.btnHoy.Name = "btnHoy"
        Me.btnHoy.Size = New System.Drawing.Size(39, 25)
        Me.btnHoy.TabIndex = 10
        Me.btnHoy.Text = "Hoy"
        Me.btnHoy.UseVisualStyleBackColor = True
        '
        'txtTopArticulos
        '
        Me.txtTopArticulos.Location = New System.Drawing.Point(121, 41)
        Me.txtTopArticulos.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.txtTopArticulos.Name = "txtTopArticulos"
        Me.txtTopArticulos.Size = New System.Drawing.Size(48, 20)
        Me.txtTopArticulos.TabIndex = 9
        Me.txtTopArticulos.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'viewTopProveedores
        '
        Me.viewTopProveedores.AllowUserToAddRows = False
        Me.viewTopProveedores.AllowUserToDeleteRows = False
        Me.viewTopProveedores.AllowUserToResizeColumns = False
        Me.viewTopProveedores.AllowUserToResizeRows = False
        Me.viewTopProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.viewTopProveedores.BackgroundColor = System.Drawing.Color.White
        Me.viewTopProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewTopProveedores.Location = New System.Drawing.Point(521, 293)
        Me.viewTopProveedores.MultiSelect = False
        Me.viewTopProveedores.Name = "viewTopProveedores"
        Me.viewTopProveedores.ReadOnly = True
        Me.viewTopProveedores.RowHeadersVisible = False
        Me.viewTopProveedores.RowTemplate.Height = 28
        Me.viewTopProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewTopProveedores.Size = New System.Drawing.Size(444, 197)
        Me.viewTopProveedores.TabIndex = 8
        '
        'viewTopClientes
        '
        Me.viewTopClientes.AllowUserToAddRows = False
        Me.viewTopClientes.AllowUserToDeleteRows = False
        Me.viewTopClientes.AllowUserToResizeColumns = False
        Me.viewTopClientes.AllowUserToResizeRows = False
        Me.viewTopClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.viewTopClientes.BackgroundColor = System.Drawing.Color.White
        Me.viewTopClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewTopClientes.Location = New System.Drawing.Point(521, 63)
        Me.viewTopClientes.MultiSelect = False
        Me.viewTopClientes.Name = "viewTopClientes"
        Me.viewTopClientes.ReadOnly = True
        Me.viewTopClientes.RowHeadersVisible = False
        Me.viewTopClientes.RowTemplate.Height = 28
        Me.viewTopClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewTopClientes.Size = New System.Drawing.Size(444, 197)
        Me.viewTopClientes.TabIndex = 4
        '
        'viewTopVendedores
        '
        Me.viewTopVendedores.AllowUserToAddRows = False
        Me.viewTopVendedores.AllowUserToDeleteRows = False
        Me.viewTopVendedores.AllowUserToResizeColumns = False
        Me.viewTopVendedores.AllowUserToResizeRows = False
        Me.viewTopVendedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.viewTopVendedores.BackgroundColor = System.Drawing.Color.White
        Me.viewTopVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewTopVendedores.Location = New System.Drawing.Point(25, 293)
        Me.viewTopVendedores.MultiSelect = False
        Me.viewTopVendedores.Name = "viewTopVendedores"
        Me.viewTopVendedores.ReadOnly = True
        Me.viewTopVendedores.RowHeadersVisible = False
        Me.viewTopVendedores.RowTemplate.Height = 28
        Me.viewTopVendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewTopVendedores.Size = New System.Drawing.Size(444, 197)
        Me.viewTopVendedores.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(518, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Top Proveedores"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Top Productos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(518, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Top Clientes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Top Vendedores"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Chart1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1000, 507)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Comparativo de ventas de un año"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend2"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(3, 3)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series1.CustomProperties = "BarLabelStyle=Left"
        Series1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.LabelForeColor = System.Drawing.Color.White
        Series1.LabelFormat = "C"
        Series1.Legend = "Legend2"
        Series1.LegendText = "Contado"
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series2.CustomProperties = "BarLabelStyle=Left"
        Series2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Series2.IsValueShownAsLabel = True
        Series2.LabelForeColor = System.Drawing.Color.White
        Series2.LabelFormat = "C"
        Series2.Legend = "Legend2"
        Series2.LegendText = "Credito"
        Series2.Name = "Series2"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series3.CustomProperties = "BarLabelStyle=Left"
        Series3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Series3.IsValueShownAsLabel = True
        Series3.LabelForeColor = System.Drawing.Color.White
        Series3.LabelFormat = "C"
        Series3.Legend = "Legend2"
        Series3.LegendText = "Recibos"
        Series3.Name = "Series3"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(994, 501)
        Me.Chart1.TabIndex = 16
        Me.Chart1.Text = "Chart1"
        '
        'frmPaneldeControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 536)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPaneldeControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        CType(Me.viewTopArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txtTopProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTopVendedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTopCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTopArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewTopProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewTopClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewTopVendedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents viewTopArticulos As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents viewTopClientes As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents viewTopVendedores As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnMes As System.Windows.Forms.Button
    Friend WithEvents btnSemana As System.Windows.Forms.Button
    Friend WithEvents btnHoy As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents viewTopProveedores As System.Windows.Forms.DataGridView
    Friend WithEvents txtTopArticulos As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtTopProveedores As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtTopVendedores As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtTopCliente As System.Windows.Forms.NumericUpDown
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
End Class
