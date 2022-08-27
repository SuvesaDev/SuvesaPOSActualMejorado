<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargarCabys
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
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.cCodigoProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cBuscaCodigoInterno = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cId_ArticuloInterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCodigoInterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDescripcionInterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPresentacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMontoDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cImpuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMontoImpuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMontoOtroImpuestos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrecioIva1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrecioIva2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrecioIva3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCantidadxPresentacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrecioFraccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCodigoCabys = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImportar
        '
        Me.btnImportar.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportar.Location = New System.Drawing.Point(22, 12)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(191, 86)
        Me.btnImportar.TabIndex = 0
        Me.btnImportar.Text = "Importar Archivos"
        Me.btnImportar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "xml files (*.xml)|*.xml"
        Me.OpenFileDialog1.Multiselect = True
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
        Me.viewDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.viewDatos.BackgroundColor = System.Drawing.Color.White
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cCodigoProveedor, Me.cDescripcion, Me.cBuscaCodigoInterno, Me.cId_ArticuloInterno, Me.cCodigoInterno, Me.cDescripcionInterno, Me.cPresentacion, Me.cCantidad, Me.cCosto, Me.cDescuento, Me.cMontoDescuento, Me.cImpuesto, Me.cMontoImpuesto, Me.cMontoOtroImpuestos, Me.cPrecioIva1, Me.cPrecioIva2, Me.cPrecioIva3, Me.cCantidadxPresentacion, Me.cPrecioFraccion, Me.cCodigoCabys})
        Me.viewDatos.Location = New System.Drawing.Point(39, 106)
        Me.viewDatos.MultiSelect = False
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.RowTemplate.Height = 28
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(138, 99)
        Me.viewDatos.TabIndex = 4
        '
        'cCodigoProveedor
        '
        Me.cCodigoProveedor.HeaderText = "Codigo proveedor"
        Me.cCodigoProveedor.Name = "cCodigoProveedor"
        Me.cCodigoProveedor.ReadOnly = True
        Me.cCodigoProveedor.Width = 106
        '
        'cDescripcion
        '
        Me.cDescripcion.HeaderText = "Descripcion Proveedor"
        Me.cDescripcion.Name = "cDescripcion"
        Me.cDescripcion.ReadOnly = True
        Me.cDescripcion.Width = 128
        '
        'cBuscaCodigoInterno
        '
        Me.cBuscaCodigoInterno.HeaderText = ""
        Me.cBuscaCodigoInterno.Name = "cBuscaCodigoInterno"
        Me.cBuscaCodigoInterno.ReadOnly = True
        Me.cBuscaCodigoInterno.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cBuscaCodigoInterno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cBuscaCodigoInterno.Width = 19
        '
        'cId_ArticuloInterno
        '
        Me.cId_ArticuloInterno.HeaderText = "IdArticuloInterno"
        Me.cId_ArticuloInterno.Name = "cId_ArticuloInterno"
        Me.cId_ArticuloInterno.ReadOnly = True
        Me.cId_ArticuloInterno.Visible = False
        Me.cId_ArticuloInterno.Width = 109
        '
        'cCodigoInterno
        '
        Me.cCodigoInterno.HeaderText = "Codigo Interno"
        Me.cCodigoInterno.Name = "cCodigoInterno"
        Me.cCodigoInterno.ReadOnly = True
        Me.cCodigoInterno.Width = 93
        '
        'cDescripcionInterno
        '
        Me.cDescripcionInterno.HeaderText = "Descripcion Interna"
        Me.cDescripcionInterno.Name = "cDescripcionInterno"
        Me.cDescripcionInterno.ReadOnly = True
        Me.cDescripcionInterno.Width = 114
        '
        'cPresentacion
        '
        Me.cPresentacion.HeaderText = "Presentacion"
        Me.cPresentacion.Name = "cPresentacion"
        Me.cPresentacion.ReadOnly = True
        Me.cPresentacion.Width = 94
        '
        'cCantidad
        '
        Me.cCantidad.HeaderText = "Cantidad"
        Me.cCantidad.Name = "cCantidad"
        Me.cCantidad.ReadOnly = True
        Me.cCantidad.Visible = False
        Me.cCantidad.Width = 74
        '
        'cCosto
        '
        Me.cCosto.HeaderText = "Costo"
        Me.cCosto.Name = "cCosto"
        Me.cCosto.ReadOnly = True
        Me.cCosto.Visible = False
        Me.cCosto.Width = 59
        '
        'cDescuento
        '
        Me.cDescuento.HeaderText = "Descuento"
        Me.cDescuento.Name = "cDescuento"
        Me.cDescuento.ReadOnly = True
        Me.cDescuento.Visible = False
        Me.cDescuento.Width = 84
        '
        'cMontoDescuento
        '
        Me.cMontoDescuento.HeaderText = "MontoDescuento"
        Me.cMontoDescuento.Name = "cMontoDescuento"
        Me.cMontoDescuento.ReadOnly = True
        Me.cMontoDescuento.Visible = False
        Me.cMontoDescuento.Width = 114
        '
        'cImpuesto
        '
        Me.cImpuesto.HeaderText = "Impuesto"
        Me.cImpuesto.Name = "cImpuesto"
        Me.cImpuesto.ReadOnly = True
        Me.cImpuesto.Visible = False
        Me.cImpuesto.Width = 75
        '
        'cMontoImpuesto
        '
        Me.cMontoImpuesto.HeaderText = "MontoImpuesto"
        Me.cMontoImpuesto.Name = "cMontoImpuesto"
        Me.cMontoImpuesto.Visible = False
        Me.cMontoImpuesto.Width = 105
        '
        'cMontoOtroImpuestos
        '
        Me.cMontoOtroImpuestos.HeaderText = "MontoOtrosImpuestos"
        Me.cMontoOtroImpuestos.Name = "cMontoOtroImpuestos"
        Me.cMontoOtroImpuestos.Visible = False
        Me.cMontoOtroImpuestos.Width = 135
        '
        'cPrecioIva1
        '
        Me.cPrecioIva1.HeaderText = "PrecioIva1"
        Me.cPrecioIva1.Name = "cPrecioIva1"
        Me.cPrecioIva1.ReadOnly = True
        Me.cPrecioIva1.Visible = False
        Me.cPrecioIva1.Width = 83
        '
        'cPrecioIva2
        '
        Me.cPrecioIva2.HeaderText = "PrecioIva2"
        Me.cPrecioIva2.Name = "cPrecioIva2"
        Me.cPrecioIva2.ReadOnly = True
        Me.cPrecioIva2.Visible = False
        Me.cPrecioIva2.Width = 83
        '
        'cPrecioIva3
        '
        Me.cPrecioIva3.HeaderText = "PrecioIva3"
        Me.cPrecioIva3.Name = "cPrecioIva3"
        Me.cPrecioIva3.ReadOnly = True
        Me.cPrecioIva3.Visible = False
        Me.cPrecioIva3.Width = 83
        '
        'cCantidadxPresentacion
        '
        Me.cCantidadxPresentacion.HeaderText = "Cantidad por Presentacion"
        Me.cCantidadxPresentacion.Name = "cCantidadxPresentacion"
        Me.cCantidadxPresentacion.Width = 143
        '
        'cPrecioFraccion
        '
        Me.cPrecioFraccion.HeaderText = "PrecioFraccion"
        Me.cPrecioFraccion.Name = "cPrecioFraccion"
        Me.cPrecioFraccion.Visible = False
        Me.cPrecioFraccion.Width = 103
        '
        'cCodigoCabys
        '
        Me.cCodigoCabys.HeaderText = "CodigoCabys"
        Me.cCodigoCabys.Name = "cCodigoCabys"
        Me.cCodigoCabys.Visible = False
        Me.cCodigoCabys.Width = 94
        '
        'frmCargarCabys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(235, 123)
        Me.Controls.Add(Me.viewDatos)
        Me.Controls.Add(Me.btnImportar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCargarCabys"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargar Cabys"
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnImportar As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents cCodigoProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cBuscaCodigoInterno As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cId_ArticuloInterno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCodigoInterno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDescripcionInterno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPresentacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDescuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMontoDescuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cImpuesto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMontoImpuesto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMontoOtroImpuestos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPrecioIva1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPrecioIva2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPrecioIva3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCantidadxPresentacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPrecioFraccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCodigoCabys As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
