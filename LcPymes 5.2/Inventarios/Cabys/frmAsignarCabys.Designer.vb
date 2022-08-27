<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarCabys
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
        Me.cboOpcionMostrar = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnMAG = New System.Windows.Forms.Button()
        Me.btnQuitarMAG = New System.Windows.Forms.Button()
        Me.ckSoloActivos = New System.Windows.Forms.CheckBox()
        Me.lblRecuento = New System.Windows.Forms.Label()
        Me.btnAsigarxReferencia = New System.Windows.Forms.Button()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'viewDatos
        '
        Me.viewDatos.AllowUserToAddRows = False
        Me.viewDatos.AllowUserToDeleteRows = False
        Me.viewDatos.AllowUserToOrderColumns = True
        Me.viewDatos.AllowUserToResizeColumns = False
        Me.viewDatos.AllowUserToResizeRows = False
        Me.viewDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.viewDatos.BackgroundColor = System.Drawing.Color.White
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Location = New System.Drawing.Point(3, 70)
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.ReadOnly = True
        Me.viewDatos.RowTemplate.Height = 27
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(925, 371)
        Me.viewDatos.TabIndex = 0
        '
        'cboOpcionMostrar
        '
        Me.cboOpcionMostrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOpcionMostrar.FormattingEnabled = True
        Me.cboOpcionMostrar.Items.AddRange(New Object() {"Mostrar solo articulos sin codigo cabys", "Mostrar solo articulos con codigo cabys", "Mostrar todos los articulos"})
        Me.cboOpcionMostrar.Location = New System.Drawing.Point(5, 43)
        Me.cboOpcionMostrar.Name = "cboOpcionMostrar"
        Me.cboOpcionMostrar.Size = New System.Drawing.Size(228, 21)
        Me.cboOpcionMostrar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Opcion para mostrar articulos :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(239, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Buscar Articulos por Descripcion :"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.Location = New System.Drawing.Point(242, 44)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(388, 20)
        Me.txtDescripcion.TabIndex = 4
        '
        'btnAsignar
        '
        Me.btnAsignar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsignar.Location = New System.Drawing.Point(636, 37)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(114, 24)
        Me.btnAsignar.TabIndex = 5
        Me.btnAsignar.Text = "Asignar Cabys"
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitar.Location = New System.Drawing.Point(782, 37)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(140, 24)
        Me.btnQuitar.TabIndex = 6
        Me.btnQuitar.Text = "Quitar Codigo Cabys"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnMAG
        '
        Me.btnMAG.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMAG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMAG.Location = New System.Drawing.Point(636, 7)
        Me.btnMAG.Name = "btnMAG"
        Me.btnMAG.Size = New System.Drawing.Size(140, 24)
        Me.btnMAG.TabIndex = 7
        Me.btnMAG.Text = "Producto Agricula (MAG)"
        Me.btnMAG.UseVisualStyleBackColor = True
        '
        'btnQuitarMAG
        '
        Me.btnQuitarMAG.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarMAG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarMAG.Location = New System.Drawing.Point(782, 7)
        Me.btnQuitarMAG.Name = "btnQuitarMAG"
        Me.btnQuitarMAG.Size = New System.Drawing.Size(140, 24)
        Me.btnQuitarMAG.TabIndex = 8
        Me.btnQuitarMAG.Text = "Quitar MAG"
        Me.btnQuitarMAG.UseVisualStyleBackColor = True
        '
        'ckSoloActivos
        '
        Me.ckSoloActivos.AutoSize = True
        Me.ckSoloActivos.Location = New System.Drawing.Point(242, 3)
        Me.ckSoloActivos.Name = "ckSoloActivos"
        Me.ckSoloActivos.Size = New System.Drawing.Size(121, 17)
        Me.ckSoloActivos.TabIndex = 9
        Me.ckSoloActivos.Text = "Mostrar solo Activos"
        Me.ckSoloActivos.UseVisualStyleBackColor = True
        '
        'lblRecuento
        '
        Me.lblRecuento.AutoSize = True
        Me.lblRecuento.Location = New System.Drawing.Point(9, 7)
        Me.lblRecuento.Name = "lblRecuento"
        Me.lblRecuento.Size = New System.Drawing.Size(39, 13)
        Me.lblRecuento.TabIndex = 10
        Me.lblRecuento.Text = "Label3"
        '
        'btnAsigarxReferencia
        '
        Me.btnAsigarxReferencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAsigarxReferencia.Location = New System.Drawing.Point(753, 37)
        Me.btnAsigarxReferencia.Name = "btnAsigarxReferencia"
        Me.btnAsigarxReferencia.Size = New System.Drawing.Size(23, 23)
        Me.btnAsigarxReferencia.TabIndex = 11
        Me.btnAsigarxReferencia.Text = "..."
        Me.btnAsigarxReferencia.UseVisualStyleBackColor = True
        '
        'frmAsignarCabys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 445)
        Me.Controls.Add(Me.btnAsigarxReferencia)
        Me.Controls.Add(Me.lblRecuento)
        Me.Controls.Add(Me.ckSoloActivos)
        Me.Controls.Add(Me.btnQuitarMAG)
        Me.Controls.Add(Me.btnMAG)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAsignar)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboOpcionMostrar)
        Me.Controls.Add(Me.viewDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAsignarCabys"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignar Codigo Cabys"
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents cboOpcionMostrar As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents btnAsignar As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnMAG As System.Windows.Forms.Button
    Friend WithEvents btnQuitarMAG As System.Windows.Forms.Button
    Friend WithEvents ckSoloActivos As System.Windows.Forms.CheckBox
    Friend WithEvents lblRecuento As System.Windows.Forms.Label
    Friend WithEvents btnAsigarxReferencia As System.Windows.Forms.Button
End Class
