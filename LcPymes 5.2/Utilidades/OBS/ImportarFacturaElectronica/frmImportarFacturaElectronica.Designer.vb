<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportarFacturaElectronica
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtConsecutivo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnInventario = New System.Windows.Forms.Button()
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
        Me.cPrecioIva1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrecioIva2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrecioIva3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCantidadxPresentacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCabys = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cFlete = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImportar
        '
        Me.btnImportar.Location = New System.Drawing.Point(16, 14)
        Me.btnImportar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(299, 44)
        Me.btnImportar.TabIndex = 2
        Me.btnImportar.Text = "Importar  XML de la Factura"
        Me.btnImportar.UseVisualStyleBackColor = True
        '
        'viewDatos
        '
        Me.viewDatos.AllowUserToAddRows = False
        Me.viewDatos.AllowUserToDeleteRows = False
        Me.viewDatos.AllowUserToResizeColumns = False
        Me.viewDatos.AllowUserToResizeRows = False
        Me.viewDatos.BackgroundColor = System.Drawing.Color.White
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cCodigoProveedor, Me.cDescripcion, Me.cBuscaCodigoInterno, Me.cId_ArticuloInterno, Me.cCodigoInterno, Me.cDescripcionInterno, Me.cPresentacion, Me.cCantidad, Me.cCosto, Me.cDescuento, Me.cMontoDescuento, Me.cImpuesto, Me.cPrecioIva1, Me.cPrecioIva2, Me.cPrecioIva3, Me.cCantidadxPresentacion, Me.cCabys, Me.cFlete})
        Me.viewDatos.Location = New System.Drawing.Point(16, 121)
        Me.viewDatos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.viewDatos.MultiSelect = False
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.RowTemplate.Height = 28
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(1244, 335)
        Me.viewDatos.TabIndex = 3
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(16, 89)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.ReadOnly = True
        Me.txtCedula.Size = New System.Drawing.Size(165, 22)
        Me.txtCedula.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cedula"
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(191, 89)
        Me.txtProveedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(413, 22)
        Me.txtProveedor.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(624, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Fecha"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(628, 89)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(241, 22)
        Me.txtFecha.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(191, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Proveedor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(327, 14)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Consecutivo"
        '
        'txtConsecutivo
        '
        Me.txtConsecutivo.Location = New System.Drawing.Point(327, 33)
        Me.txtConsecutivo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtConsecutivo.Name = "txtConsecutivo"
        Me.txtConsecutivo.ReadOnly = True
        Me.txtConsecutivo.Size = New System.Drawing.Size(277, 22)
        Me.txtConsecutivo.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(628, 14)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Clave"
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(628, 33)
        Me.txtClave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.ReadOnly = True
        Me.txtClave.Size = New System.Drawing.Size(492, 22)
        Me.txtClave.TabIndex = 14
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "xml files (*.xml)|*.xml"
        Me.OpenFileDialog1.Multiselect = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(1027, 463)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(233, 44)
        Me.btnCancelar.TabIndex = 16
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(785, 463)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(233, 44)
        Me.btnAceptar.TabIndex = 17
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'cboEstado
        '
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"ACEPTADO", "RECHAZADO"})
        Me.cboEstado.Location = New System.Drawing.Point(879, 87)
        Me.cboEstado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(241, 24)
        Me.cboEstado.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(879, 69)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 17)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Estado de Compra"
        '
        'btnInventario
        '
        Me.btnInventario.Location = New System.Drawing.Point(16, 463)
        Me.btnInventario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(299, 44)
        Me.btnInventario.TabIndex = 21
        Me.btnInventario.Text = "Catalogo de Inventario"
        Me.btnInventario.UseVisualStyleBackColor = True
        '
        'cCodigoProveedor
        '
        Me.cCodigoProveedor.HeaderText = "Codigo proveedor"
        Me.cCodigoProveedor.Name = "cCodigoProveedor"
        Me.cCodigoProveedor.ReadOnly = True
        Me.cCodigoProveedor.Width = 110
        '
        'cDescripcion
        '
        Me.cDescripcion.HeaderText = "Descripcion Proveedor"
        Me.cDescripcion.Name = "cDescripcion"
        Me.cDescripcion.ReadOnly = True
        Me.cDescripcion.Width = 240
        '
        'cBuscaCodigoInterno
        '
        Me.cBuscaCodigoInterno.HeaderText = ""
        Me.cBuscaCodigoInterno.Name = "cBuscaCodigoInterno"
        Me.cBuscaCodigoInterno.ReadOnly = True
        Me.cBuscaCodigoInterno.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cBuscaCodigoInterno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cBuscaCodigoInterno.Width = 25
        '
        'cId_ArticuloInterno
        '
        Me.cId_ArticuloInterno.HeaderText = "IdArticuloInterno"
        Me.cId_ArticuloInterno.Name = "cId_ArticuloInterno"
        Me.cId_ArticuloInterno.ReadOnly = True
        Me.cId_ArticuloInterno.Visible = False
        '
        'cCodigoInterno
        '
        Me.cCodigoInterno.HeaderText = "Codigo Interno"
        Me.cCodigoInterno.Name = "cCodigoInterno"
        Me.cCodigoInterno.ReadOnly = True
        Me.cCodigoInterno.Width = 110
        '
        'cDescripcionInterno
        '
        Me.cDescripcionInterno.HeaderText = "Descripcion Interna"
        Me.cDescripcionInterno.Name = "cDescripcionInterno"
        Me.cDescripcionInterno.ReadOnly = True
        Me.cDescripcionInterno.Width = 240
        '
        'cPresentacion
        '
        Me.cPresentacion.HeaderText = "Presentacion"
        Me.cPresentacion.Name = "cPresentacion"
        Me.cPresentacion.ReadOnly = True
        Me.cPresentacion.Width = 75
        '
        'cCantidad
        '
        Me.cCantidad.HeaderText = "Cantidad"
        Me.cCantidad.Name = "cCantidad"
        Me.cCantidad.ReadOnly = True
        Me.cCantidad.Visible = False
        '
        'cCosto
        '
        Me.cCosto.HeaderText = "Costo"
        Me.cCosto.Name = "cCosto"
        Me.cCosto.ReadOnly = True
        Me.cCosto.Visible = False
        '
        'cDescuento
        '
        Me.cDescuento.HeaderText = "Descuento"
        Me.cDescuento.Name = "cDescuento"
        Me.cDescuento.ReadOnly = True
        Me.cDescuento.Visible = False
        '
        'cMontoDescuento
        '
        Me.cMontoDescuento.HeaderText = "MontoDescuento"
        Me.cMontoDescuento.Name = "cMontoDescuento"
        Me.cMontoDescuento.ReadOnly = True
        Me.cMontoDescuento.Visible = False
        '
        'cImpuesto
        '
        Me.cImpuesto.HeaderText = "Impuesto"
        Me.cImpuesto.Name = "cImpuesto"
        Me.cImpuesto.ReadOnly = True
        Me.cImpuesto.Visible = False
        '
        'cPrecioIva1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        Me.cPrecioIva1.DefaultCellStyle = DataGridViewCellStyle1
        Me.cPrecioIva1.HeaderText = "PrecioIva1"
        Me.cPrecioIva1.Name = "cPrecioIva1"
        Me.cPrecioIva1.ReadOnly = True
        Me.cPrecioIva1.Visible = False
        '
        'cPrecioIva2
        '
        Me.cPrecioIva2.HeaderText = "PrecioIva2"
        Me.cPrecioIva2.Name = "cPrecioIva2"
        Me.cPrecioIva2.ReadOnly = True
        Me.cPrecioIva2.Visible = False
        '
        'cPrecioIva3
        '
        Me.cPrecioIva3.HeaderText = "PrecioIva3"
        Me.cPrecioIva3.Name = "cPrecioIva3"
        Me.cPrecioIva3.ReadOnly = True
        Me.cPrecioIva3.Visible = False
        '
        'cCantidadxPresentacion
        '
        Me.cCantidadxPresentacion.HeaderText = "Cantidad por Presentacion"
        Me.cCantidadxPresentacion.Name = "cCantidadxPresentacion"
        '
        'cCabys
        '
        Me.cCabys.HeaderText = "Cabys"
        Me.cCabys.Name = "cCabys"
        Me.cCabys.Visible = False
        '
        'cFlete
        '
        Me.cFlete.HeaderText = "Flete"
        Me.cFlete.Name = "cFlete"
        Me.cFlete.Visible = False
        '
        'frmImportarFacturaElectronica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1275, 510)
        Me.Controls.Add(Me.btnInventario)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtConsecutivo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.viewDatos)
        Me.Controls.Add(Me.btnImportar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImportarFacturaElectronica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar Factura Electronica"
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnImportar As System.Windows.Forms.Button
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtConsecutivo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents cboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnInventario As System.Windows.Forms.Button
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
    Friend WithEvents cPrecioIva1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPrecioIva2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPrecioIva3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCantidadxPresentacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCabys As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cFlete As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
