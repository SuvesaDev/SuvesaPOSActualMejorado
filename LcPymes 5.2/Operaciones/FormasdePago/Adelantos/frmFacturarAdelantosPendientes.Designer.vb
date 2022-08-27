<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturarAdelantosPendientes
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPuntoVenta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalCobro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCobrar = New System.Windows.Forms.Button()
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNumeroFactura = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscarFacturaPendiente = New System.Windows.Forms.Button()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(16, 373)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 61)
        Me.Button1.TabIndex = 40
        Me.Button1.TabStop = False
        Me.Button1.Text = "<---  Volver Atras"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtPuntoVenta
        '
        Me.txtPuntoVenta.BackColor = System.Drawing.Color.White
        Me.txtPuntoVenta.Location = New System.Drawing.Point(491, 37)
        Me.txtPuntoVenta.Name = "txtPuntoVenta"
        Me.txtPuntoVenta.ReadOnly = True
        Me.txtPuntoVenta.Size = New System.Drawing.Size(98, 20)
        Me.txtPuntoVenta.TabIndex = 33
        Me.txtPuntoVenta.TabStop = False
        Me.txtPuntoVenta.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(488, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Punto Venta"
        Me.Label5.Visible = False
        '
        'txtTotalCobro
        '
        Me.txtTotalCobro.BackColor = System.Drawing.Color.White
        Me.txtTotalCobro.Location = New System.Drawing.Point(580, 349)
        Me.txtTotalCobro.Name = "txtTotalCobro"
        Me.txtTotalCobro.ReadOnly = True
        Me.txtTotalCobro.Size = New System.Drawing.Size(129, 20)
        Me.txtTotalCobro.TabIndex = 39
        Me.txtTotalCobro.TabStop = False
        Me.txtTotalCobro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(504, 351)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Total Cobro"
        '
        'btnCobrar
        '
        Me.btnCobrar.BackColor = System.Drawing.Color.White
        Me.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCobrar.Location = New System.Drawing.Point(507, 373)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(202, 61)
        Me.btnCobrar.TabIndex = 37
        Me.btnCobrar.TabStop = False
        Me.btnCobrar.Text = "Generar Factura"
        Me.btnCobrar.UseVisualStyleBackColor = False
        '
        'viewDatos
        '
        Me.viewDatos.BackgroundColor = System.Drawing.Color.White
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Location = New System.Drawing.Point(16, 132)
        Me.viewDatos.MultiSelect = False
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.ReadOnly = True
        Me.viewDatos.Size = New System.Drawing.Size(692, 210)
        Me.viewDatos.TabIndex = 35
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtNumeroFactura)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCorreo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCedula)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(692, 67)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'txtNumeroFactura
        '
        Me.txtNumeroFactura.BackColor = System.Drawing.Color.White
        Me.txtNumeroFactura.Location = New System.Drawing.Point(6, 33)
        Me.txtNumeroFactura.Name = "txtNumeroFactura"
        Me.txtNumeroFactura.ReadOnly = True
        Me.txtNumeroFactura.Size = New System.Drawing.Size(98, 20)
        Me.txtNumeroFactura.TabIndex = 27
        Me.txtNumeroFactura.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Numero Adelanto"
        '
        'txtCorreo
        '
        Me.txtCorreo.BackColor = System.Drawing.Color.White
        Me.txtCorreo.Location = New System.Drawing.Point(464, 33)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.ReadOnly = True
        Me.txtCorreo.Size = New System.Drawing.Size(224, 20)
        Me.txtCorreo.TabIndex = 5
        Me.txtCorreo.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(460, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Correo"
        '
        'txtCedula
        '
        Me.txtCedula.BackColor = System.Drawing.Color.White
        Me.txtCedula.Location = New System.Drawing.Point(360, 33)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.ReadOnly = True
        Me.txtCedula.Size = New System.Drawing.Size(98, 20)
        Me.txtCedula.TabIndex = 3
        Me.txtCedula.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(357, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cedula"
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.White
        Me.txtCliente.Location = New System.Drawing.Point(109, 33)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(245, 20)
        Me.txtCliente.TabIndex = 1
        Me.txtCliente.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'btnBuscarFacturaPendiente
        '
        Me.btnBuscarFacturaPendiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarFacturaPendiente.Location = New System.Drawing.Point(16, 9)
        Me.btnBuscarFacturaPendiente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBuscarFacturaPendiente.Name = "btnBuscarFacturaPendiente"
        Me.btnBuscarFacturaPendiente.Size = New System.Drawing.Size(250, 46)
        Me.btnBuscarFacturaPendiente.TabIndex = 31
        Me.btnBuscarFacturaPendiente.Text = "Buscar Adelanto Pendiente"
        Me.btnBuscarFacturaPendiente.UseVisualStyleBackColor = True
        '
        'frmFacturarAdelantosPendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(725, 443)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtPuntoVenta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTotalCobro)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCobrar)
        Me.Controls.Add(Me.viewDatos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBuscarFacturaPendiente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFacturarAdelantosPendientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturar Adelantos Pendientes"
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtPuntoVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCobro As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCobrar As System.Windows.Forms.Button
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumeroFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarFacturaPendiente As System.Windows.Forms.Button
End Class
