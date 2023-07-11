<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInhabilitarExistenciaCero
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
        Me.btnInhabilitarCero = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnInhabilitarCero
        '
        Me.btnInhabilitarCero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInhabilitarCero.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInhabilitarCero.Location = New System.Drawing.Point(79, 33)
        Me.btnInhabilitarCero.Name = "btnInhabilitarCero"
        Me.btnInhabilitarCero.Size = New System.Drawing.Size(206, 72)
        Me.btnInhabilitarCero.TabIndex = 0
        Me.btnInhabilitarCero.Text = "Inhabilitar Existencia Cero"
        Me.btnInhabilitarCero.UseVisualStyleBackColor = True
        '
        'frmInhabilitarExistenciaCero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 139)
        Me.Controls.Add(Me.btnInhabilitarCero)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInhabilitarExistenciaCero"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inhabilitar Existencia Cero"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInhabilitarCero As System.Windows.Forms.Button
End Class
