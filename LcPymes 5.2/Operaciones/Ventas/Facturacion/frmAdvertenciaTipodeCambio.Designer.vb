<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdvertenciaTipodeCambio
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
        Me.lblTexto = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTexto
        '
        Me.lblTexto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto.ForeColor = System.Drawing.Color.Yellow
        Me.lblTexto.Location = New System.Drawing.Point(0, 0)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(499, 168)
        Me.lblTexto.TabIndex = 0
        Me.lblTexto.Text = "Favor confirme con gerencia que el tipo de cambio del dolar sea el correcto"
        Me.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAdvertenciaTipodeCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(499, 168)
        Me.Controls.Add(Me.lblTexto)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdvertenciaTipodeCambio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advertencia"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTexto As System.Windows.Forms.Label
End Class
