Imports System.Data.SqlClient
Imports System.Windows.Forms


Public Class frmReporteCompras
    Inherits System.Windows.Forms.Form
    Dim NuevaConexion As String
    Dim strModulos As String = ""
    Friend WithEvents ckReporteResumido As System.Windows.Forms.CheckBox
    Dim tipo As Integer

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(Optional ByVal Conexion As String = "", Optional ByVal STipo As Integer = 0)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        tipo = STipo
        NuevaConexion = Conexion
    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboMonedas As System.Windows.Forms.ComboBox
    Friend WithEvents FechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTipoCambio As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents daMoneda As System.Data.SqlClient.SqlDataAdapter

    Friend WithEvents cbxOpcionesdeCompra As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbxTipoCompra As System.Windows.Forms.ComboBox
    Friend WithEvents cboProveedores As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents VisorReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsReporteCompras As DsReporteCompras
    Friend WithEvents CBTipo As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ck_Mascotas As System.Windows.Forms.CheckBox

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.VisorReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ck_Mascotas = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CBTipo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboProveedores = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxTipoCompra = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboMonedas = New System.Windows.Forms.ComboBox()
        Me.DsReporteCompras = New LcPymes_5._2.dsReporteCompras()
        Me.cbxOpcionesdeCompra = New System.Windows.Forms.ComboBox()
        Me.FechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.FechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.ButtonMostrar = New DevExpress.XtraEditors.SimpleButton()
        Me.lblTipoCambio = New System.Windows.Forms.Label()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.daMoneda = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.ckReporteResumido = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DsReporteCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VisorReporte
        '
        Me.VisorReporte.ActiveViewIndex = -1
        Me.VisorReporte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VisorReporte.AutoScroll = True
        Me.VisorReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VisorReporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.VisorReporte.Location = New System.Drawing.Point(0, 96)
        Me.VisorReporte.Name = "VisorReporte"
        Me.VisorReporte.ShowCloseButton = False
        Me.VisorReporte.Size = New System.Drawing.Size(909, 464)
        Me.VisorReporte.TabIndex = 82
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox1.Controls.Add(Me.ckReporteResumido)
        Me.GroupBox1.Controls.Add(Me.ck_Mascotas)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.CBTipo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboProveedores)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbxTipoCompra)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cboMonedas)
        Me.GroupBox1.Controls.Add(Me.cbxOpcionesdeCompra)
        Me.GroupBox1.Controls.Add(Me.FechaFinal)
        Me.GroupBox1.Controls.Add(Me.FechaInicio)
        Me.GroupBox1.Controls.Add(Me.ButtonMostrar)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(911, 96)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        '
        'ck_Mascotas
        '
        Me.ck_Mascotas.Location = New System.Drawing.Point(192, 75)
        Me.ck_Mascotas.Name = "ck_Mascotas"
        Me.ck_Mascotas.Size = New System.Drawing.Size(80, 16)
        Me.ck_Mascotas.TabIndex = 69
        Me.ck_Mascotas.Text = "Mascotas"
        Me.ck_Mascotas.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(192, 56)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(56, 16)
        Me.CheckBox1.TabIndex = 68
        Me.CheckBox1.Text = "Taller"
        Me.CheckBox1.Visible = False
        '
        'CBTipo
        '
        Me.CBTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBTipo.ForeColor = System.Drawing.Color.Blue
        Me.CBTipo.Items.AddRange(New Object() {"TODAS", "CON", "CRE"})
        Me.CBTipo.Location = New System.Drawing.Point(16, 64)
        Me.CBTipo.Name = "CBTipo"
        Me.CBTipo.Size = New System.Drawing.Size(168, 21)
        Me.CBTipo.TabIndex = 67
        Me.CBTipo.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(396, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 16)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Monto >="
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(396, 64)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(128, 20)
        Me.txtMonto.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(13, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 16)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Proveedores"
        '
        'cboProveedores
        '
        Me.cboProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProveedores.Location = New System.Drawing.Point(13, 64)
        Me.cboProveedores.Name = "cboProveedores"
        Me.cboProveedores.Size = New System.Drawing.Size(240, 21)
        Me.cboProveedores.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(-134, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 16)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Tipo Compra"
        '
        'cbxTipoCompra
        '
        Me.cbxTipoCompra.DisplayMember = "ValorCompra"
        Me.cbxTipoCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoCompra.Enabled = False
        Me.cbxTipoCompra.Items.AddRange(New Object() {"Contado", "Crédito"})
        Me.cbxTipoCompra.Location = New System.Drawing.Point(-134, 64)
        Me.cbxTipoCompra.Name = "cbxTipoCompra"
        Me.cbxTipoCompra.Size = New System.Drawing.Size(134, 21)
        Me.cbxTipoCompra.TabIndex = 58
        Me.cbxTipoCompra.ValueMember = "ValorCompra"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(276, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Hasta"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(276, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Desde"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 16)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Ver Reporte Según"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label13.Location = New System.Drawing.Point(396, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 16)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Moneda"
        '
        'cboMonedas
        '
        Me.cboMonedas.DataSource = Me.DsReporteCompras
        Me.cboMonedas.DisplayMember = "Moneda.MonedaNombre"
        Me.cboMonedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonedas.Location = New System.Drawing.Point(396, 24)
        Me.cboMonedas.Name = "cboMonedas"
        Me.cboMonedas.Size = New System.Drawing.Size(128, 21)
        Me.cboMonedas.TabIndex = 41
        Me.cboMonedas.ValueMember = "ValorCompra"
        '
        'DsReporteCompras
        '
        Me.DsReporteCompras.DataSetName = "dsReporteCompras"
        Me.DsReporteCompras.Locale = New System.Globalization.CultureInfo("es")
        Me.DsReporteCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbxOpcionesdeCompra
        '
        Me.cbxOpcionesdeCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxOpcionesdeCompra.Items.AddRange(New Object() {"Entre Fechas", "Por Proveedores", "Por Seguimiento de Proveedor", "Mayores por Proveedor", "Del Día"})
        Me.cbxOpcionesdeCompra.Location = New System.Drawing.Point(12, 24)
        Me.cbxOpcionesdeCompra.Name = "cbxOpcionesdeCompra"
        Me.cbxOpcionesdeCompra.Size = New System.Drawing.Size(240, 21)
        Me.cbxOpcionesdeCompra.TabIndex = 38
        '
        'FechaFinal
        '
        Me.FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaFinal.Location = New System.Drawing.Point(276, 64)
        Me.FechaFinal.Name = "FechaFinal"
        Me.FechaFinal.Size = New System.Drawing.Size(96, 20)
        Me.FechaFinal.TabIndex = 37
        Me.FechaFinal.Value = New Date(2006, 4, 19, 0, 0, 0, 0)
        '
        'FechaInicio
        '
        Me.FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaInicio.Location = New System.Drawing.Point(276, 24)
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.Size = New System.Drawing.Size(96, 20)
        Me.FechaInicio.TabIndex = 36
        Me.FechaInicio.Value = New Date(2006, 4, 10, 0, 0, 0, 0)
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Location = New System.Drawing.Point(781, 13)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(88, 72)
        Me.ButtonMostrar.TabIndex = 20
        Me.ButtonMostrar.Text = "Mostrar"
        '
        'lblTipoCambio
        '
        Me.lblTipoCambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsReporteCompras, "Moneda.ValorCompra", True))
        Me.lblTipoCambio.Location = New System.Drawing.Point(552, 208)
        Me.lblTipoCambio.Name = "lblTipoCambio"
        Me.lblTipoCambio.Size = New System.Drawing.Size(100, 23)
        Me.lblTipoCambio.TabIndex = 80
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=ZEUS;Initial Catalog=SeePOS;Integrated Security=True;Persist Security" & _
    " Info=False;User ID=SeeSOFT;Packet Size=4096;Workstation ID=."
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'daMoneda
        '
        Me.daMoneda.SelectCommand = Me.SqlSelectCommand1
        Me.daMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT CodMoneda, MonedaNombre, tccompra as ValorCompra, tccompra as ValorVenta, " & _
    "Simbolo FROM Moneda"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'ckReporteResumido
        '
        Me.ckReporteResumido.AutoSize = True
        Me.ckReporteResumido.Location = New System.Drawing.Point(540, 64)
        Me.ckReporteResumido.Name = "ckReporteResumido"
        Me.ckReporteResumido.Size = New System.Drawing.Size(224, 17)
        Me.ckReporteResumido.TabIndex = 70
        Me.ckReporteResumido.Text = "Version Resumida (Solo impuestos)"
        Me.ckReporteResumido.UseVisualStyleBackColor = True
        '
        'frmReporteCompras
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(911, 566)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.VisorReporte)
        Me.Controls.Add(Me.lblTipoCambio)
        Me.Name = "frmReporteCompras"
        Me.Text = "Reporte Compras"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DsReporteCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "variables"

    Private cConexion As Conexion
    Private sqlConexion As SqlConnection
#End Region

    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        Select Case cbxOpcionesdeCompra.SelectedIndex
            Case 0
                If CBTipo.SelectedIndex = 0 Then
                    If Me.ck_Mascotas.Checked = False And Me.CheckBox1.Checked = False Then

                        Dim RptComprasxFecha As New ComprasxFechas2

                        RptComprasxFecha.SetParameterValue(0, CDbl(lblTipoCambio.Text))
                        RptComprasxFecha.SetParameterValue(1, cboMonedas.Text)
                        RptComprasxFecha.SetParameterValue(2, CDate(Me.FechaInicio.Value))
                        RptComprasxFecha.SetParameterValue(3, CDate(Me.FechaFinal.Value))
                        RptComprasxFecha.SetParameterValue(4, CBool(tipo))
                        RptComprasxFecha.SetParameterValue(5, Me.ckReporteResumido.Checked)
                        CrystalReportsConexion.LoadReportViewer(VisorReporte, RptComprasxFecha, , SqlConnection1.ConnectionString)
                        VisorReporte.Show()


                    Else
                        Dim RptComprasxFecha As New ComprasxFechas
                        RptComprasxFecha.SetParameterValue(0, CDbl(lblTipoCambio.Text))
                        RptComprasxFecha.SetParameterValue(1, cboMonedas.Text)
                        RptComprasxFecha.SetParameterValue(2, CDate(Me.FechaInicio.Value))
                        RptComprasxFecha.SetParameterValue(3, CDate(Me.FechaFinal.Value))
                        RptComprasxFecha.SetParameterValue(4, CBool(tipo))
                        RptComprasxFecha.SetParameterValue(5, CheckBox1.Checked)
                        RptComprasxFecha.SetParameterValue(6, Me.ck_Mascotas.Checked)
                        CrystalReportsConexion.LoadReportViewer(VisorReporte, RptComprasxFecha, , SqlConnection1.ConnectionString)
                        VisorReporte.Show()
                    End If
                Else
                    If Me.ck_Mascotas.Checked = False And Me.CheckBox1.Checked = False Then

                        Dim RptComprasxFecha As New ComprasxFechasxTipo2
                        RptComprasxFecha.SetParameterValue(0, CDbl(lblTipoCambio.Text))
                        RptComprasxFecha.SetParameterValue(1, cboMonedas.Text)
                        RptComprasxFecha.SetParameterValue(2, CDate(FechaInicio.Value))
                        RptComprasxFecha.SetParameterValue(3, CDate(FechaFinal.Value))
                        RptComprasxFecha.SetParameterValue(4, CBool(tipo))
                        RptComprasxFecha.SetParameterValue(5, CBTipo.Text)
                        CrystalReportsConexion.LoadReportViewer(VisorReporte, RptComprasxFecha, , SqlConnection1.ConnectionString)
                        VisorReporte.Show()

                    Else
                        Dim RptComprasxFecha As New ComprasxFechasxTipo
                        RptComprasxFecha.SetParameterValue(0, CDbl(lblTipoCambio.Text))
                        RptComprasxFecha.SetParameterValue(1, cboMonedas.Text)
                        RptComprasxFecha.SetParameterValue(2, CDate(FechaInicio.Value))
                        RptComprasxFecha.SetParameterValue(3, CDate(FechaFinal.Value))
                        RptComprasxFecha.SetParameterValue(4, CBool(tipo))
                        RptComprasxFecha.SetParameterValue(5, CheckBox1.Checked)
                        RptComprasxFecha.SetParameterValue(6, CBTipo.Text)
                        RptComprasxFecha.SetParameterValue(7, Me.ck_Mascotas.Checked)
                        CrystalReportsConexion.LoadReportViewer(VisorReporte, RptComprasxFecha, , SqlConnection1.ConnectionString)
                        VisorReporte.Show()
                    End If

                End If

            Case 1
                Dim RptComprasxProveedor As New ComprasxProveedor
                RptComprasxProveedor.SetParameterValue(0, CDbl(lblTipoCambio.Text))
                RptComprasxProveedor.SetParameterValue(1, cboMonedas.Text)
                RptComprasxProveedor.SetParameterValue(2, CDate(Me.FechaInicio.Value))
                RptComprasxProveedor.SetParameterValue(3, CDate(Me.FechaFinal.Value))
                RptComprasxProveedor.SetParameterValue(4, CBool(tipo))
                CrystalReportsConexion.LoadReportViewer(VisorReporte, RptComprasxProveedor, , SqlConnection1.ConnectionString)
                VisorReporte.Show()
            Case 2
                Dim RptComprasxProveedor As New ComprasxProveedorX
                RptComprasxProveedor.SetParameterValue(0, CDbl(lblTipoCambio.Text))
                RptComprasxProveedor.SetParameterValue(1, cboMonedas.Text)
                RptComprasxProveedor.SetParameterValue(2, CDate(Me.FechaInicio.Value))
                RptComprasxProveedor.SetParameterValue(3, CDate(Me.FechaFinal.Value))
                RptComprasxProveedor.SetParameterValue(4, cboProveedores.Text)
                RptComprasxProveedor.SetParameterValue(5, CBool(tipo))
                CrystalReportsConexion.LoadReportViewer(VisorReporte, RptComprasxProveedor, , SqlConnection1.ConnectionString)
                VisorReporte.Show()
            Case 3
                Dim RptComprasMayores As New ComprasMayores
                RptComprasMayores.SetParameterValue(0, CDbl(txtMonto.Text))
                RptComprasMayores.SetParameterValue(1, CDate(FechaInicio.Value))
                RptComprasMayores.SetParameterValue(2, CDate(FechaFinal.Value))
                RptComprasMayores.SetParameterValue(3, lblTipoCambio.Text)
                RptComprasMayores.SetParameterValue(4, cboMonedas.Text)
                RptComprasMayores.SetParameterValue(5, CBool(tipo))
                CrystalReportsConexion.LoadReportViewer(VisorReporte, RptComprasMayores, , SqlConnection1.ConnectionString)
                VisorReporte.Show()

            Case 4

                Dim RptComprasxHoy As New ComprasxHoy
                RptComprasxHoy.SetParameterValue(0, CDbl(lblTipoCambio.Text))
                RptComprasxHoy.SetParameterValue(1, cboMonedas.Text)
                RptComprasxHoy.SetParameterValue(2, CDate(Me.FechaInicio.Value))
                RptComprasxHoy.SetParameterValue(3, CDate(Me.FechaFinal.Value))
                RptComprasxHoy.SetParameterValue(4, CBool(tipo))
                CrystalReportsConexion.LoadReportViewer(VisorReporte, RptComprasxHoy, , SqlConnection1.ConnectionString)
                VisorReporte.Show()

        End Select
    End Sub

    Private Sub cbxOpcionesdeVenta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxOpcionesdeCompra.SelectedIndexChanged
        txtMonto.Visible = False
        Label6.Visible = False
        cboProveedores.Visible = False
        Label2.Visible = False
        Label2.Text = "Proveedores"
        CheckBox1.Visible = False
        Me.ck_Mascotas.Visible = False
        CBTipo.Visible = False
        Me.ckReporteResumido.Visible = False

        Select Case cbxOpcionesdeCompra.SelectedIndex
            Case 0
                Me.ckReporteResumido.Visible = True
                If tipo = 0 Then
                    CBTipo.Visible = True
                    Label2.Text = "Tipo de Compra"
                    Label2.Visible = True
                    CheckBox1.Visible = True
                    Me.ck_Mascotas.Visible = True
                End If
                cbxTipoCompra.Enabled = False
                cboProveedores.Enabled = False
                FechaInicio.Focus()

            Case 1
                cbxTipoCompra.Enabled = False
                cboProveedores.Enabled = False

            Case 2
                cbxTipoCompra.Enabled = False
                cboProveedores.Enabled = True
                cboProveedores.Visible = True
                Label2.Visible = True

                Dim rs As SqlDataReader
                rs = cConexion.GetRecorset(cConexion.sQlconexion, "SELECT distinct(nombre) from proveedores order by nombre")
                While rs.Read
                    Try
                        cboProveedores.Items.Add(rs!nombre)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End While
                rs.Close()

            Case 3
                cbxTipoCompra.Enabled = False
                cboProveedores.Enabled = False
                FechaInicio.Focus()
                txtMonto.Visible = True
                Label6.Visible = True
            Case 4
                cbxTipoCompra.Enabled = False
                cboProveedores.Enabled = False
                FechaInicio.Focus()
        End Select
    End Sub

    Private Sub frmReporteCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = IIf(NuevaConexion = "", CadenaConexionSeePOS, NuevaConexion) 'JCGA
            strModulos = IIf(NuevaConexion = "", "SeePOS", "SeePos")

            cConexion = New Conexion
            sqlConexion = cConexion.Conectar(strModulos)

            daMoneda.Fill(Me.DsReporteCompras, "Moneda")

            If tipo = 0 Then
                Text = "Reporte de Compras"
            Else
                Text = "Reporte de Gastos"
            End If

            FechaInicio.Text = Date.Today

            FechaFinal.Text = Date.Today
            txtMonto.Visible = False
            Label6.Visible = False

            cboProveedores.Visible = False
            Label2.Visible = False
            CBTipo.SelectedIndex = 0

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then e.Handled = True ' esto invalida la tecla pulsada         End If
        End If
    End Sub

    Private Sub FechaInicio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FechaInicio.KeyDown
        If e.KeyCode = Keys.Enter Then
            FechaFinal.Focus()
        End If
    End Sub

    Private Sub FechaFinal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FechaFinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboMonedas.Focus()
        End If
    End Sub

    Private Sub cboMonedas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboMonedas.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonMostrar.Focus()
        End If
    End Sub

    Private Sub CBTipo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBTipo.KeyDown
        If e.KeyCode = Keys.Enter Then
            FechaInicio.Focus()
        End If
    End Sub
    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        Me.ck_Mascotas.Checked = False
    End Sub

    Private Sub ck_Mascotas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ck_Mascotas.Click
        Me.CheckBox1.Checked = False
    End Sub

  
End Class
