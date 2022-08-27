Imports System.Windows.Forms
Namespace Prestamos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frm_buscar_devolucion
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
            Me.bt_aceptar = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtbuscar = New System.Windows.Forms.TextBox()
            Me.datalistado = New System.Windows.Forms.DataGridView()
            Me.prestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.destino = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Destinatario = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.rb_codigo = New System.Windows.Forms.RadioButton()
            Me.rb_descripcion = New System.Windows.Forms.RadioButton()
            CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'bt_aceptar
            '
            Me.bt_aceptar.Location = New System.Drawing.Point(572, 289)
            Me.bt_aceptar.Name = "bt_aceptar"
            Me.bt_aceptar.Size = New System.Drawing.Size(75, 23)
            Me.bt_aceptar.TabIndex = 15
            Me.bt_aceptar.Text = "Aceptar"
            Me.bt_aceptar.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(12, 273)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(40, 13)
            Me.Label1.TabIndex = 14
            Me.Label1.Text = "Buscar"
            '
            'txtbuscar
            '
            Me.txtbuscar.Location = New System.Drawing.Point(14, 289)
            Me.txtbuscar.Name = "txtbuscar"
            Me.txtbuscar.Size = New System.Drawing.Size(250, 20)
            Me.txtbuscar.TabIndex = 13
            '
            'datalistado
            '
            Me.datalistado.AllowUserToAddRows = False
            Me.datalistado.AllowUserToDeleteRows = False
            Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prestamo, Me.fecha, Me.destino, Me.Destinatario, Me.cantidad})
            Me.datalistado.Location = New System.Drawing.Point(12, 12)
            Me.datalistado.Name = "datalistado"
            Me.datalistado.ReadOnly = True
            Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.datalistado.Size = New System.Drawing.Size(645, 251)
            Me.datalistado.TabIndex = 12
            '
            'prestamo
            '
            Me.prestamo.DataPropertyName = "id_prestamo"
            Me.prestamo.HeaderText = "Prestamo"
            Me.prestamo.Name = "prestamo"
            Me.prestamo.ReadOnly = True
            '
            'fecha
            '
            Me.fecha.DataPropertyName = "fecha"
            Me.fecha.HeaderText = "Fecha"
            Me.fecha.Name = "fecha"
            Me.fecha.ReadOnly = True
            '
            'destino
            '
            Me.destino.DataPropertyName = "codigo"
            Me.destino.HeaderText = "Codigo"
            Me.destino.Name = "destino"
            Me.destino.ReadOnly = True
            Me.destino.Width = 75
            '
            'Destinatario
            '
            Me.Destinatario.DataPropertyName = "descripcion"
            Me.Destinatario.HeaderText = "Descripcion"
            Me.Destinatario.Name = "Destinatario"
            Me.Destinatario.ReadOnly = True
            Me.Destinatario.Width = 225
            '
            'cantidad
            '
            Me.cantidad.DataPropertyName = "cantidad"
            Me.cantidad.HeaderText = "cantidad"
            Me.cantidad.Name = "cantidad"
            Me.cantidad.ReadOnly = True
            '
            'rb_codigo
            '
            Me.rb_codigo.AutoSize = True
            Me.rb_codigo.Location = New System.Drawing.Point(282, 292)
            Me.rb_codigo.Name = "rb_codigo"
            Me.rb_codigo.Size = New System.Drawing.Size(69, 17)
            Me.rb_codigo.TabIndex = 16
            Me.rb_codigo.TabStop = True
            Me.rb_codigo.Text = "Prestamo"
            Me.rb_codigo.UseVisualStyleBackColor = True
            '
            'rb_descripcion
            '
            Me.rb_descripcion.AutoSize = True
            Me.rb_descripcion.Location = New System.Drawing.Point(357, 292)
            Me.rb_descripcion.Name = "rb_descripcion"
            Me.rb_descripcion.Size = New System.Drawing.Size(81, 17)
            Me.rb_descripcion.TabIndex = 16
            Me.rb_descripcion.TabStop = True
            Me.rb_descripcion.Text = "Descripcion"
            Me.rb_descripcion.UseVisualStyleBackColor = True
            '
            'frm_buscar_devolucion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(664, 325)
            Me.Controls.Add(Me.rb_descripcion)
            Me.Controls.Add(Me.rb_codigo)
            Me.Controls.Add(Me.bt_aceptar)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtbuscar)
            Me.Controls.Add(Me.datalistado)
            Me.Name = "frm_buscar_devolucion"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Buscar Devolución"
            CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents bt_aceptar As Button
        Friend WithEvents Label1 As Label
        Friend WithEvents txtbuscar As TextBox
        Friend WithEvents datalistado As DataGridView
        Friend WithEvents prestamo As DataGridViewTextBoxColumn
        Friend WithEvents fecha As DataGridViewTextBoxColumn
        Friend WithEvents destino As DataGridViewTextBoxColumn
        Friend WithEvents Destinatario As DataGridViewTextBoxColumn
        Friend WithEvents cantidad As DataGridViewTextBoxColumn
        Friend WithEvents rb_codigo As RadioButton
        Friend WithEvents rb_descripcion As RadioButton
    End Class

End Namespace
