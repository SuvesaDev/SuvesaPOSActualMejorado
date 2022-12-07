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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.cBanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMonedaDeposito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMontoDeposito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Panel1.Location = New System.Drawing.Point(8, 33)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(731, 232)
        Me.Panel1.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(355, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Tipo "
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"Deposito", "Sinpe", "Otros"})
        Me.cboTipo.Location = New System.Drawing.Point(359, 144)
        Me.cboTipo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(191, 28)
        Me.cboTipo.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 17)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Cajero(a) :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(646, 126)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 48)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Moneda"
        '
        'txtIdApertura
        '
        Me.txtIdApertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdApertura.Location = New System.Drawing.Point(636, 11)
        Me.txtIdApertura.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdApertura.Name = "txtIdApertura"
        Me.txtIdApertura.ReadOnly = True
        Me.txtIdApertura.Size = New System.Drawing.Size(87, 26)
        Me.txtIdApertura.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(120, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 17)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Monto Deposito"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(556, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 17)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "# Apertura"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(355, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Cuenta"
        '
        'txtCajero
        '
        Me.txtCajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCajero.Location = New System.Drawing.Point(81, 10)
        Me.txtCajero.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCajero.Name = "txtCajero"
        Me.txtCajero.ReadOnly = True
        Me.txtCajero.Size = New System.Drawing.Size(468, 26)
        Me.txtCajero.TabIndex = 38
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(556, 126)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(84, 48)
        Me.btnAgregar.TabIndex = 26
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtMontoDeposito
        '
        Me.txtMontoDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoDeposito.Location = New System.Drawing.Point(124, 146)
        Me.txtMontoDeposito.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMontoDeposito.Name = "txtMontoDeposito"
        Me.txtMontoDeposito.Size = New System.Drawing.Size(228, 26)
        Me.txtMontoDeposito.TabIndex = 20
        '
        'txtMoneda
        '
        Me.txtMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMoneda.Location = New System.Drawing.Point(5, 146)
        Me.txtMoneda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.ReadOnly = True
        Me.txtMoneda.Size = New System.Drawing.Size(111, 26)
        Me.txtMoneda.TabIndex = 27
        '
        'cboCuenta
        '
        Me.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuenta.FormattingEnabled = True
        Me.cboCuenta.Location = New System.Drawing.Point(359, 87)
        Me.cboCuenta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboCuenta.Name = "cboCuenta"
        Me.cboCuenta.Size = New System.Drawing.Size(191, 28)
        Me.cboCuenta.TabIndex = 19
        '
        'txtNumeroDeposito
        '
        Me.txtNumeroDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDeposito.Location = New System.Drawing.Point(556, 87)
        Me.txtNumeroDeposito.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNumeroDeposito.Name = "txtNumeroDeposito"
        Me.txtNumeroDeposito.Size = New System.Drawing.Size(167, 26)
        Me.txtNumeroDeposito.TabIndex = 28
        '
        'cboBanco
        '
        Me.cboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBanco.FormattingEnabled = True
        Me.cboBanco.Location = New System.Drawing.Point(5, 87)
        Me.cboBanco.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Size = New System.Drawing.Size(347, 28)
        Me.cboBanco.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(553, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 17)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Numero de Deposito"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Banco"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 485)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 17)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Deposito Colones"
        '
        'txtDepositoGeneral
        '
        Me.txtDepositoGeneral.Location = New System.Drawing.Point(616, 481)
        Me.txtDepositoGeneral.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDepositoGeneral.Name = "txtDepositoGeneral"
        Me.txtDepositoGeneral.Size = New System.Drawing.Size(112, 22)
        Me.txtDepositoGeneral.TabIndex = 49
        Me.txtDepositoGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDepositoColones
        '
        Me.txtDepositoColones.Location = New System.Drawing.Point(133, 481)
        Me.txtDepositoColones.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDepositoColones.Name = "txtDepositoColones"
        Me.txtDepositoColones.Size = New System.Drawing.Size(112, 22)
        Me.txtDepositoColones.TabIndex = 45
        Me.txtDepositoColones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(499, 485)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 17)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Deposito General"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(252, 485)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 17)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Deposito Dolares"
        '
        'txtDepositoDolares
        '
        Me.txtDepositoDolares.Location = New System.Drawing.Point(371, 481)
        Me.txtDepositoDolares.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDepositoDolares.Name = "txtDepositoDolares"
        Me.txtDepositoDolares.Size = New System.Drawing.Size(112, 22)
        Me.txtDepositoDolares.TabIndex = 47
        Me.txtDepositoDolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'viewDepositos
        '
        Me.viewDepositos.AllowUserToAddRows = False
        Me.viewDepositos.AllowUserToDeleteRows = False
        Me.viewDepositos.AllowUserToResizeColumns = False
        Me.viewDepositos.AllowUserToResizeRows = False
        Me.viewDepositos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.viewDepositos.BackgroundColor = System.Drawing.Color.White
        Me.viewDepositos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cBanco, Me.cCuenta, Me.cMonedaDeposito, Me.cNumero, Me.cMontoDeposito, Me.cTipo, Me.cObservaciones})
        Me.viewDepositos.Location = New System.Drawing.Point(12, 273)
        Me.viewDepositos.Margin = New System.Windows.Forms.Padding(4)
        Me.viewDepositos.MultiSelect = False
        Me.viewDepositos.Name = "viewDepositos"
        Me.viewDepositos.ReadOnly = True
        Me.viewDepositos.RowTemplate.Height = 28
        Me.viewDepositos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDepositos.Size = New System.Drawing.Size(717, 200)
        Me.viewDepositos.TabIndex = 43
        '
        'btnBuscarArqueo
        '
        Me.btnBuscarArqueo.Location = New System.Drawing.Point(16, 0)
        Me.btnBuscarArqueo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscarArqueo.Name = "btnBuscarArqueo"
        Me.btnBuscarArqueo.Size = New System.Drawing.Size(221, 28)
        Me.btnBuscarArqueo.TabIndex = 51
        Me.btnBuscarArqueo.Text = "Buscar Arqueo"
        Me.btnBuscarArqueo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(6, 198)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(717, 26)
        Me.txtObservaciones.TabIndex = 46
        '
        'cBanco
        '
        Me.cBanco.HeaderText = "Banco"
        Me.cBanco.Name = "cBanco"
        Me.cBanco.ReadOnly = True
        Me.cBanco.Width = 77
        '
        'cCuenta
        '
        Me.cCuenta.HeaderText = "Cuenta"
        Me.cCuenta.Name = "cCuenta"
        Me.cCuenta.ReadOnly = True
        Me.cCuenta.Width = 82
        '
        'cMonedaDeposito
        '
        Me.cMonedaDeposito.HeaderText = "Moneda"
        Me.cMonedaDeposito.Name = "cMonedaDeposito"
        Me.cMonedaDeposito.ReadOnly = True
        Me.cMonedaDeposito.Width = 88
        '
        'cNumero
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        Me.cNumero.DefaultCellStyle = DataGridViewCellStyle1
        Me.cNumero.HeaderText = "Numero"
        Me.cNumero.Name = "cNumero"
        Me.cNumero.ReadOnly = True
        Me.cNumero.Width = 87
        '
        'cMontoDeposito
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.cMontoDeposito.DefaultCellStyle = DataGridViewCellStyle2
        Me.cMontoDeposito.HeaderText = "Monto"
        Me.cMontoDeposito.Name = "cMontoDeposito"
        Me.cMontoDeposito.ReadOnly = True
        Me.cMontoDeposito.Width = 76
        '
        'cTipo
        '
        Me.cTipo.HeaderText = "Tipo"
        Me.cTipo.Name = "cTipo"
        Me.cTipo.ReadOnly = True
        Me.cTipo.Visible = False
        Me.cTipo.Width = 65
        '
        'cObservaciones
        '
        Me.cObservaciones.HeaderText = "Observaciones"
        Me.cObservaciones.Name = "cObservaciones"
        Me.cObservaciones.ReadOnly = True
        Me.cObservaciones.Visible = False
        Me.cObservaciones.Width = 132
        '
        'frmEditarDepositos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 508)
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
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents cBanco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMonedaDeposito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMontoDeposito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
