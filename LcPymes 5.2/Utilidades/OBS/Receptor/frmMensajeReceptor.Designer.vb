<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMensajeReceptor
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.viewDatosXML = New System.Windows.Forms.DataGridView()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnValidarComprobantes = New System.Windows.Forms.Button()
        Me.btnQuitarRechazados = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblCarpetaXML = New System.Windows.Forms.Label()
        Me.ckInformar = New System.Windows.Forms.CheckBox()
        Me.ckBorrar = New System.Windows.Forms.CheckBox()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cTipo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cClave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNumeroCedulaEmisor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMontoTotalImpuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTotalFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNumeroCedulaReceptor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMensaje = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cDetalleMensaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCodigoActividad = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cCondicionImpuesto = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cMontoTotalImpuestoAcreditar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMontoTotaldeGastoAplicable = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.viewDatosXML.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cTipo, Me.cClave, Me.cNumeroCedulaEmisor, Me.cNombre, Me.cMontoTotalImpuesto, Me.cTotalFactura, Me.cNumeroCedulaReceptor, Me.cMensaje, Me.cDetalleMensaje, Me.cCodigoActividad, Me.cCondicionImpuesto, Me.cMontoTotalImpuestoAcreditar, Me.cMontoTotaldeGastoAplicable})
        Me.viewDatosXML.Location = New System.Drawing.Point(2, 65)
        Me.viewDatosXML.Name = "viewDatosXML"
        Me.viewDatosXML.RowHeadersVisible = False
        Me.viewDatosXML.Size = New System.Drawing.Size(1138, 336)
        Me.viewDatosXML.TabIndex = 0
        '
        'btnImportar
        '
        Me.btnImportar.Location = New System.Drawing.Point(89, 6)
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
        Me.btnCancelar.Location = New System.Drawing.Point(953, 405)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(187, 36)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(760, 405)
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
        'btnValidarComprobantes
        '
        Me.btnValidarComprobantes.Location = New System.Drawing.Point(664, 6)
        Me.btnValidarComprobantes.Name = "btnValidarComprobantes"
        Me.btnValidarComprobantes.Size = New System.Drawing.Size(222, 36)
        Me.btnValidarComprobantes.TabIndex = 4
        Me.btnValidarComprobantes.Text = "Validar Comprobantes Electronicos"
        Me.btnValidarComprobantes.UseVisualStyleBackColor = True
        '
        'btnQuitarRechazados
        '
        Me.btnQuitarRechazados.Enabled = False
        Me.btnQuitarRechazados.Location = New System.Drawing.Point(889, 6)
        Me.btnQuitarRechazados.Name = "btnQuitarRechazados"
        Me.btnQuitarRechazados.Size = New System.Drawing.Size(222, 36)
        Me.btnQuitarRechazados.TabIndex = 5
        Me.btnQuitarRechazados.Text = "Quitar Comprobantes Rechazados"
        Me.btnQuitarRechazados.UseVisualStyleBackColor = True
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Selecciones la carpeta que contiene los XML"
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(2, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 36)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Elegir Carpeta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblCarpetaXML
        '
        Me.lblCarpetaXML.AutoSize = True
        Me.lblCarpetaXML.Location = New System.Drawing.Point(2, 45)
        Me.lblCarpetaXML.Name = "lblCarpetaXML"
        Me.lblCarpetaXML.Size = New System.Drawing.Size(0, 13)
        Me.lblCarpetaXML.TabIndex = 7
        '
        'ckInformar
        '
        Me.ckInformar.AutoSize = True
        Me.ckInformar.Location = New System.Drawing.Point(364, 6)
        Me.ckInformar.Name = "ckInformar"
        Me.ckInformar.Size = New System.Drawing.Size(157, 17)
        Me.ckInformar.TabIndex = 8
        Me.ckInformar.Text = "Informar XML ya ingresados"
        Me.ckInformar.UseVisualStyleBackColor = True
        '
        'ckBorrar
        '
        Me.ckBorrar.AutoSize = True
        Me.ckBorrar.Location = New System.Drawing.Point(364, 25)
        Me.ckBorrar.Name = "ckBorrar"
        Me.ckBorrar.Size = New System.Drawing.Size(147, 17)
        Me.ckBorrar.TabIndex = 9
        Me.ckBorrar.Text = "Borrar XML ya ingresados"
        Me.ckBorrar.UseVisualStyleBackColor = True
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"Compra", "Gasto"})
        Me.cboTipo.Location = New System.Drawing.Point(527, 21)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(121, 21)
        Me.cboTipo.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(528, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Valor por Defecto :"
        '
        'cTipo
        '
        Me.cTipo.HeaderText = "Tipo"
        Me.cTipo.Items.AddRange(New Object() {"Compra", "Gasto"})
        Me.cTipo.Name = "cTipo"
        Me.cTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'cClave
        '
        Me.cClave.HeaderText = "Clave"
        Me.cClave.Name = "cClave"
        Me.cClave.ReadOnly = True
        Me.cClave.Visible = False
        Me.cClave.Width = 250
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
        Me.cNombre.Width = 200
        '
        'cMontoTotalImpuesto
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.cMontoTotalImpuesto.DefaultCellStyle = DataGridViewCellStyle13
        Me.cMontoTotalImpuesto.HeaderText = "Total Impuesto"
        Me.cMontoTotalImpuesto.Name = "cMontoTotalImpuesto"
        Me.cMontoTotalImpuesto.ReadOnly = True
        '
        'cTotalFactura
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.cTotalFactura.DefaultCellStyle = DataGridViewCellStyle14
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
        'cDetalleMensaje
        '
        Me.cDetalleMensaje.HeaderText = "Detalle del Mensaje"
        Me.cDetalleMensaje.Name = "cDetalleMensaje"
        '
        'cCodigoActividad
        '
        Me.cCodigoActividad.DropDownWidth = 350
        Me.cCodigoActividad.HeaderText = "Codigo Actividad"
        Me.cCodigoActividad.Name = "cCodigoActividad"
        Me.cCodigoActividad.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'cCondicionImpuesto
        '
        Me.cCondicionImpuesto.DropDownWidth = 350
        Me.cCondicionImpuesto.HeaderText = "CondicionImpuesto"
        Me.cCondicionImpuesto.Name = "cCondicionImpuesto"
        Me.cCondicionImpuesto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cCondicionImpuesto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'cMontoTotalImpuestoAcreditar
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N2"
        Me.cMontoTotalImpuestoAcreditar.DefaultCellStyle = DataGridViewCellStyle15
        Me.cMontoTotalImpuestoAcreditar.HeaderText = "Impuesto Acreditable"
        Me.cMontoTotalImpuestoAcreditar.Name = "cMontoTotalImpuestoAcreditar"
        '
        'cMontoTotaldeGastoAplicable
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "N2"
        Me.cMontoTotaldeGastoAplicable.DefaultCellStyle = DataGridViewCellStyle16
        Me.cMontoTotaldeGastoAplicable.HeaderText = "Gasto Aplicable"
        Me.cMontoTotaldeGastoAplicable.Name = "cMontoTotaldeGastoAplicable"
        '
        'frmMensajeReceptor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1142, 444)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.ckBorrar)
        Me.Controls.Add(Me.ckInformar)
        Me.Controls.Add(Me.lblCarpetaXML)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnQuitarRechazados)
        Me.Controls.Add(Me.btnValidarComprobantes)
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
        Me.PerformLayout()

    End Sub
    Friend WithEvents viewDatosXML As System.Windows.Forms.DataGridView
    Friend WithEvents btnImportar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnValidarComprobantes As System.Windows.Forms.Button
    Friend WithEvents btnQuitarRechazados As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblCarpetaXML As System.Windows.Forms.Label
    Friend WithEvents ckInformar As System.Windows.Forms.CheckBox
    Friend WithEvents ckBorrar As System.Windows.Forms.CheckBox
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cTipo As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cClave As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNumeroCedulaEmisor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMontoTotalImpuesto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTotalFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNumeroCedulaReceptor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMensaje As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cDetalleMensaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCodigoActividad As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cCondicionImpuesto As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cMontoTotalImpuestoAcreditar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMontoTotaldeGastoAplicable As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
