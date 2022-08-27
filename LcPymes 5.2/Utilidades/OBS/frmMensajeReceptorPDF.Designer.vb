<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMensajeReceptorPDF
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.viewDatosXML = New System.Windows.Forms.DataGridView()
        Me.cClave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNumeroCedulaEmisor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMontoTotalImpuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTotalFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNumeroCedulaReceptor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMensaje = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.viewDatosXML, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'viewDatosXML
        '
        Me.viewDatosXML.AllowUserToAddRows = False
        Me.viewDatosXML.AllowUserToDeleteRows = False
        Me.viewDatosXML.AllowUserToResizeColumns = False
        Me.viewDatosXML.AllowUserToResizeRows = False
        Me.viewDatosXML.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewDatosXML.BackgroundColor = System.Drawing.Color.White
        Me.viewDatosXML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatosXML.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cClave, Me.cNumeroCedulaEmisor, Me.cNombre, Me.cMontoTotalImpuesto, Me.cTotalFactura, Me.cNumeroCedulaReceptor, Me.cMensaje})
        Me.viewDatosXML.Location = New System.Drawing.Point(2, 49)
        Me.viewDatosXML.Name = "viewDatosXML"
        Me.viewDatosXML.RowHeadersVisible = False
        Me.viewDatosXML.Size = New System.Drawing.Size(878, 322)
        Me.viewDatosXML.TabIndex = 0
        '
        'cClave
        '
        Me.cClave.HeaderText = "Clave"
        Me.cClave.Name = "cClave"
        Me.cClave.ReadOnly = True
        Me.cClave.Width = 320
        '
        'cNumeroCedulaEmisor
        '
        Me.cNumeroCedulaEmisor.HeaderText = "NumeroCedulaEmisor"
        Me.cNumeroCedulaEmisor.Name = "cNumeroCedulaEmisor"
        Me.cNumeroCedulaEmisor.ReadOnly = True
        Me.cNumeroCedulaEmisor.Visible = False
        Me.cNumeroCedulaEmisor.Width = 150
        '
        'cNombre
        '
        Me.cNombre.HeaderText = "Proveedor"
        Me.cNombre.Name = "cNombre"
        Me.cNombre.ReadOnly = True
        Me.cNombre.Width = 230
        '
        'cMontoTotalImpuesto
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.cMontoTotalImpuesto.DefaultCellStyle = DataGridViewCellStyle1
        Me.cMontoTotalImpuesto.HeaderText = "Total Impuesto"
        Me.cMontoTotalImpuesto.Name = "cMontoTotalImpuesto"
        Me.cMontoTotalImpuesto.ReadOnly = True
        '
        'cTotalFactura
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.cTotalFactura.DefaultCellStyle = DataGridViewCellStyle2
        Me.cTotalFactura.HeaderText = "Total Factura"
        Me.cTotalFactura.Name = "cTotalFactura"
        Me.cTotalFactura.ReadOnly = True
        '
        'cNumeroCedulaReceptor
        '
        Me.cNumeroCedulaReceptor.HeaderText = "NumeroCedulaReceptor"
        Me.cNumeroCedulaReceptor.Name = "cNumeroCedulaReceptor"
        Me.cNumeroCedulaReceptor.ReadOnly = True
        Me.cNumeroCedulaReceptor.Visible = False
        '
        'cMensaje
        '
        Me.cMensaje.HeaderText = "Mensaje"
        Me.cMensaje.Items.AddRange(New Object() {"ACEPTADO", "RECHAZADO"})
        Me.cMensaje.Name = "cMensaje"
        Me.cMensaje.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cMensaje.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'btnImportar
        '
        Me.btnImportar.Location = New System.Drawing.Point(2, 6)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(269, 36)
        Me.btnImportar.TabIndex = 1
        Me.btnImportar.Text = "Importar  XML de Facturas de Compras y Gastos"
        Me.btnImportar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(693, 373)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(187, 36)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(500, 373)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(187, 36)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "xml files (*.xml)|*.xml"
        Me.OpenFileDialog1.Multiselect = True
        '
        'frmMensajeReceptor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 410)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnImportar)
        Me.Controls.Add(Me.viewDatosXML)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMensajeReceptor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mensaje Receptor"
        CType(Me.viewDatosXML, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents viewDatosXML As System.Windows.Forms.DataGridView
    Friend WithEvents btnImportar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cClave As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNumeroCedulaEmisor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMontoTotalImpuesto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTotalFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNumeroCedulaReceptor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMensaje As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
