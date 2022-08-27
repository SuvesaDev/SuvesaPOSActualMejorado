<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conecta_Frm
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
        Me.Mensaje_Lab = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Mensaje_Lab
        '
        Me.Mensaje_Lab.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mensaje_Lab.Location = New System.Drawing.Point(7, 11)
        Me.Mensaje_Lab.Name = "Mensaje_Lab"
        Me.Mensaje_Lab.Size = New System.Drawing.Size(174, 50)
        Me.Mensaje_Lab.TabIndex = 0
        Me.Mensaje_Lab.Text = "Conectando"
        Me.Mensaje_Lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Conecta_Frm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(192, 77)
        Me.ControlBox = False
        Me.Controls.Add(Me.Mensaje_Lab)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Conecta_Frm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Mensaje_Lab As System.Windows.Forms.Label
End Class
