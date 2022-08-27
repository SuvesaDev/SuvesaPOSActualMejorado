<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatosPreVenta
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPuntoVenta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.viewFichas = New System.Windows.Forms.DataGridView()
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnFactura = New System.Windows.Forms.Button()
        Me.btnTiquete = New System.Windows.Forms.Button()
        Me.btnReciboDinero = New System.Windows.Forms.Button()
        Me.btnGeneraAdelanto = New System.Windows.Forms.Button()
        Me.txtTotalCobro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGenerarApartado = New System.Windows.Forms.Button()
        Me.ckEsElectronica = New System.Windows.Forms.CheckBox()
        Me.txtTotalPendiente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCobrar = New System.Windows.Forms.Button()
        Me.cFicha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cRenta = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cPendiente = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cExpress = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cFE = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCorreo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPuntoVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAbono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cIdDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.viewFichas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtPuntoVenta)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCorreo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCedula)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(836, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(692, 69)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'txtPuntoVenta
        '
        Me.txtPuntoVenta.BackColor = System.Drawing.Color.White
        Me.txtPuntoVenta.Location = New System.Drawing.Point(592, 32)
        Me.txtPuntoVenta.Name = "txtPuntoVenta"
        Me.txtPuntoVenta.ReadOnly = True
        Me.txtPuntoVenta.Size = New System.Drawing.Size(98, 20)
        Me.txtPuntoVenta.TabIndex = 7
        Me.txtPuntoVenta.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(589, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Punto Venta"
        '
        'txtCorreo
        '
        Me.txtCorreo.BackColor = System.Drawing.Color.White
        Me.txtCorreo.Location = New System.Drawing.Point(361, 32)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.ReadOnly = True
        Me.txtCorreo.Size = New System.Drawing.Size(224, 20)
        Me.txtCorreo.TabIndex = 5
        Me.txtCorreo.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(358, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Correo"
        '
        'txtCedula
        '
        Me.txtCedula.BackColor = System.Drawing.Color.White
        Me.txtCedula.Location = New System.Drawing.Point(257, 32)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.ReadOnly = True
        Me.txtCedula.Size = New System.Drawing.Size(98, 20)
        Me.txtCedula.TabIndex = 3
        Me.txtCedula.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(254, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cedula"
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.White
        Me.txtCliente.Location = New System.Drawing.Point(6, 32)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(245, 20)
        Me.txtCliente.TabIndex = 1
        Me.txtCliente.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'viewFichas
        '
        Me.viewFichas.AllowUserToAddRows = False
        Me.viewFichas.AllowUserToDeleteRows = False
        Me.viewFichas.AllowUserToResizeColumns = False
        Me.viewFichas.AllowUserToResizeRows = False
        Me.viewFichas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewFichas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.viewFichas.BackgroundColor = System.Drawing.Color.White
        Me.viewFichas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewFichas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cFicha, Me.cRenta, Me.cPendiente, Me.cExpress, Me.cFE, Me.cId, Me.cTipo, Me.cCedula, Me.cCliente, Me.cCorreo, Me.cPuntoVenta, Me.cTotal, Me.cAbono, Me.cDocumento, Me.cIdDocumento})
        Me.viewFichas.Location = New System.Drawing.Point(9, 4)
        Me.viewFichas.MultiSelect = False
        Me.viewFichas.Name = "viewFichas"
        Me.viewFichas.RowHeadersVisible = False
        Me.viewFichas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewFichas.Size = New System.Drawing.Size(810, 124)
        Me.viewFichas.TabIndex = 8
        '
        'viewDatos
        '
        Me.viewDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewDatos.BackgroundColor = System.Drawing.Color.White
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Location = New System.Drawing.Point(9, 132)
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(810, 119)
        Me.viewDatos.TabIndex = 1
        '
        'btnAtras
        '
        Me.btnAtras.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAtras.BackColor = System.Drawing.Color.White
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Image = Global.LcPymes_5._2.My.Resources.Resources.iconfinder_Left_arrow_circle_2202279
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtras.Location = New System.Drawing.Point(9, 281)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(150, 68)
        Me.btnAtras.TabIndex = 2
        Me.btnAtras.TabStop = False
        Me.btnAtras.Text = "      Volver Atras    "
        Me.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'btnFactura
        '
        Me.btnFactura.BackColor = System.Drawing.Color.White
        Me.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactura.Location = New System.Drawing.Point(88, 151)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Size = New System.Drawing.Size(102, 68)
        Me.btnFactura.TabIndex = 3
        Me.btnFactura.TabStop = False
        Me.btnFactura.Text = "Factura Electronica 2"
        Me.btnFactura.UseVisualStyleBackColor = False
        Me.btnFactura.Visible = False
        '
        'btnTiquete
        '
        Me.btnTiquete.BackColor = System.Drawing.Color.White
        Me.btnTiquete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTiquete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTiquete.Location = New System.Drawing.Point(196, 151)
        Me.btnTiquete.Name = "btnTiquete"
        Me.btnTiquete.Size = New System.Drawing.Size(102, 68)
        Me.btnTiquete.TabIndex = 4
        Me.btnTiquete.TabStop = False
        Me.btnTiquete.Text = "Tiquete Electronico 3"
        Me.btnTiquete.UseVisualStyleBackColor = False
        Me.btnTiquete.Visible = False
        '
        'btnReciboDinero
        '
        Me.btnReciboDinero.BackColor = System.Drawing.Color.White
        Me.btnReciboDinero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReciboDinero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReciboDinero.Location = New System.Drawing.Point(304, 151)
        Me.btnReciboDinero.Name = "btnReciboDinero"
        Me.btnReciboDinero.Size = New System.Drawing.Size(102, 68)
        Me.btnReciboDinero.TabIndex = 5
        Me.btnReciboDinero.TabStop = False
        Me.btnReciboDinero.Text = "Recibo    Dinero 4"
        Me.btnReciboDinero.UseVisualStyleBackColor = False
        Me.btnReciboDinero.Visible = False
        '
        'btnGeneraAdelanto
        '
        Me.btnGeneraAdelanto.BackColor = System.Drawing.Color.White
        Me.btnGeneraAdelanto.Enabled = False
        Me.btnGeneraAdelanto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeneraAdelanto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGeneraAdelanto.Location = New System.Drawing.Point(412, 151)
        Me.btnGeneraAdelanto.Name = "btnGeneraAdelanto"
        Me.btnGeneraAdelanto.Size = New System.Drawing.Size(102, 68)
        Me.btnGeneraAdelanto.TabIndex = 14
        Me.btnGeneraAdelanto.TabStop = False
        Me.btnGeneraAdelanto.Text = "Generar Adelanto 5"
        Me.btnGeneraAdelanto.UseVisualStyleBackColor = False
        Me.btnGeneraAdelanto.Visible = False
        '
        'txtTotalCobro
        '
        Me.txtTotalCobro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalCobro.BackColor = System.Drawing.Color.White
        Me.txtTotalCobro.Location = New System.Drawing.Point(715, 257)
        Me.txtTotalCobro.Name = "txtTotalCobro"
        Me.txtTotalCobro.ReadOnly = True
        Me.txtTotalCobro.Size = New System.Drawing.Size(104, 20)
        Me.txtTotalCobro.TabIndex = 16
        Me.txtTotalCobro.TabStop = False
        Me.txtTotalCobro.Text = "0.00"
        Me.txtTotalCobro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(622, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Total Cobro"
        '
        'btnGenerarApartado
        '
        Me.btnGenerarApartado.BackColor = System.Drawing.Color.White
        Me.btnGenerarApartado.Enabled = False
        Me.btnGenerarApartado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerarApartado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarApartado.Location = New System.Drawing.Point(520, 151)
        Me.btnGenerarApartado.Name = "btnGenerarApartado"
        Me.btnGenerarApartado.Size = New System.Drawing.Size(102, 68)
        Me.btnGenerarApartado.TabIndex = 17
        Me.btnGenerarApartado.TabStop = False
        Me.btnGenerarApartado.Text = "Generar Apartado 6"
        Me.btnGenerarApartado.UseVisualStyleBackColor = False
        Me.btnGenerarApartado.Visible = False
        '
        'ckEsElectronica
        '
        Me.ckEsElectronica.AutoSize = True
        Me.ckEsElectronica.Enabled = False
        Me.ckEsElectronica.Location = New System.Drawing.Point(835, 300)
        Me.ckEsElectronica.Name = "ckEsElectronica"
        Me.ckEsElectronica.Size = New System.Drawing.Size(94, 17)
        Me.ckEsElectronica.TabIndex = 18
        Me.ckEsElectronica.Text = "Es Electronica"
        Me.ckEsElectronica.UseVisualStyleBackColor = True
        Me.ckEsElectronica.Visible = False
        '
        'txtTotalPendiente
        '
        Me.txtTotalPendiente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalPendiente.BackColor = System.Drawing.Color.White
        Me.txtTotalPendiente.Location = New System.Drawing.Point(497, 255)
        Me.txtTotalPendiente.Name = "txtTotalPendiente"
        Me.txtTotalPendiente.ReadOnly = True
        Me.txtTotalPendiente.Size = New System.Drawing.Size(104, 20)
        Me.txtTotalPendiente.TabIndex = 21
        Me.txtTotalPendiente.TabStop = False
        Me.txtTotalPendiente.Text = "0.00"
        Me.txtTotalPendiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(404, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Total Pendiente"
        '
        'btnCobrar
        '
        Me.btnCobrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCobrar.BackColor = System.Drawing.Color.White
        Me.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCobrar.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCobrar.Image = Global.LcPymes_5._2.My.Resources.Resources.iconfinder_resolutions_24_897227_2_
        Me.btnCobrar.Location = New System.Drawing.Point(407, 281)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(412, 68)
        Me.btnCobrar.TabIndex = 19
        Me.btnCobrar.TabStop = False
        Me.btnCobrar.Text = "Cobrar 2"
        Me.btnCobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCobrar.UseVisualStyleBackColor = False
        '
        'cFicha
        '
        Me.cFicha.HeaderText = "# Ficha"
        Me.cFicha.Name = "cFicha"
        Me.cFicha.ReadOnly = True
        Me.cFicha.Width = 68
        '
        'cRenta
        '
        Me.cRenta.HeaderText = "Renta"
        Me.cRenta.Name = "cRenta"
        Me.cRenta.Width = 42
        '
        'cPendiente
        '
        Me.cPendiente.HeaderText = "es Pendiente"
        Me.cPendiente.Name = "cPendiente"
        Me.cPendiente.ReadOnly = True
        Me.cPendiente.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cPendiente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cPendiente.Width = 94
        '
        'cExpress
        '
        Me.cExpress.HeaderText = "Express"
        Me.cExpress.Name = "cExpress"
        Me.cExpress.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cExpress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cExpress.Width = 69
        '
        'cFE
        '
        Me.cFE.HeaderText = "es Factura"
        Me.cFE.Name = "cFE"
        Me.cFE.Width = 63
        '
        'cId
        '
        Me.cId.HeaderText = "Id"
        Me.cId.Name = "cId"
        Me.cId.ReadOnly = True
        Me.cId.Visible = False
        Me.cId.Width = 41
        '
        'cTipo
        '
        Me.cTipo.HeaderText = "Tipo"
        Me.cTipo.Name = "cTipo"
        Me.cTipo.ReadOnly = True
        Me.cTipo.Width = 53
        '
        'cCedula
        '
        Me.cCedula.HeaderText = "Cedula"
        Me.cCedula.Name = "cCedula"
        Me.cCedula.ReadOnly = True
        Me.cCedula.Width = 65
        '
        'cCliente
        '
        Me.cCliente.HeaderText = "Cliente"
        Me.cCliente.Name = "cCliente"
        Me.cCliente.ReadOnly = True
        Me.cCliente.Width = 64
        '
        'cCorreo
        '
        Me.cCorreo.HeaderText = "Correo"
        Me.cCorreo.Name = "cCorreo"
        Me.cCorreo.ReadOnly = True
        Me.cCorreo.Visible = False
        Me.cCorreo.Width = 63
        '
        'cPuntoVenta
        '
        Me.cPuntoVenta.HeaderText = "Punto Venta"
        Me.cPuntoVenta.Name = "cPuntoVenta"
        Me.cPuntoVenta.ReadOnly = True
        Me.cPuntoVenta.Width = 91
        '
        'cTotal
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.cTotal.DefaultCellStyle = DataGridViewCellStyle1
        Me.cTotal.HeaderText = "Total"
        Me.cTotal.Name = "cTotal"
        Me.cTotal.ReadOnly = True
        Me.cTotal.Width = 56
        '
        'cAbono
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.cAbono.DefaultCellStyle = DataGridViewCellStyle2
        Me.cAbono.HeaderText = "Abono Inicial"
        Me.cAbono.Name = "cAbono"
        Me.cAbono.ReadOnly = True
        Me.cAbono.Width = 93
        '
        'cDocumento
        '
        Me.cDocumento.HeaderText = "Documento"
        Me.cDocumento.Name = "cDocumento"
        Me.cDocumento.ReadOnly = True
        Me.cDocumento.Visible = False
        Me.cDocumento.Width = 87
        '
        'cIdDocumento
        '
        Me.cIdDocumento.HeaderText = "IdDocumento"
        Me.cIdDocumento.Name = "cIdDocumento"
        Me.cIdDocumento.ReadOnly = True
        Me.cIdDocumento.Visible = False
        Me.cIdDocumento.Width = 96
        '
        'frmDatosPreVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(830, 354)
        Me.Controls.Add(Me.viewDatos)
        Me.Controls.Add(Me.txtTotalPendiente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.viewFichas)
        Me.Controls.Add(Me.ckEsElectronica)
        Me.Controls.Add(Me.txtTotalCobro)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnFactura)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCobrar)
        Me.Controls.Add(Me.btnGenerarApartado)
        Me.Controls.Add(Me.btnGeneraAdelanto)
        Me.Controls.Add(Me.btnReciboDinero)
        Me.Controls.Add(Me.btnTiquete)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDatosPreVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos PreVenta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.viewFichas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnFactura As System.Windows.Forms.Button
    Friend WithEvents btnTiquete As System.Windows.Forms.Button
    Friend WithEvents btnReciboDinero As System.Windows.Forms.Button
    Friend WithEvents btnGeneraAdelanto As System.Windows.Forms.Button
    Friend WithEvents txtTotalCobro As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPuntoVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnGenerarApartado As System.Windows.Forms.Button
    Friend WithEvents ckEsElectronica As System.Windows.Forms.CheckBox
    Friend WithEvents viewFichas As System.Windows.Forms.DataGridView
    Friend WithEvents btnCobrar As System.Windows.Forms.Button
    Friend WithEvents txtTotalPendiente As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cFicha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cRenta As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cPendiente As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cExpress As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cFE As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCorreo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPuntoVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cAbono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cIdDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
