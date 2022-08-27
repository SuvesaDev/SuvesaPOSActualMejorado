Imports System.Windows.Forms
Namespace Prestamos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frm_buscar_producto
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
            Me.datalistado = New System.Windows.Forms.DataGridView()
            Me.txtbuscar = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.rb_codigo = New System.Windows.Forms.RadioButton()
            Me.rb_descripcion = New System.Windows.Forms.RadioButton()
            Me.bt_aceptar = New System.Windows.Forms.Button()
            Me.codigo_interno = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.codbarras = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.presentacant = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.presentacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.existencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'datalistado
            '
            Me.datalistado.AllowUserToAddRows = False
            Me.datalistado.AllowUserToDeleteRows = False
            Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo_interno, Me.codbarras, Me.descripcion, Me.presentacant, Me.presentacion, Me.existencia, Me.precio})
            Me.datalistado.Location = New System.Drawing.Point(12, 12)
            Me.datalistado.Name = "datalistado"
            Me.datalistado.ReadOnly = True
            Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.datalistado.Size = New System.Drawing.Size(747, 251)
            Me.datalistado.TabIndex = 0
            '
            'txtbuscar
            '
            Me.txtbuscar.Location = New System.Drawing.Point(12, 289)
            Me.txtbuscar.Name = "txtbuscar"
            Me.txtbuscar.Size = New System.Drawing.Size(250, 20)
            Me.txtbuscar.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(12, 273)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(40, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Buscar"
            '
            'rb_codigo
            '
            Me.rb_codigo.AutoSize = True
            Me.rb_codigo.Location = New System.Drawing.Point(316, 290)
            Me.rb_codigo.Name = "rb_codigo"
            Me.rb_codigo.Size = New System.Drawing.Size(58, 17)
            Me.rb_codigo.TabIndex = 3
            Me.rb_codigo.TabStop = True
            Me.rb_codigo.Text = "Codigo"
            Me.rb_codigo.UseVisualStyleBackColor = True
            '
            'rb_descripcion
            '
            Me.rb_descripcion.AutoSize = True
            Me.rb_descripcion.Location = New System.Drawing.Point(380, 290)
            Me.rb_descripcion.Name = "rb_descripcion"
            Me.rb_descripcion.Size = New System.Drawing.Size(81, 17)
            Me.rb_descripcion.TabIndex = 4
            Me.rb_descripcion.TabStop = True
            Me.rb_descripcion.Text = "Descripción"
            Me.rb_descripcion.UseVisualStyleBackColor = True
            '
            'bt_aceptar
            '
            Me.bt_aceptar.Location = New System.Drawing.Point(572, 289)
            Me.bt_aceptar.Name = "bt_aceptar"
            Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
            Me.bt_aceptar.TabIndex = 5
            Me.bt_aceptar.Text = "Aceptar"
            Me.bt_aceptar.UseVisualStyleBackColor = True
            '
            'codigo_interno
            '
            Me.codigo_interno.DataPropertyName = "codigo"
            Me.codigo_interno.HeaderText = "Codigo"
            Me.codigo_interno.Name = "codigo_interno"
            Me.codigo_interno.ReadOnly = True
            '
            'codbarras
            '
            Me.codbarras.DataPropertyName = "cod_articulo"
            Me.codbarras.HeaderText = "Codigo art"
            Me.codbarras.Name = "codbarras"
            Me.codbarras.ReadOnly = True
            '
            'descripcion
            '
            Me.descripcion.DataPropertyName = "descripcion"
            Me.descripcion.HeaderText = "Descripcion"
            Me.descripcion.Name = "descripcion"
            Me.descripcion.ReadOnly = True
            Me.descripcion.Width = 300
            '
            'presentacant
            '
            Me.presentacant.DataPropertyName = "presentacant"
            Me.presentacant.HeaderText = "Presentacion"
            Me.presentacant.Name = "presentacant"
            Me.presentacant.ReadOnly = True
            '
            'presentacion
            '
            Me.presentacion.DataPropertyName = "presentaciones"
            Me.presentacion.HeaderText = "Presentacion"
            Me.presentacion.Name = "presentacion"
            Me.presentacion.ReadOnly = True
            '
            'existencia
            '
            Me.existencia.DataPropertyName = "existencia"
            Me.existencia.HeaderText = "Existencia"
            Me.existencia.Name = "existencia"
            Me.existencia.ReadOnly = True
            '
            'precio
            '
            Me.precio.DataPropertyName = "preciofinal"
            Me.precio.HeaderText = "Precio"
            Me.precio.Name = "precio"
            Me.precio.ReadOnly = True
            Me.precio.Visible = False
            '
            'frm_buscar_producto
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(768, 332)
            Me.Controls.Add(Me.bt_aceptar)
            Me.Controls.Add(Me.rb_descripcion)
            Me.Controls.Add(Me.rb_codigo)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtbuscar)
            Me.Controls.Add(Me.datalistado)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "frm_buscar_producto"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Buscar Producto"
            CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents datalistado As DataGridView
        Friend WithEvents txtbuscar As TextBox
        Friend WithEvents Label1 As Label
        Friend WithEvents rb_codigo As RadioButton
        Friend WithEvents rb_descripcion As RadioButton
        Friend WithEvents bt_aceptar As Button
        Friend WithEvents codigo_interno As DataGridViewTextBoxColumn
        Friend WithEvents codbarras As DataGridViewTextBoxColumn
        Friend WithEvents descripcion As DataGridViewTextBoxColumn
        Friend WithEvents presentacant As DataGridViewTextBoxColumn
        Friend WithEvents presentacion As DataGridViewTextBoxColumn
        Friend WithEvents existencia As DataGridViewTextBoxColumn
        Friend WithEvents precio As DataGridViewTextBoxColumn
    End Class

End Namespace
