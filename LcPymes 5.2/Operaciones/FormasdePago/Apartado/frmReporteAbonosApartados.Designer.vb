<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteAbonosApartados
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdApartado = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtTotalApartado = New System.Windows.Forms.TextBox()
        Me.btnImprimirApartado = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.btnImprimirLista = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtTotalInicial = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalAbonos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalPendiente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apartado #"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(335, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Apartado"
        '
        'txtIdApartado
        '
        Me.txtIdApartado.BackColor = System.Drawing.Color.White
        Me.txtIdApartado.Location = New System.Drawing.Point(11, 28)
        Me.txtIdApartado.Name = "txtIdApartado"
        Me.txtIdApartado.ReadOnly = True
        Me.txtIdApartado.Size = New System.Drawing.Size(57, 20)
        Me.txtIdApartado.TabIndex = 3
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.White
        Me.txtCliente.Location = New System.Drawing.Point(77, 28)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(256, 20)
        Me.txtCliente.TabIndex = 4
        '
        'txtTotalApartado
        '
        Me.txtTotalApartado.BackColor = System.Drawing.Color.White
        Me.txtTotalApartado.Location = New System.Drawing.Point(338, 28)
        Me.txtTotalApartado.Name = "txtTotalApartado"
        Me.txtTotalApartado.ReadOnly = True
        Me.txtTotalApartado.Size = New System.Drawing.Size(96, 20)
        Me.txtTotalApartado.TabIndex = 5
        Me.txtTotalApartado.Text = "0.00"
        Me.txtTotalApartado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnImprimirApartado
        '
        Me.btnImprimirApartado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimirApartado.Location = New System.Drawing.Point(440, 12)
        Me.btnImprimirApartado.Name = "btnImprimirApartado"
        Me.btnImprimirApartado.Size = New System.Drawing.Size(75, 39)
        Me.btnImprimirApartado.TabIndex = 6
        Me.btnImprimirApartado.Text = "Imprimir Apartado"
        Me.btnImprimirApartado.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.viewDatos)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(585, 211)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Abonos del Apartado"
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
        Me.viewDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewDatos.Location = New System.Drawing.Point(3, 16)
        Me.viewDatos.MultiSelect = False
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.ReadOnly = True
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.RowTemplate.Height = 30
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(579, 192)
        Me.viewDatos.TabIndex = 0
        '
        'btnImprimirLista
        '
        Me.btnImprimirLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimirLista.Location = New System.Drawing.Point(521, 12)
        Me.btnImprimirLista.Name = "btnImprimirLista"
        Me.btnImprimirLista.Size = New System.Drawing.Size(75, 39)
        Me.btnImprimirLista.TabIndex = 8
        Me.btnImprimirLista.Text = "Imprimir Abonos"
        Me.btnImprimirLista.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(293, 309)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(300, 35)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Cerrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtTotalInicial
        '
        Me.txtTotalInicial.BackColor = System.Drawing.Color.White
        Me.txtTotalInicial.Location = New System.Drawing.Point(293, 282)
        Me.txtTotalInicial.Name = "txtTotalInicial"
        Me.txtTotalInicial.ReadOnly = True
        Me.txtTotalInicial.Size = New System.Drawing.Size(96, 20)
        Me.txtTotalInicial.TabIndex = 11
        Me.txtTotalInicial.Text = "0.00"
        Me.txtTotalInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(290, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total Apartado"
        '
        'txtTotalAbonos
        '
        Me.txtTotalAbonos.BackColor = System.Drawing.Color.White
        Me.txtTotalAbonos.Location = New System.Drawing.Point(395, 282)
        Me.txtTotalAbonos.Name = "txtTotalAbonos"
        Me.txtTotalAbonos.ReadOnly = True
        Me.txtTotalAbonos.Size = New System.Drawing.Size(96, 20)
        Me.txtTotalAbonos.TabIndex = 13
        Me.txtTotalAbonos.Text = "0.00"
        Me.txtTotalAbonos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(392, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Total Abonos"
        '
        'txtTotalPendiente
        '
        Me.txtTotalPendiente.BackColor = System.Drawing.Color.White
        Me.txtTotalPendiente.Location = New System.Drawing.Point(497, 282)
        Me.txtTotalPendiente.Name = "txtTotalPendiente"
        Me.txtTotalPendiente.ReadOnly = True
        Me.txtTotalPendiente.Size = New System.Drawing.Size(96, 20)
        Me.txtTotalPendiente.TabIndex = 15
        Me.txtTotalPendiente.Text = "0.00"
        Me.txtTotalPendiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(494, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Saldo Pendiente"
        '
        'frmReporteAbonosApartados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(607, 349)
        Me.Controls.Add(Me.txtTotalPendiente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTotalAbonos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTotalInicial)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnImprimirLista)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnImprimirApartado)
        Me.Controls.Add(Me.txtTotalApartado)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.txtIdApartado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReporteAbonosApartados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Abonos de Apartados"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnImprimirApartado As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents btnImprimirLista As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtIdApartado As System.Windows.Forms.TextBox
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalApartado As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotalAbonos As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotalPendiente As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
