<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCartaExoneracionSoloLectura
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
        Me.txtIV = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.viewCartasExoneracion = New System.Windows.Forms.DataGridView()
        Me.dtpFechaVence = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPorcentajeCompra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFechaEmison = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumeroDocumento = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboExoneracion = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.viewCartasExoneracion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIV
        '
        Me.txtIV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIV.ForeColor = System.Drawing.Color.Blue
        Me.txtIV.Location = New System.Drawing.Point(15, 110)
        Me.txtIV.Name = "txtIV"
        Me.txtIV.ReadOnly = True
        Me.txtIV.Size = New System.Drawing.Size(41, 20)
        Me.txtIV.TabIndex = 82
        Me.txtIV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIV.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(15, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 15)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "% IV"
        Me.Label6.Visible = False
        '
        'txtCodCliente
        '
        Me.txtCodCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCliente.ForeColor = System.Drawing.Color.Blue
        Me.txtCodCliente.Location = New System.Drawing.Point(92, 28)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.ReadOnly = True
        Me.txtCodCliente.Size = New System.Drawing.Size(117, 20)
        Me.txtCodCliente.TabIndex = 80
        Me.txtCodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'viewCartasExoneracion
        '
        Me.viewCartasExoneracion.AllowUserToAddRows = False
        Me.viewCartasExoneracion.AllowUserToDeleteRows = False
        Me.viewCartasExoneracion.AllowUserToResizeColumns = False
        Me.viewCartasExoneracion.AllowUserToResizeRows = False
        Me.viewCartasExoneracion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewCartasExoneracion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.viewCartasExoneracion.BackgroundColor = System.Drawing.Color.White
        Me.viewCartasExoneracion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewCartasExoneracion.Location = New System.Drawing.Point(15, 54)
        Me.viewCartasExoneracion.Name = "viewCartasExoneracion"
        Me.viewCartasExoneracion.ReadOnly = True
        Me.viewCartasExoneracion.RowHeadersVisible = False
        Me.viewCartasExoneracion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewCartasExoneracion.Size = New System.Drawing.Size(883, 382)
        Me.viewCartasExoneracion.TabIndex = 79
        '
        'dtpFechaVence
        '
        Me.dtpFechaVence.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVence.Location = New System.Drawing.Point(435, 69)
        Me.dtpFechaVence.Name = "dtpFechaVence"
        Me.dtpFechaVence.Size = New System.Drawing.Size(103, 20)
        Me.dtpFechaVence.TabIndex = 78
        Me.dtpFechaVence.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Location = New System.Drawing.Point(434, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 15)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Fecha Vence"
        Me.Label7.Visible = False
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Location = New System.Drawing.Point(15, 12)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(71, 36)
        Me.btnBuscarCliente.TabIndex = 76
        Me.btnBuscarCliente.Text = "Buscar Cliente"
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.ForeColor = System.Drawing.Color.Blue
        Me.txtCliente.Location = New System.Drawing.Point(211, 28)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(595, 20)
        Me.txtCliente.TabIndex = 75
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(92, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(714, 15)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Cliente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(544, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 21)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "%"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label4.Visible = False
        '
        'txtPorcentajeCompra
        '
        Me.txtPorcentajeCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPorcentajeCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcentajeCompra.ForeColor = System.Drawing.Color.Blue
        Me.txtPorcentajeCompra.Location = New System.Drawing.Point(569, 69)
        Me.txtPorcentajeCompra.Name = "txtPorcentajeCompra"
        Me.txtPorcentajeCompra.Size = New System.Drawing.Size(55, 20)
        Me.txtPorcentajeCompra.TabIndex = 70
        Me.txtPorcentajeCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPorcentajeCompra.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(544, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Exoneracion"
        Me.Label3.Visible = False
        '
        'dtpFechaEmison
        '
        Me.dtpFechaEmison.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEmison.Location = New System.Drawing.Point(328, 69)
        Me.dtpFechaEmison.Name = "dtpFechaEmison"
        Me.dtpFechaEmison.Size = New System.Drawing.Size(103, 20)
        Me.dtpFechaEmison.TabIndex = 68
        Me.dtpFechaEmison.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(327, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 15)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Fecha Emision"
        Me.Label2.Visible = False
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumeroDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDocumento.ForeColor = System.Drawing.Color.Blue
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(185, 70)
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(139, 20)
        Me.txtNumeroDocumento.TabIndex = 66
        Me.txtNumeroDocumento.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(185, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 15)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Numero Documento"
        Me.Label1.Visible = False
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label22.Location = New System.Drawing.Point(15, 54)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(164, 15)
        Me.Label22.TabIndex = 64
        Me.Label22.Text = "Motivo Exoneracion"
        Me.Label22.Visible = False
        '
        'cboExoneracion
        '
        Me.cboExoneracion.DisplayMember = "1"
        Me.cboExoneracion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExoneracion.DropDownWidth = 400
        Me.cboExoneracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboExoneracion.ForeColor = System.Drawing.Color.Blue
        Me.cboExoneracion.Location = New System.Drawing.Point(15, 70)
        Me.cboExoneracion.Name = "cboExoneracion"
        Me.cboExoneracion.Size = New System.Drawing.Size(164, 21)
        Me.cboExoneracion.TabIndex = 63
        Me.cboExoneracion.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(812, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 36)
        Me.Button1.TabIndex = 83
        Me.Button1.Text = "Agregar Carta "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmCartaExoneracionSoloLectura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 448)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.viewCartasExoneracion)
        Me.Controls.Add(Me.txtIV)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCodCliente)
        Me.Controls.Add(Me.dtpFechaVence)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPorcentajeCompra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpFechaEmison)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumeroDocumento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cboExoneracion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCartaExoneracionSoloLectura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cartas de Exoneracion"
        CType(Me.viewCartasExoneracion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIV As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCodCliente As System.Windows.Forms.TextBox
    Friend WithEvents viewCartasExoneracion As System.Windows.Forms.DataGridView
    Friend WithEvents dtpFechaVence As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarCliente As System.Windows.Forms.Button
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPorcentajeCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaEmison As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumento As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cboExoneracion As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
