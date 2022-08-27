<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnirCodigosPuntoVenta
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
        Me.ViewDatos = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPuntoVenta1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cBuscarCodigo1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cCodigo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCodAlterno1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDescripcion1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPuntoVenta2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cBuscarCodigo2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cCodigo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCodAlterno2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDescripcion2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cEliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.ViewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ViewDatos
        '
        Me.ViewDatos.AllowUserToAddRows = False
        Me.ViewDatos.AllowUserToDeleteRows = False
        Me.ViewDatos.AllowUserToResizeColumns = False
        Me.ViewDatos.AllowUserToResizeRows = False
        Me.ViewDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewDatos.BackgroundColor = System.Drawing.Color.White
        Me.ViewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cId, Me.cPuntoVenta1, Me.cBuscarCodigo1, Me.cCodigo1, Me.cCodAlterno1, Me.cDescripcion1, Me.cPuntoVenta2, Me.cBuscarCodigo2, Me.cCodigo2, Me.cCodAlterno2, Me.cDescripcion2, Me.cEliminar})
        Me.ViewDatos.Location = New System.Drawing.Point(1, 42)
        Me.ViewDatos.MultiSelect = False
        Me.ViewDatos.Name = "ViewDatos"
        Me.ViewDatos.RowHeadersVisible = False
        Me.ViewDatos.RowTemplate.Height = 27
        Me.ViewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewDatos.Size = New System.Drawing.Size(1000, 433)
        Me.ViewDatos.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(5, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cId
        '
        Me.cId.HeaderText = "Id"
        Me.cId.Name = "cId"
        Me.cId.Visible = False
        '
        'cPuntoVenta1
        '
        Me.cPuntoVenta1.HeaderText = "Punto de Venta 1"
        Me.cPuntoVenta1.Name = "cPuntoVenta1"
        Me.cPuntoVenta1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cPuntoVenta1.Width = 135
        '
        'cBuscarCodigo1
        '
        Me.cBuscarCodigo1.HeaderText = "..."
        Me.cBuscarCodigo1.Name = "cBuscarCodigo1"
        Me.cBuscarCodigo1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cBuscarCodigo1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cBuscarCodigo1.Visible = False
        Me.cBuscarCodigo1.Width = 25
        '
        'cCodigo1
        '
        Me.cCodigo1.HeaderText = "Codigo"
        Me.cCodigo1.Name = "cCodigo1"
        Me.cCodigo1.Visible = False
        '
        'cCodAlterno1
        '
        Me.cCodAlterno1.HeaderText = "Codigo"
        Me.cCodAlterno1.Name = "cCodAlterno1"
        Me.cCodAlterno1.ReadOnly = True
        Me.cCodAlterno1.Width = 120
        '
        'cDescripcion1
        '
        Me.cDescripcion1.HeaderText = "Descripcion"
        Me.cDescripcion1.Name = "cDescripcion1"
        Me.cDescripcion1.ReadOnly = True
        Me.cDescripcion1.Width = 230
        '
        'cPuntoVenta2
        '
        Me.cPuntoVenta2.HeaderText = "Punto de Venta 2"
        Me.cPuntoVenta2.Name = "cPuntoVenta2"
        Me.cPuntoVenta2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cPuntoVenta2.Width = 135
        '
        'cBuscarCodigo2
        '
        Me.cBuscarCodigo2.HeaderText = "..."
        Me.cBuscarCodigo2.Name = "cBuscarCodigo2"
        Me.cBuscarCodigo2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cBuscarCodigo2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cBuscarCodigo2.Visible = False
        Me.cBuscarCodigo2.Width = 25
        '
        'cCodigo2
        '
        Me.cCodigo2.HeaderText = "Codigo"
        Me.cCodigo2.Name = "cCodigo2"
        Me.cCodigo2.ReadOnly = True
        Me.cCodigo2.Visible = False
        '
        'cCodAlterno2
        '
        Me.cCodAlterno2.HeaderText = "Codigo"
        Me.cCodAlterno2.Name = "cCodAlterno2"
        Me.cCodAlterno2.ReadOnly = True
        Me.cCodAlterno2.Width = 120
        '
        'cDescripcion2
        '
        Me.cDescripcion2.HeaderText = "Descripcion"
        Me.cDescripcion2.Name = "cDescripcion2"
        Me.cDescripcion2.Width = 230
        '
        'cEliminar
        '
        Me.cEliminar.HeaderText = "Eliminar"
        Me.cEliminar.Name = "cEliminar"
        Me.cEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cEliminar.Text = ""
        Me.cEliminar.Visible = False
        Me.cEliminar.Width = 50
        '
        'frmUnirCodigosPuntoVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 476)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ViewDatos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUnirCodigosPuntoVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unir Codigos Entre Puntos de Venta"
        CType(Me.ViewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ViewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPuntoVenta1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cBuscarCodigo1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cCodigo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCodAlterno1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDescripcion1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPuntoVenta2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cBuscarCodigo2 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cCodigo2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCodAlterno2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDescripcion2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cEliminar As System.Windows.Forms.DataGridViewButtonColumn
End Class
