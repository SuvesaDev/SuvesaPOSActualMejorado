<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleApertura
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
        Me.VisorReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnBuscarApertura = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'VisorReporte
        '
        Me.VisorReporte.ActiveViewIndex = -1
        Me.VisorReporte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VisorReporte.AutoScroll = True
        Me.VisorReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VisorReporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.VisorReporte.Location = New System.Drawing.Point(1, 57)
        Me.VisorReporte.Name = "VisorReporte"
        Me.VisorReporte.SelectionFormula = ""
        Me.VisorReporte.ShowCloseButton = False
        Me.VisorReporte.Size = New System.Drawing.Size(1053, 425)
        Me.VisorReporte.TabIndex = 121
        Me.VisorReporte.ViewTimeSelectionFormula = ""
        '
        'btnBuscarApertura
        '
        Me.btnBuscarApertura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarApertura.Location = New System.Drawing.Point(12, 12)
        Me.btnBuscarApertura.Name = "btnBuscarApertura"
        Me.btnBuscarApertura.Size = New System.Drawing.Size(205, 30)
        Me.btnBuscarApertura.TabIndex = 122
        Me.btnBuscarApertura.Text = "Buscar Caja"
        Me.btnBuscarApertura.UseVisualStyleBackColor = True
        '
        'frmDetalleApertura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 483)
        Me.Controls.Add(Me.btnBuscarApertura)
        Me.Controls.Add(Me.VisorReporte)
        Me.Name = "frmDetalleApertura"
        Me.Text = "frmDetalleApertura"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VisorReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnBuscarApertura As System.Windows.Forms.Button
End Class
