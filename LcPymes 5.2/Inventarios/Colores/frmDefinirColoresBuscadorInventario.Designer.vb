<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDefinirColoresBuscadorInventario
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ExistenciaNegativa = New System.Windows.Forms.ColorDialog()
        Me.MeDeben = New System.Windows.Forms.ColorDialog()
        Me.YoDebo = New System.Windows.Forms.ColorDialog()
        Me.lblNegativo = New System.Windows.Forms.Label()
        Me.lblYoDebo = New System.Windows.Forms.Label()
        Me.lblMeDeben = New System.Windows.Forms.Label()
        Me.btnNegativo = New System.Windows.Forms.Button()
        Me.btnMeDeben = New System.Windows.Forms.Button()
        Me.btnYoDebo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Articulos con Existencias Negativas "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Defenir Colores"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(233, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Articulos con Prestamos por Devolver"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(219, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Articulos con Prestamos por Cobrar"
        '
        'lblNegativo
        '
        Me.lblNegativo.BackColor = System.Drawing.Color.Red
        Me.lblNegativo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNegativo.Location = New System.Drawing.Point(272, 63)
        Me.lblNegativo.Name = "lblNegativo"
        Me.lblNegativo.Size = New System.Drawing.Size(91, 20)
        Me.lblNegativo.TabIndex = 4
        '
        'lblYoDebo
        '
        Me.lblYoDebo.BackColor = System.Drawing.Color.Green
        Me.lblYoDebo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYoDebo.Location = New System.Drawing.Point(272, 114)
        Me.lblYoDebo.Name = "lblYoDebo"
        Me.lblYoDebo.Size = New System.Drawing.Size(91, 20)
        Me.lblYoDebo.TabIndex = 5
        '
        'lblMeDeben
        '
        Me.lblMeDeben.BackColor = System.Drawing.Color.Orange
        Me.lblMeDeben.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMeDeben.Location = New System.Drawing.Point(272, 159)
        Me.lblMeDeben.Name = "lblMeDeben"
        Me.lblMeDeben.Size = New System.Drawing.Size(91, 20)
        Me.lblMeDeben.TabIndex = 6
        '
        'btnNegativo
        '
        Me.btnNegativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNegativo.Image = Global.LcPymes_5._2.My.Resources.Resources.color_wheel
        Me.btnNegativo.Location = New System.Drawing.Point(366, 63)
        Me.btnNegativo.Name = "btnNegativo"
        Me.btnNegativo.Size = New System.Drawing.Size(21, 20)
        Me.btnNegativo.TabIndex = 7
        Me.btnNegativo.UseVisualStyleBackColor = True
        '
        'btnMeDeben
        '
        Me.btnMeDeben.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMeDeben.Image = Global.LcPymes_5._2.My.Resources.Resources.color_wheel
        Me.btnMeDeben.Location = New System.Drawing.Point(366, 159)
        Me.btnMeDeben.Name = "btnMeDeben"
        Me.btnMeDeben.Size = New System.Drawing.Size(21, 20)
        Me.btnMeDeben.TabIndex = 8
        Me.btnMeDeben.UseVisualStyleBackColor = True
        '
        'btnYoDebo
        '
        Me.btnYoDebo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYoDebo.Image = Global.LcPymes_5._2.My.Resources.Resources.color_wheel
        Me.btnYoDebo.Location = New System.Drawing.Point(366, 114)
        Me.btnYoDebo.Name = "btnYoDebo"
        Me.btnYoDebo.Size = New System.Drawing.Size(21, 20)
        Me.btnYoDebo.TabIndex = 9
        Me.btnYoDebo.UseVisualStyleBackColor = True
        '
        'frmDefinirColoresBuscadorInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 217)
        Me.Controls.Add(Me.btnYoDebo)
        Me.Controls.Add(Me.btnMeDeben)
        Me.Controls.Add(Me.btnNegativo)
        Me.Controls.Add(Me.lblMeDeben)
        Me.Controls.Add(Me.lblYoDebo)
        Me.Controls.Add(Me.lblNegativo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDefinirColoresBuscadorInventario"
        Me.Text = "Definir Colores Inventario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ExistenciaNegativa As System.Windows.Forms.ColorDialog
    Friend WithEvents MeDeben As System.Windows.Forms.ColorDialog
    Friend WithEvents YoDebo As System.Windows.Forms.ColorDialog
    Friend WithEvents lblNegativo As System.Windows.Forms.Label
    Friend WithEvents lblYoDebo As System.Windows.Forms.Label
    Friend WithEvents lblMeDeben As System.Windows.Forms.Label
    Friend WithEvents btnNegativo As System.Windows.Forms.Button
    Friend WithEvents btnMeDeben As System.Windows.Forms.Button
    Friend WithEvents btnYoDebo As System.Windows.Forms.Button
End Class
