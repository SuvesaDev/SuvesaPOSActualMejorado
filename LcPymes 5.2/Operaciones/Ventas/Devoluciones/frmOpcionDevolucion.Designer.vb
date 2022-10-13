<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpcionDevolucion
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
        Me.btnAnticipo = New System.Windows.Forms.Button()
        Me.btnDeposito = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEfectivo = New System.Windows.Forms.Button()
        Me.pDeposito = New System.Windows.Forms.GroupBox()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pAnticipo = New System.Windows.Forms.GroupBox()
        Me.txtNombreAnticcipo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.pDeposito.SuspendLayout()
        Me.pAnticipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAnticipo
        '
        Me.btnAnticipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnticipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnticipo.Location = New System.Drawing.Point(509, 55)
        Me.btnAnticipo.Name = "btnAnticipo"
        Me.btnAnticipo.Size = New System.Drawing.Size(240, 78)
        Me.btnAnticipo.TabIndex = 1
        Me.btnAnticipo.Text = "Anticipo"
        '
        'btnDeposito
        '
        Me.btnDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeposito.Location = New System.Drawing.Point(263, 55)
        Me.btnDeposito.Name = "btnDeposito"
        Me.btnDeposito.Size = New System.Drawing.Size(240, 78)
        Me.btnDeposito.TabIndex = 2
        Me.btnDeposito.Text = "Deposito"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(424, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Como desea aplicar esta Devolucion ?"
        '
        'btnEfectivo
        '
        Me.btnEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEfectivo.Location = New System.Drawing.Point(12, 55)
        Me.btnEfectivo.Name = "btnEfectivo"
        Me.btnEfectivo.Size = New System.Drawing.Size(240, 78)
        Me.btnEfectivo.TabIndex = 4
        Me.btnEfectivo.Text = "Efectivo"
        '
        'pDeposito
        '
        Me.pDeposito.Controls.Add(Me.txtCuenta)
        Me.pDeposito.Controls.Add(Me.Label4)
        Me.pDeposito.Controls.Add(Me.txtNombre)
        Me.pDeposito.Controls.Add(Me.Label3)
        Me.pDeposito.Controls.Add(Me.txtCedula)
        Me.pDeposito.Controls.Add(Me.Label2)
        Me.pDeposito.Enabled = False
        Me.pDeposito.Location = New System.Drawing.Point(20, 142)
        Me.pDeposito.Name = "pDeposito"
        Me.pDeposito.Size = New System.Drawing.Size(729, 98)
        Me.pDeposito.TabIndex = 5
        Me.pDeposito.TabStop = False
        Me.pDeposito.Text = "Deposito"
        '
        'txtCuenta
        '
        Me.txtCuenta.Location = New System.Drawing.Point(89, 55)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(143, 22)
        Me.txtCuenta.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Cuenta"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(302, 27)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(404, 22)
        Me.txtNombre.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(244, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(89, 27)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(143, 22)
        Me.txtCedula.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cedula"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(509, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(240, 78)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Aceptar"
        '
        'pAnticipo
        '
        Me.pAnticipo.Controls.Add(Me.btnBuscarCliente)
        Me.pAnticipo.Controls.Add(Me.txtNombreAnticcipo)
        Me.pAnticipo.Controls.Add(Me.Label6)
        Me.pAnticipo.Enabled = False
        Me.pAnticipo.Location = New System.Drawing.Point(20, 141)
        Me.pAnticipo.Name = "pAnticipo"
        Me.pAnticipo.Size = New System.Drawing.Size(725, 98)
        Me.pAnticipo.TabIndex = 6
        Me.pAnticipo.TabStop = False
        Me.pAnticipo.Text = "Cliente Anticipo"
        '
        'txtNombreAnticcipo
        '
        Me.txtNombreAnticcipo.Location = New System.Drawing.Point(113, 49)
        Me.txtNombreAnticcipo.Name = "txtNombreAnticcipo"
        Me.txtNombreAnticcipo.Size = New System.Drawing.Size(594, 22)
        Me.txtNombreAnticcipo.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(110, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Nombre"
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Location = New System.Drawing.Point(29, 28)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(75, 43)
        Me.btnBuscarCliente.TabIndex = 4
        Me.btnBuscarCliente.Text = "Buscar Cliente"
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'frmOpcionDevolucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 339)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pDeposito)
        Me.Controls.Add(Me.btnEfectivo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDeposito)
        Me.Controls.Add(Me.btnAnticipo)
        Me.Controls.Add(Me.pAnticipo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOpcionDevolucion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elija una opcion"
        Me.pDeposito.ResumeLayout(False)
        Me.pDeposito.PerformLayout()
        Me.pAnticipo.ResumeLayout(False)
        Me.pAnticipo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAnticipo As System.Windows.Forms.Button
    Friend WithEvents btnDeposito As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEfectivo As System.Windows.Forms.Button
    Friend WithEvents pDeposito As System.Windows.Forms.GroupBox
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pAnticipo As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombreAnticcipo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarCliente As System.Windows.Forms.Button
End Class
