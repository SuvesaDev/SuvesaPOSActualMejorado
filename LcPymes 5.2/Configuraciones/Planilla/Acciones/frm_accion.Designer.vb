<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_accion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_accion))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Bt_nuevo = New System.Windows.Forms.Button
        Me.Bt_eliminar = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cbo_categoria = New System.Windows.Forms.ComboBox
        Me.ck_anulada = New System.Windows.Forms.CheckBox
        Me.dt_final = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.dt_inicio = New System.Windows.Forms.DateTimePicker
        Me.txt_observaciones = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_empleado = New System.Windows.Forms.TextBox
        Me.txt_nombre_empleado = New System.Windows.Forms.TextBox
        Me.lbid = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Bt_editar = New System.Windows.Forms.Button
        Me.Bt_guardar = New System.Windows.Forms.Button
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Bt_nuevo)
        Me.Panel1.Controls.Add(Me.Bt_eliminar)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Bt_editar)
        Me.Panel1.Controls.Add(Me.Bt_guardar)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(706, 417)
        Me.Panel1.TabIndex = 43
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Gray
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.ImageIndex = 3
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(306, 349)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 55)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "Buscar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
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
        'Bt_nuevo
        '
        Me.Bt_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_nuevo.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_nuevo.ForeColor = System.Drawing.Color.Gray
        Me.Bt_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bt_nuevo.ImageIndex = 1
        Me.Bt_nuevo.ImageList = Me.ImageList1
        Me.Bt_nuevo.Location = New System.Drawing.Point(12, 349)
        Me.Bt_nuevo.Name = "Bt_nuevo"
        Me.Bt_nuevo.Size = New System.Drawing.Size(92, 55)
        Me.Bt_nuevo.TabIndex = 39
        Me.Bt_nuevo.Text = "Nuevo"
        Me.Bt_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bt_nuevo.UseVisualStyleBackColor = True
        '
        'Bt_eliminar
        '
        Me.Bt_eliminar.Enabled = False
        Me.Bt_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_eliminar.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_eliminar.ForeColor = System.Drawing.Color.Gray
        Me.Bt_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bt_eliminar.ImageIndex = 2
        Me.Bt_eliminar.ImageList = Me.ImageList1
        Me.Bt_eliminar.Location = New System.Drawing.Point(404, 349)
        Me.Bt_eliminar.Name = "Bt_eliminar"
        Me.Bt_eliminar.Size = New System.Drawing.Size(92, 55)
        Me.Bt_eliminar.TabIndex = 38
        Me.Bt_eliminar.Text = "Eliminar"
        Me.Bt_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bt_eliminar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MonthCalendar1)
        Me.Panel2.Controls.Add(Me.cbo_categoria)
        Me.Panel2.Controls.Add(Me.ck_anulada)
        Me.Panel2.Controls.Add(Me.dt_final)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.dt_inicio)
        Me.Panel2.Controls.Add(Me.txt_observaciones)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txt_empleado)
        Me.Panel2.Controls.Add(Me.txt_nombre_empleado)
        Me.Panel2.Controls.Add(Me.lbid)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(684, 262)
        Me.Panel2.TabIndex = 40
        '
        'cbo_categoria
        '
        Me.cbo_categoria.BackColor = System.Drawing.Color.White
        Me.cbo_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_categoria.FormattingEnabled = True
        Me.cbo_categoria.Location = New System.Drawing.Point(120, 50)
        Me.cbo_categoria.Name = "cbo_categoria"
        Me.cbo_categoria.Size = New System.Drawing.Size(285, 21)
        Me.cbo_categoria.TabIndex = 45
        '
        'ck_anulada
        '
        Me.ck_anulada.AutoSize = True
        Me.ck_anulada.Enabled = False
        Me.ck_anulada.ForeColor = System.Drawing.Color.DimGray
        Me.ck_anulada.Location = New System.Drawing.Point(15, 152)
        Me.ck_anulada.Name = "ck_anulada"
        Me.ck_anulada.Size = New System.Drawing.Size(65, 17)
        Me.ck_anulada.TabIndex = 44
        Me.ck_anulada.Text = "Anulada"
        Me.ck_anulada.UseVisualStyleBackColor = True
        '
        'dt_final
        '
        Me.dt_final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_final.Location = New System.Drawing.Point(315, 83)
        Me.dt_final.Name = "dt_final"
        Me.dt_final.Size = New System.Drawing.Size(109, 20)
        Me.dt_final.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(235, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Fecha Final:"
        '
        'dt_inicio
        '
        Me.dt_inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_inicio.Location = New System.Drawing.Point(120, 83)
        Me.dt_inicio.Name = "dt_inicio"
        Me.dt_inicio.Size = New System.Drawing.Size(109, 20)
        Me.dt_inicio.TabIndex = 41
        '
        'txt_observaciones
        '
        Me.txt_observaciones.BackColor = System.Drawing.Color.White
        Me.txt_observaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_observaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_observaciones.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_observaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_observaciones.Location = New System.Drawing.Point(120, 114)
        Me.txt_observaciones.MaxLength = 150
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(285, 55)
        Me.txt_observaciones.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(34, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 18)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Observación:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(35, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Fecha Inicio:"
        '
        'txt_empleado
        '
        Me.txt_empleado.BackColor = System.Drawing.Color.White
        Me.txt_empleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_empleado.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_empleado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_empleado.Location = New System.Drawing.Point(120, 16)
        Me.txt_empleado.MaxLength = 50
        Me.txt_empleado.Name = "txt_empleado"
        Me.txt_empleado.Size = New System.Drawing.Size(70, 21)
        Me.txt_empleado.TabIndex = 33
        '
        'txt_nombre_empleado
        '
        Me.txt_nombre_empleado.BackColor = System.Drawing.Color.White
        Me.txt_nombre_empleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nombre_empleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre_empleado.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre_empleado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_nombre_empleado.Location = New System.Drawing.Point(196, 16)
        Me.txt_nombre_empleado.Name = "txt_nombre_empleado"
        Me.txt_nombre_empleado.ReadOnly = True
        Me.txt_nombre_empleado.Size = New System.Drawing.Size(209, 21)
        Me.txt_nombre_empleado.TabIndex = 24
        '
        'lbid
        '
        Me.lbid.AutoSize = True
        Me.lbid.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbid.Location = New System.Drawing.Point(9, 7)
        Me.lbid.Name = "lbid"
        Me.lbid.Size = New System.Drawing.Size(0, 18)
        Me.lbid.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(50, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 18)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Empleado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(50, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Categoría:"
        '
        'Bt_editar
        '
        Me.Bt_editar.Enabled = False
        Me.Bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_editar.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_editar.ForeColor = System.Drawing.Color.Gray
        Me.Bt_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bt_editar.ImageIndex = 4
        Me.Bt_editar.ImageList = Me.ImageList1
        Me.Bt_editar.Location = New System.Drawing.Point(208, 349)
        Me.Bt_editar.Name = "Bt_editar"
        Me.Bt_editar.Size = New System.Drawing.Size(92, 55)
        Me.Bt_editar.TabIndex = 37
        Me.Bt_editar.Text = "Editar"
        Me.Bt_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bt_editar.UseVisualStyleBackColor = True
        '
        'Bt_guardar
        '
        Me.Bt_guardar.Enabled = False
        Me.Bt_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_guardar.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_guardar.ForeColor = System.Drawing.Color.Gray
        Me.Bt_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bt_guardar.ImageIndex = 0
        Me.Bt_guardar.ImageList = Me.ImageList1
        Me.Bt_guardar.Location = New System.Drawing.Point(110, 349)
        Me.Bt_guardar.Name = "Bt_guardar"
        Me.Bt_guardar.Size = New System.Drawing.Size(92, 55)
        Me.Bt_guardar.TabIndex = 36
        Me.Bt_guardar.Text = "Guardar"
        Me.Bt_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bt_guardar.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(446, 9)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 46
        '
        'frm_accion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 428)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_accion"
        Me.Text = "Accion de empleado"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Bt_nuevo As System.Windows.Forms.Button
    Friend WithEvents Bt_eliminar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cbo_categoria As System.Windows.Forms.ComboBox
    Friend WithEvents ck_anulada As System.Windows.Forms.CheckBox
    Friend WithEvents dt_final As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dt_inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_empleado As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_empleado As System.Windows.Forms.TextBox
    Friend WithEvents lbid As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Bt_editar As System.Windows.Forms.Button
    Friend WithEvents Bt_guardar As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
End Class
