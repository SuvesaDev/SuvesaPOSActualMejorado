<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductosRelacionados
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCodArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDescripccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrecioAntes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNuevoPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAplicar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descripccion del Producto"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(9, 37)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(578, 22)
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.TabStop = False
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
        Me.viewDatos.BackgroundColor = System.Drawing.Color.White
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cCodigo, Me.cCodArticulo, Me.cDescripccion, Me.cPrecioAntes, Me.cNuevoPrecio, Me.cAplicar})
        Me.viewDatos.Location = New System.Drawing.Point(9, 84)
        Me.viewDatos.MultiSelect = False
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.RowTemplate.Height = 31
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(892, 465)
        Me.viewDatos.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(593, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(309, 57)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Aplicar Cambios"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cCodigo
        '
        Me.cCodigo.HeaderText = "Codigo"
        Me.cCodigo.Name = "cCodigo"
        Me.cCodigo.ReadOnly = True
        Me.cCodigo.Visible = False
        '
        'cCodArticulo
        '
        Me.cCodArticulo.HeaderText = "Cod Articculo"
        Me.cCodArticulo.Name = "cCodArticulo"
        Me.cCodArticulo.ReadOnly = True
        '
        'cDescripccion
        '
        Me.cDescripccion.HeaderText = "Descripcion"
        Me.cDescripccion.Name = "cDescripccion"
        Me.cDescripccion.ReadOnly = True
        Me.cDescripccion.Width = 315
        '
        'cPrecioAntes
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.cPrecioAntes.DefaultCellStyle = DataGridViewCellStyle5
        Me.cPrecioAntes.HeaderText = "Precio Actual"
        Me.cPrecioAntes.Name = "cPrecioAntes"
        Me.cPrecioAntes.ReadOnly = True
        Me.cPrecioAntes.Width = 75
        '
        'cNuevoPrecio
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.cNuevoPrecio.DefaultCellStyle = DataGridViewCellStyle6
        Me.cNuevoPrecio.HeaderText = "Precio Nuevo"
        Me.cNuevoPrecio.Name = "cNuevoPrecio"
        Me.cNuevoPrecio.Width = 75
        '
        'cAplicar
        '
        Me.cAplicar.HeaderText = "Aplicar Cambio"
        Me.cAplicar.Name = "cAplicar"
        Me.cAplicar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cAplicar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cAplicar.Width = 75
        '
        'frmProductosRelacionados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 561)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.viewDatos)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProductosRelacionados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos Relacionados"
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCodArticulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDescripccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPrecioAntes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNuevoPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cAplicar As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
