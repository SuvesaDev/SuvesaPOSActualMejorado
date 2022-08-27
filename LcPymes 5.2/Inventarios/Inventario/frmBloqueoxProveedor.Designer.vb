<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBloqueoxProveedor
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnBloquear = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDesbloquear = New System.Windows.Forms.ToolStripButton()
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.cCodigoProv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cBloqueado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txtBuscar, Me.ToolStripSeparator1, Me.btnBloquear, Me.ToolStripSeparator2, Me.btnDesbloquear})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(732, 39)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(133, 36)
        Me.ToolStripLabel1.Text = "Buscar Casa Comercial :"
        '
        'txtBuscar
        '
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(350, 39)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnBloquear
        '
        Me.btnBloquear.Image = Global.LcPymes_5._2.My.Resources.Resources.cancel1
        Me.btnBloquear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBloquear.Name = "btnBloquear"
        Me.btnBloquear.Size = New System.Drawing.Size(90, 36)
        Me.btnBloquear.Text = "Bloquear"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'btnDesbloquear
        '
        Me.btnDesbloquear.Image = Global.LcPymes_5._2.My.Resources.Resources.accept_button1
        Me.btnDesbloquear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDesbloquear.Name = "btnDesbloquear"
        Me.btnDesbloquear.Size = New System.Drawing.Size(109, 36)
        Me.btnDesbloquear.Text = "Desbloquear"
        '
        'viewDatos
        '
        Me.viewDatos.AllowUserToAddRows = False
        Me.viewDatos.AllowUserToDeleteRows = False
        Me.viewDatos.AllowUserToResizeColumns = False
        Me.viewDatos.AllowUserToResizeRows = False
        Me.viewDatos.BackgroundColor = System.Drawing.Color.White
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cCodigoProv, Me.cNombre, Me.cBloqueado})
        Me.viewDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewDatos.Location = New System.Drawing.Point(0, 39)
        Me.viewDatos.MultiSelect = False
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.RowTemplate.Height = 28
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(732, 420)
        Me.viewDatos.TabIndex = 1
        '
        'cCodigoProv
        '
        Me.cCodigoProv.HeaderText = "CodigoProv"
        Me.cCodigoProv.Name = "cCodigoProv"
        Me.cCodigoProv.Visible = False
        '
        'cNombre
        '
        Me.cNombre.HeaderText = "Casa Comercial"
        Me.cNombre.Name = "cNombre"
        Me.cNombre.ReadOnly = True
        Me.cNombre.Width = 600
        '
        'cBloqueado
        '
        Me.cBloqueado.HeaderText = "Bloqueado"
        Me.cBloqueado.Name = "cBloqueado"
        Me.cBloqueado.ReadOnly = True
        Me.cBloqueado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cBloqueado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'frmBloqueoxProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 459)
        Me.Controls.Add(Me.viewDatos)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBloqueoxProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bloqueo de Articulos por Casa Comercial"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtBuscar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnBloquear As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDesbloquear As System.Windows.Forms.ToolStripButton
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents cCodigoProv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cBloqueado As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
