<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambiarCorreo
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
        Me.txtCorreoElectronico = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.viewCorreos = New System.Windows.Forms.DataGridView()
        Me.cCorreo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtCorreos = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        CType(Me.viewCorreos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCorreoElectronico
        '
        Me.txtCorreoElectronico.Location = New System.Drawing.Point(28, 26)
        Me.txtCorreoElectronico.Name = "txtCorreoElectronico"
        Me.txtCorreoElectronico.Size = New System.Drawing.Size(292, 20)
        Me.txtCorreoElectronico.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Correo Electronico :"
        '
        'viewCorreos
        '
        Me.viewCorreos.AllowUserToAddRows = False
        Me.viewCorreos.AllowUserToResizeColumns = False
        Me.viewCorreos.AllowUserToResizeRows = False
        Me.viewCorreos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.viewCorreos.BackgroundColor = System.Drawing.Color.White
        Me.viewCorreos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewCorreos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cCorreo})
        Me.viewCorreos.Location = New System.Drawing.Point(28, 81)
        Me.viewCorreos.MultiSelect = False
        Me.viewCorreos.Name = "viewCorreos"
        Me.viewCorreos.ReadOnly = True
        Me.viewCorreos.Size = New System.Drawing.Size(414, 159)
        Me.viewCorreos.TabIndex = 2
        '
        'cCorreo
        '
        Me.cCorreo.HeaderText = "Correo Electronico"
        Me.cCorreo.Name = "cCorreo"
        Me.cCorreo.ReadOnly = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(326, 26)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(116, 24)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Agregar Correo"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtCorreos
        '
        Me.txtCorreos.Location = New System.Drawing.Point(28, 246)
        Me.txtCorreos.Multiline = True
        Me.txtCorreos.Name = "txtCorreos"
        Me.txtCorreos.ReadOnly = True
        Me.txtCorreos.Size = New System.Drawing.Size(414, 46)
        Me.txtCorreos.TabIndex = 4
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(326, 298)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(116, 28)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(204, 298)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(116, 28)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(326, 51)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(116, 24)
        Me.btnLimpiar.TabIndex = 7
        Me.btnLimpiar.Text = "Limpiar Correos"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'frmCambiarCorreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 334)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtCorreos)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.viewCorreos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCorreoElectronico)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCambiarCorreo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Correo Electronico"
        CType(Me.viewCorreos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCorreoElectronico As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents viewCorreos As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents cCorreo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCorreos As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
End Class
