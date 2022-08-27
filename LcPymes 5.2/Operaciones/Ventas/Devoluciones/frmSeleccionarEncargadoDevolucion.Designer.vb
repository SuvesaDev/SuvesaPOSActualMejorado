<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeleccionarEncargadoDevolucion
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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.cboEncargado = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNotasDevolucion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRefacturacion = New System.Windows.Forms.Button()
        Me.btnSinExistencia = New System.Windows.Forms.Button()
        Me.btnCambio = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(362, 210)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(116, 40)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(240, 210)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(116, 40)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'cboEncargado
        '
        Me.cboEncargado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEncargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEncargado.FormattingEnabled = True
        Me.cboEncargado.Location = New System.Drawing.Point(12, 40)
        Me.cboEncargado.Name = "cboEncargado"
        Me.cboEncargado.Size = New System.Drawing.Size(466, 24)
        Me.cboEncargado.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Seleccionar usuario recibio devolucion :"
        '
        'txtNotasDevolucion
        '
        Me.txtNotasDevolucion.Location = New System.Drawing.Point(12, 95)
        Me.txtNotasDevolucion.Multiline = True
        Me.txtNotasDevolucion.Name = "txtNotasDevolucion"
        Me.txtNotasDevolucion.Size = New System.Drawing.Size(466, 109)
        Me.txtNotasDevolucion.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Observaciones Devolucion :"
        '
        'btnRefacturacion
        '
        Me.btnRefacturacion.AutoSize = True
        Me.btnRefacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefacturacion.Location = New System.Drawing.Point(190, 68)
        Me.btnRefacturacion.Name = "btnRefacturacion"
        Me.btnRefacturacion.Size = New System.Drawing.Size(92, 25)
        Me.btnRefacturacion.TabIndex = 6
        Me.btnRefacturacion.Text = "Refacturacion"
        Me.btnRefacturacion.UseVisualStyleBackColor = True
        '
        'btnSinExistencia
        '
        Me.btnSinExistencia.AutoSize = True
        Me.btnSinExistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSinExistencia.Location = New System.Drawing.Point(288, 68)
        Me.btnSinExistencia.Name = "btnSinExistencia"
        Me.btnSinExistencia.Size = New System.Drawing.Size(92, 25)
        Me.btnSinExistencia.TabIndex = 7
        Me.btnSinExistencia.Text = "Sin Existencia"
        Me.btnSinExistencia.UseVisualStyleBackColor = True
        '
        'btnCambio
        '
        Me.btnCambio.AutoSize = True
        Me.btnCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambio.Location = New System.Drawing.Point(386, 68)
        Me.btnCambio.Name = "btnCambio"
        Me.btnCambio.Size = New System.Drawing.Size(92, 25)
        Me.btnCambio.TabIndex = 8
        Me.btnCambio.Text = "Cambio x Otro"
        Me.btnCambio.UseVisualStyleBackColor = True
        '
        'frmSeleccionarEncargadoDevolucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 262)
        Me.Controls.Add(Me.btnCambio)
        Me.Controls.Add(Me.btnSinExistencia)
        Me.Controls.Add(Me.btnRefacturacion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNotasDevolucion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboEncargado)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSeleccionarEncargadoDevolucion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccionar Encargado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents cboEncargado As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNotasDevolucion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRefacturacion As System.Windows.Forms.Button
    Friend WithEvents btnSinExistencia As System.Windows.Forms.Button
    Friend WithEvents btnCambio As System.Windows.Forms.Button
End Class
