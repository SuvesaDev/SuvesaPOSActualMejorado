<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstadoCuentaAlbaran
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
        Me.ButtonMostrar = New DevExpress.XtraEditors.SimpleButton()
        Me.VisorReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAnticipos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Location = New System.Drawing.Point(731, 11)
        Me.ButtonMostrar.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(117, 25)
        Me.ButtonMostrar.TabIndex = 131
        Me.ButtonMostrar.Text = "Mostrar"
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
        Me.VisorReporte.Margin = New System.Windows.Forms.Padding(4)
        Me.VisorReporte.Name = "VisorReporte"
        Me.VisorReporte.SelectionFormula = ""
        Me.VisorReporte.ShowCloseButton = False
        Me.VisorReporte.Size = New System.Drawing.Size(984, 495)
        Me.VisorReporte.TabIndex = 130
        Me.VisorReporte.ToolPanelWidth = 267
        Me.VisorReporte.ViewTimeSelectionFormula = ""
        '
        'lblNombre
        '
        Me.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblNombre.Location = New System.Drawing.Point(162, 12)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(402, 24)
        Me.lblNombre.TabIndex = 134
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(78, 13)
        Me.txtIdentificacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(81, 22)
        Me.txtIdentificacion.TabIndex = 133
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Cliente :"
        '
        'lblAnticipos
        '
        Me.lblAnticipos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnticipos.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblAnticipos.Location = New System.Drawing.Point(572, 11)
        Me.lblAnticipos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAnticipos.Name = "lblAnticipos"
        Me.lblAnticipos.Size = New System.Drawing.Size(151, 24)
        Me.lblAnticipos.TabIndex = 135
        Me.lblAnticipos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmEstadoCuentaAlbaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 540)
        Me.Controls.Add(Me.lblAnticipos)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtIdentificacion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonMostrar)
        Me.Controls.Add(Me.VisorReporte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmEstadoCuentaAlbaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado de Cuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents VisorReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtIdentificacion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAnticipos As System.Windows.Forms.Label
End Class
