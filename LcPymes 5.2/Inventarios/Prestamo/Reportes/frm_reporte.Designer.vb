Imports System.Windows.Forms
Namespace Prestamos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frm_reporte
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
            Me.visor = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.cbo_empresa = New System.Windows.Forms.ComboBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.Button3 = New System.Windows.Forms.Button()
            Me.Button4 = New System.Windows.Forms.Button()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cbo_empresa2 = New System.Windows.Forms.ComboBox()
            Me.txtCodigoDebe = New System.Windows.Forms.TextBox()
            Me.Button5 = New System.Windows.Forms.Button()
            Me.Button6 = New System.Windows.Forms.Button()
            Me.txtCodigoDebo = New System.Windows.Forms.TextBox()
            Me.Button7 = New System.Windows.Forms.Button()
            Me.Button8 = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'visor
            '
            Me.visor.ActiveViewIndex = -1
            Me.visor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.visor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.visor.Cursor = System.Windows.Forms.Cursors.Default
            Me.visor.Location = New System.Drawing.Point(0, 100)
            Me.visor.Margin = New System.Windows.Forms.Padding(4)
            Me.visor.Name = "visor"
            Me.visor.Size = New System.Drawing.Size(1138, 497)
            Me.visor.TabIndex = 3
            Me.visor.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'cbo_empresa
            '
            Me.cbo_empresa.FormattingEnabled = True
            Me.cbo_empresa.Location = New System.Drawing.Point(16, 41)
            Me.cbo_empresa.Margin = New System.Windows.Forms.Padding(4)
            Me.cbo_empresa.Name = "cbo_empresa"
            Me.cbo_empresa.Size = New System.Drawing.Size(257, 24)
            Me.cbo_empresa.TabIndex = 6
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(16, 21)
            Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(186, 17)
            Me.Label1.TabIndex = 7
            Me.Label1.Text = "Consultar cuanto me deben "
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(283, 39)
            Me.Button1.Margin = New System.Windows.Forms.Padding(4)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(100, 28)
            Me.Button1.TabIndex = 8
            Me.Button1.Text = "Mostrar"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'Button2
            '
            Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.Button2.Enabled = False
            Me.Button2.Location = New System.Drawing.Point(391, 41)
            Me.Button2.Margin = New System.Windows.Forms.Padding(4)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(163, 28)
            Me.Button2.TabIndex = 9
            Me.Button2.Text = "General debe"
            Me.Button2.UseVisualStyleBackColor = False
            Me.Button2.Visible = False
            '
            'Button3
            '
            Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Button3.Enabled = False
            Me.Button3.Location = New System.Drawing.Point(965, 41)
            Me.Button3.Margin = New System.Windows.Forms.Padding(4)
            Me.Button3.Name = "Button3"
            Me.Button3.Size = New System.Drawing.Size(163, 28)
            Me.Button3.TabIndex = 13
            Me.Button3.Text = "General debo"
            Me.Button3.UseVisualStyleBackColor = False
            Me.Button3.Visible = False
            '
            'Button4
            '
            Me.Button4.Location = New System.Drawing.Point(857, 39)
            Me.Button4.Margin = New System.Windows.Forms.Padding(4)
            Me.Button4.Name = "Button4"
            Me.Button4.Size = New System.Drawing.Size(100, 28)
            Me.Button4.TabIndex = 12
            Me.Button4.Text = "Mostrar"
            Me.Button4.UseVisualStyleBackColor = True
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(591, 21)
            Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(167, 17)
            Me.Label2.TabIndex = 11
            Me.Label2.Text = "Consultar cuanto debo a "
            '
            'cbo_empresa2
            '
            Me.cbo_empresa2.FormattingEnabled = True
            Me.cbo_empresa2.Location = New System.Drawing.Point(591, 41)
            Me.cbo_empresa2.Margin = New System.Windows.Forms.Padding(4)
            Me.cbo_empresa2.Name = "cbo_empresa2"
            Me.cbo_empresa2.Size = New System.Drawing.Size(257, 24)
            Me.cbo_empresa2.TabIndex = 10
            '
            'txtCodigoDebe
            '
            Me.txtCodigoDebe.Location = New System.Drawing.Point(123, 71)
            Me.txtCodigoDebe.Name = "txtCodigoDebe"
            Me.txtCodigoDebe.ReadOnly = True
            Me.txtCodigoDebe.Size = New System.Drawing.Size(260, 22)
            Me.txtCodigoDebe.TabIndex = 14
            '
            'Button5
            '
            Me.Button5.Location = New System.Drawing.Point(16, 68)
            Me.Button5.Margin = New System.Windows.Forms.Padding(4)
            Me.Button5.Name = "Button5"
            Me.Button5.Size = New System.Drawing.Size(100, 28)
            Me.Button5.TabIndex = 15
            Me.Button5.Text = "Buscar"
            Me.Button5.UseVisualStyleBackColor = True
            '
            'Button6
            '
            Me.Button6.Location = New System.Drawing.Point(591, 68)
            Me.Button6.Margin = New System.Windows.Forms.Padding(4)
            Me.Button6.Name = "Button6"
            Me.Button6.Size = New System.Drawing.Size(100, 28)
            Me.Button6.TabIndex = 17
            Me.Button6.Text = "Buscar"
            Me.Button6.UseVisualStyleBackColor = True
            '
            'txtCodigoDebo
            '
            Me.txtCodigoDebo.Location = New System.Drawing.Point(698, 71)
            Me.txtCodigoDebo.Name = "txtCodigoDebo"
            Me.txtCodigoDebo.ReadOnly = True
            Me.txtCodigoDebo.Size = New System.Drawing.Size(260, 22)
            Me.txtCodigoDebo.TabIndex = 16
            '
            'Button7
            '
            Me.Button7.Location = New System.Drawing.Point(391, 68)
            Me.Button7.Margin = New System.Windows.Forms.Padding(4)
            Me.Button7.Name = "Button7"
            Me.Button7.Size = New System.Drawing.Size(100, 28)
            Me.Button7.TabIndex = 18
            Me.Button7.Text = "Quitar"
            Me.Button7.UseVisualStyleBackColor = True
            '
            'Button8
            '
            Me.Button8.Location = New System.Drawing.Point(965, 68)
            Me.Button8.Margin = New System.Windows.Forms.Padding(4)
            Me.Button8.Name = "Button8"
            Me.Button8.Size = New System.Drawing.Size(100, 28)
            Me.Button8.TabIndex = 19
            Me.Button8.Text = "Quitar"
            Me.Button8.UseVisualStyleBackColor = True
            '
            'frm_reporte
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1139, 598)
            Me.Controls.Add(Me.Button8)
            Me.Controls.Add(Me.Button7)
            Me.Controls.Add(Me.Button6)
            Me.Controls.Add(Me.txtCodigoDebo)
            Me.Controls.Add(Me.Button5)
            Me.Controls.Add(Me.txtCodigoDebe)
            Me.Controls.Add(Me.Button3)
            Me.Controls.Add(Me.Button4)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.cbo_empresa2)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.cbo_empresa)
            Me.Controls.Add(Me.visor)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "frm_reporte"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Reporte"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents visor As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents cbo_empresa As ComboBox
        Friend WithEvents Label1 As Label
        Friend WithEvents Button1 As Button
        Friend WithEvents Button2 As Button
        Friend WithEvents Button3 As Button
        Friend WithEvents Button4 As Button
        Friend WithEvents Label2 As Label
        Friend WithEvents cbo_empresa2 As ComboBox
        Friend WithEvents txtCodigoDebe As System.Windows.Forms.TextBox
        Friend WithEvents Button5 As System.Windows.Forms.Button
        Friend WithEvents Button6 As System.Windows.Forms.Button
        Friend WithEvents txtCodigoDebo As System.Windows.Forms.TextBox
        Friend WithEvents Button7 As System.Windows.Forms.Button
        Friend WithEvents Button8 As System.Windows.Forms.Button
    End Class

End Namespace
