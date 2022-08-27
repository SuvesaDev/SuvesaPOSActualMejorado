<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_buscar_empleado
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
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.rb_nombre = New System.Windows.Forms.RadioButton
        Me.rb_cedula = New System.Windows.Forms.RadioButton
        Me.txtbuscar = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtaListado = New System.Windows.Forms.DataGridView
        Me.cedula = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.puesto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fecha_ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fecha_salida = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.activo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.salario = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dtaListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(387, 215)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 21
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'rb_nombre
        '
        Me.rb_nombre.AutoSize = True
        Me.rb_nombre.Checked = True
        Me.rb_nombre.ForeColor = System.Drawing.Color.DimGray
        Me.rb_nombre.Location = New System.Drawing.Point(293, 218)
        Me.rb_nombre.Name = "rb_nombre"
        Me.rb_nombre.Size = New System.Drawing.Size(62, 17)
        Me.rb_nombre.TabIndex = 19
        Me.rb_nombre.TabStop = True
        Me.rb_nombre.Text = "Nombre"
        Me.rb_nombre.UseVisualStyleBackColor = True
        '
        'rb_cedula
        '
        Me.rb_cedula.AutoSize = True
        Me.rb_cedula.ForeColor = System.Drawing.Color.DimGray
        Me.rb_cedula.Location = New System.Drawing.Point(226, 218)
        Me.rb_cedula.Name = "rb_cedula"
        Me.rb_cedula.Size = New System.Drawing.Size(58, 17)
        Me.rb_cedula.TabIndex = 20
        Me.rb_cedula.Text = "Cedula"
        Me.rb_cedula.UseVisualStyleBackColor = True
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(45, 218)
        Me.txtbuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbuscar.MaxLength = 50
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(165, 20)
        Me.txtbuscar.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(7, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Valor:"
        '
        'dtaListado
        '
        Me.dtaListado.AllowUserToAddRows = False
        Me.dtaListado.AllowUserToDeleteRows = False
        Me.dtaListado.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtaListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtaListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cedula, Me.nombre, Me.apellidos, Me.puesto, Me.telefono, Me.fecha_ingreso, Me.fecha_salida, Me.activo, Me.salario})
        Me.dtaListado.Location = New System.Drawing.Point(10, 13)
        Me.dtaListado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtaListado.Name = "dtaListado"
        Me.dtaListado.ReadOnly = True
        Me.dtaListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtaListado.Size = New System.Drawing.Size(452, 191)
        Me.dtaListado.TabIndex = 17
        '
        'cedula
        '
        Me.cedula.DataPropertyName = "cedula"
        Me.cedula.HeaderText = "cedula"
        Me.cedula.Name = "cedula"
        Me.cedula.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'apellidos
        '
        Me.apellidos.DataPropertyName = "apellidos"
        Me.apellidos.HeaderText = "apellidos"
        Me.apellidos.Name = "apellidos"
        Me.apellidos.ReadOnly = True
        '
        'puesto
        '
        Me.puesto.DataPropertyName = "puesto"
        Me.puesto.HeaderText = "puesto"
        Me.puesto.Name = "puesto"
        Me.puesto.ReadOnly = True
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "telefono"
        Me.telefono.HeaderText = "telefono"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        Me.telefono.Visible = False
        '
        'fecha_ingreso
        '
        Me.fecha_ingreso.DataPropertyName = "fecha_ingreso"
        Me.fecha_ingreso.HeaderText = "fecha_ingreso"
        Me.fecha_ingreso.Name = "fecha_ingreso"
        Me.fecha_ingreso.ReadOnly = True
        Me.fecha_ingreso.Visible = False
        '
        'fecha_salida
        '
        Me.fecha_salida.DataPropertyName = "fecha_salida"
        Me.fecha_salida.HeaderText = "fecha_salida"
        Me.fecha_salida.Name = "fecha_salida"
        Me.fecha_salida.ReadOnly = True
        Me.fecha_salida.Visible = False
        '
        'activo
        '
        Me.activo.DataPropertyName = "activo"
        Me.activo.HeaderText = "activo"
        Me.activo.Name = "activo"
        Me.activo.ReadOnly = True
        Me.activo.Visible = False
        '
        'salario
        '
        Me.salario.DataPropertyName = "salario"
        Me.salario.HeaderText = "salario"
        Me.salario.Name = "salario"
        Me.salario.ReadOnly = True
        Me.salario.Visible = False
        '
        'frm_buscar_empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 247)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.rb_nombre)
        Me.Controls.Add(Me.rb_cedula)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtaListado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frm_buscar_empleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Empleado"
        CType(Me.dtaListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents rb_nombre As System.Windows.Forms.RadioButton
    Friend WithEvents rb_cedula As System.Windows.Forms.RadioButton
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtaListado As System.Windows.Forms.DataGridView
    Friend WithEvents cedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents puesto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_ingreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_salida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents activo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents salario As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
