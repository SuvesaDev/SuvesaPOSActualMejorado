<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaProductosPagina
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
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.btnAntes = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.rbDescripcion = New System.Windows.Forms.RadioButton()
        Me.rbSku = New System.Windows.Forms.RadioButton()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.btnCambiarUtilidad = New System.Windows.Forms.Button()
        Me.lblPagina = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.names = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cImpuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Utilidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdVariacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cActualizar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'viewDatos
        '
        Me.viewDatos.AllowUserToAddRows = False
        Me.viewDatos.AllowUserToDeleteRows = False
        Me.viewDatos.AllowUserToResizeColumns = False
        Me.viewDatos.AllowUserToResizeRows = False
        Me.viewDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.viewDatos.BackgroundColor = System.Drawing.Color.White
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.names, Me.type, Me.status, Me.sku, Me.Costo, Me.Price, Me.PrecioUnitario, Me.cImpuesto, Me.Utilidad, Me.Precio, Me.IdVariacion, Me.cActualizar, Me.cCodigo})
        Me.viewDatos.Location = New System.Drawing.Point(7, 41)
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.RowTemplate.Height = 30
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(1089, 660)
        Me.viewDatos.TabIndex = 0
        '
        'btnAntes
        '
        Me.btnAntes.Location = New System.Drawing.Point(7, 12)
        Me.btnAntes.Name = "btnAntes"
        Me.btnAntes.Size = New System.Drawing.Size(75, 23)
        Me.btnAntes.TabIndex = 1
        Me.btnAntes.Text = "<"
        Me.btnAntes.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(120, 12)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.btnSiguiente.TabIndex = 2
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(584, 13)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(211, 20)
        Me.txtBuscar.TabIndex = 3
        '
        'rbDescripcion
        '
        Me.rbDescripcion.AutoSize = True
        Me.rbDescripcion.Checked = True
        Me.rbDescripcion.Location = New System.Drawing.Point(339, 14)
        Me.rbDescripcion.Name = "rbDescripcion"
        Me.rbDescripcion.Size = New System.Drawing.Size(135, 17)
        Me.rbDescripcion.TabIndex = 4
        Me.rbDescripcion.TabStop = True
        Me.rbDescripcion.Text = "Buscar por Descripcion"
        Me.rbDescripcion.UseVisualStyleBackColor = True
        '
        'rbSku
        '
        Me.rbSku.AutoSize = True
        Me.rbSku.Location = New System.Drawing.Point(480, 14)
        Me.rbSku.Name = "rbSku"
        Me.rbSku.Size = New System.Drawing.Size(98, 17)
        Me.rbSku.TabIndex = 5
        Me.rbSku.Text = "Buscar por Sku"
        Me.rbSku.UseVisualStyleBackColor = True
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"Todos", "simple", "variable"})
        Me.cboTipo.Location = New System.Drawing.Point(206, 12)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(126, 21)
        Me.cboTipo.TabIndex = 6
        '
        'btnCambiarUtilidad
        '
        Me.btnCambiarUtilidad.Location = New System.Drawing.Point(801, 11)
        Me.btnCambiarUtilidad.Name = "btnCambiarUtilidad"
        Me.btnCambiarUtilidad.Size = New System.Drawing.Size(116, 23)
        Me.btnCambiarUtilidad.TabIndex = 8
        Me.btnCambiarUtilidad.Text = "Cambiar Utilidad"
        Me.btnCambiarUtilidad.UseVisualStyleBackColor = True
        '
        'lblPagina
        '
        Me.lblPagina.Location = New System.Drawing.Point(84, 15)
        Me.lblPagina.Name = "lblPagina"
        Me.lblPagina.Size = New System.Drawing.Size(34, 18)
        Me.lblPagina.TabIndex = 9
        Me.lblPagina.Text = "1"
        Me.lblPagina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(923, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Aplicar Utilidad"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 40
        '
        'names
        '
        Me.names.HeaderText = "name"
        Me.names.Name = "names"
        Me.names.ReadOnly = True
        Me.names.Width = 58
        '
        'type
        '
        Me.type.HeaderText = "type"
        Me.type.Name = "type"
        Me.type.ReadOnly = True
        Me.type.Width = 52
        '
        'status
        '
        Me.status.HeaderText = "status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Width = 60
        '
        'sku
        '
        Me.sku.HeaderText = "sku"
        Me.sku.Name = "sku"
        Me.sku.ReadOnly = True
        Me.sku.Width = 49
        '
        'Costo
        '
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        Me.Costo.ReadOnly = True
        Me.Costo.Width = 59
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Width = 56
        '
        'PrecioUnitario
        '
        Me.PrecioUnitario.HeaderText = "Precio Unitario"
        Me.PrecioUnitario.Name = "PrecioUnitario"
        Me.PrecioUnitario.ReadOnly = True
        Me.PrecioUnitario.Width = 101
        '
        'cImpuesto
        '
        Me.cImpuesto.HeaderText = "Impuesto"
        Me.cImpuesto.Name = "cImpuesto"
        Me.cImpuesto.ReadOnly = True
        Me.cImpuesto.Width = 75
        '
        'Utilidad
        '
        Me.Utilidad.HeaderText = "Utilidad"
        Me.Utilidad.Name = "Utilidad"
        Me.Utilidad.ReadOnly = True
        Me.Utilidad.Width = 67
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.Width = 62
        '
        'IdVariacion
        '
        Me.IdVariacion.HeaderText = "IdVariacion"
        Me.IdVariacion.Name = "IdVariacion"
        Me.IdVariacion.ReadOnly = True
        Me.IdVariacion.Visible = False
        Me.IdVariacion.Width = 85
        '
        'cActualizar
        '
        Me.cActualizar.HeaderText = "cActualizar"
        Me.cActualizar.Name = "cActualizar"
        Me.cActualizar.ReadOnly = True
        Me.cActualizar.Visible = False
        Me.cActualizar.Width = 84
        '
        'cCodigo
        '
        Me.cCodigo.HeaderText = "Codigo "
        Me.cCodigo.Name = "cCodigo"
        Me.cCodigo.ReadOnly = True
        Me.cCodigo.Visible = False
        Me.cCodigo.Width = 68
        '
        'frmListaProductosPagina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 713)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblPagina)
        Me.Controls.Add(Me.btnCambiarUtilidad)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.rbSku)
        Me.Controls.Add(Me.rbDescripcion)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAntes)
        Me.Controls.Add(Me.viewDatos)
        Me.Name = "frmListaProductosPagina"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Productos Pagina"
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents btnAntes As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents rbDescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents rbSku As System.Windows.Forms.RadioButton
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents btnCambiarUtilidad As System.Windows.Forms.Button
    Friend WithEvents lblPagina As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents names As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sku As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cImpuesto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Utilidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdVariacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cActualizar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
