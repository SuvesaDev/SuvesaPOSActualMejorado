<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArqueoCaja
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.viewEfectivo = New System.Windows.Forms.DataGridView()
        Me.cId_Arqueo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cId_Denominacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMoneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDenominacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEfectivoColon = New System.Windows.Forms.TextBox()
        Me.txtEfectivoDolar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.viewDepositos = New System.Windows.Forms.DataGridView()
        Me.cBanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMonedaDeposito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMontoDeposito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNumeroDeposito = New System.Windows.Forms.TextBox()
        Me.txtMoneda = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMontoDeposito = New System.Windows.Forms.TextBox()
        Me.cboCuenta = New System.Windows.Forms.ComboBox()
        Me.cboBanco = New System.Windows.Forms.ComboBox()
        Me.txtEfectivoGeneral = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTotalenTarjeta = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTarjetaAutomatico = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTarjetaManual = New System.Windows.Forms.TextBox()
        Me.viewDatosTarjetas = New System.Windows.Forms.DataGridView()
        Me.txtTerminalId = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnCierre = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDepositoGeneral = New System.Windows.Forms.TextBox()
        Me.txtDepositoColones = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDepositoDolares = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCajero = New System.Windows.Forms.TextBox()
        Me.txtIdApertura = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnCargarDepositos = New System.Windows.Forms.Button()
        CType(Me.viewEfectivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewDepositos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.viewDatosTarjetas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'viewEfectivo
        '
        Me.viewEfectivo.AllowUserToAddRows = False
        Me.viewEfectivo.AllowUserToDeleteRows = False
        Me.viewEfectivo.AllowUserToResizeColumns = False
        Me.viewEfectivo.AllowUserToResizeRows = False
        Me.viewEfectivo.BackgroundColor = System.Drawing.Color.White
        Me.viewEfectivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewEfectivo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cId_Arqueo, Me.cId_Denominacion, Me.cMoneda, Me.cTipo, Me.cDenominacion, Me.cCantidad, Me.cMonto})
        Me.viewEfectivo.Location = New System.Drawing.Point(5, 6)
        Me.viewEfectivo.Name = "viewEfectivo"
        Me.viewEfectivo.RowHeadersVisible = False
        Me.viewEfectivo.Size = New System.Drawing.Size(495, 287)
        Me.viewEfectivo.TabIndex = 0
        '
        'cId_Arqueo
        '
        Me.cId_Arqueo.HeaderText = "Id_Arqueo"
        Me.cId_Arqueo.Name = "cId_Arqueo"
        Me.cId_Arqueo.ReadOnly = True
        Me.cId_Arqueo.Visible = False
        '
        'cId_Denominacion
        '
        Me.cId_Denominacion.HeaderText = "Id_Denominacion"
        Me.cId_Denominacion.Name = "cId_Denominacion"
        Me.cId_Denominacion.ReadOnly = True
        Me.cId_Denominacion.Visible = False
        '
        'cMoneda
        '
        Me.cMoneda.HeaderText = "Moneda"
        Me.cMoneda.Name = "cMoneda"
        Me.cMoneda.ReadOnly = True
        '
        'cTipo
        '
        Me.cTipo.HeaderText = "Tipo"
        Me.cTipo.Name = "cTipo"
        Me.cTipo.ReadOnly = True
        '
        'cDenominacion
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cDenominacion.DefaultCellStyle = DataGridViewCellStyle1
        Me.cDenominacion.HeaderText = "Denominacion"
        Me.cDenominacion.Name = "cDenominacion"
        Me.cDenominacion.ReadOnly = True
        Me.cDenominacion.Width = 80
        '
        'cCantidad
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cCantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.cCantidad.HeaderText = "Cantidad"
        Me.cCantidad.Name = "cCantidad"
        Me.cCantidad.Width = 75
        '
        'cMonto
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cMonto.DefaultCellStyle = DataGridViewCellStyle3
        Me.cMonto.HeaderText = "Monto"
        Me.cMonto.Name = "cMonto"
        Me.cMonto.ReadOnly = True
        Me.cMonto.Width = 110
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 301)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Efectivo Colones"
        '
        'txtEfectivoColon
        '
        Me.txtEfectivoColon.Location = New System.Drawing.Point(98, 299)
        Me.txtEfectivoColon.Name = "txtEfectivoColon"
        Me.txtEfectivoColon.ReadOnly = True
        Me.txtEfectivoColon.Size = New System.Drawing.Size(71, 20)
        Me.txtEfectivoColon.TabIndex = 2
        Me.txtEfectivoColon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEfectivoDolar
        '
        Me.txtEfectivoDolar.Location = New System.Drawing.Point(266, 299)
        Me.txtEfectivoDolar.Name = "txtEfectivoDolar"
        Me.txtEfectivoDolar.ReadOnly = True
        Me.txtEfectivoDolar.Size = New System.Drawing.Size(71, 20)
        Me.txtEfectivoDolar.TabIndex = 4
        Me.txtEfectivoDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Efectivo Dolares"
        '
        'viewDepositos
        '
        Me.viewDepositos.AllowUserToAddRows = False
        Me.viewDepositos.AllowUserToDeleteRows = False
        Me.viewDepositos.AllowUserToResizeColumns = False
        Me.viewDepositos.AllowUserToResizeRows = False
        Me.viewDepositos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.viewDepositos.BackgroundColor = System.Drawing.Color.White
        Me.viewDepositos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cBanco, Me.cCuenta, Me.cMonedaDeposito, Me.cNumero, Me.cMontoDeposito})
        Me.viewDepositos.Location = New System.Drawing.Point(5, 34)
        Me.viewDepositos.Name = "viewDepositos"
        Me.viewDepositos.RowHeadersVisible = False
        Me.viewDepositos.Size = New System.Drawing.Size(502, 260)
        Me.viewDepositos.TabIndex = 6
        '
        'cBanco
        '
        Me.cBanco.HeaderText = "Banco"
        Me.cBanco.Name = "cBanco"
        Me.cBanco.Width = 63
        '
        'cCuenta
        '
        Me.cCuenta.HeaderText = "Cuenta"
        Me.cCuenta.Name = "cCuenta"
        Me.cCuenta.Width = 66
        '
        'cMonedaDeposito
        '
        Me.cMonedaDeposito.HeaderText = "Moneda"
        Me.cMonedaDeposito.Name = "cMonedaDeposito"
        Me.cMonedaDeposito.Width = 71
        '
        'cNumero
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N0"
        Me.cNumero.DefaultCellStyle = DataGridViewCellStyle4
        Me.cNumero.HeaderText = "Numero"
        Me.cNumero.Name = "cNumero"
        Me.cNumero.Width = 69
        '
        'cMontoDeposito
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.cMontoDeposito.DefaultCellStyle = DataGridViewCellStyle5
        Me.cMontoDeposito.HeaderText = "Monto"
        Me.cMontoDeposito.Name = "cMontoDeposito"
        Me.cMontoDeposito.Width = 62
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(292, 72)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Numero de Deposito"
        '
        'txtNumeroDeposito
        '
        Me.txtNumeroDeposito.Location = New System.Drawing.Point(294, 89)
        Me.txtNumeroDeposito.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumeroDeposito.Name = "txtNumeroDeposito"
        Me.txtNumeroDeposito.Size = New System.Drawing.Size(126, 20)
        Me.txtNumeroDeposito.TabIndex = 10
        '
        'txtMoneda
        '
        Me.txtMoneda.Location = New System.Drawing.Point(7, 76)
        Me.txtMoneda.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.ReadOnly = True
        Me.txtMoneda.Size = New System.Drawing.Size(56, 20)
        Me.txtMoneda.TabIndex = 9
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(163, 59)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(122, 36)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar Deposito"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(68, 59)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Monto Deposito"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 58)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Moneda"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(160, 72)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cuenta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 72)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Banco"
        '
        'txtMontoDeposito
        '
        Me.txtMontoDeposito.Location = New System.Drawing.Point(70, 76)
        Me.txtMontoDeposito.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMontoDeposito.Name = "txtMontoDeposito"
        Me.txtMontoDeposito.Size = New System.Drawing.Size(90, 20)
        Me.txtMontoDeposito.TabIndex = 3
        '
        'cboCuenta
        '
        Me.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCuenta.FormattingEnabled = True
        Me.cboCuenta.Location = New System.Drawing.Point(163, 89)
        Me.cboCuenta.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCuenta.Name = "cboCuenta"
        Me.cboCuenta.Size = New System.Drawing.Size(122, 21)
        Me.cboCuenta.TabIndex = 1
        '
        'cboBanco
        '
        Me.cboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBanco.FormattingEnabled = True
        Me.cboBanco.Location = New System.Drawing.Point(6, 89)
        Me.cboBanco.Margin = New System.Windows.Forms.Padding(2)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Size = New System.Drawing.Size(153, 21)
        Me.cboBanco.TabIndex = 0
        '
        'txtEfectivoGeneral
        '
        Me.txtEfectivoGeneral.Location = New System.Drawing.Point(425, 299)
        Me.txtEfectivoGeneral.Name = "txtEfectivoGeneral"
        Me.txtEfectivoGeneral.ReadOnly = True
        Me.txtEfectivoGeneral.Size = New System.Drawing.Size(76, 20)
        Me.txtEfectivoGeneral.TabIndex = 7
        Me.txtEfectivoGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(340, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Efectivo General"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.ToolStripSeparator1, Me.btnGuardar, Me.ToolStripSeparator2, Me.btnBuscar, Me.ToolStripSeparator3, Me.btnEliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(522, 39)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.LcPymes_5._2.My.Resources.Resources.page_add1
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(78, 36)
        Me.btnNuevo.Text = "Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.LcPymes_5._2.My.Resources.Resources.page_save
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(85, 36)
        Me.btnGuardar.Text = "Guardar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.LcPymes_5._2.My.Resources.Resources.page_find1
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(78, 36)
        Me.btnBuscar.Text = "Buscar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Image = Global.LcPymes_5._2.My.Resources.Resources.page_delete
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(78, 36)
        Me.btnEliminar.Text = "Anular"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.ItemSize = New System.Drawing.Size(112, 30)
        Me.TabControl1.Location = New System.Drawing.Point(0, 80)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(519, 357)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.viewEfectivo)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtEfectivoGeneral)
        Me.TabPage1.Controls.Add(Me.txtEfectivoColon)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtEfectivoDolar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(511, 319)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ingresar Efectivo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.txtTotalenTarjeta)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.txtTarjetaAutomatico)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.txtTarjetaManual)
        Me.TabPage3.Controls.Add(Me.viewDatosTarjetas)
        Me.TabPage3.Controls.Add(Me.txtTerminalId)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.btnCierre)
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(511, 319)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Ingresar Tarjeta"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(198, 289)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(134, 13)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Total de Cobro en Tarjeta :"
        '
        'txtTotalenTarjeta
        '
        Me.txtTotalenTarjeta.Location = New System.Drawing.Point(338, 286)
        Me.txtTotalenTarjeta.Name = "txtTotalenTarjeta"
        Me.txtTotalenTarjeta.ReadOnly = True
        Me.txtTotalenTarjeta.Size = New System.Drawing.Size(161, 20)
        Me.txtTotalenTarjeta.TabIndex = 23
        Me.txtTotalenTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(182, 236)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(150, 13)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Monto de Tarjeta Automatico :"
        '
        'txtTarjetaAutomatico
        '
        Me.txtTarjetaAutomatico.Location = New System.Drawing.Point(338, 236)
        Me.txtTarjetaAutomatico.Name = "txtTarjetaAutomatico"
        Me.txtTarjetaAutomatico.ReadOnly = True
        Me.txtTarjetaAutomatico.Size = New System.Drawing.Size(161, 20)
        Me.txtTarjetaAutomatico.TabIndex = 21
        Me.txtTarjetaAutomatico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(200, 263)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(132, 13)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Monto de Tarjeta Manual :"
        '
        'txtTarjetaManual
        '
        Me.txtTarjetaManual.Location = New System.Drawing.Point(338, 260)
        Me.txtTarjetaManual.Name = "txtTarjetaManual"
        Me.txtTarjetaManual.Size = New System.Drawing.Size(161, 20)
        Me.txtTarjetaManual.TabIndex = 19
        Me.txtTarjetaManual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'viewDatosTarjetas
        '
        Me.viewDatosTarjetas.AllowUserToAddRows = False
        Me.viewDatosTarjetas.AllowUserToDeleteRows = False
        Me.viewDatosTarjetas.AllowUserToResizeColumns = False
        Me.viewDatosTarjetas.AllowUserToResizeRows = False
        Me.viewDatosTarjetas.BackgroundColor = System.Drawing.Color.White
        Me.viewDatosTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatosTarjetas.Location = New System.Drawing.Point(4, 41)
        Me.viewDatosTarjetas.Name = "viewDatosTarjetas"
        Me.viewDatosTarjetas.RowHeadersVisible = False
        Me.viewDatosTarjetas.Size = New System.Drawing.Size(495, 189)
        Me.viewDatosTarjetas.TabIndex = 17
        '
        'txtTerminalId
        '
        Me.txtTerminalId.Location = New System.Drawing.Point(75, 14)
        Me.txtTerminalId.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTerminalId.Name = "txtTerminalId"
        Me.txtTerminalId.ReadOnly = True
        Me.txtTerminalId.Size = New System.Drawing.Size(257, 20)
        Me.txtTerminalId.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 17)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 13)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Terminal Id :"
        '
        'btnCierre
        '
        Me.btnCierre.Location = New System.Drawing.Point(338, 12)
        Me.btnCierre.Name = "btnCierre"
        Me.btnCierre.Size = New System.Drawing.Size(161, 24)
        Me.btnCierre.TabIndex = 14
        Me.btnCierre.Text = "Generar Cierre Automatico"
        Me.btnCierre.UseVisualStyleBackColor = True
        Me.btnCierre.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnCargarDepositos)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.txtDepositoGeneral)
        Me.TabPage2.Controls.Add(Me.txtDepositoColones)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txtDepositoDolares)
        Me.TabPage2.Controls.Add(Me.viewDepositos)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.cboBanco)
        Me.TabPage2.Controls.Add(Me.txtNumeroDeposito)
        Me.TabPage2.Controls.Add(Me.cboCuenta)
        Me.TabPage2.Controls.Add(Me.txtMoneda)
        Me.TabPage2.Controls.Add(Me.txtMontoDeposito)
        Me.TabPage2.Controls.Add(Me.btnAgregar)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(511, 319)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lista de Depositos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 299)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Deposito Colones"
        '
        'txtDepositoGeneral
        '
        Me.txtDepositoGeneral.Location = New System.Drawing.Point(433, 296)
        Me.txtDepositoGeneral.Name = "txtDepositoGeneral"
        Me.txtDepositoGeneral.ReadOnly = True
        Me.txtDepositoGeneral.Size = New System.Drawing.Size(76, 20)
        Me.txtDepositoGeneral.TabIndex = 17
        Me.txtDepositoGeneral.Text = "0.00"
        Me.txtDepositoGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDepositoColones
        '
        Me.txtDepositoColones.Location = New System.Drawing.Point(105, 296)
        Me.txtDepositoColones.Name = "txtDepositoColones"
        Me.txtDepositoColones.ReadOnly = True
        Me.txtDepositoColones.Size = New System.Drawing.Size(71, 20)
        Me.txtDepositoColones.TabIndex = 13
        Me.txtDepositoColones.Text = "0.00"
        Me.txtDepositoColones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(344, 299)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Deposito General"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(183, 299)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Deposito Dolares"
        '
        'txtDepositoDolares
        '
        Me.txtDepositoDolares.Location = New System.Drawing.Point(272, 296)
        Me.txtDepositoDolares.Name = "txtDepositoDolares"
        Me.txtDepositoDolares.ReadOnly = True
        Me.txtDepositoDolares.Size = New System.Drawing.Size(71, 20)
        Me.txtDepositoDolares.TabIndex = 15
        Me.txtDepositoDolares.Text = "0.00"
        Me.txtDepositoDolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 46)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Cajero(a) :"
        '
        'txtCajero
        '
        Me.txtCajero.Location = New System.Drawing.Point(79, 44)
        Me.txtCajero.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCajero.Name = "txtCajero"
        Me.txtCajero.ReadOnly = True
        Me.txtCajero.Size = New System.Drawing.Size(209, 20)
        Me.txtCajero.TabIndex = 11
        '
        'txtIdApertura
        '
        Me.txtIdApertura.Location = New System.Drawing.Point(356, 42)
        Me.txtIdApertura.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdApertura.Name = "txtIdApertura"
        Me.txtIdApertura.ReadOnly = True
        Me.txtIdApertura.Size = New System.Drawing.Size(66, 20)
        Me.txtIdApertura.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(296, 45)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "# Apertura"
        '
        'btnCargarDepositos
        '
        Me.btnCargarDepositos.Location = New System.Drawing.Point(6, 5)
        Me.btnCargarDepositos.Name = "btnCargarDepositos"
        Me.btnCargarDepositos.Size = New System.Drawing.Size(500, 25)
        Me.btnCargarDepositos.TabIndex = 18
        Me.btnCargarDepositos.Text = "Cargar Depositos"
        Me.btnCargarDepositos.UseVisualStyleBackColor = True
        '
        'frmArqueoCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 441)
        Me.Controls.Add(Me.txtIdApertura)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCajero)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmArqueoCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arqueo Caja"
        CType(Me.viewEfectivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewDepositos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.viewDatosTarjetas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents viewEfectivo As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEfectivoColon As System.Windows.Forms.TextBox
    Friend WithEvents txtEfectivoDolar As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cId_Arqueo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cId_Denominacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMoneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDenominacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMonto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMontoDeposito As System.Windows.Forms.TextBox
    Friend WithEvents cboCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents cboBanco As System.Windows.Forms.ComboBox
    Friend WithEvents txtMoneda As System.Windows.Forms.TextBox
    Friend WithEvents viewDepositos As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDeposito As System.Windows.Forms.TextBox
    Friend WithEvents txtEfectivoGeneral As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCajero As System.Windows.Forms.TextBox
    Friend WithEvents txtIdApertura As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cBanco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMonedaDeposito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMontoDeposito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDepositoGeneral As System.Windows.Forms.TextBox
    Friend WithEvents txtDepositoColones As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDepositoDolares As System.Windows.Forms.TextBox
    Friend WithEvents btnCierre As System.Windows.Forms.Button
    Friend WithEvents txtTerminalId As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents viewDatosTarjetas As System.Windows.Forms.DataGridView
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtTotalenTarjeta As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtTarjetaAutomatico As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTarjetaManual As System.Windows.Forms.TextBox
    Friend WithEvents btnCargarDepositos As System.Windows.Forms.Button
End Class
