<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteClienteSinVisita
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.ButtonMostrar = New DevExpress.XtraEditors.SimpleButton()
        Me.VisorReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.txtVentas = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(162, 12)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 20)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "Ventas"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(13, 12)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 20)
        Me.Label3.TabIndex = 134
        Me.Label3.Text = "Fecha Corte"
        '
        'FechaInicio
        '
        Me.FechaInicio.CustomFormat = "yyyy"
        Me.FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaInicio.Location = New System.Drawing.Point(13, 32)
        Me.FechaInicio.Margin = New System.Windows.Forms.Padding(4)
        Me.FechaInicio.MinDate = New Date(2016, 1, 1, 0, 0, 0, 0)
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.Size = New System.Drawing.Size(127, 22)
        Me.FechaInicio.TabIndex = 131
        Me.FechaInicio.Value = New Date(2016, 4, 10, 0, 0, 0, 0)
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Location = New System.Drawing.Point(298, 8)
        Me.ButtonMostrar.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(117, 50)
        Me.ButtonMostrar.TabIndex = 133
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
        Me.VisorReporte.Location = New System.Drawing.Point(2, 66)
        Me.VisorReporte.Margin = New System.Windows.Forms.Padding(4)
        Me.VisorReporte.Name = "VisorReporte"
        Me.VisorReporte.SelectionFormula = ""
        Me.VisorReporte.ShowCloseButton = False
        Me.VisorReporte.Size = New System.Drawing.Size(1105, 523)
        Me.VisorReporte.TabIndex = 130
        Me.VisorReporte.ToolPanelWidth = 267
        Me.VisorReporte.ViewTimeSelectionFormula = ""
        '
        'txtVentas
        '
        Me.txtVentas.Location = New System.Drawing.Point(166, 34)
        Me.txtVentas.Name = "txtVentas"
        Me.txtVentas.Size = New System.Drawing.Size(124, 22)
        Me.txtVentas.TabIndex = 136
        '
        'frmReporteClienteSinVisita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 594)
        Me.Controls.Add(Me.txtVentas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FechaInicio)
        Me.Controls.Add(Me.ButtonMostrar)
        Me.Controls.Add(Me.VisorReporte)
        Me.Name = "frmReporteClienteSinVisita"
        Me.Text = "frmReporteClienteSinVisita"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents VisorReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents txtVentas As System.Windows.Forms.TextBox
End Class
