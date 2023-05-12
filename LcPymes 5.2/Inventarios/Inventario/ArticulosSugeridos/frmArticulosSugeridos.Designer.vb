<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticulosSugeridos
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
        Me.cId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDescripccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescripccionSugerido = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnBuscarSugerido = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescripccionPrincipal = New System.Windows.Forms.TextBox()
        Me.btnBuscarPrincipal = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.viewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cId, Me.cCodigo, Me.cDescripccion})
        Me.viewDatos.Location = New System.Drawing.Point(15, 75)
        Me.viewDatos.MultiSelect = False
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.ReadOnly = True
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.RowTemplate.Height = 28
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(713, 282)
        Me.viewDatos.TabIndex = 0
        '
        'cId
        '
        Me.cId.HeaderText = "Id"
        Me.cId.Name = "cId"
        Me.cId.ReadOnly = True
        Me.cId.Visible = False
        '
        'cCodigo
        '
        Me.cCodigo.HeaderText = "Codigo"
        Me.cCodigo.Name = "cCodigo"
        Me.cCodigo.ReadOnly = True
        Me.cCodigo.Width = 140
        '
        'cDescripccion
        '
        Me.cDescripccion.HeaderText = "Descripccion"
        Me.cDescripccion.Name = "cDescripccion"
        Me.cDescripccion.ReadOnly = True
        Me.cDescripccion.Width = 375
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDescripccionSugerido)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.btnBuscarSugerido)
        Me.GroupBox1.Controls.Add(Me.viewDatos)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(749, 379)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sugeridos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Descripccion Articulo"
        '
        'txtDescripccionSugerido
        '
        Me.txtDescripccionSugerido.Location = New System.Drawing.Point(96, 43)
        Me.txtDescripccionSugerido.Name = "txtDescripccionSugerido"
        Me.txtDescripccionSugerido.Size = New System.Drawing.Size(477, 22)
        Me.txtDescripccionSugerido.TabIndex = 5
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(660, 40)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 28)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Quitar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Location = New System.Drawing.Point(579, 40)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 28)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnBuscarSugerido
        '
        Me.btnBuscarSugerido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarSugerido.Location = New System.Drawing.Point(15, 40)
        Me.btnBuscarSugerido.Name = "btnBuscarSugerido"
        Me.btnBuscarSugerido.Size = New System.Drawing.Size(75, 28)
        Me.btnBuscarSugerido.TabIndex = 2
        Me.btnBuscarSugerido.Text = "Buscar"
        Me.btnBuscarSugerido.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Descripccion Articulo Principal"
        '
        'txtDescripccionPrincipal
        '
        Me.txtDescripccionPrincipal.Location = New System.Drawing.Point(108, 33)
        Me.txtDescripccionPrincipal.Name = "txtDescripccionPrincipal"
        Me.txtDescripccionPrincipal.Size = New System.Drawing.Size(558, 22)
        Me.txtDescripccionPrincipal.TabIndex = 8
        '
        'btnBuscarPrincipal
        '
        Me.btnBuscarPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarPrincipal.Location = New System.Drawing.Point(27, 30)
        Me.btnBuscarPrincipal.Name = "btnBuscarPrincipal"
        Me.btnBuscarPrincipal.Size = New System.Drawing.Size(75, 28)
        Me.btnBuscarPrincipal.TabIndex = 7
        Me.btnBuscarPrincipal.Text = "Buscar"
        Me.btnBuscarPrincipal.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Location = New System.Drawing.Point(672, 30)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 28)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "Nuevo "
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'frmArticulosSugeridos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 485)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtDescripccionPrincipal)
        Me.Controls.Add(Me.btnBuscarPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmArticulosSugeridos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Articulos Sugeridos"
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescripccionSugerido As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnBuscarSugerido As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescripccionPrincipal As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarPrincipal As System.Windows.Forms.Button
    Friend WithEvents cId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDescripccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
End Class
