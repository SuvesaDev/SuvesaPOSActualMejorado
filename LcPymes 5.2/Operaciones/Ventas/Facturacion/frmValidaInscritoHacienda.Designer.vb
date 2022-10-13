<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmValidaInscritoHacienda
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
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.btnValidarClientes = New System.Windows.Forms.Button()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'viewDatos
        '
        Me.viewDatos.BackgroundColor = System.Drawing.Color.White
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Location = New System.Drawing.Point(12, 73)
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.RowTemplate.Height = 24
        Me.viewDatos.Size = New System.Drawing.Size(1002, 627)
        Me.viewDatos.TabIndex = 0
        '
        'btnValidarClientes
        '
        Me.btnValidarClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidarClientes.Location = New System.Drawing.Point(12, 12)
        Me.btnValidarClientes.Name = "btnValidarClientes"
        Me.btnValidarClientes.Size = New System.Drawing.Size(256, 51)
        Me.btnValidarClientes.TabIndex = 1
        Me.btnValidarClientes.Text = "Validar Registro Hacienda"
        Me.btnValidarClientes.UseVisualStyleBackColor = True
        '
        'frmValidaInscritoHacienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 712)
        Me.Controls.Add(Me.btnValidarClientes)
        Me.Controls.Add(Me.viewDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmValidaInscritoHacienda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Valida Inscripciones en Hacienda"
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents btnValidarClientes As System.Windows.Forms.Button
End Class
