<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarUnificar
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
        Me.cboPuntoVenta1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigo1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion1 = New System.Windows.Forms.TextBox()
        Me.txtDescripcion2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodigo2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboPuntoVenta2 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnBuscar1 = New System.Windows.Forms.Button()
        Me.btnBuscar2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboPuntoVenta1
        '
        Me.cboPuntoVenta1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPuntoVenta1.FormattingEnabled = True
        Me.cboPuntoVenta1.Location = New System.Drawing.Point(12, 38)
        Me.cboPuntoVenta1.Name = "cboPuntoVenta1"
        Me.cboPuntoVenta1.Size = New System.Drawing.Size(135, 21)
        Me.cboPuntoVenta1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Punto de Venta 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(150, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Codigo 1"
        '
        'txtCodigo1
        '
        Me.txtCodigo1.Location = New System.Drawing.Point(174, 39)
        Me.txtCodigo1.Name = "txtCodigo1"
        Me.txtCodigo1.ReadOnly = True
        Me.txtCodigo1.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Descripcon 1"
        '
        'txtDescripcion1
        '
        Me.txtDescripcion1.Location = New System.Drawing.Point(12, 87)
        Me.txtDescripcion1.Name = "txtDescripcion1"
        Me.txtDescripcion1.ReadOnly = True
        Me.txtDescripcion1.Size = New System.Drawing.Size(262, 20)
        Me.txtDescripcion1.TabIndex = 6
        '
        'txtDescripcion2
        '
        Me.txtDescripcion2.Location = New System.Drawing.Point(299, 88)
        Me.txtDescripcion2.Name = "txtDescripcion2"
        Me.txtDescripcion2.ReadOnly = True
        Me.txtDescripcion2.Size = New System.Drawing.Size(262, 20)
        Me.txtDescripcion2.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(296, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Descripcon 2"
        '
        'txtCodigo2
        '
        Me.txtCodigo2.Location = New System.Drawing.Point(461, 40)
        Me.txtCodigo2.Name = "txtCodigo2"
        Me.txtCodigo2.ReadOnly = True
        Me.txtCodigo2.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo2.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(437, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Codigo 2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(296, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Punto de Venta 2"
        '
        'cboPuntoVenta2
        '
        Me.cboPuntoVenta2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPuntoVenta2.FormattingEnabled = True
        Me.cboPuntoVenta2.Location = New System.Drawing.Point(299, 39)
        Me.cboPuntoVenta2.Name = "cboPuntoVenta2"
        Me.cboPuntoVenta2.Size = New System.Drawing.Size(135, 21)
        Me.cboPuntoVenta2.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(284, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(6, 116)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Codigo 1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(299, 137)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(121, 27)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(12, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(549, 5)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Codigo 1"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(440, 137)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(121, 27)
        Me.btnAceptar.TabIndex = 16
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnBuscar1
        '
        Me.btnBuscar1.Location = New System.Drawing.Point(152, 38)
        Me.btnBuscar1.Name = "btnBuscar1"
        Me.btnBuscar1.Size = New System.Drawing.Size(22, 22)
        Me.btnBuscar1.TabIndex = 17
        Me.btnBuscar1.Text = "Button1"
        Me.btnBuscar1.UseVisualStyleBackColor = True
        '
        'btnBuscar2
        '
        Me.btnBuscar2.Location = New System.Drawing.Point(439, 39)
        Me.btnBuscar2.Name = "btnBuscar2"
        Me.btnBuscar2.Size = New System.Drawing.Size(22, 22)
        Me.btnBuscar2.TabIndex = 18
        Me.btnBuscar2.Text = "Button2"
        Me.btnBuscar2.UseVisualStyleBackColor = True
        '
        'frmAgregarUnificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 169)
        Me.Controls.Add(Me.btnBuscar2)
        Me.Controls.Add(Me.btnBuscar1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDescripcion2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCodigo2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboPuntoVenta2)
        Me.Controls.Add(Me.txtDescripcion1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCodigo1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboPuntoVenta1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAgregarUnificar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vincular productos entre puntos de venta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboPuntoVenta1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboPuntoVenta2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar1 As System.Windows.Forms.Button
    Friend WithEvents btnBuscar2 As System.Windows.Forms.Button
End Class
