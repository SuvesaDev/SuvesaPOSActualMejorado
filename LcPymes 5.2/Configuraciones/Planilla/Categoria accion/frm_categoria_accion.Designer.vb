<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_categoria_accion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_categoria_accion))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lb_id = New System.Windows.Forms.Label
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Bt_guardar = New System.Windows.Forms.Button
        Me.Bt_nuevo = New System.Windows.Forms.Button
        Me.Bt_editar = New System.Windows.Forms.Button
        Me.Bt_eliminar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Bt_guardar)
        Me.Panel1.Controls.Add(Me.Bt_nuevo)
        Me.Panel1.Controls.Add(Me.Bt_editar)
        Me.Panel1.Controls.Add(Me.Bt_eliminar)
        Me.Panel1.Location = New System.Drawing.Point(-3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(522, 147)
        Me.Panel1.TabIndex = 49
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lb_id)
        Me.Panel2.Controls.Add(Me.txt_nombre)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(18, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(484, 65)
        Me.Panel2.TabIndex = 46
        '
        'lb_id
        '
        Me.lb_id.AutoSize = True
        Me.lb_id.Location = New System.Drawing.Point(11, 17)
        Me.lb_id.Name = "lb_id"
        Me.lb_id.Size = New System.Drawing.Size(0, 13)
        Me.lb_id.TabIndex = 25
        '
        'txt_nombre
        '
        Me.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.ForeColor = System.Drawing.Color.Gray
        Me.txt_nombre.Location = New System.Drawing.Point(177, 21)
        Me.txt_nombre.MaxLength = 150
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(209, 21)
        Me.txt_nombre.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(124, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 18)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nombre:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Gray
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.ImageIndex = 3
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(312, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 55)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "Buscar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Bt_guardar
        '
        Me.Bt_guardar.BackColor = System.Drawing.Color.White
        Me.Bt_guardar.Enabled = False
        Me.Bt_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_guardar.ForeColor = System.Drawing.Color.Gray
        Me.Bt_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bt_guardar.ImageIndex = 0
        Me.Bt_guardar.ImageList = Me.ImageList1
        Me.Bt_guardar.Location = New System.Drawing.Point(116, 80)
        Me.Bt_guardar.Name = "Bt_guardar"
        Me.Bt_guardar.Size = New System.Drawing.Size(92, 55)
        Me.Bt_guardar.TabIndex = 42
        Me.Bt_guardar.Text = "Guardar"
        Me.Bt_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bt_guardar.UseVisualStyleBackColor = False
        '
        'Bt_nuevo
        '
        Me.Bt_nuevo.BackColor = System.Drawing.Color.White
        Me.Bt_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_nuevo.ForeColor = System.Drawing.Color.Gray
        Me.Bt_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bt_nuevo.ImageIndex = 1
        Me.Bt_nuevo.ImageList = Me.ImageList1
        Me.Bt_nuevo.Location = New System.Drawing.Point(18, 80)
        Me.Bt_nuevo.Name = "Bt_nuevo"
        Me.Bt_nuevo.Size = New System.Drawing.Size(92, 55)
        Me.Bt_nuevo.TabIndex = 45
        Me.Bt_nuevo.Text = "Nuevo"
        Me.Bt_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bt_nuevo.UseVisualStyleBackColor = False
        '
        'Bt_editar
        '
        Me.Bt_editar.BackColor = System.Drawing.Color.White
        Me.Bt_editar.Enabled = False
        Me.Bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_editar.ForeColor = System.Drawing.Color.Gray
        Me.Bt_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bt_editar.ImageIndex = 4
        Me.Bt_editar.ImageList = Me.ImageList1
        Me.Bt_editar.Location = New System.Drawing.Point(214, 80)
        Me.Bt_editar.Name = "Bt_editar"
        Me.Bt_editar.Size = New System.Drawing.Size(92, 55)
        Me.Bt_editar.TabIndex = 43
        Me.Bt_editar.Text = "Editar"
        Me.Bt_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bt_editar.UseVisualStyleBackColor = False
        '
        'Bt_eliminar
        '
        Me.Bt_eliminar.BackColor = System.Drawing.Color.White
        Me.Bt_eliminar.Enabled = False
        Me.Bt_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_eliminar.ForeColor = System.Drawing.Color.Gray
        Me.Bt_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bt_eliminar.ImageIndex = 2
        Me.Bt_eliminar.ImageList = Me.ImageList1
        Me.Bt_eliminar.Location = New System.Drawing.Point(410, 80)
        Me.Bt_eliminar.Name = "Bt_eliminar"
        Me.Bt_eliminar.Size = New System.Drawing.Size(92, 55)
        Me.Bt_eliminar.TabIndex = 44
        Me.Bt_eliminar.Text = "Eliminar"
        Me.Bt_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bt_eliminar.UseVisualStyleBackColor = False
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
        'frm_categoria_accion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 155)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_categoria_accion"
        Me.Text = "Categoría Acción"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lb_id As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Bt_guardar As System.Windows.Forms.Button
    Friend WithEvents Bt_nuevo As System.Windows.Forms.Button
    Friend WithEvents Bt_editar As System.Windows.Forms.Button
    Friend WithEvents Bt_eliminar As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
