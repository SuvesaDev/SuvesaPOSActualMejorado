<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaldoPendiente
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
        Me.lblSaldoPendiete = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSaldoPendiete
        '
        Me.lblSaldoPendiete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSaldoPendiete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoPendiete.Location = New System.Drawing.Point(0, 0)
        Me.lblSaldoPendiete.Name = "lblSaldoPendiete"
        Me.lblSaldoPendiete.Size = New System.Drawing.Size(502, 126)
        Me.lblSaldoPendiete.TabIndex = 0
        Me.lblSaldoPendiete.Text = "Label1"
        Me.lblSaldoPendiete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSaldoPendiente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 126)
        Me.Controls.Add(Me.lblSaldoPendiete)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSaldoPendiente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saldo Pendiente"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSaldoPendiete As System.Windows.Forms.Label
End Class
