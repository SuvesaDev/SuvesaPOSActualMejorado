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
        Me.txtExistenciaDescargar.Location = New System.Drawing.Point(377, 42)
        Me.txtExistenciaDescargar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtExistenciaDescargar.MaxLength = 20
        Me.txtExistenciaDescargar.Name = "txtExistenciaDescargar"
        Me.txtExistenciaDescargar.ReadOnly = True
        Me.txtExistenciaDescargar.Size = New System.Drawing.Size(84, 20)
        Me.txtExistenciaDescargar.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(374, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Existencia actual"
        '
        'txtDescripcionDescargar
        '
        Me.txtDescripcionDescargar.Location = New System.Drawing.Point(88, 42)
        Me.txtDescripcionDescargar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDescripcionDescargar.MaxLength = 20
        Me.txtDescripcionDescargar.Name = "txtDescripcionDescargar"
        Me.txtDescripcionDescargar.ReadOnly = True
        Me.txtDescripcionDescargar.Size = New System.Drawing.Size(279, 20)
        Me.txtDescripcionDescargar.TabIndex = 11
        '
        'txtCodigoDescargar
        '
        Me.txtCodigoDescargar.Location = New System.Drawing.Point(31, 42)
        Me.txtCodigoDescargar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodigoDescargar.MaxLength = 20
        Me.txtCodigoDescargar.Name = "txtCodigoDescargar"
        Me.txtCodigoDescargar.ReadOnly = True
        Me.txtCodigoDescargar.Size = New System.Drawing.Size(50, 20)
        Me.txtCodigoDescargar.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(86, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Descripción"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Codigo"
        '
        'txtCantidadDescargar
        '
        Me.txtCantidadDescargar.Location = New System.Drawing.Point(6, 93)
        Me.txtCantidadDescargar.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txtCantidadDescargar.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCantidadDescargar.Name = "txtCantidadDescargar"
        Me.txtCantidadDescargar.Size = New System.Drawing.Size(84, 20)
        Me.txtCantidadDescargar.TabIndex = 15
        Me.txtCantidadDescargar.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(3, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Cantidad Descargar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(185, 279)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(141, 35)
        Me.btnAceptar.TabIndex = 16
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(332, 279)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(141, 35)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(483, 126)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(5, -4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(171, 24)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Articulo a Disminuir"
        '
        'btnBuscarDescargar
        '
        Me.btnBuscarDescargar.Image = Global.LcPymes_5._2.My.Resources.Resources.research
        Me.btnBuscarDescargar.Location = New System.Drawing.Point(6, 40)
        Me.btnBuscarDescargar.Name = "btnBuscarDescargar"
        Me.btnBuscarDescargar.Size = New System.Drawing.Size(25, 24)
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 147)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(483, 126)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label11.Location = New System.Drawing.Point(4, -5)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(175, 24)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Articulo a Aumentar"
        '
        'txtCantidadAumentar
        '
        Me.txtCantidadAumentar.Location = New System.Drawing.Point(108, 90)
        Me.txtCantidadAumentar.Name = "txtCantidadAumentar"
        Me.txtCantidadAumentar.ReadOnly = True
        Me.txtCantidadAumentar.Size = New System.Drawing.Size(94, 20)
        Me.txtCantidadAumentar.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Aumentar x Saco"
        '
        'txtDescargaxSaco
        '
        Me.txtDescargaxSaco.Location = New System.Drawing.Point(6, 90)
        Me.txtDescargaxSaco.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDescargaxSaco.MaxLength = 20
        Me.txtDescargaxSaco.Name = "txtDescargaxSaco"
        Me.txtDescargaxSaco.Size = New System.Drawing.Size(84, 20)
        Me.txtDescargaxSaco.TabIndex = 29
        '
        'btnBuscarAumentar
        '
        Me.btnBuscarAumentar.Image = Global.LcPymes_5._2.My.Resources.Resources.research
        Me.btnBuscarAumentar.Location = New System.Drawing.Point(6, 40)
        Me.btnBuscarAumentar.Name = "btnBuscarAumentar"
        Me.btnBuscarAumentar.Size = New System.Drawing.Size(25, 24)
        Me.btnBuscarAumentar.TabIndex = 27
        Me.btnBuscarAumentar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Descripción"
        '
        'txtCodigoAumentar
        '
        Me.txtCodigoAumentar.Location = New System.Drawing.Point(31, 42)
        Me.txtCodigoAumentar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodigoAumentar.MaxLength = 20
        Me.txtCodigoAumentar.Name = "txtCodigoAumentar"
        Me.txtCodigoAumentar.ReadOnly = True
        Me.txtCodigoAumentar.Size = New System.Drawing.Size(50, 20)
        Me.txtCodigoAumentar.TabIndex = 10
        '
        'txtDescripcionAumentar
        '
        Me.txtDescripcionAumentar.Location = New System.Drawing.Point(88, 42)
        Me.txtDescripcionAumentar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDescripcionAumentar.MaxLength = 20
        Me.txtDescripcionAumentar.Name = "txtDescripcionAumentar"
        Me.txtDescripcionAumentar.ReadOnly = True
        Me.txtDescripcionAumentar.Size = New System.Drawing.Size(279, 20)
        Me.txtDescripcionAumentar.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(105, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Cantidad Aumentar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(374, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Existencia actual"
        '
        'txtExistenciaAumentar
        '
        Me.txtExistenciaAumentar.Location = New System.Drawing.Point(377, 42)
        Me.txtExistenciaAumentar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtExistenciaAumentar.MaxLength = 20
        Me.txtExistenciaAumentar.Name = "txtExistenciaAumentar"
        Me.txtExistenciaAumentar.ReadOnly = True
        Me.txtExistenciaAumentar.Size = New System.Drawing.Size(84, 20)
        Me.txtExistenciaAumentar.TabIndex = 13
        '
        'frmAumentarOtro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 325)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
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
