Namespace Modulos
    Namespace FE
        <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
        Partial Class frmBuscarListaActividad
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
                Me.viewDatos = New System.Windows.Forms.DataGridView()
                Me.btnAceptar = New System.Windows.Forms.Button()
                Me.btnCancelar = New System.Windows.Forms.Button()
                Me.Label1 = New System.Windows.Forms.Label()
                Me.txtBuscar = New System.Windows.Forms.TextBox()
                CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
                Me.SuspendLayout()
                '
                'viewDatos
                '
                Me.viewDatos.AllowUserToAddRows = False
                Me.viewDatos.AllowUserToDeleteRows = False
                Me.viewDatos.AllowUserToResizeColumns = False
                Me.viewDatos.AllowUserToResizeRows = False
                Me.viewDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                Me.viewDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
                Me.viewDatos.BackgroundColor = System.Drawing.Color.White
                Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
                Me.viewDatos.Location = New System.Drawing.Point(4, 4)
                Me.viewDatos.Margin = New System.Windows.Forms.Padding(2)
                Me.viewDatos.MultiSelect = False
                Me.viewDatos.Name = "viewDatos"
                Me.viewDatos.ReadOnly = True
                Me.viewDatos.RowHeadersVisible = False
                Me.viewDatos.RowTemplate.Height = 30
                Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
                Me.viewDatos.Size = New System.Drawing.Size(811, 380)
                Me.viewDatos.TabIndex = 2
                '
                'btnAceptar
                '
                Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.btnAceptar.Location = New System.Drawing.Point(574, 388)
                Me.btnAceptar.Margin = New System.Windows.Forms.Padding(2)
                Me.btnAceptar.Name = "btnAceptar"
                Me.btnAceptar.Size = New System.Drawing.Size(118, 36)
                Me.btnAceptar.TabIndex = 3
                Me.btnAceptar.Text = "Aceptar"
                Me.btnAceptar.UseVisualStyleBackColor = True
                '
                'btnCancelar
                '
                Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.btnCancelar.Location = New System.Drawing.Point(697, 388)
                Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
                Me.btnCancelar.Name = "btnCancelar"
                Me.btnCancelar.Size = New System.Drawing.Size(118, 36)
                Me.btnCancelar.TabIndex = 4
                Me.btnCancelar.Text = "Cancelar"
                Me.btnCancelar.UseVisualStyleBackColor = True
                '
                'Label1
                '
                Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
                Me.Label1.AutoSize = True
                Me.Label1.Location = New System.Drawing.Point(7, 388)
                Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
                Me.Label1.Name = "Label1"
                Me.Label1.Size = New System.Drawing.Size(231, 13)
                Me.Label1.TabIndex = 19
                Me.Label1.Text = "Descripcion o Codigo de la actividad a Buscar :"
                '
                'txtBuscar
                '
                Me.txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
                Me.txtBuscar.Location = New System.Drawing.Point(4, 404)
                Me.txtBuscar.Margin = New System.Windows.Forms.Padding(2)
                Me.txtBuscar.Name = "txtBuscar"
                Me.txtBuscar.Size = New System.Drawing.Size(566, 20)
                Me.txtBuscar.TabIndex = 1
                '
                'frmBuscarListaActividad
                '
                Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
                Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
                Me.ClientSize = New System.Drawing.Size(819, 432)
                Me.Controls.Add(Me.Label1)
                Me.Controls.Add(Me.txtBuscar)
                Me.Controls.Add(Me.btnAceptar)
                Me.Controls.Add(Me.btnCancelar)
                Me.Controls.Add(Me.viewDatos)
                Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
                Me.MaximizeBox = False
                Me.MinimizeBox = False
                Me.Name = "frmBuscarListaActividad"
                Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
                Me.Text = "Buscar Actividad Economica"
                CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
                Me.ResumeLayout(False)
                Me.PerformLayout()

            End Sub
            Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
            Friend WithEvents btnAceptar As System.Windows.Forms.Button
            Friend WithEvents btnCancelar As System.Windows.Forms.Button
            Friend WithEvents Label1 As System.Windows.Forms.Label
            Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
        End Class
    End Namespace
End Namespace


