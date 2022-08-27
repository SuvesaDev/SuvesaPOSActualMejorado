<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarApartados
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
        Me.opNombre = New System.Windows.Forms.RadioButton()
        Me.opApartado = New System.Windows.Forms.RadioButton()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.viewApartados = New System.Windows.Forms.DataGridView()
        Me.btnAbonar = New System.Windows.Forms.Button()
        CType(Me.viewApartados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'opNombre
        '
        Me.opNombre.AutoSize = True
        Me.opNombre.Checked = True
        Me.opNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opNombre.Location = New System.Drawing.Point(12, 353)
        Me.opNombre.Name = "opNombre"
        Me.opNombre.Size = New System.Drawing.Size(182, 24)
        Me.opNombre.TabIndex = 2
        Me.opNombre.TabStop = True
        Me.opNombre.Text = "Consultar por Nombre"
        Me.opNombre.UseVisualStyleBackColor = True
        '
        'opApartado
        '
        Me.opApartado.AutoSize = True
        Me.opApartado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opApartado.Location = New System.Drawing.Point(249, 353)
        Me.opApartado.Name = "opApartado"
        Me.opApartado.Size = New System.Drawing.Size(252, 24)
        Me.opApartado.TabIndex = 3
        Me.opApartado.Text = "Consultar por Numero Apartado"
        Me.opApartado.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(12, 318)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(489, 29)
        Me.txtBuscar.TabIndex = 1
        '
        'viewApartados
        '
        Me.viewApartados.AllowUserToAddRows = False
        Me.viewApartados.AllowUserToDeleteRows = False
        Me.viewApartados.AllowUserToResizeColumns = False
        Me.viewApartados.AllowUserToResizeRows = False
        Me.viewApartados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.viewApartados.BackgroundColor = System.Drawing.Color.White
        Me.viewApartados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewApartados.Location = New System.Drawing.Point(12, 2)
        Me.viewApartados.MultiSelect = False
        Me.viewApartados.Name = "viewApartados"
        Me.viewApartados.ReadOnly = True
        Me.viewApartados.RowHeadersVisible = False
        Me.viewApartados.RowTemplate.Height = 29
        Me.viewApartados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewApartados.Size = New System.Drawing.Size(693, 310)
        Me.viewApartados.TabIndex = 4
        '
        'btnAbonar
        '
        Me.btnAbonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbonar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbonar.Location = New System.Drawing.Point(529, 318)
        Me.btnAbonar.Name = "btnAbonar"
        Me.btnAbonar.Size = New System.Drawing.Size(174, 59)
        Me.btnAbonar.TabIndex = 5
        Me.btnAbonar.Text = "Registrar Abono"
        Me.btnAbonar.UseVisualStyleBackColor = True
        '
        'frmBuscarApartados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(715, 389)
        Me.Controls.Add(Me.btnAbonar)
        Me.Controls.Add(Me.viewApartados)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.opApartado)
        Me.Controls.Add(Me.opNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscarApartados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Abonos a Apartados"
        CType(Me.viewApartados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents opNombre As System.Windows.Forms.RadioButton
    Friend WithEvents opApartado As System.Windows.Forms.RadioButton
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents viewApartados As System.Windows.Forms.DataGridView
    Friend WithEvents btnAbonar As System.Windows.Forms.Button
End Class
