<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productos_patrocinadores
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
        Me.datalistado = New System.Windows.Forms.DataGridView
        Me.Label50 = New System.Windows.Forms.Label
        Me.cbo_rifa = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_mostrar = New System.Windows.Forms.Button
        Me.S = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cod_articulo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.barras = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.AllowUserToResizeColumns = False
        Me.datalistado.AllowUserToResizeRows = False
        Me.datalistado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datalistado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.S, Me.codigo, Me.cod_articulo, Me.barras, Me.descripcion})
        Me.datalistado.Location = New System.Drawing.Point(12, 64)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(625, 363)
        Me.datalistado.TabIndex = 0
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.Red
        Me.Label50.Location = New System.Drawing.Point(12, 9)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(38, 18)
        Me.Label50.TabIndex = 94
        Me.Label50.Text = "Rifa"
        '
        'cbo_rifa
        '
        Me.cbo_rifa.FormattingEnabled = True
        Me.cbo_rifa.Location = New System.Drawing.Point(56, 9)
        Me.cbo_rifa.Name = "cbo_rifa"
        Me.cbo_rifa.Size = New System.Drawing.Size(263, 21)
        Me.cbo_rifa.TabIndex = 93
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 13)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Seleccionar rifa para ver que productos son los patrocinadores"
        '
        'btn_mostrar
        '
        Me.btn_mostrar.Location = New System.Drawing.Point(325, 8)
        Me.btn_mostrar.Name = "btn_mostrar"
        Me.btn_mostrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_mostrar.TabIndex = 96
        Me.btn_mostrar.Text = "Mostrar"
        Me.btn_mostrar.UseVisualStyleBackColor = True
        '
        'S
        '
        Me.S.HeaderText = ""
        Me.S.Name = "S"
        Me.S.Visible = False
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "Codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.Visible = False
        '
        'cod_articulo
        '
        Me.cod_articulo.DataPropertyName = "cod_articulo"
        Me.cod_articulo.HeaderText = "cod_articulo"
        Me.cod_articulo.Name = "cod_articulo"
        '
        'barras
        '
        Me.barras.DataPropertyName = "barras"
        Me.barras.HeaderText = "barras"
        Me.barras.Name = "barras"
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "descripcion"
        Me.descripcion.Name = "descripcion"
        '
        'frm_productos_patrocinadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 439)
        Me.Controls.Add(Me.btn_mostrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.cbo_rifa)
        Me.Controls.Add(Me.datalistado)
        Me.MaximizeBox = False
        Me.Name = "frm_productos_patrocinadores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos patrocinadores"
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents cbo_rifa As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_mostrar As System.Windows.Forms.Button
    Friend WithEvents S As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cod_articulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents barras As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
