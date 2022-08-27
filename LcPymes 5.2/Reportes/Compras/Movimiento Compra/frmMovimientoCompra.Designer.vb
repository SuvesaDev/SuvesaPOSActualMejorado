<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientoCompra
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
        Me.VisorReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.lblCompra = New System.Windows.Forms.Label()
        Me.btnMostrar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBuscarCompra = New DevExpress.XtraEditors.SimpleButton()
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
        Me.VisorReporte.Location = New System.Drawing.Point(2, 44)
        Me.VisorReporte.Name = "VisorReporte"
        Me.VisorReporte.SelectionFormula = ""
        Me.VisorReporte.ShowCloseButton = False
        Me.VisorReporte.Size = New System.Drawing.Size(692, 282)
        Me.VisorReporte.TabIndex = 102
        Me.VisorReporte.ViewTimeSelectionFormula = ""
        '
        'lblCompra
        '
        Me.lblCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCompra.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblCompra.Location = New System.Drawing.Point(166, 16)
        Me.lblCompra.Name = "lblCompra"
        Me.lblCompra.Size = New System.Drawing.Size(334, 20)
        Me.lblCompra.TabIndex = 113
        Me.lblCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(506, 14)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(88, 24)
        Me.btnMostrar.TabIndex = 110
        Me.btnMostrar.Text = "Mostrar"
        '
        'btnBuscarCompra
        '
        Me.btnBuscarCompra.Location = New System.Drawing.Point(12, 14)
        Me.btnBuscarCompra.Name = "btnBuscarCompra"
        Me.btnBuscarCompra.Size = New System.Drawing.Size(143, 24)
        Me.btnBuscarCompra.TabIndex = 114
        Me.btnBuscarCompra.Text = "Buscar Compra"
        '
        'frmMovimientoCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 327)
        Me.Controls.Add(Me.btnBuscarCompra)
        Me.Controls.Add(Me.lblCompra)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.VisorReporte)
        Me.Name = "frmMovimientoCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimientos de Compra"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VisorReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents lblCompra As System.Windows.Forms.Label
    Friend WithEvents btnMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscarCompra As DevExpress.XtraEditors.SimpleButton
End Class
