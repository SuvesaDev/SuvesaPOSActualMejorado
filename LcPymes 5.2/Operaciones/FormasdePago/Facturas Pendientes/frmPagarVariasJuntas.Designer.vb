<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagarVariasJuntas
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
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.txtTotalCobro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCobrar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPuntoVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cBasededatos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNumFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAbono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTexto = New System.Windows.Forms.Label()
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
        Me.viewDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.viewDatos.BackgroundColor = System.Drawing.Color.White
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cId, Me.cPuntoVenta, Me.cBasededatos, Me.cNumFactura, Me.cCliente, Me.cTotal, Me.cAbono})
        Me.viewDatos.Location = New System.Drawing.Point(12, 49)
        Me.viewDatos.MultiSelect = False
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(790, 278)
        Me.viewDatos.TabIndex = 11
        '
        'txtTotalCobro
        '
        Me.txtTotalCobro.BackColor = System.Drawing.Color.White
        Me.txtTotalCobro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCobro.Location = New System.Drawing.Point(638, 331)
        Me.txtTotalCobro.Name = "txtTotalCobro"
        Me.txtTotalCobro.ReadOnly = True
        Me.txtTotalCobro.Size = New System.Drawing.Size(164, 26)
        Me.txtTotalCobro.TabIndex = 27
        Me.txtTotalCobro.TabStop = False
        Me.txtTotalCobro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(541, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Total Cobro"
        '
        'btnCobrar
        '
        Me.btnCobrar.BackColor = System.Drawing.Color.White
        Me.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCobrar.Location = New System.Drawing.Point(470, 362)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(162, 61)
        Me.btnCobrar.TabIndex = 28
        Me.btnCobrar.TabStop = False
        Me.btnCobrar.Text = "Cobrar "
        Me.btnCobrar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(256, 35)
        Me.Button1.TabIndex = 29
        Me.Button1.TabStop = False
        Me.Button1.Text = "Agregar Facturas"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(641, 362)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(162, 61)
        Me.btnCancelar.TabIndex = 30
        Me.btnCancelar.TabStop = False
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 362)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(162, 61)
        Me.Button2.TabIndex = 31
        Me.Button2.TabStop = False
        Me.Button2.Text = "<---  Volver Atras"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(274, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(256, 35)
        Me.Button3.TabIndex = 32
        Me.Button3.TabStop = False
        Me.Button3.Text = "Reimprimir Recibos"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'cId
        '
        Me.cId.HeaderText = "Id"
        Me.cId.Name = "cId"
        Me.cId.ReadOnly = True
        Me.cId.Visible = False
        '
        'cPuntoVenta
        '
        Me.cPuntoVenta.HeaderText = "PuntodeVenta"
        Me.cPuntoVenta.Name = "cPuntoVenta"
        Me.cPuntoVenta.ReadOnly = True
        '
        'cBasededatos
        '
        Me.cBasededatos.HeaderText = "BasedeDatos"
        Me.cBasededatos.Name = "cBasededatos"
        Me.cBasededatos.ReadOnly = True
        Me.cBasededatos.Visible = False
        '
        'cNumFactura
        '
        Me.cNumFactura.HeaderText = "Factura"
        Me.cNumFactura.Name = "cNumFactura"
        Me.cNumFactura.ReadOnly = True
        Me.cNumFactura.Width = 68
        '
        'cCliente
        '
        Me.cCliente.HeaderText = "Cliente"
        Me.cCliente.Name = "cCliente"
        Me.cCliente.ReadOnly = True
        Me.cCliente.Width = 64
        '
        'cTotal
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.cTotal.DefaultCellStyle = DataGridViewCellStyle1
        Me.cTotal.HeaderText = "Total Factura"
        Me.cTotal.Name = "cTotal"
        Me.cTotal.ReadOnly = True
        Me.cTotal.Width = 95
        '
        'cAbono
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.cAbono.DefaultCellStyle = DataGridViewCellStyle2
        Me.cAbono.HeaderText = "Monto Abono"
        Me.cAbono.Name = "cAbono"
        Me.cAbono.Width = 96
        '
        'lblTexto
        '
        Me.lblTexto.AutoSize = True
        Me.lblTexto.Location = New System.Drawing.Point(12, 331)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(0, 13)
        Me.lblTexto.TabIndex = 33
        '
        'frmPagarVariasJuntas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 428)
        Me.Controls.Add(Me.lblTexto)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCobrar)
        Me.Controls.Add(Me.txtTotalCobro)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.viewDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPagarVariasJuntas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cobrar Varias Juntas"
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents txtTotalCobro As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCobrar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPuntoVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cBasededatos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNumFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cAbono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblTexto As System.Windows.Forms.Label
End Class
