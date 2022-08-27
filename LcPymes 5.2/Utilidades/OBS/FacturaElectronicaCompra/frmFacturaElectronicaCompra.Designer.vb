<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturaElectronicaCompra
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
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnBuscarCedula = New System.Windows.Forms.Button()
        Me.cboTipoIdentificacion = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.cboProvincia = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCanton = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboDistrito = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOtrasSenias = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboActividadEconomica = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCorreoElectronico = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTipoCambio = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboFormaPago = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPlazo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboCondicionVenta = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNumFactura = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtTotalCompra = New System.Windows.Forms.TextBox()
        Me.txtMontoDescuento = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.viewDatelle = New System.Windows.Forms.DataGridView()
        Me.cNumeroLinea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUnidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMontoDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cId_Impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTarifa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMontoImpuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMontoTotalLinea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregarDetalle = New System.Windows.Forms.Button()
        Me.cboIVA = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cboUnidadMedida = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.viewDatelle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBuscarCedula
        '
        Me.btnBuscarCedula.Location = New System.Drawing.Point(107, 34)
        Me.btnBuscarCedula.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarCedula.Name = "btnBuscarCedula"
        Me.btnBuscarCedula.Size = New System.Drawing.Size(24, 23)
        Me.btnBuscarCedula.TabIndex = 30
        Me.btnBuscarCedula.TabStop = False
        Me.btnBuscarCedula.UseVisualStyleBackColor = True
        '
        'cboTipoIdentificacion
        '
        Me.cboTipoIdentificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoIdentificacion.FormattingEnabled = True
        Me.cboTipoIdentificacion.Items.AddRange(New Object() {"Fisica", "Juridica", "DIMEX"})
        Me.cboTipoIdentificacion.Location = New System.Drawing.Point(132, 35)
        Me.cboTipoIdentificacion.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTipoIdentificacion.Name = "cboTipoIdentificacion"
        Me.cboTipoIdentificacion.Size = New System.Drawing.Size(72, 21)
        Me.cboTipoIdentificacion.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 19)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Identificacion :"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(212, 35)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(324, 20)
        Me.txtNombre.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(210, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Nombre :"
        '
        'txtCedula
        '
        Me.txtCedula.BackColor = System.Drawing.Color.White
        Me.txtCedula.Location = New System.Drawing.Point(7, 35)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCedula.MaxLength = 12
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(100, 20)
        Me.txtCedula.TabIndex = 26
        '
        'cboProvincia
        '
        Me.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProvincia.FormattingEnabled = True
        Me.cboProvincia.Location = New System.Drawing.Point(65, 62)
        Me.cboProvincia.Margin = New System.Windows.Forms.Padding(2)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(139, 21)
        Me.cboProvincia.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 65)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Provincia :"
        '
        'cboCanton
        '
        Me.cboCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCanton.FormattingEnabled = True
        Me.cboCanton.Location = New System.Drawing.Point(65, 87)
        Me.cboCanton.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCanton.Name = "cboCanton"
        Me.cboCanton.Size = New System.Drawing.Size(139, 21)
        Me.cboCanton.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 90)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Canton :"
        '
        'cboDistrito
        '
        Me.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDistrito.FormattingEnabled = True
        Me.cboDistrito.Location = New System.Drawing.Point(65, 112)
        Me.cboDistrito.Margin = New System.Windows.Forms.Padding(2)
        Me.cboDistrito.Name = "cboDistrito"
        Me.cboDistrito.Size = New System.Drawing.Size(139, 21)
        Me.cboDistrito.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 115)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Distrito :"
        '
        'txtOtrasSenias
        '
        Me.txtOtrasSenias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOtrasSenias.Location = New System.Drawing.Point(213, 84)
        Me.txtOtrasSenias.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOtrasSenias.Multiline = True
        Me.txtOtrasSenias.Name = "txtOtrasSenias"
        Me.txtOtrasSenias.Size = New System.Drawing.Size(323, 49)
        Me.txtOtrasSenias.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(210, 67)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Otras Señas:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboActividadEconomica)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCorreoElectronico)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtOtrasSenias)
        Me.GroupBox1.Controls.Add(Me.cboDistrito)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCedula)
        Me.GroupBox1.Controls.Add(Me.cboCanton)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.cboProvincia)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboTipoIdentificacion)
        Me.GroupBox1.Controls.Add(Me.btnBuscarCedula)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(855, 142)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion del Proveedor"
        '
        'cboActividadEconomica
        '
        Me.cboActividadEconomica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboActividadEconomica.DropDownWidth = 500
        Me.cboActividadEconomica.FormattingEnabled = True
        Me.cboActividadEconomica.Location = New System.Drawing.Point(544, 84)
        Me.cboActividadEconomica.Margin = New System.Windows.Forms.Padding(2)
        Me.cboActividadEconomica.Name = "cboActividadEconomica"
        Me.cboActividadEconomica.Size = New System.Drawing.Size(293, 21)
        Me.cboActividadEconomica.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(541, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Actividad Economica del Proveedor :"
        '
        'txtCorreoElectronico
        '
        Me.txtCorreoElectronico.BackColor = System.Drawing.Color.White
        Me.txtCorreoElectronico.Location = New System.Drawing.Point(680, 34)
        Me.txtCorreoElectronico.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCorreoElectronico.MaxLength = 255
        Me.txtCorreoElectronico.Name = "txtCorreoElectronico"
        Me.txtCorreoElectronico.Size = New System.Drawing.Size(157, 20)
        Me.txtCorreoElectronico.TabIndex = 43
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(677, 19)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 13)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Correo Electronico :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(540, 37)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "(506)"
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.White
        Me.txtTelefono.Location = New System.Drawing.Point(574, 34)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelefono.MaxLength = 12
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(104, 20)
        Me.txtTelefono.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(540, 19)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Telefono :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTipoCambio)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.cboMoneda)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.cboFormaPago)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtPlazo)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.cboCondicionVenta)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.dtpFecha)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtNumFactura)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 147)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(855, 61)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion de la Compra"
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.BackColor = System.Drawing.Color.White
        Me.txtTipoCambio.Location = New System.Drawing.Point(740, 32)
        Me.txtTipoCambio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTipoCambio.MaxLength = 12
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Size = New System.Drawing.Size(64, 20)
        Me.txtTipoCambio.TabIndex = 56
        Me.txtTipoCambio.Text = "1"
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(736, 16)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(66, 13)
        Me.Label23.TabIndex = 57
        Me.Label23.Text = "Tipo Cambio"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cboMoneda
        '
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Items.AddRange(New Object() {"Fisica", "Juridica", "DIMEX"})
        Me.cboMoneda.Location = New System.Drawing.Point(642, 32)
        Me.cboMoneda.Margin = New System.Windows.Forms.Padding(2)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(94, 21)
        Me.cboMoneda.TabIndex = 53
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(639, 17)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(52, 13)
        Me.Label22.TabIndex = 52
        Me.Label22.Text = "Moneda :"
        '
        'cboFormaPago
        '
        Me.cboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormaPago.FormattingEnabled = True
        Me.cboFormaPago.Items.AddRange(New Object() {"Fisica", "Juridica", "DIMEX"})
        Me.cboFormaPago.Location = New System.Drawing.Point(491, 32)
        Me.cboFormaPago.Margin = New System.Windows.Forms.Padding(2)
        Me.cboFormaPago.Name = "cboFormaPago"
        Me.cboFormaPago.Size = New System.Drawing.Size(147, 21)
        Me.cboFormaPago.TabIndex = 51
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(488, 17)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 13)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "Medio de Pago : "
        '
        'txtPlazo
        '
        Me.txtPlazo.BackColor = System.Drawing.Color.White
        Me.txtPlazo.Location = New System.Drawing.Point(423, 33)
        Me.txtPlazo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPlazo.MaxLength = 12
        Me.txtPlazo.Name = "txtPlazo"
        Me.txtPlazo.Size = New System.Drawing.Size(64, 20)
        Me.txtPlazo.TabIndex = 48
        Me.txtPlazo.Text = "0"
        Me.txtPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(420, 17)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 13)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Plazo Cre. :"
        '
        'cboCondicionVenta
        '
        Me.cboCondicionVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCondicionVenta.FormattingEnabled = True
        Me.cboCondicionVenta.Items.AddRange(New Object() {"Fisica", "Juridica", "DIMEX"})
        Me.cboCondicionVenta.Location = New System.Drawing.Point(272, 33)
        Me.cboCondicionVenta.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCondicionVenta.Name = "cboCondicionVenta"
        Me.cboCondicionVenta.Size = New System.Drawing.Size(147, 21)
        Me.cboCondicionVenta.TabIndex = 42
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(269, 18)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 13)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Condicon Venta :"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(131, 34)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(136, 20)
        Me.dtpFecha.TabIndex = 47
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(128, 18)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Fecha Emision :"
        '
        'txtNumFactura
        '
        Me.txtNumFactura.BackColor = System.Drawing.Color.White
        Me.txtNumFactura.Location = New System.Drawing.Point(7, 34)
        Me.txtNumFactura.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumFactura.MaxLength = 12
        Me.txtNumFactura.Name = "txtNumFactura"
        Me.txtNumFactura.Size = New System.Drawing.Size(119, 20)
        Me.txtNumFactura.TabIndex = 44
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 18)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 13)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Numero Factura :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.viewDatelle)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.txtTotalCompra)
        Me.GroupBox3.Controls.Add(Me.txtMontoDescuento)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.btnAgregarDetalle)
        Me.GroupBox3.Controls.Add(Me.cboIVA)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txtPrecioUnitario)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txtDetalle)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.cboUnidadMedida)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtCantidad)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 147)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(855, 329)
        Me.GroupBox3.TabIndex = 41
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle de la Compra"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(594, 242)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(76, 13)
        Me.Label24.TabIndex = 65
        Me.Label24.Text = "Total Compra :"
        '
        'txtTotalCompra
        '
        Me.txtTotalCompra.BackColor = System.Drawing.Color.White
        Me.txtTotalCompra.Location = New System.Drawing.Point(674, 239)
        Me.txtTotalCompra.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotalCompra.MaxLength = 12
        Me.txtTotalCompra.Name = "txtTotalCompra"
        Me.txtTotalCompra.ReadOnly = True
        Me.txtTotalCompra.Size = New System.Drawing.Size(163, 20)
        Me.txtTotalCompra.TabIndex = 64
        Me.txtTotalCompra.Text = "0.00"
        Me.txtTotalCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMontoDescuento
        '
        Me.txtMontoDescuento.BackColor = System.Drawing.Color.White
        Me.txtMontoDescuento.Location = New System.Drawing.Point(491, 34)
        Me.txtMontoDescuento.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMontoDescuento.MaxLength = 12
        Me.txtMontoDescuento.Name = "txtMontoDescuento"
        Me.txtMontoDescuento.Size = New System.Drawing.Size(94, 20)
        Me.txtMontoDescuento.TabIndex = 58
        Me.txtMontoDescuento.Text = "0"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(487, 17)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(98, 13)
        Me.Label21.TabIndex = 59
        Me.Label21.Text = "Monto Descuento :"
        '
        'viewDatelle
        '
        Me.viewDatelle.AllowUserToAddRows = False
        Me.viewDatelle.AllowUserToDeleteRows = False
        Me.viewDatelle.AllowUserToResizeColumns = False
        Me.viewDatelle.AllowUserToResizeRows = False
        Me.viewDatelle.BackgroundColor = System.Drawing.Color.White
        Me.viewDatelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatelle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cNumeroLinea, Me.cCantidad, Me.cUnidadMedida, Me.cDetalle, Me.cPrecioUnitario, Me.cSubTotal, Me.cMontoDescuento, Me.cId_Impuesto, Me.cTarifa, Me.cMontoImpuesto, Me.cMontoTotalLinea})
        Me.viewDatelle.Location = New System.Drawing.Point(7, 16)
        Me.viewDatelle.MultiSelect = False
        Me.viewDatelle.Name = "viewDatelle"
        Me.viewDatelle.ReadOnly = True
        Me.viewDatelle.RowHeadersVisible = False
        Me.viewDatelle.RowTemplate.Height = 27
        Me.viewDatelle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatelle.Size = New System.Drawing.Size(830, 220)
        Me.viewDatelle.TabIndex = 57
        '
        'cNumeroLinea
        '
        Me.cNumeroLinea.HeaderText = "#"
        Me.cNumeroLinea.Name = "cNumeroLinea"
        Me.cNumeroLinea.ReadOnly = True
        Me.cNumeroLinea.Width = 35
        '
        'cCantidad
        '
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle19.Format = "N2"
        Me.cCantidad.DefaultCellStyle = DataGridViewCellStyle19
        Me.cCantidad.HeaderText = "Cant"
        Me.cCantidad.Name = "cCantidad"
        Me.cCantidad.ReadOnly = True
        Me.cCantidad.Width = 50
        '
        'cUnidadMedida
        '
        Me.cUnidadMedida.HeaderText = "Medida"
        Me.cUnidadMedida.Name = "cUnidadMedida"
        Me.cUnidadMedida.ReadOnly = True
        Me.cUnidadMedida.Width = 50
        '
        'cDetalle
        '
        Me.cDetalle.HeaderText = "Detalle"
        Me.cDetalle.Name = "cDetalle"
        Me.cDetalle.ReadOnly = True
        Me.cDetalle.Width = 215
        '
        'cPrecioUnitario
        '
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle20.Format = "N2"
        Me.cPrecioUnitario.DefaultCellStyle = DataGridViewCellStyle20
        Me.cPrecioUnitario.HeaderText = "Precio Unt"
        Me.cPrecioUnitario.Name = "cPrecioUnitario"
        Me.cPrecioUnitario.ReadOnly = True
        '
        'cSubTotal
        '
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle21.Format = "N2"
        Me.cSubTotal.DefaultCellStyle = DataGridViewCellStyle21
        Me.cSubTotal.HeaderText = "Subtotal"
        Me.cSubTotal.Name = "cSubTotal"
        Me.cSubTotal.ReadOnly = True
        '
        'cMontoDescuento
        '
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle22.Format = "N2"
        Me.cMontoDescuento.DefaultCellStyle = DataGridViewCellStyle22
        Me.cMontoDescuento.HeaderText = "Descuento"
        Me.cMontoDescuento.Name = "cMontoDescuento"
        Me.cMontoDescuento.ReadOnly = True
        '
        'cId_Impuesto
        '
        Me.cId_Impuesto.HeaderText = "Id_Impuesto"
        Me.cId_Impuesto.Name = "cId_Impuesto"
        Me.cId_Impuesto.ReadOnly = True
        Me.cId_Impuesto.Visible = False
        '
        'cTarifa
        '
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle23.Format = "N2"
        Me.cTarifa.DefaultCellStyle = DataGridViewCellStyle23
        Me.cTarifa.HeaderText = "Tarifa"
        Me.cTarifa.Name = "cTarifa"
        Me.cTarifa.ReadOnly = True
        Me.cTarifa.Width = 50
        '
        'cMontoImpuesto
        '
        Me.cMontoImpuesto.HeaderText = "MontoImpuesto"
        Me.cMontoImpuesto.Name = "cMontoImpuesto"
        Me.cMontoImpuesto.ReadOnly = True
        Me.cMontoImpuesto.Visible = False
        Me.cMontoImpuesto.Width = 80
        '
        'cMontoTotalLinea
        '
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle24.Format = "N2"
        Me.cMontoTotalLinea.DefaultCellStyle = DataGridViewCellStyle24
        Me.cMontoTotalLinea.HeaderText = "Total"
        Me.cMontoTotalLinea.Name = "cMontoTotalLinea"
        Me.cMontoTotalLinea.ReadOnly = True
        '
        'btnAgregarDetalle
        '
        Me.btnAgregarDetalle.Location = New System.Drawing.Point(741, 16)
        Me.btnAgregarDetalle.Name = "btnAgregarDetalle"
        Me.btnAgregarDetalle.Size = New System.Drawing.Size(96, 40)
        Me.btnAgregarDetalle.TabIndex = 56
        Me.btnAgregarDetalle.Text = "Agregar al Detalle"
        Me.btnAgregarDetalle.UseVisualStyleBackColor = True
        '
        'cboIVA
        '
        Me.cboIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIVA.FormattingEnabled = True
        Me.cboIVA.Location = New System.Drawing.Point(589, 34)
        Me.cboIVA.Margin = New System.Windows.Forms.Padding(2)
        Me.cboIVA.Name = "cboIVA"
        Me.cboIVA.Size = New System.Drawing.Size(147, 21)
        Me.cboIVA.TabIndex = 53
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(586, 16)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(24, 13)
        Me.Label20.TabIndex = 52
        Me.Label20.Text = "IVA"
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.BackColor = System.Drawing.Color.White
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(423, 34)
        Me.txtPrecioUnitario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrecioUnitario.MaxLength = 12
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(64, 20)
        Me.txtPrecioUnitario.TabIndex = 54
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(419, 18)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 13)
        Me.Label19.TabIndex = 55
        Me.Label19.Text = "P. Unitario :"
        '
        'txtDetalle
        '
        Me.txtDetalle.BackColor = System.Drawing.Color.White
        Me.txtDetalle.Location = New System.Drawing.Point(161, 34)
        Me.txtDetalle.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDetalle.MaxLength = 12
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(260, 20)
        Me.txtDetalle.TabIndex = 52
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(158, 18)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(134, 13)
        Me.Label18.TabIndex = 53
        Me.Label18.Text = "Descripcion de la Compra :"
        '
        'cboUnidadMedida
        '
        Me.cboUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidadMedida.FormattingEnabled = True
        Me.cboUnidadMedida.Items.AddRange(New Object() {"Fisica", "Juridica", "DIMEX"})
        Me.cboUnidadMedida.Location = New System.Drawing.Point(65, 33)
        Me.cboUnidadMedida.Margin = New System.Windows.Forms.Padding(2)
        Me.cboUnidadMedida.Name = "cboUnidadMedida"
        Me.cboUnidadMedida.Size = New System.Drawing.Size(92, 21)
        Me.cboUnidadMedida.TabIndex = 53
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(62, 18)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 13)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "Unidad Medida :"
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.White
        Me.txtCantidad.Location = New System.Drawing.Point(7, 34)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidad.MaxLength = 12
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(52, 20)
        Me.txtCantidad.TabIndex = 46
        Me.txtCantidad.Text = "1"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(4, 18)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 13)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "Cantidad :"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(526, 480)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(155, 40)
        Me.btnAceptar.TabIndex = 43
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnCancelar.Location = New System.Drawing.Point(687, 480)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(155, 40)
        Me.btnCancelar.TabIndex = 42
        Me.btnCancelar.Text = "Cancelar"
        '
        'frmFacturaElectronicaCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 522)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFacturaElectronicaCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso Factura de Compra Electronica "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.viewDatelle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBuscarCedula As System.Windows.Forms.Button
    Friend WithEvents cboTipoIdentificacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents cboProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboCanton As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboDistrito As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOtrasSenias As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCorreoElectronico As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNumFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPlazo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboCondicionVenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboUnidadMedida As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtPrecioUnitario As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboIVA As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarDetalle As System.Windows.Forms.Button
    Friend WithEvents viewDatelle As System.Windows.Forms.DataGridView
    Friend WithEvents txtMontoDescuento As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCompra As System.Windows.Forms.TextBox
    Friend WithEvents cNumeroLinea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUnidadMedida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDetalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPrecioUnitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMontoDescuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cId_Impuesto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTarifa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMontoImpuesto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMontoTotalLinea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtTipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cboActividadEconomica As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
