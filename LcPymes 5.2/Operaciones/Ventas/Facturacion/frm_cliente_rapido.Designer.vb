<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cliente_rapido
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
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbo_tipo_cliente = New System.Windows.Forms.ComboBox()
        Me.Txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.LabelObs = New System.Windows.Forms.Label()
        Me.txtTelefono = New ValidText.ValidText()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigo = New ValidText.ValidText()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.Green
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.Location = New System.Drawing.Point(451, 172)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(102, 28)
        Me.btn_guardar.TabIndex = 7
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.cbo_tipo_cliente)
        Me.GroupBox6.Controls.Add(Me.Txtdireccion)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.txt_email)
        Me.GroupBox6.Controls.Add(Me.LabelObs)
        Me.GroupBox6.Controls.Add(Me.txtTelefono)
        Me.GroupBox6.Controls.Add(Me.Label38)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.txtCodigo)
        Me.GroupBox6.Controls.Add(Me.txtNombre)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox6.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox6.Size = New System.Drawing.Size(541, 163)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(134, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 17)
        Me.Label9.TabIndex = 166
        Me.Label9.Text = "Cedula"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbo_tipo_cliente
        '
        Me.cbo_tipo_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_tipo_cliente.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_tipo_cliente.ForeColor = System.Drawing.Color.Black
        Me.cbo_tipo_cliente.FormattingEnabled = True
        Me.cbo_tipo_cliente.Items.AddRange(New Object() {"FISICA", "JURIDICA", "DIMEX"})
        Me.cbo_tipo_cliente.Location = New System.Drawing.Point(9, 36)
        Me.cbo_tipo_cliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_tipo_cliente.Name = "cbo_tipo_cliente"
        Me.cbo_tipo_cliente.Size = New System.Drawing.Size(121, 24)
        Me.cbo_tipo_cliente.TabIndex = 1
        '
        'Txtdireccion
        '
        Me.Txtdireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtdireccion.ForeColor = System.Drawing.Color.Black
        Me.Txtdireccion.Location = New System.Drawing.Point(8, 135)
        Me.Txtdireccion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txtdireccion.Name = "Txtdireccion"
        Me.Txtdireccion.Size = New System.Drawing.Size(523, 20)
        Me.Txtdireccion.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(6, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(273, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Dirección"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_email
        '
        Me.txt_email.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_email.ForeColor = System.Drawing.Color.Black
        Me.txt_email.Location = New System.Drawing.Point(137, 89)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(394, 20)
        Me.txt_email.TabIndex = 5
        '
        'LabelObs
        '
        Me.LabelObs.BackColor = System.Drawing.Color.Transparent
        Me.LabelObs.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelObs.ForeColor = System.Drawing.Color.Black
        Me.LabelObs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelObs.Location = New System.Drawing.Point(134, 69)
        Me.LabelObs.Name = "LabelObs"
        Me.LabelObs.Size = New System.Drawing.Size(49, 17)
        Me.LabelObs.TabIndex = 162
        Me.LabelObs.Text = "Email:"
        Me.LabelObs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTelefono
        '
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono.FieldReference = Nothing
        Me.txtTelefono.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.ForeColor = System.Drawing.Color.Black
        Me.txtTelefono.Location = New System.Drawing.Point(8, 89)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTelefono.MaskEdit = ""
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.txtTelefono.Required = False
        Me.txtTelefono.ShowErrorIcon = True
        Me.txtTelefono.Size = New System.Drawing.Size(122, 20)
        Me.txtTelefono.TabIndex = 4
        Me.txtTelefono.Text = "000 0000"
        Me.txtTelefono.ValidationMode = ValidText.ValidText.ValidationModes.None
        Me.txtTelefono.ValidText = ""
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label38.Location = New System.Drawing.Point(5, 69)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(63, 17)
        Me.Label38.TabIndex = 159
        Me.Label38.Text = "Teléfono"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(241, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(276, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nombre del Cliente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.FieldReference = Nothing
        Me.txtCodigo.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.Location = New System.Drawing.Point(136, 37)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodigo.MaskEdit = ""
        Me.txtCodigo.MaxLength = 20
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.txtCodigo.Required = False
        Me.txtCodigo.ShowErrorIcon = True
        Me.txtCodigo.Size = New System.Drawing.Size(101, 20)
        Me.txtCodigo.TabIndex = 2
        Me.txtCodigo.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.txtCodigo.ValidText = "No se permiten caracteres"
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Location = New System.Drawing.Point(243, 37)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(288, 20)
        Me.txtNombre.TabIndex = 3
        '
        'frm_cliente_rapido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 205)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.btn_guardar)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frm_cliente_rapido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGREGAR CLIENTE"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_guardar As Windows.Forms.Button
    Friend WithEvents GroupBox6 As Windows.Forms.GroupBox
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents cbo_tipo_cliente As Windows.Forms.ComboBox
    Friend WithEvents Txtdireccion As Windows.Forms.TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents txt_email As Windows.Forms.TextBox
    Friend WithEvents LabelObs As Windows.Forms.Label
    Friend WithEvents txtTelefono As ValidText.ValidText
    Friend WithEvents Label38 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txtCodigo As ValidText.ValidText
    Friend WithEvents txtNombre As Windows.Forms.TextBox
End Class
