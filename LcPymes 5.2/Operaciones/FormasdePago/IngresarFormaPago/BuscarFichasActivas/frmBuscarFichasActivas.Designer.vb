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
        Me.viewFichasActivas.Name = "viewFichasActivas"
        Me.viewFichasActivas.ReadOnly = True
        Me.viewFichasActivas.RowHeadersVisible = False
        Me.viewFichasActivas.RowTemplate.Height = 30
        Me.viewFichasActivas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewFichasActivas.Size = New System.Drawing.Size(747, 409)
        Me.viewFichasActivas.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1, 411)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(375, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Buscar Fichas Activas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnInactivar
        '
        Me.btnInactivar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInactivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInactivar.Location = New System.Drawing.Point(381, 411)
        Me.btnInactivar.Name = "btnInactivar"
        Me.btnInactivar.Size = New System.Drawing.Size(367, 42)
        Me.btnInactivar.TabIndex = 2
        Me.btnInactivar.Text = "Inactivar Ficha Seleccionada"
        Me.btnInactivar.UseVisualStyleBackColor = True
        '
        'lblNumeroCaja
        '
        Me.lblNumeroCaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroCaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumeroCaja.Location = New System.Drawing.Point(675, 471)
        Me.lblNumeroCaja.Name = "lblNumeroCaja"
        Me.lblNumeroCaja.Size = New System.Drawing.Size(73, 20)
        Me.lblNumeroCaja.TabIndex = 23
        Me.lblNumeroCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUsuario
        '
        Me.lblUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUsuario.Location = New System.Drawing.Point(50, 472)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(619, 20)
        Me.lblUsuario.TabIndex = 22
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(672, 455)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Caja"
        '
        'txtClave
        '
        Me.txtClave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtClave.Location = New System.Drawing.Point(3, 472)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.ReadOnly = True
        Me.txtClave.Size = New System.Drawing.Size(42, 20)
        Me.txtClave.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-1, 456)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Usuario "
        '
        'frmBuscarFichasActivas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 494)
        Me.Controls.Add(Me.lblNumeroCaja)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnInactivar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.viewFichasActivas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
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
End Class
