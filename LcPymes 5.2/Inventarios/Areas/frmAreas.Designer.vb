<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAreasme
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
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.pEncabezado = New System.Windows.Forms.GroupBox()
        Me.viewEncargados = New System.Windows.Forms.DataGridView()
        Me.cCedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboEncargado = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.viewArticulosArea = New System.Windows.Forms.DataGridView()
        Me.cCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCodArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cBarras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cExistencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescripcionProducto = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pDetalle = New System.Windows.Forms.GroupBox()
        Me.btnAgregarArticulo = New System.Windows.Forms.Button()
        Me.btnAgregarEncargado = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.btnAnular = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.pEncabezado.SuspendLayout()
        CType(Me.viewEncargados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewArticulosArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pDetalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.ToolStripSeparator1, Me.btnGuardar, Me.ToolStripSeparator2, Me.btnBuscar, Me.ToolStripSeparator3, Me.btnAnular, Me.ToolStripSeparator5, Me.btnImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(691, 54)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 54)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 54)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 54)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 54)
        '
        'pEncabezado
        '
        Me.pEncabezado.Controls.Add(Me.cboEncargado)
        Me.pEncabezado.Controls.Add(Me.btnAgregarEncargado)
        Me.pEncabezado.Controls.Add(Me.viewEncargados)
        Me.pEncabezado.Controls.Add(Me.txtObservaciones)
        Me.pEncabezado.Controls.Add(Me.txtDescripcion)
        Me.pEncabezado.Controls.Add(Me.Label3)
        Me.pEncabezado.Controls.Add(Me.Label2)
        Me.pEncabezado.Controls.Add(Me.Label1)
        Me.pEncabezado.Enabled = False
        Me.pEncabezado.Location = New System.Drawing.Point(12, 57)
        Me.pEncabezado.Name = "pEncabezado"
        Me.pEncabezado.Size = New System.Drawing.Size(661, 147)
        Me.pEncabezado.TabIndex = 2
        Me.pEncabezado.TabStop = False
        Me.pEncabezado.Text = "Area"
        '
        'viewEncargados
        '
        Me.viewEncargados.AllowUserToAddRows = False
        Me.viewEncargados.AllowUserToResizeColumns = False
        Me.viewEncargados.AllowUserToResizeRows = False
        Me.viewEncargados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.viewEncargados.BackgroundColor = System.Drawing.Color.White
        Me.viewEncargados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewEncargados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cCedula, Me.cNombre})
        Me.viewEncargados.Location = New System.Drawing.Point(336, 54)
        Me.viewEncargados.MultiSelect = False
        Me.viewEncargados.Name = "viewEncargados"
        Me.viewEncargados.ReadOnly = True
        Me.viewEncargados.RowHeadersVisible = False
        Me.viewEncargados.RowTemplate.Height = 29
        Me.viewEncargados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewEncargados.Size = New System.Drawing.Size(309, 84)
        Me.viewEncargados.TabIndex = 6
        '
        'cCedula
        '
        Me.cCedula.HeaderText = "Cedula"
        Me.cCedula.Name = "cCedula"
        Me.cCedula.ReadOnly = True
        Me.cCedula.Visible = False
        '
        'cNombre
        '
        Me.cNombre.HeaderText = "Encargado"
        Me.cNombre.Name = "cNombre"
        Me.cNombre.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(334, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Encargado"
        '
        'cboEncargado
        '
        Me.cboEncargado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEncargado.FormattingEnabled = True
        Me.cboEncargado.Location = New System.Drawing.Point(336, 30)
        Me.cboEncargado.Name = "cboEncargado"
        Me.cboEncargado.Size = New System.Drawing.Size(266, 21)
        Me.cboEncargado.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(6, 73)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(315, 68)
        Me.txtObservaciones.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Descripcion del Area"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(6, 34)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(315, 20)
        Me.txtDescripcion.TabIndex = 0
        '
        'viewArticulosArea
        '
        Me.viewArticulosArea.AllowUserToAddRows = False
        Me.viewArticulosArea.AllowUserToResizeColumns = False
        Me.viewArticulosArea.AllowUserToResizeRows = False
        Me.viewArticulosArea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.viewArticulosArea.BackgroundColor = System.Drawing.Color.White
        Me.viewArticulosArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewArticulosArea.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cCodigo, Me.cCodArticulo, Me.cBarras, Me.cDescripcion, Me.cExistencia})
        Me.viewArticulosArea.Location = New System.Drawing.Point(11, 62)
        Me.viewArticulosArea.MultiSelect = False
        Me.viewArticulosArea.Name = "viewArticulosArea"
        Me.viewArticulosArea.ReadOnly = True
        Me.viewArticulosArea.RowHeadersVisible = False
        Me.viewArticulosArea.RowTemplate.Height = 29
        Me.viewArticulosArea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewArticulosArea.Size = New System.Drawing.Size(636, 194)
        Me.viewArticulosArea.TabIndex = 3
        '
        'cCodigo
        '
        Me.cCodigo.HeaderText = "Codigo"
        Me.cCodigo.Name = "cCodigo"
        Me.cCodigo.ReadOnly = True
        Me.cCodigo.Visible = False
        Me.cCodigo.Width = 46
        '
        'cCodArticulo
        '
        Me.cCodArticulo.HeaderText = "Cod Articulo"
        Me.cCodArticulo.Name = "cCodArticulo"
        Me.cCodArticulo.ReadOnly = True
        Me.cCodArticulo.Width = 89
        '
        'cBarras
        '
        Me.cBarras.HeaderText = "Barras"
        Me.cBarras.Name = "cBarras"
        Me.cBarras.ReadOnly = True
        Me.cBarras.Width = 62
        '
        'cDescripcion
        '
        Me.cDescripcion.HeaderText = "Descripcion"
        Me.cDescripcion.Name = "cDescripcion"
        Me.cDescripcion.ReadOnly = True
        Me.cDescripcion.Width = 88
        '
        'cExistencia
        '
        Me.cExistencia.HeaderText = "Existencia"
        Me.cExistencia.Name = "cExistencia"
        Me.cExistencia.ReadOnly = True
        Me.cExistencia.Width = 80
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(335, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Descripcion del Producto :"
        '
        'txtDescripcionProducto
        '
        Me.txtDescripcionProducto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionProducto.Location = New System.Drawing.Point(335, 32)
        Me.txtDescripcionProducto.Name = "txtDescripcionProducto"
        Me.txtDescripcionProducto.ReadOnly = True
        Me.txtDescripcionProducto.Size = New System.Drawing.Size(312, 23)
        Me.txtDescripcionProducto.TabIndex = 8
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(11, 32)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(266, 23)
        Me.txtCodigo.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Codigo del Producto :"
        '
        'pDetalle
        '
        Me.pDetalle.Controls.Add(Me.txtDescripcionProducto)
        Me.pDetalle.Controls.Add(Me.viewArticulosArea)
        Me.pDetalle.Controls.Add(Me.btnAgregarArticulo)
        Me.pDetalle.Controls.Add(Me.txtCodigo)
        Me.pDetalle.Controls.Add(Me.Label5)
        Me.pDetalle.Controls.Add(Me.Label4)
        Me.pDetalle.Enabled = False
        Me.pDetalle.Location = New System.Drawing.Point(12, 207)
        Me.pDetalle.Name = "pDetalle"
        Me.pDetalle.Size = New System.Drawing.Size(661, 266)
        Me.pDetalle.TabIndex = 10
        Me.pDetalle.TabStop = False
        '
        'btnAgregarArticulo
        '
        Me.btnAgregarArticulo.Image = Global.LcPymes_5._2.My.Resources.Resources.add
        Me.btnAgregarArticulo.Location = New System.Drawing.Point(283, 30)
        Me.btnAgregarArticulo.Name = "btnAgregarArticulo"
        Me.btnAgregarArticulo.Size = New System.Drawing.Size(40, 26)
        Me.btnAgregarArticulo.TabIndex = 8
        Me.btnAgregarArticulo.UseVisualStyleBackColor = True
        '
        'btnAgregarEncargado
        '
        Me.btnAgregarEncargado.Image = Global.LcPymes_5._2.My.Resources.Resources.add
        Me.btnAgregarEncargado.Location = New System.Drawing.Point(605, 27)
        Me.btnAgregarEncargado.Name = "btnAgregarEncargado"
        Me.btnAgregarEncargado.Size = New System.Drawing.Size(40, 25)
        Me.btnAgregarEncargado.TabIndex = 7
        Me.btnAgregarEncargado.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.LcPymes_5._2.My.Resources.Resources.page
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 51)
        Me.btnNuevo.Text = "Nueva Area"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.LcPymes_5._2.My.Resources.Resources.page_save
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(80, 51)
        Me.btnGuardar.Text = "Guardar Area"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.LcPymes_5._2.My.Resources.Resources.page_find1
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(73, 51)
        Me.btnBuscar.Text = "Buscar Area"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnAnular
        '
        Me.btnAnular.Image = Global.LcPymes_5._2.My.Resources.Resources.page_delete
        Me.btnAnular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(81, 51)
        Me.btnAnular.Text = "Eliminar Area"
        Me.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.LcPymes_5._2.My.Resources.Resources.printer
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(57, 51)
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmAreasme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 478)
        Me.Controls.Add(Me.pDetalle)
        Me.Controls.Add(Me.pEncabezado)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAreasme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Areas"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pEncabezado.ResumeLayout(False)
        Me.pEncabezado.PerformLayout()
        CType(Me.viewEncargados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewArticulosArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pDetalle.ResumeLayout(False)
        Me.pDetalle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAnular As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents pEncabezado As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents viewArticulosArea As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarEncargado As System.Windows.Forms.Button
    Friend WithEvents viewEncargados As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboEncargado As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionProducto As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarArticulo As System.Windows.Forms.Button
    Friend WithEvents cCedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCodArticulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cBarras As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cExistencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
End Class
