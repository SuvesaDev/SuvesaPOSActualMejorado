﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarSeries
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.viewSerie = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cSerie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.viewSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(197, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero de Serie"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(215, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Agregar "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'viewSerie
        '
        Me.viewSerie.AllowUserToAddRows = False
        Me.viewSerie.AllowUserToDeleteRows = False
        Me.viewSerie.AllowUserToResizeColumns = False
        Me.viewSerie.AllowUserToResizeRows = False
        Me.viewSerie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.viewSerie.BackgroundColor = System.Drawing.Color.White
        Me.viewSerie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewSerie.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cSerie})
        Me.viewSerie.Location = New System.Drawing.Point(12, 61)
        Me.viewSerie.MultiSelect = False
        Me.viewSerie.Name = "viewSerie"
        Me.viewSerie.RowHeadersVisible = False
        Me.viewSerie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewSerie.Size = New System.Drawing.Size(385, 150)
        Me.viewSerie.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(215, 217)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(182, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(27, 217)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(182, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Aceptar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cSerie
        '
        Me.cSerie.HeaderText = "Serie"
        Me.cSerie.Name = "cSerie"
        '
        'frmAgregarSeries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 259)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.viewSerie)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAgregarSeries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Serie"
        CType(Me.viewSerie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents viewSerie As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cSerie As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
