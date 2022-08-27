<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlAbono
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
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.btnAbonar = New System.Windows.Forms.Button()
        Me.txtTotalAbono = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotalFactura = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalCobro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'viewDatos
        '
        Me.viewDatos.AllowUserToAddRows = False
        Me.viewDatos.AllowUserToDeleteRows = False
        Me.viewDatos.AllowUserToResizeColumns = False
        Me.viewDatos.AllowUserToResizeRows = False
        Me.viewDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.viewDatos.BackgroundColor = System.Drawing.Color.White
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Location = New System.Drawing.Point(5, 95)
        Me.viewDatos.MultiSelect = False
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.ReadOnly = True
        Me.viewDatos.RowTemplate.Height = 30
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(744, 316)
        Me.viewDatos.TabIndex = 0
        '
        'btnAbonar
        '
        Me.btnAbonar.BackColor = System.Drawing.Color.White
        Me.btnAbonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbonar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbonar.Location = New System.Drawing.Point(5, 13)
        Me.btnAbonar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAbonar.Name = "btnAbonar"
        Me.btnAbonar.Size = New System.Drawing.Size(296, 75)
        Me.btnAbonar.TabIndex = 21
        Me.btnAbonar.TabStop = False
        Me.btnAbonar.Text = "Ingresar abono"
        Me.btnAbonar.UseVisualStyleBackColor = False
        '
        'txtTotalAbono
        '
        Me.txtTotalAbono.BackColor = System.Drawing.Color.White
        Me.txtTotalAbono.Location = New System.Drawing.Point(578, 441)
        Me.txtTotalAbono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalAbono.Name = "txtTotalAbono"
        Me.txtTotalAbono.ReadOnly = True
        Me.txtTotalAbono.Size = New System.Drawing.Size(171, 22)
        Me.txtTotalAbono.TabIndex = 36
        Me.txtTotalAbono.TabStop = False
        Me.txtTotalAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(477, 444)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 17)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Total Abonos"
        '
        'txtTotalFactura
        '
        Me.txtTotalFactura.BackColor = System.Drawing.Color.White
        Me.txtTotalFactura.Location = New System.Drawing.Point(578, 418)
        Me.txtTotalFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalFactura.Name = "txtTotalFactura"
        Me.txtTotalFactura.ReadOnly = True
        Me.txtTotalFactura.Size = New System.Drawing.Size(171, 22)
        Me.txtTotalFactura.TabIndex = 34
        Me.txtTotalFactura.TabStop = False
        Me.txtTotalFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(478, 421)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Total Factura"
        '
        'txtTotalCobro
        '
        Me.txtTotalCobro.BackColor = System.Drawing.Color.White
        Me.txtTotalCobro.Location = New System.Drawing.Point(578, 464)
        Me.txtTotalCobro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalCobro.Name = "txtTotalCobro"
        Me.txtTotalCobro.ReadOnly = True
        Me.txtTotalCobro.Size = New System.Drawing.Size(171, 22)
        Me.txtTotalCobro.TabIndex = 32
        Me.txtTotalCobro.TabStop = False
        Me.txtTotalCobro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(477, 467)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Total Cobro"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(5, 418)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(296, 66)
        Me.Button1.TabIndex = 37
        Me.Button1.TabStop = False
        Me.Button1.Text = "Volver a Reintegro facturas"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmControlAbono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(753, 496)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtTotalAbono)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTotalFactura)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotalCobro)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAbonar)
        Me.Controls.Add(Me.viewDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmControlAbono"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Abonos "
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents btnAbonar As System.Windows.Forms.Button
    Friend WithEvents txtTotalAbono As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTotalFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCobro As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
