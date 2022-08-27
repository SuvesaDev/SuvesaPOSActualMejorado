<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFichasporUsuario
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
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cIdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDesde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cHasta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cEnMostrador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnQuitar = New System.Windows.Forms.Button()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'viewDatos
        '
        Me.viewDatos.AllowUserToAddRows = False
        Me.viewDatos.AllowUserToDeleteRows = False
        Me.viewDatos.AllowUserToResizeColumns = False
        Me.viewDatos.AllowUserToResizeRows = False
        Me.viewDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewDatos.BackgroundColor = System.Drawing.Color.White
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cId, Me.cIdUsuario, Me.cUsuario, Me.cDesde, Me.cHasta, Me.cEnMostrador})
        Me.viewDatos.Location = New System.Drawing.Point(0, 38)
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.ReadOnly = True
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(619, 455)
        Me.viewDatos.TabIndex = 0
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Location = New System.Drawing.Point(1, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(170, 30)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar Usuario"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'cId
        '
        Me.cId.HeaderText = "Id"
        Me.cId.Name = "cId"
        Me.cId.ReadOnly = True
        Me.cId.Visible = False
        '
        'cIdUsuario
        '
        Me.cIdUsuario.HeaderText = "IdUsuario"
        Me.cIdUsuario.Name = "cIdUsuario"
        Me.cIdUsuario.ReadOnly = True
        Me.cIdUsuario.Visible = False
        '
        'cUsuario
        '
        Me.cUsuario.HeaderText = "Usuario"
        Me.cUsuario.Name = "cUsuario"
        Me.cUsuario.ReadOnly = True
        Me.cUsuario.Width = 265
        '
        'cDesde
        '
        Me.cDesde.HeaderText = "Desde"
        Me.cDesde.Name = "cDesde"
        Me.cDesde.ReadOnly = True
        '
        'cHasta
        '
        Me.cHasta.HeaderText = "Hasta"
        Me.cHasta.Name = "cHasta"
        Me.cHasta.ReadOnly = True
        '
        'cEnMostrador
        '
        Me.cEnMostrador.HeaderText = "EnMostrador"
        Me.cEnMostrador.Name = "cEnMostrador"
        Me.cEnMostrador.ReadOnly = True
        '
        'btnQuitar
        '
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitar.Location = New System.Drawing.Point(177, 4)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(170, 30)
        Me.btnQuitar.TabIndex = 2
        Me.btnQuitar.Text = "Quitar Seleccionados"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'frmFichasporUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 493)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.viewDatos)
        Me.MinimumSize = New System.Drawing.Size(635, 532)
        Me.Name = "frmFichasporUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fichas por Usuario"
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents cId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cIdUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDesde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cHasta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cEnMostrador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
End Class
