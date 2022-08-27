<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarRespuestaReceptor
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtXML = New System.Windows.Forms.TextBox()
        Me.txtPDF = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.ofdXML = New System.Windows.Forms.OpenFileDialog()
        Me.ofdPDF = New System.Windows.Forms.OpenFileDialog()
        Me.viewDatosXML = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBuscarXML = New System.Windows.Forms.Button()
        Me.cClave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNumeroCedulaEmisor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMontoTotalImpuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTotalFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNumeroCedulaReceptor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMensaje = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cFechaComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.viewDatosXML, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar XML Factura Compra o Gasto"
        '
        'txtXML
        '
        Me.txtXML.Location = New System.Drawing.Point(44, 29)
        Me.txtXML.Name = "txtXML"
        Me.txtXML.ReadOnly = True
        Me.txtXML.Size = New System.Drawing.Size(491, 20)
        Me.txtXML.TabIndex = 2
        '
        'txtPDF
        '
        Me.txtPDF.Location = New System.Drawing.Point(44, 82)
        Me.txtPDF.Name = "txtPDF"
        Me.txtPDF.ReadOnly = True
        Me.txtPDF.Size = New System.Drawing.Size(491, 20)
        Me.txtPDF.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Buscar PDF Factura Compra o Gasto"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(403, 170)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(132, 40)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(263, 170)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(132, 40)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Aceptado"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'ofdXML
        '
        Me.ofdXML.Filter = "xml files (*.xml)|*.xml"
        '
        'ofdPDF
        '
        Me.ofdPDF.Filter = "pdf files (*.pdf)|*.pdf"
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
        Me.viewDatosXML.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.viewDatosXML.BackgroundColor = System.Drawing.Color.White
        Me.viewDatosXML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatosXML.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cClave, Me.cNumeroCedulaEmisor, Me.cNombre, Me.cMontoTotalImpuesto, Me.cTotalFactura, Me.cNumeroCedulaReceptor, Me.cMensaje, Me.cFechaComprobante})
        Me.viewDatosXML.Location = New System.Drawing.Point(15, 109)
        Me.viewDatosXML.Name = "viewDatosXML"
        Me.viewDatosXML.RowHeadersVisible = False
        Me.viewDatosXML.Size = New System.Drawing.Size(520, 55)
        Me.viewDatosXML.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Image = Global.LcPymes_5._2.My.Resources.Resources.page_find
        Me.Button1.Location = New System.Drawing.Point(12, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnBuscarXML
        '
        Me.btnBuscarXML.Image = Global.LcPymes_5._2.My.Resources.Resources.page_find
        Me.btnBuscarXML.Location = New System.Drawing.Point(12, 27)
        Me.btnBuscarXML.Name = "btnBuscarXML"
        Me.btnBuscarXML.Size = New System.Drawing.Size(26, 23)
        Me.btnBuscarXML.TabIndex = 0
        Me.btnBuscarXML.UseVisualStyleBackColor = True
        '
        'cClave
        '
        Me.cClave.HeaderText = "Clave"
        Me.cClave.Name = "cClave"
        Me.cClave.ReadOnly = True
        Me.cClave.Visible = False
        '
        'cNumeroCedulaEmisor
        '
        Me.cNumeroCedulaEmisor.HeaderText = "NumeroCedulaEmisor"
        Me.cNumeroCedulaEmisor.Name = "cNumeroCedulaEmisor"
        Me.cNumeroCedulaEmisor.ReadOnly = True
        Me.cNumeroCedulaEmisor.Visible = False
        '
        'cNombre
        '
        Me.cNombre.HeaderText = "Proveedor"
        Me.cNombre.Name = "cNombre"
        Me.cNombre.ReadOnly = True
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
        Me.cMensaje.Visible = False
        '
        'cFechaComprobante
        '
        Me.cFechaComprobante.HeaderText = "FechaComprobante"
        Me.cFechaComprobante.Name = "cFechaComprobante"
        '
        'frmAgregarRespuestaReceptor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 216)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtPDF)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtXML)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuscarXML)
        Me.Controls.Add(Me.viewDatosXML)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAgregarRespuestaReceptor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Respuesta Receptor"
        CType(Me.viewDatosXML, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscarXML As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtXML As System.Windows.Forms.TextBox
    Friend WithEvents txtPDF As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents ofdXML As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ofdPDF As System.Windows.Forms.OpenFileDialog
    Friend WithEvents viewDatosXML As System.Windows.Forms.DataGridView
    Friend WithEvents cClave As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNumeroCedulaEmisor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMontoTotalImpuesto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTotalFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNumeroCedulaReceptor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMensaje As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cFechaComprobante As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
