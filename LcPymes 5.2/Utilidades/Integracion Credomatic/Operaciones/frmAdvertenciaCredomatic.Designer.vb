Namespace Credomatic
    Namespace Operaciones
        <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
        Partial Class frmAdvertenciaCredomatic
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
                Me.PictureBox1 = New System.Windows.Forms.PictureBox()
                Me.btnAceptar = New System.Windows.Forms.Button()
                Me.lblDetalle = New System.Windows.Forms.Label()
                Me.lblEncabezado = New System.Windows.Forms.Label()
                CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
                Me.SuspendLayout()
                '
                'PictureBox1
                '
                Me.PictureBox1.Image = Global.LcPymes_5._2.My.Resources.Resources.iconfinder_Warning_31226
                Me.PictureBox1.Location = New System.Drawing.Point(2, 1)
                Me.PictureBox1.Name = "PictureBox1"
                Me.PictureBox1.Size = New System.Drawing.Size(129, 133)
                Me.PictureBox1.TabIndex = 0
                Me.PictureBox1.TabStop = False
                '
                'btnAceptar
                '
                Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.btnAceptar.Location = New System.Drawing.Point(306, 89)
                Me.btnAceptar.Name = "btnAceptar"
                Me.btnAceptar.Size = New System.Drawing.Size(150, 34)
                Me.btnAceptar.TabIndex = 1
                Me.btnAceptar.Text = "Aceptar"
                Me.btnAceptar.UseVisualStyleBackColor = True
                '
                'lblDetalle
                '
                Me.lblDetalle.Location = New System.Drawing.Point(137, 35)
                Me.lblDetalle.Name = "lblDetalle"
                Me.lblDetalle.Size = New System.Drawing.Size(319, 51)
                Me.lblDetalle.TabIndex = 2
                Me.lblDetalle.Text = "Label1"
                Me.lblDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                '
                'lblEncabezado
                '
                Me.lblEncabezado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.lblEncabezado.Location = New System.Drawing.Point(137, 1)
                Me.lblEncabezado.Name = "lblEncabezado"
                Me.lblEncabezado.Size = New System.Drawing.Size(319, 34)
                Me.lblEncabezado.TabIndex = 3
                Me.lblEncabezado.Text = "Label1"
                Me.lblEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                '
                'frmAdvertenciaCredomatic
                '
                Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
                Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
                Me.BackColor = System.Drawing.Color.White
                Me.ClientSize = New System.Drawing.Size(468, 135)
                Me.Controls.Add(Me.lblEncabezado)
                Me.Controls.Add(Me.lblDetalle)
                Me.Controls.Add(Me.btnAceptar)
                Me.Controls.Add(Me.PictureBox1)
                Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
                Me.MaximizeBox = False
                Me.MinimizeBox = False
                Me.Name = "frmAdvertenciaCredomatic"
                Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
                Me.Text = "Advertencia"
                CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
                Me.ResumeLayout(False)

            End Sub
            Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
            Friend WithEvents btnAceptar As System.Windows.Forms.Button
            Friend WithEvents lblDetalle As System.Windows.Forms.Label
            Friend WithEvents lblEncabezado As System.Windows.Forms.Label
        End Class
    End Namespace
End Namespace