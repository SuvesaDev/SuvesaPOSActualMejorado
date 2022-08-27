<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelacionarProductos
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
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.cCodigoPrestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDescripcionPrestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cCodigoInterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCodArticuloInterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDescripcionInterna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAplicar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'viewDatos
        '
        Me.viewDatos.AllowUserToAddRows = False
        Me.viewDatos.AllowUserToDeleteRows = False
        Me.viewDatos.AllowUserToResizeColumns = False
        Me.viewDatos.AllowUserToResizeRows = False
        Me.viewDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewDatos.BackgroundColor = System.Drawing.Color.White
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cCodigoPrestamo, Me.cDescripcionPrestamo, Me.btn, Me.cCodigoInterno, Me.cCodArticuloInterno, Me.cDescripcionInterna})
        Me.viewDatos.Location = New System.Drawing.Point(0, 40)
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.ReadOnly = True
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(888, 419)
        Me.viewDatos.TabIndex = 0
        '
        'cCodigoPrestamo
        '
        Me.cCodigoPrestamo.HeaderText = "CodigoPrestamo"
        Me.cCodigoPrestamo.Name = "cCodigoPrestamo"
        Me.cCodigoPrestamo.ReadOnly = True
        Me.cCodigoPrestamo.Visible = False
        '
        'cDescripcionPrestamo
        '
        Me.cDescripcionPrestamo.HeaderText = "Descripcion Prestamo"
        Me.cDescripcionPrestamo.Name = "cDescripcionPrestamo"
        Me.cDescripcionPrestamo.ReadOnly = True
        Me.cDescripcionPrestamo.Width = 350
        '
        'btn
        '
        Me.btn.HeaderText = ""
        Me.btn.Name = "btn"
        Me.btn.ReadOnly = True
        Me.btn.Width = 30
        '
        'cCodigoInterno
        '
        Me.cCodigoInterno.HeaderText = "CodigoInterno"
        Me.cCodigoInterno.Name = "cCodigoInterno"
        Me.cCodigoInterno.ReadOnly = True
        Me.cCodigoInterno.Visible = False
        '
        'cCodArticuloInterno
        '
        Me.cCodArticuloInterno.HeaderText = "Cod Interno"
        Me.cCodArticuloInterno.Name = "cCodArticuloInterno"
        Me.cCodArticuloInterno.ReadOnly = True
        '
        'cDescripcionInterna
        '
        Me.cDescripcionInterna.HeaderText = "Descripcion Interna"
        Me.cDescripcionInterna.Name = "cDescripcionInterna"
        Me.cDescripcionInterna.ReadOnly = True
        Me.cDescripcionInterna.Width = 350
        '
        'btnAplicar
        '
        Me.btnAplicar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAplicar.Location = New System.Drawing.Point(678, 460)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(210, 37)
        Me.btnAplicar.TabIndex = 1
        Me.btnAplicar.Text = "Aplicar Cambios"
        Me.btnAplicar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 38)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Ver Todos los Articulos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(244, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(235, 38)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Ver los pendientes de Relacionar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmRelacionarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 499)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.viewDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmRelacionarProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relacionar codigos"
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents cCodigoPrestamo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDescripcionPrestamo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cCodigoInterno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCodArticuloInterno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDescripcionInterna As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAplicar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
