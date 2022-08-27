<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_empleados
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_empleados))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Bt_nuevo = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button2 = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.ck_activo = New System.Windows.Forms.CheckBox
        Me.dt_fecha_salida = New System.Windows.Forms.DateTimePicker
        Me.dt_fecha_ingreso = New System.Windows.Forms.DateTimePicker
        Me.txt_telefono = New System.Windows.Forms.MaskedTextBox
        Me.txt_salario = New System.Windows.Forms.NumericUpDown
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_puesto = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_apellidos = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_cedula = New System.Windows.Forms.TextBox
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Bt_guardar = New System.Windows.Forms.Button
        Me.Bt_eliminar = New System.Windows.Forms.Button
        Me.Bt_editar = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.txt_salario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Bt_nuevo)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Bt_guardar)
        Me.Panel1.Controls.Add(Me.Bt_eliminar)
        Me.Panel1.Controls.Add(Me.Bt_editar)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(515, 271)
        Me.Panel1.TabIndex = 43
        '
        'Bt_nuevo
        '
        Me.Bt_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_nuevo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_nuevo.ForeColor = System.Drawing.Color.Gray
        Me.Bt_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bt_nuevo.ImageIndex = 1
        Me.Bt_nuevo.ImageList = Me.ImageList1
        Me.Bt_nuevo.Location = New System.Drawing.Point(16, 203)
        Me.Bt_nuevo.Name = "Bt_nuevo"
        Me.Bt_nuevo.Size = New System.Drawing.Size(92, 55)
        Me.Bt_nuevo.TabIndex = 39
        Me.Bt_nuevo.Text = "Nuevo"
        Me.Bt_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bt_nuevo.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "1437535964_floppy.png")
        Me.ImageList1.Images.SetKeyName(1, "1437535974_sign-add.png")
        Me.ImageList1.Images.SetKeyName(2, "1437535982_sign-error.png")
        Me.ImageList1.Images.SetKeyName(3, "1437535991_search.png")
        Me.ImageList1.Images.SetKeyName(4, "1437536010_pencil.png")
        Me.ImageList1.Images.SetKeyName(5, "1437536057_sign-ban.png")
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Gray
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.ImageIndex = 3
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(310, 203)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 55)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "Buscar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ck_activo)
        Me.Panel2.Controls.Add(Me.dt_fecha_salida)
        Me.Panel2.Controls.Add(Me.dt_fecha_ingreso)
        Me.Panel2.Controls.Add(Me.txt_telefono)
        Me.Panel2.Controls.Add(Me.txt_salario)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txt_puesto)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txt_apellidos)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txt_cedula)
        Me.Panel2.Controls.Add(Me.txt_nombre)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Enabled = False
        Me.Panel2.Location = New System.Drawing.Point(9, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(491, 191)
        Me.Panel2.TabIndex = 40
        '
        'ck_activo
        '
        Me.ck_activo.AutoSize = True
        Me.ck_activo.ForeColor = System.Drawing.Color.Gray
        Me.ck_activo.Location = New System.Drawing.Point(340, 152)
        Me.ck_activo.Name = "ck_activo"
        Me.ck_activo.Size = New System.Drawing.Size(56, 17)
        Me.ck_activo.TabIndex = 44
        Me.ck_activo.Text = "Activo"
        Me.ck_activo.UseVisualStyleBackColor = True
        '
        'dt_fecha_salida
        '
        Me.dt_fecha_salida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fecha_salida.Location = New System.Drawing.Point(145, 119)
        Me.dt_fecha_salida.Name = "dt_fecha_salida"
        Me.dt_fecha_salida.Size = New System.Drawing.Size(111, 20)
        Me.dt_fecha_salida.TabIndex = 43
        '
        'dt_fecha_ingreso
        '
        Me.dt_fecha_ingreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fecha_ingreso.Location = New System.Drawing.Point(145, 93)
        Me.dt_fecha_ingreso.Name = "dt_fecha_ingreso"
        Me.dt_fecha_ingreso.Size = New System.Drawing.Size(111, 20)
        Me.dt_fecha_ingreso.TabIndex = 43
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(340, 96)
        Me.txt_telefono.Mask = "0000-0000"
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(100, 20)
        Me.txt_telefono.TabIndex = 42
        '
        'txt_salario
        '
        Me.txt_salario.Location = New System.Drawing.Point(340, 120)
        Me.txt_salario.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.txt_salario.Name = "txt_salario"
        Me.txt_salario.Size = New System.Drawing.Size(104, 20)
        Me.txt_salario.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(94, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 18)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Puesto:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(286, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 18)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Salario:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(274, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 18)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Telefono:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(47, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 18)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Fecha de salida:"
        '
        'txt_puesto
        '
        Me.txt_puesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_puesto.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_puesto.Location = New System.Drawing.Point(146, 148)
        Me.txt_puesto.Name = "txt_puesto"
        Me.txt_puesto.Size = New System.Drawing.Size(124, 21)
        Me.txt_puesto.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(55, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 18)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Fecha Ingreso:"
        '
        'txt_apellidos
        '
        Me.txt_apellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_apellidos.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_apellidos.Location = New System.Drawing.Point(146, 66)
        Me.txt_apellidos.Name = "txt_apellidos"
        Me.txt_apellidos.Size = New System.Drawing.Size(209, 21)
        Me.txt_apellidos.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(83, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 18)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Apellidos:"
        '
        'txt_cedula
        '
        Me.txt_cedula.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cedula.Location = New System.Drawing.Point(145, 11)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(70, 21)
        Me.txt_cedula.TabIndex = 33
        '
        'txt_nombre
        '
        Me.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(145, 39)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(209, 21)
        Me.txt_nombre.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(95, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 18)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Cedula:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(89, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 18)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nombre:"
        '
        'Bt_guardar
        '
        Me.Bt_guardar.Enabled = False
        Me.Bt_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_guardar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_guardar.ForeColor = System.Drawing.Color.Gray
        Me.Bt_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bt_guardar.ImageIndex = 0
        Me.Bt_guardar.ImageList = Me.ImageList1
        Me.Bt_guardar.Location = New System.Drawing.Point(114, 203)
        Me.Bt_guardar.Name = "Bt_guardar"
        Me.Bt_guardar.Size = New System.Drawing.Size(92, 55)
        Me.Bt_guardar.TabIndex = 36
        Me.Bt_guardar.Text = "Guardar"
        Me.Bt_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bt_guardar.UseVisualStyleBackColor = True
        '
        'Bt_eliminar
        '
        Me.Bt_eliminar.Enabled = False
        Me.Bt_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_eliminar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_eliminar.ForeColor = System.Drawing.Color.Gray
        Me.Bt_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bt_eliminar.ImageKey = "1437535982_sign-error.png"
        Me.Bt_eliminar.ImageList = Me.ImageList1
        Me.Bt_eliminar.Location = New System.Drawing.Point(408, 203)
        Me.Bt_eliminar.Name = "Bt_eliminar"
        Me.Bt_eliminar.Size = New System.Drawing.Size(92, 55)
        Me.Bt_eliminar.TabIndex = 38
        Me.Bt_eliminar.Text = "Eliminar"
        Me.Bt_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bt_eliminar.UseVisualStyleBackColor = True
        '
        'Bt_editar
        '
        Me.Bt_editar.Enabled = False
        Me.Bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_editar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_editar.ForeColor = System.Drawing.Color.Gray
        Me.Bt_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bt_editar.ImageIndex = 4
        Me.Bt_editar.ImageList = Me.ImageList1
        Me.Bt_editar.Location = New System.Drawing.Point(212, 203)
        Me.Bt_editar.Name = "Bt_editar"
        Me.Bt_editar.Size = New System.Drawing.Size(92, 55)
        Me.Bt_editar.TabIndex = 37
        Me.Bt_editar.Text = "Editar"
        Me.Bt_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bt_editar.UseVisualStyleBackColor = True
        '
        'frm_empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 276)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_empleados"
        Me.Text = "Empleados"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txt_salario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Bt_nuevo As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ck_activo As System.Windows.Forms.CheckBox
    Friend WithEvents dt_fecha_salida As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_fecha_ingreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_telefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_salario As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_puesto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_apellidos As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_cedula As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Bt_guardar As System.Windows.Forms.Button
    Friend WithEvents Bt_eliminar As System.Windows.Forms.Button
    Friend WithEvents Bt_editar As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
