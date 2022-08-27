<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_reportes_planilla
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
        Me.VisorReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.ButtonMostrar = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.txt_empleado = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
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
        Me.VisorReporte.Location = New System.Drawing.Point(0, 61)
        Me.VisorReporte.Name = "VisorReporte"
        Me.VisorReporte.SelectionFormula = ""
        Me.VisorReporte.ShowCloseButton = False
        Me.VisorReporte.Size = New System.Drawing.Size(680, 369)
        Me.VisorReporte.TabIndex = 126
        Me.VisorReporte.ViewTimeSelectionFormula = ""
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=192.168.0.2;packet size=4096;integrated security=SSPI;data source=" & _
            "192.168.0.2;persist security info=False;initial catalog=Seepos"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Location = New System.Drawing.Point(178, 20)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(88, 24)
        Me.ButtonMostrar.TabIndex = 129
        Me.ButtonMostrar.Text = "Mostrar"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(414, 20)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(88, 24)
        Me.SimpleButton1.TabIndex = 132
        Me.SimpleButton1.Text = "General"
        '
        'txt_empleado
        '
        Me.txt_empleado.Location = New System.Drawing.Point(72, 22)
        Me.txt_empleado.Name = "txt_empleado"
        Me.txt_empleado.Size = New System.Drawing.Size(100, 20)
        Me.txt_empleado.TabIndex = 133
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "Empleado"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(508, 20)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(172, 24)
        Me.SimpleButton2.TabIndex = 135
        Me.SimpleButton2.Text = "General Listado de empleados"
        '
        'frm_reportes_planilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 430)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_empleado)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.VisorReporte)
        Me.Controls.Add(Me.ButtonMostrar)
        Me.Name = "frm_reportes_planilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VisorReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents ButtonMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_empleado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
