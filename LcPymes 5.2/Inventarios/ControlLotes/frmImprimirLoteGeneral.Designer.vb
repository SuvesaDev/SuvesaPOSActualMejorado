<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImprimirLoteGeneral
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
        Me.viewLotes = New System.Windows.Forms.DataGridView()
        Me.btnCargarlotes = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.viewLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'viewLotes
        '
        Me.viewLotes.AllowUserToAddRows = False
        Me.viewLotes.AllowUserToDeleteRows = False
        Me.viewLotes.AllowUserToResizeColumns = False
        Me.viewLotes.AllowUserToResizeRows = False
        Me.viewLotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewLotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.viewLotes.BackgroundColor = System.Drawing.Color.White
        Me.viewLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewLotes.Location = New System.Drawing.Point(4, 47)
        Me.viewLotes.MultiSelect = False
        Me.viewLotes.Name = "viewLotes"
        Me.viewLotes.RowHeadersVisible = False
        Me.viewLotes.Size = New System.Drawing.Size(728, 425)
        Me.viewLotes.TabIndex = 0
        '
        'btnCargarlotes
        '
        Me.btnCargarlotes.Location = New System.Drawing.Point(4, 12)
        Me.btnCargarlotes.Name = "btnCargarlotes"
        Me.btnCargarlotes.Size = New System.Drawing.Size(210, 32)
        Me.btnCargarlotes.TabIndex = 1
        Me.btnCargarlotes.Text = "Cargar lotes sin Imprimir"
        Me.btnCargarlotes.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(522, 476)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(210, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Imprimir Lotes Seleccionados"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmImprimirLoteGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 512)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCargarlotes)
        Me.Controls.Add(Me.viewLotes)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImprimirLoteGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir Lotes"
        CType(Me.viewLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents viewLotes As System.Windows.Forms.DataGridView
    Friend WithEvents btnCargarlotes As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
