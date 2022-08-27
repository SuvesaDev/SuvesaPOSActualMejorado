<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaldoFirmadoContado
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumFactura = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtRetiro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalFactura = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAbonos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDevoluciones = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSaldoPendiente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero Factura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cliente"
        '
        'txtNumFactura
        '
        Me.txtNumFactura.Location = New System.Drawing.Point(17, 68)
        Me.txtNumFactura.Name = "txtNumFactura"
        Me.txtNumFactura.ReadOnly = True
        Me.txtNumFactura.Size = New System.Drawing.Size(100, 20)
        Me.txtNumFactura.TabIndex = 2
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(133, 68)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(418, 20)
        Me.txtCliente.TabIndex = 3
        '
        'txtRetiro
        '
        Me.txtRetiro.Location = New System.Drawing.Point(133, 110)
        Me.txtRetiro.Name = "txtRetiro"
        Me.txtRetiro.ReadOnly = True
        Me.txtRetiro.Size = New System.Drawing.Size(418, 20)
        Me.txtRetiro.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(130, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre Retiro"
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(17, 110)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.ReadOnly = True
        Me.txtCedula.Size = New System.Drawing.Size(100, 20)
        Me.txtCedula.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Identificacion"
        '
        'txtTotalFactura
        '
        Me.txtTotalFactura.Location = New System.Drawing.Point(133, 157)
        Me.txtTotalFactura.Name = "txtTotalFactura"
        Me.txtTotalFactura.ReadOnly = True
        Me.txtTotalFactura.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalFactura.TabIndex = 9
        Me.txtTotalFactura.Text = "0"
        Me.txtTotalFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(130, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Total Factura"
        '
        'txtAbonos
        '
        Me.txtAbonos.Location = New System.Drawing.Point(239, 157)
        Me.txtAbonos.Name = "txtAbonos"
        Me.txtAbonos.ReadOnly = True
        Me.txtAbonos.Size = New System.Drawing.Size(100, 20)
        Me.txtAbonos.TabIndex = 11
        Me.txtAbonos.Text = "0"
        Me.txtAbonos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(236, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Total Abonos"
        '
        'txtDevoluciones
        '
        Me.txtDevoluciones.Location = New System.Drawing.Point(345, 157)
        Me.txtDevoluciones.Name = "txtDevoluciones"
        Me.txtDevoluciones.ReadOnly = True
        Me.txtDevoluciones.Size = New System.Drawing.Size(100, 20)
        Me.txtDevoluciones.TabIndex = 13
        Me.txtDevoluciones.Text = "0"
        Me.txtDevoluciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(342, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Total Devoluciones"
        '
        'txtSaldoPendiente
        '
        Me.txtSaldoPendiente.Location = New System.Drawing.Point(451, 157)
        Me.txtSaldoPendiente.Name = "txtSaldoPendiente"
        Me.txtSaldoPendiente.ReadOnly = True
        Me.txtSaldoPendiente.Size = New System.Drawing.Size(100, 20)
        Me.txtSaldoPendiente.TabIndex = 15
        Me.txtSaldoPendiente.Text = "0"
        Me.txtSaldoPendiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(448, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Saldo Pendiente"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(133, 190)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 49)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(345, 190)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(206, 49)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Location = New System.Drawing.Point(14, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(537, 35)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Factura Firmado Contado"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSaldoFirmadoContado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 251)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSaldoPendiente)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDevoluciones)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAbonos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTotalFactura)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRetiro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.txtNumFactura)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSaldoFirmadoContado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirmar Accion!!!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNumFactura As System.Windows.Forms.TextBox
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtRetiro As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotalFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAbonos As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDevoluciones As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoPendiente As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
