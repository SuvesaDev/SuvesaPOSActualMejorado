<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidoWeb
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreFactura = New System.Windows.Forms.TextBox()
        Me.txtApellidoFactura = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDireccionFactura = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCiudadFactura = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCorreoFactura = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelefonoEnvio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCiudadEnvio = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDireccionEnvio = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtApellidoEnvio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNombreEnvio = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.lblEnvio = New System.Windows.Forms.TextBox()
        Me.lblNotas = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cvariation_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cquantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.csubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.csubtotal_tax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCorreoFactura)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCiudadFactura)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDireccionFactura)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtApellidoFactura)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombreFactura)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 243)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info Factura"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTelefonoEnvio)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtCiudadEnvio)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtDireccionEnvio)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtApellidoEnvio)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtNombreEnvio)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(443, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(406, 241)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Info Envio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre :"
        '
        'txtNombreFactura
        '
        Me.txtNombreFactura.BackColor = System.Drawing.Color.White
        Me.txtNombreFactura.Location = New System.Drawing.Point(6, 47)
        Me.txtNombreFactura.Name = "txtNombreFactura"
        Me.txtNombreFactura.ReadOnly = True
        Me.txtNombreFactura.Size = New System.Drawing.Size(190, 20)
        Me.txtNombreFactura.TabIndex = 3
        '
        'txtApellidoFactura
        '
        Me.txtApellidoFactura.BackColor = System.Drawing.Color.White
        Me.txtApellidoFactura.Location = New System.Drawing.Point(202, 47)
        Me.txtApellidoFactura.Name = "txtApellidoFactura"
        Me.txtApellidoFactura.ReadOnly = True
        Me.txtApellidoFactura.Size = New System.Drawing.Size(190, 20)
        Me.txtApellidoFactura.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(199, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Apellido :"
        '
        'txtDireccionFactura
        '
        Me.txtDireccionFactura.BackColor = System.Drawing.Color.White
        Me.txtDireccionFactura.Location = New System.Drawing.Point(6, 91)
        Me.txtDireccionFactura.Multiline = True
        Me.txtDireccionFactura.Name = "txtDireccionFactura"
        Me.txtDireccionFactura.ReadOnly = True
        Me.txtDireccionFactura.Size = New System.Drawing.Size(386, 84)
        Me.txtDireccionFactura.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Direccion :"
        '
        'txtCiudadFactura
        '
        Me.txtCiudadFactura.BackColor = System.Drawing.Color.White
        Me.txtCiudadFactura.Location = New System.Drawing.Point(6, 194)
        Me.txtCiudadFactura.Name = "txtCiudadFactura"
        Me.txtCiudadFactura.ReadOnly = True
        Me.txtCiudadFactura.Size = New System.Drawing.Size(190, 20)
        Me.txtCiudadFactura.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Ciudad :"
        '
        'txtCorreoFactura
        '
        Me.txtCorreoFactura.BackColor = System.Drawing.Color.White
        Me.txtCorreoFactura.Location = New System.Drawing.Point(202, 194)
        Me.txtCorreoFactura.Name = "txtCorreoFactura"
        Me.txtCorreoFactura.ReadOnly = True
        Me.txtCorreoFactura.Size = New System.Drawing.Size(190, 20)
        Me.txtCorreoFactura.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(199, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Correo :"
        '
        'txtTelefonoEnvio
        '
        Me.txtTelefonoEnvio.BackColor = System.Drawing.Color.White
        Me.txtTelefonoEnvio.Location = New System.Drawing.Point(202, 192)
        Me.txtTelefonoEnvio.Name = "txtTelefonoEnvio"
        Me.txtTelefonoEnvio.ReadOnly = True
        Me.txtTelefonoEnvio.Size = New System.Drawing.Size(180, 20)
        Me.txtTelefonoEnvio.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(199, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Telefono :"
        '
        'txtCiudadEnvio
        '
        Me.txtCiudadEnvio.BackColor = System.Drawing.Color.White
        Me.txtCiudadEnvio.Location = New System.Drawing.Point(6, 192)
        Me.txtCiudadEnvio.Name = "txtCiudadEnvio"
        Me.txtCiudadEnvio.ReadOnly = True
        Me.txtCiudadEnvio.Size = New System.Drawing.Size(190, 20)
        Me.txtCiudadEnvio.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Ciudad :"
        '
        'txtDireccionEnvio
        '
        Me.txtDireccionEnvio.BackColor = System.Drawing.Color.White
        Me.txtDireccionEnvio.Location = New System.Drawing.Point(6, 88)
        Me.txtDireccionEnvio.Multiline = True
        Me.txtDireccionEnvio.Name = "txtDireccionEnvio"
        Me.txtDireccionEnvio.ReadOnly = True
        Me.txtDireccionEnvio.Size = New System.Drawing.Size(376, 84)
        Me.txtDireccionEnvio.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Direccion :"
        '
        'txtApellidoEnvio
        '
        Me.txtApellidoEnvio.BackColor = System.Drawing.Color.White
        Me.txtApellidoEnvio.Location = New System.Drawing.Point(202, 44)
        Me.txtApellidoEnvio.Name = "txtApellidoEnvio"
        Me.txtApellidoEnvio.ReadOnly = True
        Me.txtApellidoEnvio.Size = New System.Drawing.Size(180, 20)
        Me.txtApellidoEnvio.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(199, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Apellido :"
        '
        'txtNombreEnvio
        '
        Me.txtNombreEnvio.BackColor = System.Drawing.Color.White
        Me.txtNombreEnvio.Location = New System.Drawing.Point(6, 44)
        Me.txtNombreEnvio.Name = "txtNombreEnvio"
        Me.txtNombreEnvio.ReadOnly = True
        Me.txtNombreEnvio.Size = New System.Drawing.Size(190, 20)
        Me.txtNombreEnvio.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Nombre :"
        '
        'viewDatos
        '
        Me.viewDatos.AllowUserToAddRows = False
        Me.viewDatos.AllowUserToDeleteRows = False
        Me.viewDatos.AllowUserToResizeColumns = False
        Me.viewDatos.AllowUserToResizeRows = False
        Me.viewDatos.BackgroundColor = System.Drawing.Color.White
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cid, Me.cPV, Me.cvariation_id, Me.cname, Me.cquantity, Me.csubtotal, Me.csubtotal_tax, Me.ctotal})
        Me.viewDatos.Location = New System.Drawing.Point(18, 279)
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.ReadOnly = True
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.RowTemplate.Height = 28
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(831, 214)
        Me.viewDatos.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 531)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Estado :"
        '
        'cboEstado
        '
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"pending", "processing", "on-hold", "completed", "cancelled", "refunded", "failed ", "trash"})
        Me.cboEstado.Location = New System.Drawing.Point(73, 528)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(141, 21)
        Me.cboEstado.TabIndex = 4
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(220, 528)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(190, 23)
        Me.btnActualizar.TabIndex = 5
        Me.btnActualizar.Text = "Actualizar Estado"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'lblEnvio
        '
        Me.lblEnvio.Location = New System.Drawing.Point(18, 499)
        Me.lblEnvio.Name = "lblEnvio"
        Me.lblEnvio.ReadOnly = True
        Me.lblEnvio.Size = New System.Drawing.Size(196, 20)
        Me.lblEnvio.TabIndex = 6
        '
        'lblNotas
        '
        Me.lblNotas.Location = New System.Drawing.Point(220, 499)
        Me.lblNotas.Name = "lblNotas"
        Me.lblNotas.ReadOnly = True
        Me.lblNotas.Size = New System.Drawing.Size(629, 20)
        Me.lblNotas.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(659, 525)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Generar Ficha"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cid
        '
        Me.cid.HeaderText = "id"
        Me.cid.Name = "cid"
        Me.cid.ReadOnly = True
        Me.cid.Visible = False
        Me.cid.Width = 21
        '
        'cPV
        '
        Me.cPV.HeaderText = "Punto Venta"
        Me.cPV.Name = "cPV"
        Me.cPV.ReadOnly = True
        '
        'cvariation_id
        '
        Me.cvariation_id.HeaderText = "variation_id"
        Me.cvariation_id.Name = "cvariation_id"
        Me.cvariation_id.ReadOnly = True
        Me.cvariation_id.Visible = False
        Me.cvariation_id.Width = 67
        '
        'cname
        '
        Me.cname.HeaderText = "Descripcion"
        Me.cname.Name = "cname"
        Me.cname.ReadOnly = True
        Me.cname.Width = 400
        '
        'cquantity
        '
        Me.cquantity.HeaderText = "Cantidad"
        Me.cquantity.Name = "cquantity"
        Me.cquantity.ReadOnly = True
        '
        'csubtotal
        '
        DataGridViewCellStyle1.Format = "N2"
        Me.csubtotal.DefaultCellStyle = DataGridViewCellStyle1
        Me.csubtotal.HeaderText = "Sub Total"
        Me.csubtotal.Name = "csubtotal"
        Me.csubtotal.ReadOnly = True
        Me.csubtotal.Visible = False
        Me.csubtotal.Width = 78
        '
        'csubtotal_tax
        '
        DataGridViewCellStyle2.Format = "N2"
        Me.csubtotal_tax.DefaultCellStyle = DataGridViewCellStyle2
        Me.csubtotal_tax.HeaderText = "subtotal_tax"
        Me.csubtotal_tax.Name = "csubtotal_tax"
        Me.csubtotal_tax.ReadOnly = True
        Me.csubtotal_tax.Visible = False
        Me.csubtotal_tax.Width = 89
        '
        'ctotal
        '
        DataGridViewCellStyle3.Format = "N2"
        Me.ctotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.ctotal.HeaderText = "Total"
        Me.ctotal.Name = "ctotal"
        Me.ctotal.ReadOnly = True
        Me.ctotal.Width = 200
        '
        'frmPedidoWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 556)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblNotas)
        Me.Controls.Add(Me.lblEnvio)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.viewDatos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPedidoWeb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedido"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtApellidoFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombreFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCorreoFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCiudadFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDireccionFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTelefonoEnvio As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCiudadEnvio As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDireccionEnvio As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoEnvio As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNombreEnvio As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents lblEnvio As System.Windows.Forms.TextBox
    Friend WithEvents lblNotas As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cvariation_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cquantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents csubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents csubtotal_tax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ctotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
