<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmValidarRegistroMAG
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.ckMAG = New System.Windows.Forms.CheckBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFechaBaja = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.ckVenta1 = New System.Windows.Forms.CheckBox()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre "
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(15, 39)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(397, 20)
        Me.txtNombre.TabIndex = 1
        '
        'ckMAG
        '
        Me.ckMAG.AutoSize = True
        Me.ckMAG.Enabled = False
        Me.ckMAG.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ckMAG.Location = New System.Drawing.Point(15, 88)
        Me.ckMAG.Name = "ckMAG"
        Me.ckMAG.Size = New System.Drawing.Size(121, 17)
        Me.ckMAG.TabIndex = 2
        Me.ckMAG.Text = "indicadorActivoMAG"
        Me.ckMAG.UseVisualStyleBackColor = True
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(163, 87)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(121, 20)
        Me.txtEstado.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Estado"
        '
        'txtFechaBaja
        '
        Me.txtFechaBaja.Location = New System.Drawing.Point(291, 86)
        Me.txtFechaBaja.Name = "txtFechaBaja"
        Me.txtFechaBaja.ReadOnly = True
        Me.txtFechaBaja.Size = New System.Drawing.Size(121, 20)
        Me.txtFechaBaja.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(288, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha Baja(Año-Mes-Dia)"
        '
        'btnCerrar
        '
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(163, 236)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(249, 48)
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.Text = "Aceptar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'viewDatos
        '
        Me.viewDatos.AllowUserToAddRows = False
        Me.viewDatos.AllowUserToDeleteRows = False
        Me.viewDatos.AllowUserToResizeColumns = False
        Me.viewDatos.AllowUserToResizeRows = False
        Me.viewDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.viewDatos.BackgroundColor = System.Drawing.Color.White
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Location = New System.Drawing.Point(12, 113)
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.ReadOnly = True
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(400, 117)
        Me.viewDatos.TabIndex = 8
        '
        'ckVenta1
        '
        Me.ckVenta1.AutoSize = True
        Me.ckVenta1.Enabled = False
        Me.ckVenta1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ckVenta1.Location = New System.Drawing.Point(12, 253)
        Me.ckVenta1.Name = "ckVenta1"
        Me.ckVenta1.Size = New System.Drawing.Size(133, 17)
        Me.ckVenta1.TabIndex = 9
        Me.ckVenta1.Text = "Productor / Distribuidor"
        Me.ckVenta1.UseVisualStyleBackColor = True
        '
        'frmValidarRegistroMAG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 287)
        Me.Controls.Add(Me.ckVenta1)
        Me.Controls.Add(Me.viewDatos)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtFechaBaja)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ckMAG)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmValidarRegistroMAG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Registro en el MAG"
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents ckMAG As System.Windows.Forms.CheckBox
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFechaBaja As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents ckVenta1 As System.Windows.Forms.CheckBox
End Class
