﻿Imports System.Windows.Forms
Namespace Prestamos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frm_reporte_general_debe
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
            Me.SuspendLayout()
            '
            'visor
            '
            Me.visor.ActiveViewIndex = -1
            Me.visor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.visor.Cursor = System.Windows.Forms.Cursors.Default
            Me.visor.Dock = System.Windows.Forms.DockStyle.Fill
            Me.visor.Location = New System.Drawing.Point(0, 0)
            Me.visor.Name = "visor"
            Me.visor.Size = New System.Drawing.Size(542, 402)
            Me.visor.TabIndex = 2
            Me.visor.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'frm_reporte_general_debe
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(542, 402)
            Me.Controls.Add(Me.visor)
            Me.Name = "frm_reporte_general_debe"
            Me.Text = "Reporte General quien me debe"
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents visor As CrystalDecisions.Windows.Forms.CrystalReportViewer
    End Class

End Namespace
