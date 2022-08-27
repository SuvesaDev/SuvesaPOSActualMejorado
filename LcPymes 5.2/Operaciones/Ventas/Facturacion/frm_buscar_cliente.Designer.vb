<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_buscar_cliente
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
        Me.datos = New System.Windows.Forms.DataGridView
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_cedula = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.rb_nombre = New System.Windows.Forms.RadioButton
        Me.rb_cedula = New System.Windows.Forms.RadioButton
        Me.ck_tipo = New System.Windows.Forms.CheckedListBox
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datos
        '
        Me.datos.AllowUserToAddRows = False
        Me.datos.AllowUserToDeleteRows = False
        Me.datos.BackgroundColor = System.Drawing.Color.CadetBlue
        Me.datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_cedula, Me.col_nombre, Me.col_tipo})
        Me.datos.Location = New System.Drawing.Point(11, 53)
        Me.datos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.datos.Name = "datos"
        Me.datos.ReadOnly = True
        Me.datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datos.Size = New System.Drawing.Size(655, 286)
        Me.datos.TabIndex = 5
        '
        'col_id
        '
        Me.col_id.DataPropertyName = "identificacion"
        Me.col_id.HeaderText = "id"
        Me.col_id.Name = "col_id"
        Me.col_id.ReadOnly = True
        '
        'col_cedula
        '
        Me.col_cedula.DataPropertyName = "cedula"
        Me.col_cedula.HeaderText = "cedula"
        Me.col_cedula.Name = "col_cedula"
        Me.col_cedula.ReadOnly = True
        '
        'col_nombre
        '
        Me.col_nombre.DataPropertyName = "nombre"
        Me.col_nombre.HeaderText = "Nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.ReadOnly = True
        Me.col_nombre.Width = 300
        '
        'col_tipo
        '
        Me.col_tipo.DataPropertyName = "tipo_cedula"
        Me.col_tipo.HeaderText = "Tipo"
        Me.col_tipo.Name = "col_tipo"
        Me.col_tipo.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(250, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BUSCAR CLIENTE"
        '
        'txt_nombre
        '
        Me.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(159, 368)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(509, 30)
        Me.txt_nombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(156, 344)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Filtro:"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptar.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.ForeColor = System.Drawing.Color.White
        Me.btn_aceptar.Location = New System.Drawing.Point(456, 404)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(103, 30)
        Me.btn_aceptar.TabIndex = 9
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.Red
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.White
        Me.btn_cancelar.Location = New System.Drawing.Point(565, 404)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(103, 30)
        Me.btn_cancelar.TabIndex = 10
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'rb_nombre
        '
        Me.rb_nombre.AutoSize = True
        Me.rb_nombre.Checked = True
        Me.rb_nombre.ForeColor = System.Drawing.Color.White
        Me.rb_nombre.Location = New System.Drawing.Point(203, 344)
        Me.rb_nombre.Name = "rb_nombre"
        Me.rb_nombre.Size = New System.Drawing.Size(69, 22)
        Me.rb_nombre.TabIndex = 11
        Me.rb_nombre.TabStop = True
        Me.rb_nombre.Text = "Nombre"
        Me.rb_nombre.UseVisualStyleBackColor = True
        '
        'rb_cedula
        '
        Me.rb_cedula.AutoSize = True
        Me.rb_cedula.ForeColor = System.Drawing.Color.White
        Me.rb_cedula.Location = New System.Drawing.Point(278, 344)
        Me.rb_cedula.Name = "rb_cedula"
        Me.rb_cedula.Size = New System.Drawing.Size(63, 22)
        Me.rb_cedula.TabIndex = 12
        Me.rb_cedula.Text = "Cedula"
        Me.rb_cedula.UseVisualStyleBackColor = True
        '
        'ck_tipo
        '
        Me.ck_tipo.BackColor = System.Drawing.Color.SeaGreen
        Me.ck_tipo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ck_tipo.ForeColor = System.Drawing.Color.White
        Me.ck_tipo.FormattingEnabled = True
        Me.ck_tipo.Items.AddRange(New Object() {"FISICA", "JURIDICA", "OTRO"})
        Me.ck_tipo.Location = New System.Drawing.Point(11, 370)
        Me.ck_tipo.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ck_tipo.Name = "ck_tipo"
        Me.ck_tipo.Size = New System.Drawing.Size(120, 64)
        Me.ck_tipo.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 347)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 18)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Tipo:"
        '
        'frm_buscar_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(677, 442)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ck_tipo)
        Me.Controls.Add(Me.rb_cedula)
        Me.Controls.Add(Me.rb_nombre)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.datos)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_buscar_cliente"
        Me.Opacity = 0.9
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Cliente"
        CType(Me.datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents datos As Windows.Forms.DataGridView
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents txt_nombre As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents btn_aceptar As Windows.Forms.Button
    Friend WithEvents btn_cancelar As Windows.Forms.Button
    Friend WithEvents rb_nombre As Windows.Forms.RadioButton
    Friend WithEvents rb_cedula As Windows.Forms.RadioButton
    Friend WithEvents ck_tipo As Windows.Forms.CheckedListBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents col_id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cedula As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nombre As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_tipo As Windows.Forms.DataGridViewTextBoxColumn
End Class
