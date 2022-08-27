<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilidadxFactura
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
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.lblFactura = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnBuscarFactura = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(768, 5)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(92, 23)
        Me.btnMostrar.TabIndex = 10
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'lblFactura
        '
        Me.lblFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFactura.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblFactura.Location = New System.Drawing.Point(120, 6)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(642, 20)
        Me.lblFactura.TabIndex = 9
        Me.lblFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(2, 34)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(906, 415)
        Me.CrystalReportViewer1.TabIndex = 6
        '
        'btnBuscarFactura
        '
        Me.btnBuscarFactura.Location = New System.Drawing.Point(12, 5)
        Me.btnBuscarFactura.Name = "btnBuscarFactura"
        Me.btnBuscarFactura.Size = New System.Drawing.Size(102, 23)
        Me.btnBuscarFactura.TabIndex = 11
        Me.btnBuscarFactura.Text = "Buscar Factura"
        Me.btnBuscarFactura.UseVisualStyleBackColor = True
        '
        'frmUtilidadxFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 453)
        Me.Controls.Add(Me.btnBuscarFactura)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.lblFactura)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmUtilidadxFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Utilidad por Factura"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents lblFactura As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnBuscarFactura As System.Windows.Forms.Button
End Class
