<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGUARDAR_VALIDA_FIRMADOCONTADO
    Inherits System.Windows.Forms.Form

'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnAGREGAR_EXEPCION_FIRMADOCONTADO = New System.Windows.Forms.Button()
        Me.btnQUITAR_EXEPCION_FIRMADOCONTADO = New System.Windows.Forms.Button()
        Me.viewEXEPCION_FIRMADOCONTADO = New System.Windows.Forms.DataGridView()
        Me.lblCONTADO = New System.Windows.Forms.Label()
        Me.ckCONTADO = New System.Windows.Forms.CheckBox()
        Me.ckPVE = New System.Windows.Forms.CheckBox()
        Me.lblMONTO_MAXIMO = New System.Windows.Forms.Label()
        Me.txtMONTO_MAXIMO = New System.Windows.Forms.TextBox()
        Me.ckEXIGE_NOMBRE = New System.Windows.Forms.CheckBox()
        Me.lblMAXIMO_CLIENTE = New System.Windows.Forms.Label()
        Me.txtMAXIMO_CLIENTE = New System.Windows.Forms.TextBox()
        Me.lblMAXIMO_AUTORIZA = New System.Windows.Forms.Label()
        Me.txtMAXIMO_AUTORIZA = New System.Windows.Forms.TextBox()
        Me.lblMAXIMO_RETIRA = New System.Windows.Forms.Label()
        Me.txtMAXIMO_RETIRA = New System.Windows.Forms.TextBox()
        Me.lblEFCEDULA = New System.Windows.Forms.Label()
        Me.txtEFCEDULA = New System.Windows.Forms.TextBox()
        Me.lblEFNOMBRE = New System.Windows.Forms.Label()
        Me.txtEFNOMBRE = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabInfo = New System.Windows.Forms.TabPage()
        Me.TabEXEPCION_FIRMADOCONTADO = New System.Windows.Forms.TabPage()
        Me.cEFID_EXEPCION_FIRMADOCONTADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cEFID_VALIDA_FIRMADOCONTADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cEFCEDULA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cEFNOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewEXEPCION_FIRMADOCONTADO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabInfo.SuspendLayout()
        Me.TabEXEPCION_FIRMADOCONTADO.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAceptar.Location = New System.Drawing.Point(157, 282)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(104, 43)
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancelar.Location = New System.Drawing.Point(267, 282)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(104, 43)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.TabStop = False
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 500
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnAGREGAR_EXEPCION_FIRMADOCONTADO
        '
        Me.btnAGREGAR_EXEPCION_FIRMADOCONTADO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAGREGAR_EXEPCION_FIRMADOCONTADO.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAGREGAR_EXEPCION_FIRMADOCONTADO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAGREGAR_EXEPCION_FIRMADOCONTADO.Location = New System.Drawing.Point(167, 60)
        Me.btnAGREGAR_EXEPCION_FIRMADOCONTADO.Name = "btnAGREGAR_EXEPCION_FIRMADOCONTADO"
        Me.btnAGREGAR_EXEPCION_FIRMADOCONTADO.Size = New System.Drawing.Size(104, 29)
        Me.btnAGREGAR_EXEPCION_FIRMADOCONTADO.TabIndex = 10
        Me.btnAGREGAR_EXEPCION_FIRMADOCONTADO.Text = "AGREGAR"
        Me.btnAGREGAR_EXEPCION_FIRMADOCONTADO.UseVisualStyleBackColor = True
        '
        'btnQUITAR_EXEPCION_FIRMADOCONTADO
        '
        Me.btnQUITAR_EXEPCION_FIRMADOCONTADO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQUITAR_EXEPCION_FIRMADOCONTADO.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQUITAR_EXEPCION_FIRMADOCONTADO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnQUITAR_EXEPCION_FIRMADOCONTADO.Location = New System.Drawing.Point(277, 60)
        Me.btnQUITAR_EXEPCION_FIRMADOCONTADO.Name = "btnQUITAR_EXEPCION_FIRMADOCONTADO"
        Me.btnQUITAR_EXEPCION_FIRMADOCONTADO.Size = New System.Drawing.Size(104, 29)
        Me.btnQUITAR_EXEPCION_FIRMADOCONTADO.TabIndex = 8
        Me.btnQUITAR_EXEPCION_FIRMADOCONTADO.TabStop = False
        Me.btnQUITAR_EXEPCION_FIRMADOCONTADO.Text = "QUITAR"
        Me.btnQUITAR_EXEPCION_FIRMADOCONTADO.UseVisualStyleBackColor = True
        '
        'viewEXEPCION_FIRMADOCONTADO
        '
        Me.viewEXEPCION_FIRMADOCONTADO.AllowUserToAddRows = False
        Me.viewEXEPCION_FIRMADOCONTADO.AllowUserToDeleteRows = False
        Me.viewEXEPCION_FIRMADOCONTADO.BackgroundColor = System.Drawing.Color.White
        Me.viewEXEPCION_FIRMADOCONTADO.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.viewEXEPCION_FIRMADOCONTADO.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.viewEXEPCION_FIRMADOCONTADO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewEXEPCION_FIRMADOCONTADO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cEFID_EXEPCION_FIRMADOCONTADO, Me.cEFID_VALIDA_FIRMADOCONTADO, Me.cEFCEDULA, Me.cEFNOMBRE})
        Me.viewEXEPCION_FIRMADOCONTADO.Location = New System.Drawing.Point(5, 95)
        Me.viewEXEPCION_FIRMADOCONTADO.MultiSelect = False
        Me.viewEXEPCION_FIRMADOCONTADO.Name = "viewEXEPCION_FIRMADOCONTADO"
        Me.viewEXEPCION_FIRMADOCONTADO.ReadOnly = True
        Me.viewEXEPCION_FIRMADOCONTADO.RowHeadersVisible = False
        Me.viewEXEPCION_FIRMADOCONTADO.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.viewEXEPCION_FIRMADOCONTADO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewEXEPCION_FIRMADOCONTADO.Size = New System.Drawing.Size(378, 150)
        Me.viewEXEPCION_FIRMADOCONTADO.TabIndex = 13
        Me.viewEXEPCION_FIRMADOCONTADO.TabStop = False
        '
        'lblCONTADO
        '
        Me.lblCONTADO.AutoSize = True
        Me.lblCONTADO.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCONTADO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCONTADO.Location = New System.Drawing.Point(8, 21)
        Me.lblCONTADO.Name = "lblCONTADO"
        Me.lblCONTADO.Size = New System.Drawing.Size(181, 18)
        Me.lblCONTADO.TabIndex = 12
        Me.lblCONTADO.Text = "Tipos de facturas permitidas:"
        '
        'ckCONTADO
        '
        Me.ckCONTADO.AutoSize = True
        Me.ckCONTADO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ckCONTADO.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.ckCONTADO.Location = New System.Drawing.Point(209, 20)
        Me.ckCONTADO.Name = "ckCONTADO"
        Me.ckCONTADO.Size = New System.Drawing.Size(81, 22)
        Me.ckCONTADO.TabIndex = 1
        Me.ckCONTADO.Text = "CONTADO"
        Me.ckCONTADO.UseVisualStyleBackColor = True
        '
        'ckPVE
        '
        Me.ckPVE.AutoSize = True
        Me.ckPVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ckPVE.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.ckPVE.Location = New System.Drawing.Point(309, 20)
        Me.ckPVE.Name = "ckPVE"
        Me.ckPVE.Size = New System.Drawing.Size(45, 22)
        Me.ckPVE.TabIndex = 2
        Me.ckPVE.Text = "PVE"
        Me.ckPVE.UseVisualStyleBackColor = True
        '
        'lblMONTO_MAXIMO
        '
        Me.lblMONTO_MAXIMO.AutoSize = True
        Me.lblMONTO_MAXIMO.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMONTO_MAXIMO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMONTO_MAXIMO.Location = New System.Drawing.Point(8, 50)
        Me.lblMONTO_MAXIMO.Name = "lblMONTO_MAXIMO"
        Me.lblMONTO_MAXIMO.Size = New System.Drawing.Size(181, 18)
        Me.lblMONTO_MAXIMO.TabIndex = 12
        Me.lblMONTO_MAXIMO.Text = "Monto Maximo de la factura :"
        '
        'txtMONTO_MAXIMO
        '
        Me.txtMONTO_MAXIMO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMONTO_MAXIMO.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMONTO_MAXIMO.Location = New System.Drawing.Point(206, 47)
        Me.txtMONTO_MAXIMO.MaxLength = 10
        Me.txtMONTO_MAXIMO.Name = "txtMONTO_MAXIMO"
        Me.txtMONTO_MAXIMO.Size = New System.Drawing.Size(169, 23)
        Me.txtMONTO_MAXIMO.TabIndex = 3
        Me.txtMONTO_MAXIMO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ckEXIGE_NOMBRE
        '
        Me.ckEXIGE_NOMBRE.AutoSize = True
        Me.ckEXIGE_NOMBRE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ckEXIGE_NOMBRE.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.ckEXIGE_NOMBRE.Location = New System.Drawing.Point(209, 80)
        Me.ckEXIGE_NOMBRE.Name = "ckEXIGE_NOMBRE"
        Me.ckEXIGE_NOMBRE.Size = New System.Drawing.Size(170, 22)
        Me.ckEXIGE_NOMBRE.TabIndex = 4
        Me.ckEXIGE_NOMBRE.Text = "Exigir Nombre de Cliente"
        Me.ckEXIGE_NOMBRE.UseVisualStyleBackColor = True
        '
        'lblMAXIMO_CLIENTE
        '
        Me.lblMAXIMO_CLIENTE.AutoSize = True
        Me.lblMAXIMO_CLIENTE.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMAXIMO_CLIENTE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMAXIMO_CLIENTE.Location = New System.Drawing.Point(8, 147)
        Me.lblMAXIMO_CLIENTE.Name = "lblMAXIMO_CLIENTE"
        Me.lblMAXIMO_CLIENTE.Size = New System.Drawing.Size(188, 18)
        Me.lblMAXIMO_CLIENTE.TabIndex = 12
        Me.lblMAXIMO_CLIENTE.Text = "Cantidad maxima por Cliente :"
        '
        'txtMAXIMO_CLIENTE
        '
        Me.txtMAXIMO_CLIENTE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMAXIMO_CLIENTE.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMAXIMO_CLIENTE.Location = New System.Drawing.Point(206, 144)
        Me.txtMAXIMO_CLIENTE.MaxLength = 10
        Me.txtMAXIMO_CLIENTE.Name = "txtMAXIMO_CLIENTE"
        Me.txtMAXIMO_CLIENTE.Size = New System.Drawing.Size(169, 23)
        Me.txtMAXIMO_CLIENTE.TabIndex = 5
        Me.txtMAXIMO_CLIENTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblMAXIMO_AUTORIZA
        '
        Me.lblMAXIMO_AUTORIZA.AutoSize = True
        Me.lblMAXIMO_AUTORIZA.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMAXIMO_AUTORIZA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMAXIMO_AUTORIZA.Location = New System.Drawing.Point(8, 177)
        Me.lblMAXIMO_AUTORIZA.Name = "lblMAXIMO_AUTORIZA"
        Me.lblMAXIMO_AUTORIZA.Size = New System.Drawing.Size(195, 18)
        Me.lblMAXIMO_AUTORIZA.TabIndex = 12
        Me.lblMAXIMO_AUTORIZA.Text = "Cantidad maxima por Autoriza :"
        '
        'txtMAXIMO_AUTORIZA
        '
        Me.txtMAXIMO_AUTORIZA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMAXIMO_AUTORIZA.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMAXIMO_AUTORIZA.Location = New System.Drawing.Point(206, 174)
        Me.txtMAXIMO_AUTORIZA.MaxLength = 10
        Me.txtMAXIMO_AUTORIZA.Name = "txtMAXIMO_AUTORIZA"
        Me.txtMAXIMO_AUTORIZA.Size = New System.Drawing.Size(169, 23)
        Me.txtMAXIMO_AUTORIZA.TabIndex = 6
        Me.txtMAXIMO_AUTORIZA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblMAXIMO_RETIRA
        '
        Me.lblMAXIMO_RETIRA.AutoSize = True
        Me.lblMAXIMO_RETIRA.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMAXIMO_RETIRA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMAXIMO_RETIRA.Location = New System.Drawing.Point(8, 207)
        Me.lblMAXIMO_RETIRA.Name = "lblMAXIMO_RETIRA"
        Me.lblMAXIMO_RETIRA.Size = New System.Drawing.Size(182, 18)
        Me.lblMAXIMO_RETIRA.TabIndex = 12
        Me.lblMAXIMO_RETIRA.Text = "Cantidad maxima por Retira :"
        '
        'txtMAXIMO_RETIRA
        '
        Me.txtMAXIMO_RETIRA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMAXIMO_RETIRA.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMAXIMO_RETIRA.Location = New System.Drawing.Point(206, 204)
        Me.txtMAXIMO_RETIRA.MaxLength = 10
        Me.txtMAXIMO_RETIRA.Name = "txtMAXIMO_RETIRA"
        Me.txtMAXIMO_RETIRA.Size = New System.Drawing.Size(169, 23)
        Me.txtMAXIMO_RETIRA.TabIndex = 7
        Me.txtMAXIMO_RETIRA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEFCEDULA
        '
        Me.lblEFCEDULA.AutoSize = True
        Me.lblEFCEDULA.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEFCEDULA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEFCEDULA.Location = New System.Drawing.Point(8, 12)
        Me.lblEFCEDULA.Name = "lblEFCEDULA"
        Me.lblEFCEDULA.Size = New System.Drawing.Size(51, 18)
        Me.lblEFCEDULA.TabIndex = 12
        Me.lblEFCEDULA.Text = "Cedula "
        '
        'txtEFCEDULA
        '
        Me.txtEFCEDULA.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEFCEDULA.Location = New System.Drawing.Point(11, 33)
        Me.txtEFCEDULA.MaxLength = 100
        Me.txtEFCEDULA.Name = "txtEFCEDULA"
        Me.txtEFCEDULA.Size = New System.Drawing.Size(93, 23)
        Me.txtEFCEDULA.TabIndex = 1
        '
        'lblEFNOMBRE
        '
        Me.lblEFNOMBRE.AutoSize = True
        Me.lblEFNOMBRE.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEFNOMBRE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEFNOMBRE.Location = New System.Drawing.Point(107, 12)
        Me.lblEFNOMBRE.Name = "lblEFNOMBRE"
        Me.lblEFNOMBRE.Size = New System.Drawing.Size(57, 18)
        Me.lblEFNOMBRE.TabIndex = 12
        Me.lblEFNOMBRE.Text = "Nombre "
        '
        'txtEFNOMBRE
        '
        Me.txtEFNOMBRE.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEFNOMBRE.Location = New System.Drawing.Point(110, 33)
        Me.txtEFNOMBRE.MaxLength = 100
        Me.txtEFNOMBRE.Name = "txtEFNOMBRE"
        Me.txtEFNOMBRE.ReadOnly = True
        Me.txtEFNOMBRE.Size = New System.Drawing.Size(271, 23)
        Me.txtEFNOMBRE.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabInfo)
        Me.TabControl1.Controls.Add(Me.TabEXEPCION_FIRMADOCONTADO)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(395, 279)
        Me.TabControl1.TabIndex = 0
        '
        'TabInfo
        '
        Me.TabInfo.Controls.Add(Me.lblCONTADO)
        Me.TabInfo.Controls.Add(Me.ckCONTADO)
        Me.TabInfo.Controls.Add(Me.ckPVE)
        Me.TabInfo.Controls.Add(Me.lblMONTO_MAXIMO)
        Me.TabInfo.Controls.Add(Me.txtMONTO_MAXIMO)
        Me.TabInfo.Controls.Add(Me.ckEXIGE_NOMBRE)
        Me.TabInfo.Controls.Add(Me.lblMAXIMO_CLIENTE)
        Me.TabInfo.Controls.Add(Me.txtMAXIMO_CLIENTE)
        Me.TabInfo.Controls.Add(Me.lblMAXIMO_AUTORIZA)
        Me.TabInfo.Controls.Add(Me.txtMAXIMO_AUTORIZA)
        Me.TabInfo.Controls.Add(Me.lblMAXIMO_RETIRA)
        Me.TabInfo.Controls.Add(Me.txtMAXIMO_RETIRA)
        Me.TabInfo.Location = New System.Drawing.Point(4, 25)
        Me.TabInfo.Name = "TabInfo"
        Me.TabInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabInfo.Size = New System.Drawing.Size(387, 250)
        Me.TabInfo.TabIndex = 1
        Me.TabInfo.Text = "Condiciones de Uso"
        Me.TabInfo.UseVisualStyleBackColor = True
        '
        'TabEXEPCION_FIRMADOCONTADO
        '
        Me.TabEXEPCION_FIRMADOCONTADO.Controls.Add(Me.lblEFCEDULA)
        Me.TabEXEPCION_FIRMADOCONTADO.Controls.Add(Me.txtEFCEDULA)
        Me.TabEXEPCION_FIRMADOCONTADO.Controls.Add(Me.lblEFNOMBRE)
        Me.TabEXEPCION_FIRMADOCONTADO.Controls.Add(Me.txtEFNOMBRE)
        Me.TabEXEPCION_FIRMADOCONTADO.Controls.Add(Me.btnAGREGAR_EXEPCION_FIRMADOCONTADO)
        Me.TabEXEPCION_FIRMADOCONTADO.Controls.Add(Me.btnQUITAR_EXEPCION_FIRMADOCONTADO)
        Me.TabEXEPCION_FIRMADOCONTADO.Controls.Add(Me.viewEXEPCION_FIRMADOCONTADO)
        Me.TabEXEPCION_FIRMADOCONTADO.Location = New System.Drawing.Point(4, 25)
        Me.TabEXEPCION_FIRMADOCONTADO.Name = "TabEXEPCION_FIRMADOCONTADO"
        Me.TabEXEPCION_FIRMADOCONTADO.Padding = New System.Windows.Forms.Padding(3)
        Me.TabEXEPCION_FIRMADOCONTADO.Size = New System.Drawing.Size(387, 250)
        Me.TabEXEPCION_FIRMADOCONTADO.TabIndex = 1
        Me.TabEXEPCION_FIRMADOCONTADO.Text = "Exepciones"
        Me.TabEXEPCION_FIRMADOCONTADO.UseVisualStyleBackColor = True
        '
        'cEFID_EXEPCION_FIRMADOCONTADO
        '
        Me.cEFID_EXEPCION_FIRMADOCONTADO.HeaderText = "ID_EXEPCION_FIRMADOCONTADO"
        Me.cEFID_EXEPCION_FIRMADOCONTADO.Name = "cEFID_EXEPCION_FIRMADOCONTADO"
        Me.cEFID_EXEPCION_FIRMADOCONTADO.ReadOnly = True
        Me.cEFID_EXEPCION_FIRMADOCONTADO.Visible = False
        '
        'cEFID_VALIDA_FIRMADOCONTADO
        '
        Me.cEFID_VALIDA_FIRMADOCONTADO.HeaderText = "ID_VALIDA_FIRMADOCONTADO"
        Me.cEFID_VALIDA_FIRMADOCONTADO.Name = "cEFID_VALIDA_FIRMADOCONTADO"
        Me.cEFID_VALIDA_FIRMADOCONTADO.ReadOnly = True
        Me.cEFID_VALIDA_FIRMADOCONTADO.Visible = False
        '
        'cEFCEDULA
        '
        Me.cEFCEDULA.FillWeight = 91.37056!
        Me.cEFCEDULA.HeaderText = "CEDULA"
        Me.cEFCEDULA.Name = "cEFCEDULA"
        Me.cEFCEDULA.ReadOnly = True
        '
        'cEFNOMBRE
        '
        Me.cEFNOMBRE.FillWeight = 108.6294!
        Me.cEFNOMBRE.HeaderText = "NOMBRE"
        Me.cEFNOMBRE.Name = "cEFNOMBRE"
        Me.cEFNOMBRE.ReadOnly = True
        Me.cEFNOMBRE.Width = 260
        '
        'frmGUARDAR_VALIDA_FIRMADOCONTADO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(397, 330)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmGUARDAR_VALIDA_FIRMADOCONTADO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Condiciones de Uso Firmado Contado"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewEXEPCION_FIRMADOCONTADO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabInfo.ResumeLayout(False)
        Me.TabInfo.PerformLayout()
        Me.TabEXEPCION_FIRMADOCONTADO.ResumeLayout(False)
        Me.TabEXEPCION_FIRMADOCONTADO.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCONTADO As System.Windows.Forms.Label
    Friend WithEvents ckCONTADO As System.Windows.Forms.CheckBox


    Friend WithEvents ckPVE As System.Windows.Forms.CheckBox


    Friend WithEvents lblMONTO_MAXIMO As System.Windows.Forms.Label
    Friend WithEvents txtMONTO_MAXIMO As System.Windows.Forms.TextBox


    Friend WithEvents ckEXIGE_NOMBRE As System.Windows.Forms.CheckBox


    Friend WithEvents lblMAXIMO_CLIENTE As System.Windows.Forms.Label
    Friend WithEvents txtMAXIMO_CLIENTE As System.Windows.Forms.TextBox


    Friend WithEvents lblMAXIMO_AUTORIZA As System.Windows.Forms.Label
    Friend WithEvents txtMAXIMO_AUTORIZA As System.Windows.Forms.TextBox


    Friend WithEvents lblMAXIMO_RETIRA As System.Windows.Forms.Label
    Friend WithEvents txtMAXIMO_RETIRA As System.Windows.Forms.TextBox

    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabInfo As System.Windows.Forms.TabPage

    Friend WithEvents lblEFCEDULA As System.Windows.Forms.Label
    Friend WithEvents txtEFCEDULA As System.Windows.Forms.TextBox


    Friend WithEvents lblEFNOMBRE As System.Windows.Forms.Label
    Friend WithEvents txtEFNOMBRE As System.Windows.Forms.TextBox

    Friend WithEvents TabEXEPCION_FIRMADOCONTADO As System.Windows.Forms.TabPage
    Friend WithEvents btnAGREGAR_EXEPCION_FIRMADOCONTADO As System.Windows.Forms.Button
    Friend WithEvents btnQUITAR_EXEPCION_FIRMADOCONTADO As System.Windows.Forms.Button
    Friend WithEvents viewEXEPCION_FIRMADOCONTADO As System.Windows.Forms.DataGridView
    Friend WithEvents cEFID_EXEPCION_FIRMADOCONTADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cEFID_VALIDA_FIRMADOCONTADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cEFCEDULA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cEFNOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn




End Class
