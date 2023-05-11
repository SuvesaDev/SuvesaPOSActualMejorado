<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroBonificacion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnBuscarSugerido = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.cCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cBonificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'viewDatos
        '
        Me.viewDatos.AllowUserToAddRows = False
        Me.viewDatos.AllowUserToDeleteRows = False
        Me.viewDatos.AllowUserToResizeColumns = False
        Me.viewDatos.AllowUserToResizeRows = False
        Me.viewDatos.BackgroundColor = System.Drawing.Color.White
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cCodigo, Me.cProveedor, Me.cBonificacion})
        Me.viewDatos.Location = New System.Drawing.Point(27, 146)
        Me.viewDatos.MultiSelect = False
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.ReadOnly = True
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.RowTemplate.Height = 28
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(713, 282)
        Me.viewDatos.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Proveedor :"
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(108, 64)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(632, 22)
        Me.txtProveedor.TabIndex = 10
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(665, 112)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 28)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Quitar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Location = New System.Drawing.Point(584, 112)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 28)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnBuscarSugerido
        '
        Me.btnBuscarSugerido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarSugerido.Location = New System.Drawing.Point(27, 61)
        Me.btnBuscarSugerido.Name = "btnBuscarSugerido"
        Me.btnBuscarSugerido.Size = New System.Drawing.Size(75, 28)
        Me.btnBuscarSugerido.TabIndex = 7
        Me.btnBuscarSugerido.Text = "Buscar"
        Me.btnBuscarSugerido.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Descripcion de la bonificacion :"
        '
        'txtMensaje
        '
        Me.txtMensaje.Location = New System.Drawing.Point(27, 118)
        Me.txtMensaje.MaxLength = 250
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(533, 22)
        Me.txtMensaje.TabIndex = 12
        '
        'cCodigo
        '
        Me.cCodigo.HeaderText = "Codigo"
        Me.cCodigo.Name = "cCodigo"
        Me.cCodigo.ReadOnly = True
        Me.cCodigo.Visible = False
        '
        'cProveedor
        '
        Me.cProveedor.HeaderText = "Proveedor"
        Me.cProveedor.Name = "cProveedor"
        Me.cProveedor.ReadOnly = True
        Me.cProveedor.Width = 290
        '
        'cBonificacion
        '
        Me.cBonificacion.HeaderText = "Bonificacion"
        Me.cBonificacion.Name = "cBonificacion"
        Me.cBonificacion.ReadOnly = True
        Me.cBonificacion.Width = 215
        '
        'frmRegistroBonificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 485)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnBuscarSugerido)
        Me.Controls.Add(Me.viewDatos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegistroBonificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Bonificacion"
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnBuscarSugerido As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents cCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cBonificacion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
