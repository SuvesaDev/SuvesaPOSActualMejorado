<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarFichasActivas
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
        Me.viewFichasActivas = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnInactivar = New System.Windows.Forms.Button()
        Me.lblNumeroCaja = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDevolver = New System.Windows.Forms.Button()
        CType(Me.viewFichasActivas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'viewFichasActivas
        '
        Me.viewFichasActivas.AllowUserToAddRows = False
        Me.viewFichasActivas.AllowUserToDeleteRows = False
        Me.viewFichasActivas.AllowUserToResizeColumns = False
        Me.viewFichasActivas.AllowUserToResizeRows = False
        Me.viewFichasActivas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewFichasActivas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.viewFichasActivas.BackgroundColor = System.Drawing.Color.White
        Me.viewFichasActivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewFichasActivas.Location = New System.Drawing.Point(1, 0)
        Me.viewFichasActivas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.viewFichasActivas.Name = "viewFichasActivas"
        Me.viewFichasActivas.ReadOnly = True
        Me.viewFichasActivas.RowHeadersVisible = False
        Me.viewFichasActivas.RowTemplate.Height = 30
        Me.viewFichasActivas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewFichasActivas.Size = New System.Drawing.Size(1005, 503)
        Me.viewFichasActivas.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1, 505)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(335, 52)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Buscar Fichas Activas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnInactivar
        '
        Me.btnInactivar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInactivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInactivar.Location = New System.Drawing.Point(347, 505)
        Me.btnInactivar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnInactivar.Name = "btnInactivar"
        Me.btnInactivar.Size = New System.Drawing.Size(324, 52)
        Me.btnInactivar.TabIndex = 2
        Me.btnInactivar.Text = "Inactivar Ficha Seleccionada"
        Me.btnInactivar.UseVisualStyleBackColor = True
        '
        'lblNumeroCaja
        '
        Me.lblNumeroCaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroCaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumeroCaja.Location = New System.Drawing.Point(909, 580)
        Me.lblNumeroCaja.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumeroCaja.Name = "lblNumeroCaja"
        Me.lblNumeroCaja.Size = New System.Drawing.Size(97, 24)
        Me.lblNumeroCaja.TabIndex = 23
        Me.lblNumeroCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUsuario
        '
        Me.lblUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUsuario.Location = New System.Drawing.Point(67, 581)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(834, 24)
        Me.lblUsuario.TabIndex = 22
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(905, 560)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Caja"
        '
        'txtClave
        '
        Me.txtClave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtClave.Location = New System.Drawing.Point(4, 581)
        Me.txtClave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.ReadOnly = True
        Me.txtClave.Size = New System.Drawing.Size(55, 22)
        Me.txtClave.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-1, 561)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Usuario "
        '
        'btnDevolver
        '
        Me.btnDevolver.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDevolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDevolver.Location = New System.Drawing.Point(682, 505)
        Me.btnDevolver.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDevolver.Name = "btnDevolver"
        Me.btnDevolver.Size = New System.Drawing.Size(324, 52)
        Me.btnDevolver.TabIndex = 24
        Me.btnDevolver.Text = "Revertir"
        Me.btnDevolver.UseVisualStyleBackColor = True
        '
        'frmBuscarFichasActivas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 608)
        Me.Controls.Add(Me.btnDevolver)
        Me.Controls.Add(Me.lblNumeroCaja)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnInactivar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.viewFichasActivas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscarFichasActivas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Fichas Activas"
        CType(Me.viewFichasActivas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

End Sub
    Friend WithEvents viewFichasActivas As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnInactivar As System.Windows.Forms.Button
    Friend WithEvents lblNumeroCaja As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnDevolver As System.Windows.Forms.Button
End Class
