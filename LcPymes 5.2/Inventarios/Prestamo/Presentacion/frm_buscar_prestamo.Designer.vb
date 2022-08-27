Imports System.Windows.Forms
Namespace Prestamos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frm_buscar_prestamo
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
            Me.boleta = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.destino = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Destinatario = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Button1 = New System.Windows.Forms.Button()
            CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'bt_aceptar
            '
            Me.bt_aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.bt_aceptar.Location = New System.Drawing.Point(665, 355)
            Me.bt_aceptar.Name = "bt_aceptar"
            Me.bt_aceptar.Size = New System.Drawing.Size(100, 40)
            Me.bt_aceptar.TabIndex = 11
            Me.bt_aceptar.TabStop = False
            Me.bt_aceptar.Text = "Aceptar"
            Me.bt_aceptar.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(12, 355)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(40, 13)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "Buscar"
            '
            'txtbuscar
            '
            Me.txtbuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtbuscar.Location = New System.Drawing.Point(12, 371)
            Me.txtbuscar.Name = "txtbuscar"
            Me.txtbuscar.Size = New System.Drawing.Size(647, 20)
            Me.txtbuscar.TabIndex = 1
            '
            'datalistado
            '
            Me.datalistado.AllowUserToAddRows = False
            Me.datalistado.AllowUserToDeleteRows = False
            Me.datalistado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.datalistado.BackgroundColor = System.Drawing.Color.White
            Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prestamo, Me.boleta, Me.Descripcion, Me.fecha, Me.destino, Me.Destinatario})
            Me.datalistado.Location = New System.Drawing.Point(12, 12)
            Me.datalistado.Name = "datalistado"
            Me.datalistado.ReadOnly = True
            Me.datalistado.RowHeadersVisible = False
            Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.datalistado.Size = New System.Drawing.Size(856, 333)
            Me.datalistado.TabIndex = 6
            Me.datalistado.TabStop = False
            '
            'prestamo
            '
            Me.prestamo.DataPropertyName = "id"
            Me.prestamo.HeaderText = "Prestamo"
            Me.prestamo.Name = "prestamo"
            Me.prestamo.ReadOnly = True
            Me.prestamo.Width = 75
            '
            'boleta
            '
            Me.boleta.DataPropertyName = "boleta"
            Me.boleta.HeaderText = "Boleta"
            Me.boleta.Name = "boleta"
            Me.boleta.ReadOnly = True
            Me.boleta.Width = 75
            '
            'Descripcion
            '
            Me.Descripcion.DataPropertyName = "Descripcion"
            Me.Descripcion.HeaderText = "Descripcion"
            Me.Descripcion.Name = "Descripcion"
            Me.Descripcion.ReadOnly = True
            Me.Descripcion.Width = 280
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
            Me.destino.DataPropertyName = "nombre_destino"
            Me.destino.HeaderText = "Destino"
            Me.destino.Name = "destino"
            Me.destino.ReadOnly = True
            Me.destino.Width = 150
            '
            'Destinatario
            '
            Me.Destinatario.DataPropertyName = "nombre_destinatario"
            Me.Destinatario.HeaderText = "Destinatario"
            Me.Destinatario.Name = "Destinatario"
            Me.Destinatario.ReadOnly = True
            Me.Destinatario.Width = 150
            '
            'Button1
            '
            Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button1.Location = New System.Drawing.Point(768, 355)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(100, 40)
            Me.Button1.TabIndex = 12
            Me.Button1.TabStop = False
            Me.Button1.Text = "Cancelar"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'frm_buscar_prestamo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(877, 407)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.bt_aceptar)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtbuscar)
            Me.Controls.Add(Me.datalistado)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frm_buscar_prestamo"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Buscar Prestamo"
            CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents bt_aceptar As Button
        Friend WithEvents Label1 As Label
        Friend WithEvents txtbuscar As TextBox
        Friend WithEvents datalistado As DataGridView
        Friend WithEvents prestamo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents boleta As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents destino As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Destinatario As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Button1 As System.Windows.Forms.Button
    End Class

End Namespace
