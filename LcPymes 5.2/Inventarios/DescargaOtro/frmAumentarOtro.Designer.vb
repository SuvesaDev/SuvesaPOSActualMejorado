<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAumentarOtro
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
        Me.txtExistenciaDescargar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDescripcionDescargar = New System.Windows.Forms.TextBox()
        Me.txtCodigoDescargar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCantidadDescargar = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBuscarDescargar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCantidadAumentar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescargaxSaco = New System.Windows.Forms.TextBox()
        Me.btnBuscarAumentar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigoAumentar = New System.Windows.Forms.TextBox()
        Me.txtDescripcionAumentar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtExistenciaAumentar = New System.Windows.Forms.TextBox()
        CType(Me.txtCantidadDescargar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtExistenciaDescargar
        '
        Me.txtExistenciaDescargar.Location = New System.Drawing.Point(503, 52)
        Me.txtExistenciaDescargar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtExistenciaDescargar.MaxLength = 20
        Me.txtExistenciaDescargar.Name = "txtExistenciaDescargar"
        Me.txtExistenciaDescargar.ReadOnly = True
        Me.txtExistenciaDescargar.Size = New System.Drawing.Size(111, 22)
        Me.txtExistenciaDescargar.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(499, 32)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 17)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Existencia actual"
        '
        'txtDescripcionDescargar
        '
        Me.txtDescripcionDescargar.Location = New System.Drawing.Point(117, 52)
        Me.txtDescripcionDescargar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDescripcionDescargar.MaxLength = 20
        Me.txtDescripcionDescargar.Name = "txtDescripcionDescargar"
        Me.txtDescripcionDescargar.ReadOnly = True
        Me.txtDescripcionDescargar.Size = New System.Drawing.Size(371, 22)
        Me.txtDescripcionDescargar.TabIndex = 11
        '
        'txtCodigoDescargar
        '
        Me.txtCodigoDescargar.Location = New System.Drawing.Point(41, 52)
        Me.txtCodigoDescargar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCodigoDescargar.MaxLength = 20
        Me.txtCodigoDescargar.Name = "txtCodigoDescargar"
        Me.txtCodigoDescargar.ReadOnly = True
        Me.txtCodigoDescargar.Size = New System.Drawing.Size(65, 22)
        Me.txtCodigoDescargar.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(115, 31)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Descripción"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 31)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Codigo"
        '
        'txtCantidadDescargar
        '
        Me.txtCantidadDescargar.DecimalPlaces = 2
        Me.txtCantidadDescargar.Increment = New Decimal(New Integer() {50, 0, 0, 131072})
        Me.txtCantidadDescargar.Location = New System.Drawing.Point(8, 114)
        Me.txtCantidadDescargar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCantidadDescargar.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txtCantidadDescargar.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.txtCantidadDescargar.Name = "txtCantidadDescargar"
        Me.txtCantidadDescargar.Size = New System.Drawing.Size(112, 22)
        Me.txtCantidadDescargar.TabIndex = 15
        Me.txtCantidadDescargar.ThousandsSeparator = True
        Me.txtCantidadDescargar.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(4, 91)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Cantidad Descargar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(247, 343)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(188, 43)
        Me.btnAceptar.TabIndex = 16
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(443, 343)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(188, 43)
        Me.btnCancelar.TabIndex = 17
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnBuscarDescargar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtCodigoDescargar)
        Me.GroupBox1.Controls.Add(Me.txtCantidadDescargar)
        Me.GroupBox1.Controls.Add(Me.txtDescripcionDescargar)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtExistenciaDescargar)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(644, 155)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(7, -5)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(219, 29)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Articulo a Disminuir"
        '
        'btnBuscarDescargar
        '
        Me.btnBuscarDescargar.Image = Global.LcPymes_5._2.My.Resources.Resources.research
        Me.btnBuscarDescargar.Location = New System.Drawing.Point(8, 49)
        Me.btnBuscarDescargar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBuscarDescargar.Name = "btnBuscarDescargar"
        Me.btnBuscarDescargar.Size = New System.Drawing.Size(33, 30)
        Me.btnBuscarDescargar.TabIndex = 27
        Me.btnBuscarDescargar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtCantidadAumentar)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtDescargaxSaco)
        Me.GroupBox2.Controls.Add(Me.btnBuscarAumentar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtCodigoAumentar)
        Me.GroupBox2.Controls.Add(Me.txtDescripcionAumentar)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtExistenciaAumentar)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 181)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(644, 155)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label11.Location = New System.Drawing.Point(5, -6)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(220, 29)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Articulo a Aumentar"
        '
        'txtCantidadAumentar
        '
        Me.txtCantidadAumentar.Location = New System.Drawing.Point(144, 111)
        Me.txtCantidadAumentar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCantidadAumentar.Name = "txtCantidadAumentar"
        Me.txtCantidadAumentar.ReadOnly = True
        Me.txtCantidadAumentar.Size = New System.Drawing.Size(124, 22)
        Me.txtCantidadAumentar.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 91)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 17)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Aumentar x Saco"
        '
        'txtDescargaxSaco
        '
        Me.txtDescargaxSaco.Location = New System.Drawing.Point(8, 111)
        Me.txtDescargaxSaco.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDescargaxSaco.MaxLength = 20
        Me.txtDescargaxSaco.Name = "txtDescargaxSaco"
        Me.txtDescargaxSaco.Size = New System.Drawing.Size(111, 22)
        Me.txtDescargaxSaco.TabIndex = 29
        '
        'btnBuscarAumentar
        '
        Me.btnBuscarAumentar.Image = Global.LcPymes_5._2.My.Resources.Resources.research
        Me.btnBuscarAumentar.Location = New System.Drawing.Point(8, 49)
        Me.btnBuscarAumentar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBuscarAumentar.Name = "btnBuscarAumentar"
        Me.btnBuscarAumentar.Size = New System.Drawing.Size(33, 30)
        Me.btnBuscarAumentar.TabIndex = 27
        Me.btnBuscarAumentar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Descripción"
        '
        'txtCodigoAumentar
        '
        Me.txtCodigoAumentar.Location = New System.Drawing.Point(41, 52)
        Me.txtCodigoAumentar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCodigoAumentar.MaxLength = 20
        Me.txtCodigoAumentar.Name = "txtCodigoAumentar"
        Me.txtCodigoAumentar.ReadOnly = True
        Me.txtCodigoAumentar.Size = New System.Drawing.Size(65, 22)
        Me.txtCodigoAumentar.TabIndex = 10
        '
        'txtDescripcionAumentar
        '
        Me.txtDescripcionAumentar.Location = New System.Drawing.Point(117, 52)
        Me.txtDescripcionAumentar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDescripcionAumentar.MaxLength = 20
        Me.txtDescripcionAumentar.Name = "txtDescripcionAumentar"
        Me.txtDescripcionAumentar.ReadOnly = True
        Me.txtDescripcionAumentar.Size = New System.Drawing.Size(371, 22)
        Me.txtDescripcionAumentar.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(140, 85)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Cantidad Aumentar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(499, 32)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Existencia actual"
        '
        'txtExistenciaAumentar
        '
        Me.txtExistenciaAumentar.Location = New System.Drawing.Point(503, 52)
        Me.txtExistenciaAumentar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtExistenciaAumentar.MaxLength = 20
        Me.txtExistenciaAumentar.Name = "txtExistenciaAumentar"
        Me.txtExistenciaAumentar.ReadOnly = True
        Me.txtExistenciaAumentar.Size = New System.Drawing.Size(111, 22)
        Me.txtExistenciaAumentar.TabIndex = 13
        '
        'frmAumentarOtro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 400)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAumentarOtro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aumentar Existencia Otro"
        CType(Me.txtCantidadDescargar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtExistenciaDescargar As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionDescargar As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoDescargar As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCantidadDescargar As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscarDescargar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscarAumentar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoAumentar As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcionAumentar As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtExistenciaAumentar As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDescargaxSaco As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidadAumentar As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
