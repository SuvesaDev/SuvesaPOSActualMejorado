<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresarFomasdePago
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
        Me.btnChequeColones = New System.Windows.Forms.Button()
        Me.btnTarjetaColones = New System.Windows.Forms.Button()
        Me.btnTransferencia = New System.Windows.Forms.Button()
        Me.btnEfectivoColones = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPendienteCobro = New System.Windows.Forms.Label()
        Me.lblTotalCobro = New System.Windows.Forms.Label()
        Me.lblPagado = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnEfectivoDolares = New System.Windows.Forms.Button()
        Me.btnChequeDolares = New System.Windows.Forms.Button()
        Me.DataSet_Facturaciones1 = New LcPymes_5._2.DataSet_Facturaciones()
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.cDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTipoDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMontoPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cFormaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDenominacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCodMoneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNombreMoneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTipoCambio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNumApertura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNumeroDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPendientes = New System.Windows.Forms.Button()
        Me.lblTipodeCambio = New System.Windows.Forms.Label()
        Me.btnOtrasTarjetas = New System.Windows.Forms.Button()
        CType(Me.DataSet_Facturaciones1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnChequeColones
        '
        Me.btnChequeColones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChequeColones.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChequeColones.Location = New System.Drawing.Point(14, 291)
        Me.btnChequeColones.Name = "btnChequeColones"
        Me.btnChequeColones.Size = New System.Drawing.Size(204, 100)
        Me.btnChequeColones.TabIndex = 3
        Me.btnChequeColones.TabStop = False
        Me.btnChequeColones.Text = "Cheque " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Colones"
        Me.btnChequeColones.UseVisualStyleBackColor = True
        '
        'btnTarjetaColones
        '
        Me.btnTarjetaColones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTarjetaColones.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTarjetaColones.Location = New System.Drawing.Point(14, 165)
        Me.btnTarjetaColones.Name = "btnTarjetaColones"
        Me.btnTarjetaColones.Size = New System.Drawing.Size(204, 100)
        Me.btnTarjetaColones.TabIndex = 4
        Me.btnTarjetaColones.TabStop = False
        Me.btnTarjetaColones.Text = "Tarjeta " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Colones"
        Me.btnTarjetaColones.UseVisualStyleBackColor = True
        '
        'btnTransferencia
        '
        Me.btnTransferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransferencia.Location = New System.Drawing.Point(245, 32)
        Me.btnTransferencia.Name = "btnTransferencia"
        Me.btnTransferencia.Size = New System.Drawing.Size(204, 100)
        Me.btnTransferencia.TabIndex = 5
        Me.btnTransferencia.TabStop = False
        Me.btnTransferencia.Text = "Transferencia"
        Me.btnTransferencia.UseVisualStyleBackColor = True
        '
        'btnEfectivoColones
        '
        Me.btnEfectivoColones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEfectivoColones.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEfectivoColones.Location = New System.Drawing.Point(14, 32)
        Me.btnEfectivoColones.Name = "btnEfectivoColones"
        Me.btnEfectivoColones.Size = New System.Drawing.Size(204, 100)
        Me.btnEfectivoColones.TabIndex = 6
        Me.btnEfectivoColones.TabStop = False
        Me.btnEfectivoColones.Text = "Efectivo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Colones "
        Me.btnEfectivoColones.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(481, 321)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Total a Cobrar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(482, 361)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Pendiente Cobro"
        '
        'lblPendienteCobro
        '
        Me.lblPendienteCobro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendienteCobro.Location = New System.Drawing.Point(615, 361)
        Me.lblPendienteCobro.Name = "lblPendienteCobro"
        Me.lblPendienteCobro.Size = New System.Drawing.Size(93, 20)
        Me.lblPendienteCobro.TabIndex = 10
        Me.lblPendienteCobro.Text = "7,000.00"
        Me.lblPendienteCobro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalCobro
        '
        Me.lblTotalCobro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCobro.Location = New System.Drawing.Point(615, 321)
        Me.lblTotalCobro.Name = "lblTotalCobro"
        Me.lblTotalCobro.Size = New System.Drawing.Size(93, 20)
        Me.lblTotalCobro.TabIndex = 9
        Me.lblTotalCobro.Text = "10.000.00"
        Me.lblTotalCobro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPagado
        '
        Me.lblPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagado.Location = New System.Drawing.Point(615, 341)
        Me.lblPagado.Name = "lblPagado"
        Me.lblPagado.Size = New System.Drawing.Size(93, 20)
        Me.lblPagado.TabIndex = 12
        Me.lblPagado.Text = "3.000.00"
        Me.lblPagado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(482, 341)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Pagado"
        '
        'btnEfectivoDolares
        '
        Me.btnEfectivoDolares.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEfectivoDolares.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEfectivoDolares.Location = New System.Drawing.Point(485, 32)
        Me.btnEfectivoDolares.Name = "btnEfectivoDolares"
        Me.btnEfectivoDolares.Size = New System.Drawing.Size(204, 100)
        Me.btnEfectivoDolares.TabIndex = 13
        Me.btnEfectivoDolares.TabStop = False
        Me.btnEfectivoDolares.Text = "Efectivo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dolares"
        Me.btnEfectivoDolares.UseVisualStyleBackColor = True
        '
        'btnChequeDolares
        '
        Me.btnChequeDolares.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChequeDolares.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChequeDolares.Location = New System.Drawing.Point(245, 291)
        Me.btnChequeDolares.Name = "btnChequeDolares"
        Me.btnChequeDolares.Size = New System.Drawing.Size(204, 100)
        Me.btnChequeDolares.TabIndex = 14
        Me.btnChequeDolares.TabStop = False
        Me.btnChequeDolares.Text = "Cheque " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dolares"
        Me.btnChequeDolares.UseVisualStyleBackColor = True
        '
        'DataSet_Facturaciones1
        '
        Me.DataSet_Facturaciones1.DataSetName = "DataSet_Facturaciones"
        Me.DataSet_Facturaciones1.Locale = New System.Globalization.CultureInfo("es-MX")
        Me.DataSet_Facturaciones1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'viewDatos
        '
        Me.viewDatos.AllowUserToAddRows = False
        Me.viewDatos.AllowUserToDeleteRows = False
        Me.viewDatos.AllowUserToResizeColumns = False
        Me.viewDatos.AllowUserToResizeRows = False
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cDocumento, Me.cTipoDocumento, Me.cMontoPago, Me.cFormaPago, Me.cDenominacion, Me.cUsuario, Me.cNombre, Me.cCodMoneda, Me.cNombreMoneda, Me.cTipoCambio, Me.cFecha, Me.cNumApertura, Me.cNumeroDocumento})
        Me.viewDatos.Location = New System.Drawing.Point(42, 291)
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.Size = New System.Drawing.Size(234, 100)
        Me.viewDatos.TabIndex = 15
        Me.viewDatos.Visible = False
        '
        'cDocumento
        '
        Me.cDocumento.HeaderText = "Documento"
        Me.cDocumento.Name = "cDocumento"
        '
        'cTipoDocumento
        '
        Me.cTipoDocumento.HeaderText = "TipoDocumento"
        Me.cTipoDocumento.Name = "cTipoDocumento"
        '
        'cMontoPago
        '
        Me.cMontoPago.HeaderText = "MontoPago"
        Me.cMontoPago.Name = "cMontoPago"
        '
        'cFormaPago
        '
        Me.cFormaPago.HeaderText = "FormaPago"
        Me.cFormaPago.Name = "cFormaPago"
        '
        'cDenominacion
        '
        Me.cDenominacion.HeaderText = "Denominacion"
        Me.cDenominacion.Name = "cDenominacion"
        '
        'cUsuario
        '
        Me.cUsuario.HeaderText = "Usuario"
        Me.cUsuario.Name = "cUsuario"
        '
        'cNombre
        '
        Me.cNombre.HeaderText = "Nombre"
        Me.cNombre.Name = "cNombre"
        '
        'cCodMoneda
        '
        Me.cCodMoneda.HeaderText = "CodMoneda"
        Me.cCodMoneda.Name = "cCodMoneda"
        '
        'cNombreMoneda
        '
        Me.cNombreMoneda.HeaderText = "NombreMoneda"
        Me.cNombreMoneda.Name = "cNombreMoneda"
        '
        'cTipoCambio
        '
        Me.cTipoCambio.HeaderText = "TipoCambio"
        Me.cTipoCambio.Name = "cTipoCambio"
        '
        'cFecha
        '
        Me.cFecha.HeaderText = "Fecha"
        Me.cFecha.Name = "cFecha"
        '
        'cNumApertura
        '
        Me.cNumApertura.HeaderText = "NumApertura"
        Me.cNumApertura.Name = "cNumApertura"
        '
        'cNumeroDocumento
        '
        Me.cNumeroDocumento.HeaderText = "NumeroDocumento"
        Me.cNumeroDocumento.Name = "cNumeroDocumento"
        Me.cNumeroDocumento.Visible = False
        '
        'btnPendientes
        '
        Me.btnPendientes.Enabled = False
        Me.btnPendientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPendientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPendientes.Location = New System.Drawing.Point(245, 165)
        Me.btnPendientes.Name = "btnPendientes"
        Me.btnPendientes.Size = New System.Drawing.Size(204, 100)
        Me.btnPendientes.TabIndex = 16
        Me.btnPendientes.TabStop = False
        Me.btnPendientes.Text = "Factura Pendiente"
        Me.btnPendientes.UseVisualStyleBackColor = True
        '
        'lblTipodeCambio
        '
        Me.lblTipodeCambio.AutoSize = True
        Me.lblTipodeCambio.Location = New System.Drawing.Point(39, 7)
        Me.lblTipodeCambio.Name = "lblTipodeCambio"
        Me.lblTipodeCambio.Size = New System.Drawing.Size(168, 13)
        Me.lblTipodeCambio.TabIndex = 17
        Me.lblTipodeCambio.Text = "Tipo de Cambio del Dolar : 500.00"
        '
        'btnOtrasTarjetas
        '
        Me.btnOtrasTarjetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOtrasTarjetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOtrasTarjetas.Location = New System.Drawing.Point(485, 165)
        Me.btnOtrasTarjetas.Name = "btnOtrasTarjetas"
        Me.btnOtrasTarjetas.Size = New System.Drawing.Size(204, 100)
        Me.btnOtrasTarjetas.TabIndex = 18
        Me.btnOtrasTarjetas.TabStop = False
        Me.btnOtrasTarjetas.Text = "Otras " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tarjetas"
        Me.btnOtrasTarjetas.UseVisualStyleBackColor = True
        '
        'frmIngresarFomasdePago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 402)
        Me.Controls.Add(Me.btnOtrasTarjetas)
        Me.Controls.Add(Me.lblTipodeCambio)
        Me.Controls.Add(Me.btnPendientes)
        Me.Controls.Add(Me.btnChequeDolares)
        Me.Controls.Add(Me.btnEfectivoDolares)
        Me.Controls.Add(Me.lblPagado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblPendienteCobro)
        Me.Controls.Add(Me.lblTotalCobro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEfectivoColones)
        Me.Controls.Add(Me.btnTransferencia)
        Me.Controls.Add(Me.btnTarjetaColones)
        Me.Controls.Add(Me.btnChequeColones)
        Me.Controls.Add(Me.viewDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIngresarFomasdePago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresar Fomas de Pago"
        CType(Me.DataSet_Facturaciones1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnChequeColones As System.Windows.Forms.Button
    Friend WithEvents btnTarjetaColones As System.Windows.Forms.Button
    Friend WithEvents btnTransferencia As System.Windows.Forms.Button
    Friend WithEvents btnEfectivoColones As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblPendienteCobro As System.Windows.Forms.Label
    Friend WithEvents lblTotalCobro As System.Windows.Forms.Label
    Friend WithEvents lblPagado As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnEfectivoDolares As System.Windows.Forms.Button
    Friend WithEvents btnChequeDolares As System.Windows.Forms.Button
    Friend WithEvents DataSet_Facturaciones1 As LcPymes_5._2.DataSet_Facturaciones
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents btnPendientes As System.Windows.Forms.Button
    Friend WithEvents lblTipodeCambio As System.Windows.Forms.Label
    Friend WithEvents btnOtrasTarjetas As System.Windows.Forms.Button
    Friend WithEvents cDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTipoDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMontoPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cFormaPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDenominacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCodMoneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNombreMoneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTipoCambio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNumApertura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNumeroDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
