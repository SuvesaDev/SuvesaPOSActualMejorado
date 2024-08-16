<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarDepositos
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
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIdApertura = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCajero = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtMontoDeposito = New System.Windows.Forms.TextBox()
        Me.txtMoneda = New System.Windows.Forms.TextBox()
        Me.cboCuenta = New System.Windows.Forms.ComboBox()
        Me.txtNumeroDeposito = New System.Windows.Forms.TextBox()
        Me.cboBanco = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDepositoGeneral = New System.Windows.Forms.TextBox()
        Me.txtDepositoColones = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDepositoDolares = New System.Windows.Forms.TextBox()
        Me.viewDepositos = New System.Windows.Forms.DataGridView()
        Me.btnBuscarArqueo = New System.Windows.Forms.Button()
        Me.cId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cBanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMonedaDeposito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMontoDeposito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAnulado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cIdUsuarioAnulacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMotivoAnulacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.viewDepositos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtObservaciones)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cboTipo)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtIdApertura)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtCajero)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.txtMontoDeposito)
        Me.Panel1.Controls.Add(Me.txtMoneda)
        Me.Panel1.Controls.Add(Me.cboCuenta)
        Me.Panel1.Controls.Add(Me.txtNumeroDeposito)
        Me.Panel1.Controls.Add(Me.cboBanco)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(6, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(772, 188)
        Me.Panel1.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 145)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(4, 161)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(500, 22)
        Me.txtObservaciones.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(268, 98)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Tipo "
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"Deposito", "Sinpe", "Otros"})
        Me.cboTipo.Location = New System.Drawing.Point(271, 115)
        Me.cboTipo.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(144, 24)
        Me.cboTipo.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(2, 9)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Cajero(a) :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(508, 107)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 39)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(421, 55)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Moneda"
        '
        'txtIdApertura
        '
        Me.txtIdApertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdApertura.Location = New System.Drawing.Point(438, 9)
        Me.txtIdApertura.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdApertura.Name = "txtIdApertura"
        Me.txtIdApertura.ReadOnly = True
        Me.txtIdApertura.Size = New System.Drawing.Size(66, 22)
        Me.txtIdApertura.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(134, 100)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Monto Deposito"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(378, 12)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "# Apertura"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(266, 54)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Cuenta"
        '
        'txtCajero
        '
        Me.txtCajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCajero.Location = New System.Drawing.Point(61, 8)
        Me.txtCajero.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCajero.Name = "txtCajero"
        Me.txtCajero.ReadOnly = True
        Me.txtCajero.Size = New System.Drawing.Size(295, 22)
        Me.txtCajero.TabIndex = 38
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(508, 65)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(63, 39)
        Me.btnAgregar.TabIndex = 26
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtMontoDeposito
        '
        Me.txtMontoDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoDeposito.Location = New System.Drawing.Point(137, 117)
        Me.txtMontoDeposito.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMontoDeposito.Name = "txtMontoDeposito"
        Me.txtMontoDeposito.Size = New System.Drawing.Size(128, 22)
        Me.txtMontoDeposito.TabIndex = 20
        '
        'txtMoneda
        '
        Me.txtMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMoneda.Location = New System.Drawing.Point(420, 73)
        Me.txtMoneda.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.ReadOnly = True
        Me.txtMoneda.Size = New System.Drawing.Size(84, 22)
        Me.txtMoneda.TabIndex = 27
        '
        'cboCuenta
        '
        Me.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuenta.FormattingEnabled = True
        Me.cboCuenta.Location = New System.Drawing.Point(269, 71)
        Me.cboCuenta.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCuenta.Name = "cboCuenta"
        Me.cboCuenta.Size = New System.Drawing.Size(144, 24)
        Me.cboCuenta.TabIndex = 19
        '
        'txtNumeroDeposito
        '
        Me.txtNumeroDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDeposito.Location = New System.Drawing.Point(7, 117)
        Me.txtNumeroDeposito.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumeroDeposito.Name = "txtNumeroDeposito"
        Me.txtNumeroDeposito.Size = New System.Drawing.Size(126, 22)
        Me.txtNumeroDeposito.TabIndex = 28
        '
        'cboBanco
        '
        Me.cboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBanco.FormattingEnabled = True
        Me.cboBanco.Location = New System.Drawing.Point(4, 71)
        Me.cboBanco.Margin = New System.Windows.Forms.Padding(2)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Size = New System.Drawing.Size(261, 24)
        Me.cboBanco.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 100)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Numero de Deposito"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 54)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Banco"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 555)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Deposito Colones"
        '
        'txtDepositoGeneral
        '
        Me.txtDepositoGeneral.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDepositoGeneral.Location = New System.Drawing.Point(461, 552)
        Me.txtDepositoGeneral.Name = "txtDepositoGeneral"
        Me.txtDepositoGeneral.Size = New System.Drawing.Size(85, 20)
        Me.txtDepositoGeneral.TabIndex = 49
        Me.txtDepositoGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDepositoColones
        '
        Me.txtDepositoColones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDepositoColones.Location = New System.Drawing.Point(99, 552)
        Me.txtDepositoColones.Name = "txtDepositoColones"
        Me.txtDepositoColones.Size = New System.Drawing.Size(85, 20)
        Me.txtDepositoColones.TabIndex = 45
        Me.txtDepositoColones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(373, 555)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 13)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Deposito General"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(188, 555)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 13)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Deposito Dolares"
        '
        'txtDepositoDolares
        '
        Me.txtDepositoDolares.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDepositoDolares.Location = New System.Drawing.Point(277, 552)
        Me.txtDepositoDolares.Name = "txtDepositoDolares"
        Me.txtDepositoDolares.Size = New System.Drawing.Size(85, 20)
        Me.txtDepositoDolares.TabIndex = 47
        Me.txtDepositoDolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'viewDepositos
        '
        Me.viewDepositos.AllowUserToAddRows = False
        Me.viewDepositos.AllowUserToDeleteRows = False
        Me.viewDepositos.AllowUserToResizeColumns = False
        Me.viewDepositos.AllowUserToResizeRows = False
        Me.viewDepositos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewDepositos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.viewDepositos.BackgroundColor = System.Drawing.Color.White
        Me.viewDepositos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cId, Me.cEstado, Me.cBanco, Me.cCuenta, Me.cMonedaDeposito, Me.cNumero, Me.cMontoDeposito, Me.cTipo, Me.cObservaciones, Me.cAnulado, Me.cIdUsuarioAnulacion, Me.cMotivoAnulacion})
        Me.viewDepositos.Location = New System.Drawing.Point(9, 222)
        Me.viewDepositos.MultiSelect = False
        Me.viewDepositos.Name = "viewDepositos"
        Me.viewDepositos.ReadOnly = True
        Me.viewDepositos.RowTemplate.Height = 28
        Me.viewDepositos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDepositos.Size = New System.Drawing.Size(768, 324)
        Me.viewDepositos.TabIndex = 43
        '
        'btnBuscarArqueo
        '
        Me.btnBuscarArqueo.Location = New System.Drawing.Point(12, 0)
        Me.btnBuscarArqueo.Name = "btnBuscarArqueo"
        Me.btnBuscarArqueo.Size = New System.Drawing.Size(166, 23)
        Me.btnBuscarArqueo.TabIndex = 51
        Me.btnBuscarArqueo.Text = "Buscar Arqueo"
        Me.btnBuscarArqueo.UseVisualStyleBackColor = True
        '
        'cId
        '
        Me.cId.HeaderText = "Id"
        Me.cId.Name = "cId"
        Me.cId.ReadOnly = True
        Me.cId.Visible = False
        Me.cId.Width = 41
        '
        'cEstado
        '
        Me.cEstado.HeaderText = "Estado"
        Me.cEstado.Name = "cEstado"
        Me.cEstado.ReadOnly = True
        Me.cEstado.Width = 65
        '
        'cBanco
        '
        Me.cBanco.HeaderText = "Banco"
        Me.cBanco.Name = "cBanco"
        Me.cBanco.ReadOnly = True
        Me.cBanco.Width = 63
        '
        'cCuenta
        '
        Me.cCuenta.HeaderText = "Cuenta"
        Me.cCuenta.Name = "cCuenta"
        Me.cCuenta.ReadOnly = True
        Me.cCuenta.Width = 66
        '
        'cMonedaDeposito
        '
        Me.cMonedaDeposito.HeaderText = "Moneda"
        Me.cMonedaDeposito.Name = "cMonedaDeposito"
        Me.cMonedaDeposito.ReadOnly = True
        Me.cMonedaDeposito.Width = 71
        '
        'cNumero
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N0"
        Me.cNumero.DefaultCellStyle = DataGridViewCellStyle15
        Me.cNumero.HeaderText = "Numero"
        Me.cNumero.Name = "cNumero"
        Me.cNumero.ReadOnly = True
        Me.cNumero.Width = 69
        '
        'cMontoDeposito
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "N2"
        Me.cMontoDeposito.DefaultCellStyle = DataGridViewCellStyle16
        Me.cMontoDeposito.HeaderText = "Monto"
        Me.cMontoDeposito.Name = "cMontoDeposito"
        Me.cMontoDeposito.ReadOnly = True
        Me.cMontoDeposito.Width = 62
        '
        'cTipo
        '
        Me.cTipo.HeaderText = "Tipo"
        Me.cTipo.Name = "cTipo"
        Me.cTipo.ReadOnly = True
        Me.cTipo.Visible = False
        Me.cTipo.Width = 53
        '
        'cObservaciones
        '
        Me.cObservaciones.HeaderText = "Observaciones"
        Me.cObservaciones.Name = "cObservaciones"
        Me.cObservaciones.ReadOnly = True
        Me.cObservaciones.Visible = False
        Me.cObservaciones.Width = 103
        '
        'cAnulado
        '
        Me.cAnulado.HeaderText = "Anulado"
        Me.cAnulado.Name = "cAnulado"
        Me.cAnulado.ReadOnly = True
        Me.cAnulado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cAnulado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cAnulado.Visible = False
        Me.cAnulado.Width = 71
        '
        'cIdUsuarioAnulacion
        '
        Me.cIdUsuarioAnulacion.HeaderText = "IdUsuarioAnulacion"
        Me.cIdUsuarioAnulacion.Name = "cIdUsuarioAnulacion"
        Me.cIdUsuarioAnulacion.ReadOnly = True
        Me.cIdUsuarioAnulacion.Visible = False
        Me.cIdUsuarioAnulacion.Width = 124
        '
        'cMotivoAnulacion
        '
        Me.cMotivoAnulacion.HeaderText = "MotivoAnulacion"
        Me.cMotivoAnulacion.Name = "cMotivoAnulacion"
        Me.cMotivoAnulacion.ReadOnly = True
        Me.cMotivoAnulacion.Visible = False
        Me.cMotivoAnulacion.Width = 111
        '
        'frmEditarDepositos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 579)
        Me.Controls.Add(Me.btnBuscarArqueo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtDepositoGeneral)
        Me.Controls.Add(Me.txtDepositoColones)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtDepositoDolares)
        Me.Controls.Add(Me.viewDepositos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmEditarDepositos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Depositos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.viewDepositos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtIdApertura As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCajero As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtMontoDeposito As System.Windows.Forms.TextBox
    Friend WithEvents txtMoneda As System.Windows.Forms.TextBox
    Friend WithEvents cboCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents txtNumeroDeposito As System.Windows.Forms.TextBox
    Friend WithEvents cboBanco As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDepositoGeneral As System.Windows.Forms.TextBox
    Friend WithEvents txtDepositoColones As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDepositoDolares As System.Windows.Forms.TextBox
    Friend WithEvents viewDepositos As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscarArqueo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents cId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cBanco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMonedaDeposito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMontoDeposito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cAnulado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cIdUsuarioAnulacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMotivoAnulacion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
