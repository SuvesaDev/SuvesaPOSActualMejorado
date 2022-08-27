<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarDeposito
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDepositoGeneral = New System.Windows.Forms.TextBox()
        Me.txtDepositoColones = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDepositoDolares = New System.Windows.Forms.TextBox()
        Me.viewDepositos = New System.Windows.Forms.DataGridView()
        Me.cBanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMonedaDeposito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMontoDeposito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboBanco = New System.Windows.Forms.ComboBox()
        Me.txtNumeroDeposito = New System.Windows.Forms.TextBox()
        Me.cboCuenta = New System.Windows.Forms.ComboBox()
        Me.txtMoneda = New System.Windows.Forms.TextBox()
        Me.txtMontoDeposito = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIdApertura = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCajero = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.viewDepositos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 390)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Deposito Colones"
        '
        'txtDepositoGeneral
        '
        Me.txtDepositoGeneral.Location = New System.Drawing.Point(465, 387)
        Me.txtDepositoGeneral.Name = "txtDepositoGeneral"
        Me.txtDepositoGeneral.Size = New System.Drawing.Size(85, 20)
        Me.txtDepositoGeneral.TabIndex = 35
        Me.txtDepositoGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDepositoColones
        '
        Me.txtDepositoColones.Location = New System.Drawing.Point(103, 387)
        Me.txtDepositoColones.Name = "txtDepositoColones"
        Me.txtDepositoColones.Size = New System.Drawing.Size(85, 20)
        Me.txtDepositoColones.TabIndex = 31
        Me.txtDepositoColones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(377, 390)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Deposito General"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(192, 390)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Deposito Dolares"
        '
        'txtDepositoDolares
        '
        Me.txtDepositoDolares.Location = New System.Drawing.Point(281, 387)
        Me.txtDepositoDolares.Name = "txtDepositoDolares"
        Me.txtDepositoDolares.Size = New System.Drawing.Size(85, 20)
        Me.txtDepositoDolares.TabIndex = 33
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
        Me.viewDepositos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cBanco, Me.cCuenta, Me.cMonedaDeposito, Me.cNumero, Me.cMontoDeposito})
        Me.viewDepositos.Location = New System.Drawing.Point(12, 184)
        Me.viewDepositos.MultiSelect = False
        Me.viewDepositos.Name = "viewDepositos"
        Me.viewDepositos.ReadOnly = True
        Me.viewDepositos.RowTemplate.Height = 28
        Me.viewDepositos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDepositos.Size = New System.Drawing.Size(538, 197)
        Me.viewDepositos.TabIndex = 24
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        Me.cNumero.DefaultCellStyle = DataGridViewCellStyle3
        Me.cNumero.HeaderText = "Numero"
        Me.cNumero.Name = "cNumero"
        Me.cNumero.ReadOnly = True
        Me.cNumero.Width = 69
        '
        'cMontoDeposito
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.cMontoDeposito.DefaultCellStyle = DataGridViewCellStyle4
        Me.cMontoDeposito.HeaderText = "Monto"
        Me.cMontoDeposito.Name = "cMontoDeposito"
        Me.cMontoDeposito.ReadOnly = True
        Me.cMontoDeposito.Width = 62
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(415, 54)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Numero de Deposito"
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
        'txtNumeroDeposito
        '
        Me.txtNumeroDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDeposito.Location = New System.Drawing.Point(417, 71)
        Me.txtNumeroDeposito.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumeroDeposito.Name = "txtNumeroDeposito"
        Me.txtNumeroDeposito.Size = New System.Drawing.Size(126, 22)
        Me.txtNumeroDeposito.TabIndex = 28
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
        'txtMoneda
        '
        Me.txtMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMoneda.Location = New System.Drawing.Point(4, 119)
        Me.txtMoneda.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.ReadOnly = True
        Me.txtMoneda.Size = New System.Drawing.Size(84, 22)
        Me.txtMoneda.TabIndex = 27
        '
        'txtMontoDeposito
        '
        Me.txtMontoDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoDeposito.Location = New System.Drawing.Point(93, 119)
        Me.txtMontoDeposito.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMontoDeposito.Name = "txtMontoDeposito"
        Me.txtMontoDeposito.Size = New System.Drawing.Size(172, 22)
        Me.txtMontoDeposito.TabIndex = 20
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(269, 102)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(144, 39)
        Me.btnAgregar.TabIndex = 26
        Me.btnAgregar.Text = "Agregar Deposito"
        Me.btnAgregar.UseVisualStyleBackColor = True
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(90, 102)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Monto Deposito"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 101)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Moneda"
        '
        'txtIdApertura
        '
        Me.txtIdApertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdApertura.Location = New System.Drawing.Point(477, 9)
        Me.txtIdApertura.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdApertura.Name = "txtIdApertura"
        Me.txtIdApertura.ReadOnly = True
        Me.txtIdApertura.Size = New System.Drawing.Size(66, 22)
        Me.txtIdApertura.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(417, 12)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "# Apertura"
        '
        'txtCajero
        '
        Me.txtCajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCajero.Location = New System.Drawing.Point(61, 8)
        Me.txtCajero.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCajero.Name = "txtCajero"
        Me.txtCajero.ReadOnly = True
        Me.txtCajero.Size = New System.Drawing.Size(352, 22)
        Me.txtCajero.TabIndex = 38
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
        Me.Button1.Location = New System.Drawing.Point(417, 102)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 39)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Guardar Depositos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
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
        Me.Panel1.Location = New System.Drawing.Point(9, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 155)
        Me.Panel1.TabIndex = 42
        '
        'frmAgregarDeposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 413)
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
        Me.MinimizeBox = False
        Me.Name = "frmAgregarDeposito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Depositos"
        CType(Me.viewDepositos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDepositoGeneral As System.Windows.Forms.TextBox
    Friend WithEvents txtDepositoColones As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDepositoDolares As System.Windows.Forms.TextBox
    Friend WithEvents viewDepositos As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboBanco As System.Windows.Forms.ComboBox
    Friend WithEvents txtNumeroDeposito As System.Windows.Forms.TextBox
    Friend WithEvents cboCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents txtMoneda As System.Windows.Forms.TextBox
    Friend WithEvents txtMontoDeposito As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtIdApertura As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCajero As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cBanco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMonedaDeposito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMontoDeposito As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
