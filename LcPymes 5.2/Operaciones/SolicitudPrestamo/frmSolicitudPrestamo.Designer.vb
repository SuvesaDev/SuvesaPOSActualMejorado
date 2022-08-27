<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSolicitudPrestamo
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
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.cIdPedidoDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cIdPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cboEmpresa = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegistrar.Enabled = False
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(421, 417)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(123, 35)
        Me.btnRegistrar.TabIndex = 0
        Me.btnRegistrar.Text = "Registrar (F2)"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'viewDatos
        '
        Me.viewDatos.AllowUserToAddRows = False
        Me.viewDatos.AllowUserToResizeColumns = False
        Me.viewDatos.AllowUserToResizeRows = False
        Me.viewDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewDatos.BackgroundColor = System.Drawing.Color.White
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cIdPedidoDetalle, Me.cIdPedido, Me.cCodigo, Me.cDescripcion, Me.cCantidad})
        Me.viewDatos.Location = New System.Drawing.Point(7, 189)
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(532, 218)
        Me.viewDatos.TabIndex = 1
        '
        'cIdPedidoDetalle
        '
        Me.cIdPedidoDetalle.HeaderText = "IdPedidoDetalle"
        Me.cIdPedidoDetalle.Name = "cIdPedidoDetalle"
        Me.cIdPedidoDetalle.Visible = False
        '
        'cIdPedido
        '
        Me.cIdPedido.HeaderText = "IdPedido"
        Me.cIdPedido.Name = "cIdPedido"
        Me.cIdPedido.Visible = False
        '
        'cCodigo
        '
        Me.cCodigo.HeaderText = "Codigo"
        Me.cCodigo.Name = "cCodigo"
        Me.cCodigo.Visible = False
        '
        'cDescripcion
        '
        Me.cDescripcion.HeaderText = "Descripcion"
        Me.cDescripcion.Name = "cDescripcion"
        Me.cDescripcion.Width = 400
        '
        'cCantidad
        '
        Me.cCantidad.HeaderText = "Cantidad"
        Me.cCantidad.Name = "cCantidad"
        '
        'txtClave
        '
        Me.txtClave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtClave.Location = New System.Drawing.Point(12, 432)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(82, 20)
        Me.txtClave.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 417)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Clave Usuario : "
        '
        'lblUsuario
        '
        Me.lblUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUsuario.Location = New System.Drawing.Point(100, 432)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(313, 20)
        Me.lblUsuario.TabIndex = 4
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(416, 23)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(123, 20)
        Me.dtpFecha.TabIndex = 5
        '
        'cboEmpresa
        '
        Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.Location = New System.Drawing.Point(10, 23)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(398, 21)
        Me.cboEmpresa.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Solicitar Prestamo a :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(413, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Fecha Solicitud :"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(10, 63)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(529, 56)
        Me.txtObservaciones.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Observaciones :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Codigo Producto :"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(10, 162)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(62, 20)
        Me.txtCodigo.TabIndex = 8
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescripcion.Location = New System.Drawing.Point(108, 162)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(261, 20)
        Me.lblDescripcion.TabIndex = 13
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(373, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Cant. "
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(375, 163)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(33, 20)
        Me.txtCantidad.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Image = Global.LcPymes_5._2.My.Resources.Resources.add1
        Me.Button1.Location = New System.Drawing.Point(416, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 38)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Agregar"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnBuscarProducto)
        Me.Panel1.Controls.Add(Me.cboEmpresa)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.viewDatos)
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Controls.Add(Me.dtpFecha)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtObservaciones)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtCantidad)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblDescripcion)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(546, 412)
        Me.Panel1.TabIndex = 17
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.Image = Global.LcPymes_5._2.My.Resources.Resources.page_find
        Me.btnBuscarProducto.Location = New System.Drawing.Point(74, 160)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(28, 24)
        Me.btnBuscarProducto.TabIndex = 9
        Me.btnBuscarProducto.UseVisualStyleBackColor = True
        '
        'frmSolicitudPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 458)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegistrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSolicitudPrestamo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitar Prestamo"
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents cIdPedidoDetalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cIdPedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnBuscarProducto As System.Windows.Forms.Button
End Class
