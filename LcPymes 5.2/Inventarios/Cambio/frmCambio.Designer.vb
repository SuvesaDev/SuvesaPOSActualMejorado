<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambio
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
        Me.panelFacturado = New System.Windows.Forms.GroupBox()
        Me.btnBuscarFacturado = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCantidadFacturado = New System.Windows.Forms.TextBox()
        Me.txtDescripcionFacturado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigoFacturado = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.panelEntregado = New System.Windows.Forms.GroupBox()
        Me.btnBuscarEntregado = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCantidadEntegado = New System.Windows.Forms.TextBox()
        Me.txtDescripcionEntregado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodigoEntregado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDiferencia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.panelFacturado.SuspendLayout()
        Me.panelEntregado.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelFacturado
        '
        Me.panelFacturado.Controls.Add(Me.btnBuscarFacturado)
        Me.panelFacturado.Controls.Add(Me.Label2)
        Me.panelFacturado.Controls.Add(Me.txtCantidadFacturado)
        Me.panelFacturado.Controls.Add(Me.txtDescripcionFacturado)
        Me.panelFacturado.Controls.Add(Me.Label1)
        Me.panelFacturado.Controls.Add(Me.txtCodigoFacturado)
        Me.panelFacturado.Enabled = False
        Me.panelFacturado.Location = New System.Drawing.Point(15, 73)
        Me.panelFacturado.Name = "panelFacturado"
        Me.panelFacturado.Size = New System.Drawing.Size(471, 99)
        Me.panelFacturado.TabIndex = 0
        Me.panelFacturado.TabStop = False
        Me.panelFacturado.Text = "Articulo Facturado"
        '
        'btnBuscarFacturado
        '
        Me.btnBuscarFacturado.Image = Global.LcPymes_5._2.My.Resources.Resources.page_find
        Me.btnBuscarFacturado.Location = New System.Drawing.Point(116, 60)
        Me.btnBuscarFacturado.Name = "btnBuscarFacturado"
        Me.btnBuscarFacturado.Size = New System.Drawing.Size(26, 25)
        Me.btnBuscarFacturado.TabIndex = 12
        Me.btnBuscarFacturado.TabStop = False
        Me.btnBuscarFacturado.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cantidad  :"
        '
        'txtCantidadFacturado
        '
        Me.txtCantidadFacturado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadFacturado.Location = New System.Drawing.Point(152, 62)
        Me.txtCantidadFacturado.Name = "txtCantidadFacturado"
        Me.txtCantidadFacturado.Size = New System.Drawing.Size(70, 21)
        Me.txtCantidadFacturado.TabIndex = 1
        '
        'txtDescripcionFacturado
        '
        Me.txtDescripcionFacturado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionFacturado.Location = New System.Drawing.Point(15, 19)
        Me.txtDescripcionFacturado.Name = "txtDescripcionFacturado"
        Me.txtDescripcionFacturado.ReadOnly = True
        Me.txtDescripcionFacturado.Size = New System.Drawing.Size(445, 21)
        Me.txtDescripcionFacturado.TabIndex = 2
        Me.txtDescripcionFacturado.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo  :"
        '
        'txtCodigoFacturado
        '
        Me.txtCodigoFacturado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoFacturado.Location = New System.Drawing.Point(15, 62)
        Me.txtCodigoFacturado.Name = "txtCodigoFacturado"
        Me.txtCodigoFacturado.Size = New System.Drawing.Size(100, 21)
        Me.txtCodigoFacturado.TabIndex = 0
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(257, 314)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(229, 49)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Registrar Cambio"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(15, 314)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(229, 49)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'panelEntregado
        '
        Me.panelEntregado.Controls.Add(Me.btnBuscarEntregado)
        Me.panelEntregado.Controls.Add(Me.Label3)
        Me.panelEntregado.Controls.Add(Me.txtCantidadEntegado)
        Me.panelEntregado.Controls.Add(Me.txtDescripcionEntregado)
        Me.panelEntregado.Controls.Add(Me.Label4)
        Me.panelEntregado.Controls.Add(Me.txtCodigoEntregado)
        Me.panelEntregado.Enabled = False
        Me.panelEntregado.Location = New System.Drawing.Point(15, 178)
        Me.panelEntregado.Name = "panelEntregado"
        Me.panelEntregado.Size = New System.Drawing.Size(471, 99)
        Me.panelEntregado.TabIndex = 2
        Me.panelEntregado.TabStop = False
        Me.panelEntregado.Text = "Articulo Entregado"
        '
        'btnBuscarEntregado
        '
        Me.btnBuscarEntregado.Image = Global.LcPymes_5._2.My.Resources.Resources.page_find
        Me.btnBuscarEntregado.Location = New System.Drawing.Point(116, 60)
        Me.btnBuscarEntregado.Name = "btnBuscarEntregado"
        Me.btnBuscarEntregado.Size = New System.Drawing.Size(26, 25)
        Me.btnBuscarEntregado.TabIndex = 11
        Me.btnBuscarEntregado.TabStop = False
        Me.btnBuscarEntregado.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(156, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cantidad  :"
        '
        'txtCantidadEntegado
        '
        Me.txtCantidadEntegado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadEntegado.Location = New System.Drawing.Point(152, 62)
        Me.txtCantidadEntegado.Name = "txtCantidadEntegado"
        Me.txtCantidadEntegado.Size = New System.Drawing.Size(70, 21)
        Me.txtCantidadEntegado.TabIndex = 3
        '
        'txtDescripcionEntregado
        '
        Me.txtDescripcionEntregado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionEntregado.Location = New System.Drawing.Point(15, 19)
        Me.txtDescripcionEntregado.Name = "txtDescripcionEntregado"
        Me.txtDescripcionEntregado.ReadOnly = True
        Me.txtDescripcionEntregado.Size = New System.Drawing.Size(445, 21)
        Me.txtDescripcionEntregado.TabIndex = 2
        Me.txtDescripcionEntregado.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Codigo  :"
        '
        'txtCodigoEntregado
        '
        Me.txtCodigoEntregado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoEntregado.Location = New System.Drawing.Point(15, 62)
        Me.txtCodigoEntregado.Name = "txtCodigoEntregado"
        Me.txtCodigoEntregado.Size = New System.Drawing.Size(100, 21)
        Me.txtCodigoEntregado.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(254, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Diferencia :"
        '
        'txtDiferencia
        '
        Me.txtDiferencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiferencia.Location = New System.Drawing.Point(321, 285)
        Me.txtDiferencia.Name = "txtDiferencia"
        Me.txtDiferencia.ReadOnly = True
        Me.txtDiferencia.Size = New System.Drawing.Size(165, 20)
        Me.txtDiferencia.TabIndex = 6
        Me.txtDiferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Usuario"
        '
        'txtClave
        '
        Me.txtClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Location = New System.Drawing.Point(30, 36)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(70, 21)
        Me.txtClave.TabIndex = 0
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(106, 36)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(369, 21)
        Me.txtUsuario.TabIndex = 13
        Me.txtUsuario.TabStop = False
        '
        'frmCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(498, 375)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDiferencia)
        Me.Controls.Add(Me.panelEntregado)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.panelFacturado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmCambio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Cambio "
        Me.panelFacturado.ResumeLayout(False)
        Me.panelFacturado.PerformLayout()
        Me.panelEntregado.ResumeLayout(False)
        Me.panelEntregado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelFacturado As System.Windows.Forms.GroupBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCantidadFacturado As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcionFacturado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoFacturado As System.Windows.Forms.TextBox
    Friend WithEvents panelEntregado As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCantidadEntegado As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcionEntregado As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoEntregado As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDiferencia As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarFacturado As System.Windows.Forms.Button
    Friend WithEvents btnBuscarEntregado As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
End Class
