<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResumenCaja
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
        Me.viewResumenCaja = New System.Windows.Forms.DataGridView()
        Me.lblTexto = New System.Windows.Forms.Label()
        Me.txtTotalRecumen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.viewResumenCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'viewResumenCaja
        '
        Me.viewResumenCaja.AllowUserToAddRows = False
        Me.viewResumenCaja.AllowUserToDeleteRows = False
        Me.viewResumenCaja.AllowUserToResizeColumns = False
        Me.viewResumenCaja.AllowUserToResizeRows = False
        Me.viewResumenCaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.viewResumenCaja.BackgroundColor = System.Drawing.Color.White
        Me.viewResumenCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewResumenCaja.Location = New System.Drawing.Point(1, 41)
        Me.viewResumenCaja.Name = "viewResumenCaja"
        Me.viewResumenCaja.ReadOnly = True
        Me.viewResumenCaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewResumenCaja.Size = New System.Drawing.Size(523, 245)
        Me.viewResumenCaja.TabIndex = 0
        '
        'lblTexto
        '
        Me.lblTexto.AutoSize = True
        Me.lblTexto.Location = New System.Drawing.Point(13, 14)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(39, 13)
        Me.lblTexto.TabIndex = 1
        Me.lblTexto.Text = "Label1"
        '
        'txtTotalRecumen
        '
        Me.txtTotalRecumen.Location = New System.Drawing.Point(356, 292)
        Me.txtTotalRecumen.Name = "txtTotalRecumen"
        Me.txtTotalRecumen.ReadOnly = True
        Me.txtTotalRecumen.Size = New System.Drawing.Size(168, 20)
        Me.txtTotalRecumen.TabIndex = 2
        Me.txtTotalRecumen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(265, 295)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total Resumen :"
        '
        'frmResumenCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 324)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalRecumen)
        Me.Controls.Add(Me.lblTexto)
        Me.Controls.Add(Me.viewResumenCaja)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmResumenCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen Caja"
        CType(Me.viewResumenCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents viewResumenCaja As System.Windows.Forms.DataGridView
    Friend WithEvents lblTexto As System.Windows.Forms.Label
    Friend WithEvents txtTotalRecumen As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
