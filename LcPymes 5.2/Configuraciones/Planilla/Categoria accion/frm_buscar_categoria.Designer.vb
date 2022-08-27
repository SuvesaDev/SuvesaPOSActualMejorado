<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_buscar_categoria
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
        Me.txtbuscar = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtaListado = New System.Windows.Forms.DataGridView
        Me.cedula = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dtaListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(389, 215)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 26
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'rb_nombre
        '
        Me.rb_nombre.AutoSize = True
        Me.rb_nombre.Checked = True
        Me.rb_nombre.ForeColor = System.Drawing.Color.DimGray
        Me.rb_nombre.Location = New System.Drawing.Point(229, 220)
        Me.rb_nombre.Name = "rb_nombre"
        Me.rb_nombre.Size = New System.Drawing.Size(62, 17)
        Me.rb_nombre.TabIndex = 25
        Me.rb_nombre.TabStop = True
        Me.rb_nombre.Text = "Nombre"
        Me.rb_nombre.UseVisualStyleBackColor = True
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(47, 218)
        Me.txtbuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbuscar.MaxLength = 50
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(165, 20)
        Me.txtbuscar.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(9, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Valor:"
        '
        'dtaListado
        '
        Me.dtaListado.AllowUserToAddRows = False
        Me.dtaListado.AllowUserToDeleteRows = False
        Me.dtaListado.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtaListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtaListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cedula, Me.Nombre})
        Me.dtaListado.Location = New System.Drawing.Point(12, 13)
        Me.dtaListado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtaListado.Name = "dtaListado"
        Me.dtaListado.ReadOnly = True
        Me.dtaListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtaListado.Size = New System.Drawing.Size(452, 191)
        Me.dtaListado.TabIndex = 23
        '
        'cedula
        '
        Me.cedula.DataPropertyName = "id"
        Me.cedula.HeaderText = "Id"
        Me.cedula.Name = "cedula"
        Me.cedula.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "categoria"
        Me.Nombre.FillWeight = 250.0!
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 250
        '
        'frm_buscar_categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 261)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.rb_nombre)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtaListado)
        Me.Name = "frm_buscar_categoria"
        Me.Text = "Buscar Categoria"
        CType(Me.dtaListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents rb_nombre As System.Windows.Forms.RadioButton
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtaListado As System.Windows.Forms.DataGridView
    Friend WithEvents cedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
