Namespace Credomatic
    Namespace Configuracion
        <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
        Partial Class frmConfiguracionTerminal
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
                Me.txtTerminar = New System.Windows.Forms.TextBox()
                Me.Label2 = New System.Windows.Forms.Label()
                Me.btnCancelar = New System.Windows.Forms.Button()
                Me.btnAceptar = New System.Windows.Forms.Button()
                Me.txtImpresora = New System.Windows.Forms.TextBox()
                Me.Label3 = New System.Windows.Forms.Label()
                Me.btnBuscarImpresora = New System.Windows.Forms.Button()
                Me.ckDatafono = New System.Windows.Forms.CheckBox()
                Me.SuspendLayout()
                '
                'Label1
                '
                Me.Label1.AutoSize = True
                Me.Label1.Location = New System.Drawing.Point(23, 89)
                Me.Label1.Name = "Label1"
                Me.Label1.Size = New System.Drawing.Size(114, 13)
                Me.Label1.TabIndex = 0
                Me.Label1.Text = "Nombre de la Terminar"
                '
                'txtTerminar
                '
                Me.txtTerminar.Location = New System.Drawing.Point(26, 105)
                Me.txtTerminar.Name = "txtTerminar"
                Me.txtTerminar.Size = New System.Drawing.Size(255, 20)
                Me.txtTerminar.TabIndex = 1
                '
                'Label2
                '
                Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                Me.Label2.Location = New System.Drawing.Point(26, 14)
                Me.Label2.Name = "Label2"
                Me.Label2.Size = New System.Drawing.Size(255, 63)
                Me.Label2.TabIndex = 2
                Me.Label2.Text = "NOTA:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "El nombre de la terminar lo debe dar credomatic"
                Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
                '
                'btnCancelar
                '
                Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.btnCancelar.Location = New System.Drawing.Point(174, 201)
                Me.btnCancelar.Name = "btnCancelar"
                Me.btnCancelar.Size = New System.Drawing.Size(107, 41)
                Me.btnCancelar.TabIndex = 3
                Me.btnCancelar.Text = "Cancelar"
                Me.btnCancelar.UseVisualStyleBackColor = True
                '
                'btnAceptar
                '
                Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.btnAceptar.Location = New System.Drawing.Point(61, 201)
                Me.btnAceptar.Name = "btnAceptar"
                Me.btnAceptar.Size = New System.Drawing.Size(107, 41)
                Me.btnAceptar.TabIndex = 4
                Me.btnAceptar.Text = "Aceptar"
                Me.btnAceptar.UseVisualStyleBackColor = True
                '
                'txtImpresora
                '
                Me.txtImpresora.Location = New System.Drawing.Point(61, 145)
                Me.txtImpresora.Name = "txtImpresora"
                Me.txtImpresora.ReadOnly = True
                Me.txtImpresora.Size = New System.Drawing.Size(220, 20)
                Me.txtImpresora.TabIndex = 6
                '
                'Label3
                '
                Me.Label3.AutoSize = True
                Me.Label3.Location = New System.Drawing.Point(23, 129)
                Me.Label3.Name = "Label3"
                Me.Label3.Size = New System.Drawing.Size(96, 13)
                Me.Label3.TabIndex = 5
                Me.Label3.Text = "Impresora Voucher"
                '
                'btnBuscarImpresora
                '
                Me.btnBuscarImpresora.Location = New System.Drawing.Point(26, 144)
                Me.btnBuscarImpresora.Name = "btnBuscarImpresora"
                Me.btnBuscarImpresora.Size = New System.Drawing.Size(32, 20)
                Me.btnBuscarImpresora.TabIndex = 7
                Me.btnBuscarImpresora.Text = "..."
                Me.btnBuscarImpresora.UseVisualStyleBackColor = True
                '
                'ckDatafono
                '
                Me.ckDatafono.AutoSize = True
                Me.ckDatafono.Location = New System.Drawing.Point(26, 178)
                Me.ckDatafono.Name = "ckDatafono"
                Me.ckDatafono.Size = New System.Drawing.Size(126, 17)
                Me.ckDatafono.TabIndex = 8
                Me.ckDatafono.Text = "Datafono Automatico"
                Me.ckDatafono.UseVisualStyleBackColor = True
                '
                'frmConfiguracionTerminal
                '
                Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
                Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
                Me.ClientSize = New System.Drawing.Size(287, 254)
                Me.Controls.Add(Me.ckDatafono)
                Me.Controls.Add(Me.btnBuscarImpresora)
                Me.Controls.Add(Me.txtImpresora)
                Me.Controls.Add(Me.Label3)
                Me.Controls.Add(Me.btnAceptar)
                Me.Controls.Add(Me.btnCancelar)
                Me.Controls.Add(Me.Label2)
                Me.Controls.Add(Me.txtTerminar)
                Me.Controls.Add(Me.Label1)
                Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
                Me.MaximizeBox = False
                Me.MinimizeBox = False
                Me.Name = "frmConfiguracionTerminal"
                Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
                Me.Text = "Configuracion Terminal"
                Me.ResumeLayout(False)
                Me.PerformLayout()

            End Sub
            Friend WithEvents Label1 As System.Windows.Forms.Label
            Friend WithEvents txtTerminar As System.Windows.Forms.TextBox
            Friend WithEvents Label2 As System.Windows.Forms.Label
            Friend WithEvents btnCancelar As System.Windows.Forms.Button
            Friend WithEvents btnAceptar As System.Windows.Forms.Button
            Friend WithEvents txtImpresora As System.Windows.Forms.TextBox
            Friend WithEvents Label3 As System.Windows.Forms.Label
            Friend WithEvents btnBuscarImpresora As System.Windows.Forms.Button
            Friend WithEvents ckDatafono As System.Windows.Forms.CheckBox
        End Class

    End Namespace
End Namespace
