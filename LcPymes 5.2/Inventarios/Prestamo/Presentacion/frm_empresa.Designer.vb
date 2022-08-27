Imports System.Windows.Forms
Namespace Prestamos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frm_empresa
        Inherits System.Windows.Forms.Form

        'Form reemplaza a Dispose para limpiar la lista de componentes.
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

        'Requerido por el Diseñador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        'Se puede modificar usando el Diseñador de Windows Forms.  
        'No lo modifique con el editor de código.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.lb_id = New System.Windows.Forms.Label()
            Me.txt_nombre = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.bt_nuevo = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.bt_guardar = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.bt_editar = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
            Me.bt_buscar = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
            Me.bt_eliminar = New System.Windows.Forms.ToolStripButton()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Location = New System.Drawing.Point(0, 28)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(500, 108)
            Me.Panel1.TabIndex = 43
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.lb_id)
            Me.Panel2.Controls.Add(Me.txt_nombre)
            Me.Panel2.Controls.Add(Me.Label2)
            Me.Panel2.Location = New System.Drawing.Point(8, 8)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(484, 83)
            Me.Panel2.TabIndex = 40
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
            Me.txt_nombre.Location = New System.Drawing.Point(214, 35)
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
            Me.Label2.Location = New System.Drawing.Point(76, 37)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(132, 18)
            Me.Label2.TabIndex = 20
            Me.Label2.Text = "Nombre de la empresa"
            '
            'ToolStrip1
            '
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bt_nuevo, Me.ToolStripSeparator1, Me.bt_guardar, Me.ToolStripSeparator2, Me.bt_editar, Me.ToolStripSeparator3, Me.bt_buscar, Me.ToolStripSeparator4, Me.bt_eliminar})
            Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(505, 25)
            Me.ToolStrip1.TabIndex = 44
            Me.ToolStrip1.Text = "ToolStrip1"
            '
            'bt_nuevo
            '
            Me.bt_nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.bt_nuevo.Image = My.Resources.Resources._001_file
            Me.bt_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.bt_nuevo.Name = "bt_nuevo"
            Me.bt_nuevo.Size = New System.Drawing.Size(23, 22)
            Me.bt_nuevo.Text = "ToolStripButton1"
            '
            'ToolStripSeparator1
            '
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
            '
            'bt_guardar
            '
            Me.bt_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.bt_guardar.Image = My.Resources.Resources._005_floppy_disk
            Me.bt_guardar.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.bt_guardar.Name = "bt_guardar"
            Me.bt_guardar.Size = New System.Drawing.Size(23, 22)
            Me.bt_guardar.Text = "ToolStripButton1"
            '
            'ToolStripSeparator2
            '
            Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
            Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
            '
            'bt_editar
            '
            Me.bt_editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.bt_editar.Image = My.Resources.Resources._002_pen
            Me.bt_editar.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.bt_editar.Name = "bt_editar"
            Me.bt_editar.Size = New System.Drawing.Size(23, 22)
            Me.bt_editar.Text = "ToolStripButton2"
            '
            'ToolStripSeparator3
            '
            Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
            Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
            '
            'bt_buscar
            '
            Me.bt_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.bt_buscar.Image = My.Resources.Resources._003_search_engine
            Me.bt_buscar.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.bt_buscar.Name = "bt_buscar"
            Me.bt_buscar.Size = New System.Drawing.Size(23, 22)
            Me.bt_buscar.Text = "ToolStripButton3"
            '
            'ToolStripSeparator4
            '
            Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
            Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
            '
            'bt_eliminar
            '
            Me.bt_eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.bt_eliminar.Image = My.Resources.Resources._004_delete
            Me.bt_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.bt_eliminar.Name = "bt_eliminar"
            Me.bt_eliminar.Size = New System.Drawing.Size(23, 22)
            Me.bt_eliminar.Text = "ToolStripButton4"
            '
            'frm_empresa
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(505, 142)
            Me.Controls.Add(Me.ToolStrip1)
            Me.Controls.Add(Me.Panel1)
            Me.Name = "frm_empresa"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Empresa"
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Panel1 As Panel
        Friend WithEvents Panel2 As Panel
        Friend WithEvents lb_id As Label
        Friend WithEvents txt_nombre As TextBox
        Friend WithEvents Label2 As Label
        Friend WithEvents ToolStrip1 As ToolStrip
        Friend WithEvents bt_nuevo As ToolStripButton
        Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
        Friend WithEvents bt_guardar As ToolStripButton
        Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
        Friend WithEvents bt_editar As ToolStripButton
        Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
        Friend WithEvents bt_buscar As ToolStripButton
        Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
        Friend WithEvents bt_eliminar As ToolStripButton
    End Class

End Namespace
