<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArchivarCredito
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.viewFacturas = New System.Windows.Forms.DataGridView()
        Me.cId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cArchivar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cNum_Factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnArchivar = New System.Windows.Forms.Button()
        Me.btnCargarFacturas = New System.Windows.Forms.Button()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.viewFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'viewFacturas
        '
        Me.viewFacturas.AllowUserToAddRows = False
        Me.viewFacturas.AllowUserToDeleteRows = False
        Me.viewFacturas.AllowUserToResizeColumns = False
        Me.viewFacturas.AllowUserToResizeRows = False
        Me.viewFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.viewFacturas.BackgroundColor = System.Drawing.Color.White
        Me.viewFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cId, Me.cArchivar, Me.cNum_Factura, Me.cCliente, Me.cUsuario, Me.cFecha, Me.cTotal})
        Me.viewFacturas.Location = New System.Drawing.Point(12, 30)
        Me.viewFacturas.MultiSelect = False
        Me.viewFacturas.Name = "viewFacturas"
        Me.viewFacturas.RowHeadersVisible = False
        Me.viewFacturas.RowTemplate.Height = 30
        Me.viewFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewFacturas.Size = New System.Drawing.Size(687, 261)
        Me.viewFacturas.TabIndex = 9
        '
        'cId
        '
        Me.cId.HeaderText = "Id"
        Me.cId.Name = "cId"
        Me.cId.Visible = False
        Me.cId.Width = 22
        '
        'cArchivar
        '
        Me.cArchivar.HeaderText = "Archivar"
        Me.cArchivar.Name = "cArchivar"
        Me.cArchivar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cArchivar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cArchivar.Width = 71
        '
        'cNum_Factura
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cNum_Factura.DefaultCellStyle = DataGridViewCellStyle10
        Me.cNum_Factura.HeaderText = "Factura"
        Me.cNum_Factura.Name = "cNum_Factura"
        Me.cNum_Factura.ReadOnly = True
        Me.cNum_Factura.Width = 68
        '
        'cCliente
        '
        Me.cCliente.HeaderText = "Cliente"
        Me.cCliente.Name = "cCliente"
        Me.cCliente.ReadOnly = True
        Me.cCliente.Width = 64
        '
        'cUsuario
        '
        Me.cUsuario.HeaderText = "Usuario"
        Me.cUsuario.Name = "cUsuario"
        Me.cUsuario.ReadOnly = True
        Me.cUsuario.Width = 68
        '
        'cFecha
        '
        DataGridViewCellStyle11.Format = "d"
        Me.cFecha.DefaultCellStyle = DataGridViewCellStyle11
        Me.cFecha.HeaderText = "Fecha"
        Me.cFecha.Name = "cFecha"
        Me.cFecha.ReadOnly = True
        Me.cFecha.Width = 62
        '
        'cTotal
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        Me.cTotal.DefaultCellStyle = DataGridViewCellStyle12
        Me.cTotal.HeaderText = "Total"
        Me.cTotal.Name = "cTotal"
        Me.cTotal.ReadOnly = True
        Me.cTotal.Width = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Seleccione la fecha :"
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(125, 7)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(148, 20)
        Me.dtpDesde.TabIndex = 11
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(547, 294)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(153, 46)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnArchivar
        '
        Me.btnArchivar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArchivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArchivar.Location = New System.Drawing.Point(388, 294)
        Me.btnArchivar.Name = "btnArchivar"
        Me.btnArchivar.Size = New System.Drawing.Size(153, 46)
        Me.btnArchivar.TabIndex = 13
        Me.btnArchivar.Text = "Archivar"
        Me.btnArchivar.UseVisualStyleBackColor = True
        '
        'btnCargarFacturas
        '
        Me.btnCargarFacturas.Location = New System.Drawing.Point(279, 5)
        Me.btnCargarFacturas.Name = "btnCargarFacturas"
        Me.btnCargarFacturas.Size = New System.Drawing.Size(225, 23)
        Me.btnCargarFacturas.TabIndex = 14
        Me.btnCargarFacturas.Text = "Cargar Facturas de Credito del Dia"
        Me.btnCargarFacturas.UseVisualStyleBackColor = True
        '
        'lblUsuario
        '
        Me.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUsuario.Location = New System.Drawing.Point(12, 312)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(370, 23)
        Me.lblUsuario.TabIndex = 15
        Me.lblUsuario.Text = "Usuario"
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Usuario :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(510, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(189, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Reporte de Facturas sin Archivar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmArchivarCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 344)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.btnCargarFacturas)
        Me.Controls.Add(Me.btnArchivar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.dtpDesde)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.viewFacturas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmArchivarCredito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Archivar Facturas de Credito"
        CType(Me.viewFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents viewFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnArchivar As System.Windows.Forms.Button
    Friend WithEvents cId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cArchivar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cNum_Factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCargarFacturas As System.Windows.Forms.Button
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
