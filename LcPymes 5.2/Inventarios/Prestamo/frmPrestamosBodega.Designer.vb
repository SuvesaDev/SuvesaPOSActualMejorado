Imports System.Windows.Forms
Namespace Prestamos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmPrestamosBodega
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrestamosBodega))
            Me.Label15 = New System.Windows.Forms.Label()
            Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.ToolBar1 = New System.Windows.Forms.ToolBar()
            Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton()
            Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton()
            Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton()
            Me.ToolBarEliminar = New System.Windows.Forms.ToolBarButton()
            Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton()
            Me.ToolBarExcel = New System.Windows.Forms.ToolBarButton()
            Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton()
            Me.Label36 = New System.Windows.Forms.Label()
            Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
            Me.txtUsuario = New System.Windows.Forms.TextBox()
            Me.grpBox_Inventario = New System.Windows.Forms.GroupBox()
            Me.txtCodArticulo = New System.Windows.Forms.TextBox()
            Me.txtObservacion = New System.Windows.Forms.TextBox()
            Me.txtCantidad = New System.Windows.Forms.TextBox()
            Me.txtDescripcion = New System.Windows.Forms.Label()
            Me.txtCodigo = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.DataGridView1 = New System.Windows.Forms.DataGridView()
            Me.btnAgregar = New System.Windows.Forms.Button()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.cboTipoPrestamo = New System.Windows.Forms.ComboBox()
            Me.grpBox_Inventario.SuspendLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label15
            '
            Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(173, Byte), Integer))
            Me.Label15.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
            Me.Label15.ForeColor = System.Drawing.Color.White
            Me.Label15.Image = CType(resources.GetObject("Label15.Image"), System.Drawing.Image)
            Me.Label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label15.Location = New System.Drawing.Point(0, 0)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(776, 32)
            Me.Label15.TabIndex = 105
            Me.Label15.Text = "Prestamos de Bodega"
            Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'ImageList1
            '
            Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.ImageList1.Images.SetKeyName(0, "")
            Me.ImageList1.Images.SetKeyName(1, "")
            Me.ImageList1.Images.SetKeyName(2, "")
            Me.ImageList1.Images.SetKeyName(3, "")
            Me.ImageList1.Images.SetKeyName(4, "")
            Me.ImageList1.Images.SetKeyName(5, "")
            Me.ImageList1.Images.SetKeyName(6, "")
            Me.ImageList1.Images.SetKeyName(7, "")
            Me.ImageList1.Images.SetKeyName(8, "")
            '
            'ToolBar1
            '
            Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
            Me.ToolBar1.AutoSize = False
            Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarRegistrar, Me.ToolBarEliminar, Me.ToolBarImprimir, Me.ToolBarExcel, Me.ToolBarCerrar})
            Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
            Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.ToolBar1.DropDownArrows = True
            Me.ToolBar1.ImageList = Me.ImageList1
            Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.ToolBar1.Location = New System.Drawing.Point(0, 358)
            Me.ToolBar1.Name = "ToolBar1"
            Me.ToolBar1.ShowToolTips = True
            Me.ToolBar1.Size = New System.Drawing.Size(776, 52)
            Me.ToolBar1.TabIndex = 108
            '
            'ToolBarNuevo
            '
            Me.ToolBarNuevo.ImageIndex = 0
            Me.ToolBarNuevo.Name = "ToolBarNuevo"
            Me.ToolBarNuevo.Text = "Nuevo"
            '
            'ToolBarBuscar
            '
            Me.ToolBarBuscar.Enabled = False
            Me.ToolBarBuscar.ImageIndex = 1
            Me.ToolBarBuscar.Name = "ToolBarBuscar"
            Me.ToolBarBuscar.Text = "Buscar"
            '
            'ToolBarRegistrar
            '
            Me.ToolBarRegistrar.Enabled = False
            Me.ToolBarRegistrar.ImageIndex = 2
            Me.ToolBarRegistrar.Name = "ToolBarRegistrar"
            Me.ToolBarRegistrar.Text = "Registrar"
            '
            'ToolBarEliminar
            '
            Me.ToolBarEliminar.Enabled = False
            Me.ToolBarEliminar.ImageIndex = 3
            Me.ToolBarEliminar.Name = "ToolBarEliminar"
            Me.ToolBarEliminar.Text = "Anular"
            '
            'ToolBarImprimir
            '
            Me.ToolBarImprimir.Enabled = False
            Me.ToolBarImprimir.ImageIndex = 7
            Me.ToolBarImprimir.Name = "ToolBarImprimir"
            Me.ToolBarImprimir.Text = "Imprimir"
            '
            'ToolBarExcel
            '
            Me.ToolBarExcel.Enabled = False
            Me.ToolBarExcel.ImageIndex = 5
            Me.ToolBarExcel.Name = "ToolBarExcel"
            Me.ToolBarExcel.Text = "Exportar"
            Me.ToolBarExcel.Visible = False
            '
            'ToolBarCerrar
            '
            Me.ToolBarCerrar.ImageIndex = 6
            Me.ToolBarCerrar.Name = "ToolBarCerrar"
            Me.ToolBarCerrar.Text = "Cerrar"
            '
            'Label36
            '
            Me.Label36.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label36.BackColor = System.Drawing.Color.RoyalBlue
            Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label36.ForeColor = System.Drawing.Color.White
            Me.Label36.Location = New System.Drawing.Point(478, 396)
            Me.Label36.Name = "Label36"
            Me.Label36.Size = New System.Drawing.Size(72, 13)
            Me.Label36.TabIndex = 106
            Me.Label36.Text = "Usuario->"
            Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'txtNombreUsuario
            '
            Me.txtNombreUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.Control
            Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtNombreUsuario.Enabled = False
            Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
            Me.txtNombreUsuario.Location = New System.Drawing.Point(606, 396)
            Me.txtNombreUsuario.Name = "txtNombreUsuario"
            Me.txtNombreUsuario.ReadOnly = True
            Me.txtNombreUsuario.Size = New System.Drawing.Size(163, 13)
            Me.txtNombreUsuario.TabIndex = 109
            '
            'txtUsuario
            '
            Me.txtUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
            Me.txtUsuario.Location = New System.Drawing.Point(550, 396)
            Me.txtUsuario.Name = "txtUsuario"
            Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtUsuario.Size = New System.Drawing.Size(56, 13)
            Me.txtUsuario.TabIndex = 107
            '
            'grpBox_Inventario
            '
            Me.grpBox_Inventario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grpBox_Inventario.Controls.Add(Me.cboTipoPrestamo)
            Me.grpBox_Inventario.Controls.Add(Me.Label7)
            Me.grpBox_Inventario.Controls.Add(Me.Button1)
            Me.grpBox_Inventario.Controls.Add(Me.btnAgregar)
            Me.grpBox_Inventario.Controls.Add(Me.DataGridView1)
            Me.grpBox_Inventario.Controls.Add(Me.Label2)
            Me.grpBox_Inventario.Controls.Add(Me.txtObservacion)
            Me.grpBox_Inventario.Controls.Add(Me.txtCantidad)
            Me.grpBox_Inventario.Controls.Add(Me.txtDescripcion)
            Me.grpBox_Inventario.Controls.Add(Me.txtCodigo)
            Me.grpBox_Inventario.Controls.Add(Me.Label6)
            Me.grpBox_Inventario.Controls.Add(Me.Label5)
            Me.grpBox_Inventario.Controls.Add(Me.Label4)
            Me.grpBox_Inventario.Controls.Add(Me.Label3)
            Me.grpBox_Inventario.Controls.Add(Me.Label1)
            Me.grpBox_Inventario.Controls.Add(Me.txtCodArticulo)
            Me.grpBox_Inventario.Enabled = False
            Me.grpBox_Inventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grpBox_Inventario.ForeColor = System.Drawing.SystemColors.Highlight
            Me.grpBox_Inventario.Location = New System.Drawing.Point(6, 87)
            Me.grpBox_Inventario.Name = "grpBox_Inventario"
            Me.grpBox_Inventario.Size = New System.Drawing.Size(763, 271)
            Me.grpBox_Inventario.TabIndex = 110
            Me.grpBox_Inventario.TabStop = False
            Me.grpBox_Inventario.Text = "Datos de Inventario"
            '
            'txtCodArticulo
            '
            Me.txtCodArticulo.Enabled = False
            Me.txtCodArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodArticulo.Location = New System.Drawing.Point(8, 43)
            Me.txtCodArticulo.Name = "txtCodArticulo"
            Me.txtCodArticulo.Size = New System.Drawing.Size(156, 20)
            Me.txtCodArticulo.TabIndex = 175
            '
            'txtObservacion
            '
            Me.txtObservacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacion.Enabled = False
            Me.txtObservacion.Location = New System.Drawing.Point(170, 88)
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.Size = New System.Drawing.Size(371, 20)
            Me.txtObservacion.TabIndex = 10
            '
            'txtCantidad
            '
            Me.txtCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtCantidad.Enabled = False
            Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCantidad.Location = New System.Drawing.Point(547, 88)
            Me.txtCantidad.Name = "txtCantidad"
            Me.txtCantidad.Size = New System.Drawing.Size(64, 20)
            Me.txtCantidad.TabIndex = 12
            Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDescripcion
            '
            Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtDescripcion.BackColor = System.Drawing.Color.White
            Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDescripcion.Location = New System.Drawing.Point(170, 43)
            Me.txtDescripcion.Name = "txtDescripcion"
            Me.txtDescripcion.Size = New System.Drawing.Size(512, 20)
            Me.txtDescripcion.TabIndex = 3
            '
            'txtCodigo
            '
            Me.txtCodigo.Enabled = False
            Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodigo.Location = New System.Drawing.Point(-120, 32)
            Me.txtCodigo.Name = "txtCodigo"
            Me.txtCodigo.Size = New System.Drawing.Size(116, 20)
            Me.txtCodigo.TabIndex = 1
            '
            'Label6
            '
            Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label6.BackColor = System.Drawing.Color.Gainsboro
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(170, 72)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(371, 16)
            Me.Label6.TabIndex = 9
            Me.Label6.Text = "Observación"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label5
            '
            Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label5.BackColor = System.Drawing.Color.Gainsboro
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
            Me.Label5.Location = New System.Drawing.Point(547, 72)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(64, 16)
            Me.Label5.TabIndex = 11
            Me.Label5.Text = "Cantidad"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label4
            '
            Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label4.BackColor = System.Drawing.Color.Gainsboro
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
            Me.Label4.Location = New System.Drawing.Point(170, 27)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(512, 16)
            Me.Label4.TabIndex = 2
            Me.Label4.Text = "Descripción"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label3
            '
            Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label3.BackColor = System.Drawing.Color.Gainsboro
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
            Me.Label3.Location = New System.Drawing.Point(688, 27)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(67, 16)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Existencia"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Gainsboro
            Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
            Me.Label1.Location = New System.Drawing.Point(8, 27)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(156, 16)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Código"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label2
            '
            Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label2.BackColor = System.Drawing.Color.Gainsboro
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
            Me.Label2.Location = New System.Drawing.Point(8, 72)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(157, 16)
            Me.Label2.TabIndex = 176
            Me.Label2.Text = "Tipo Prestamo"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'DataGridView1
            '
            Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
            Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DataGridView1.Location = New System.Drawing.Point(8, 114)
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.Size = New System.Drawing.Size(747, 147)
            Me.DataGridView1.TabIndex = 177
            '
            'btnAgregar
            '
            Me.btnAgregar.Location = New System.Drawing.Point(615, 68)
            Me.btnAgregar.Name = "btnAgregar"
            Me.btnAgregar.Size = New System.Drawing.Size(69, 40)
            Me.btnAgregar.TabIndex = 178
            Me.btnAgregar.Text = "Agregar"
            Me.btnAgregar.UseVisualStyleBackColor = True
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(688, 68)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(69, 40)
            Me.Button1.TabIndex = 179
            Me.Button1.Text = "Quitar"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'Label7
            '
            Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label7.BackColor = System.Drawing.Color.White
            Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(688, 43)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(67, 20)
            Me.Label7.TabIndex = 180
            '
            'cboTipoPrestamo
            '
            Me.cboTipoPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboTipoPrestamo.FormattingEnabled = True
            Me.cboTipoPrestamo.Items.AddRange(New Object() {"ENTRADA", "SALIDA"})
            Me.cboTipoPrestamo.Location = New System.Drawing.Point(8, 88)
            Me.cboTipoPrestamo.Name = "cboTipoPrestamo"
            Me.cboTipoPrestamo.Size = New System.Drawing.Size(157, 21)
            Me.cboTipoPrestamo.TabIndex = 181
            '
            'frmPrestamosBodega
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(776, 410)
            Me.Controls.Add(Me.grpBox_Inventario)
            Me.Controls.Add(Me.Label36)
            Me.Controls.Add(Me.txtNombreUsuario)
            Me.Controls.Add(Me.txtUsuario)
            Me.Controls.Add(Me.ToolBar1)
            Me.Controls.Add(Me.Label15)
            Me.Name = "frmPrestamosBodega"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "frmPrestamosBodega"
            Me.grpBox_Inventario.ResumeLayout(False)
            Me.grpBox_Inventario.PerformLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
        Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
        Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
        Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
        Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
        Friend WithEvents ToolBarEliminar As System.Windows.Forms.ToolBarButton
        Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
        Friend WithEvents ToolBarExcel As System.Windows.Forms.ToolBarButton
        Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
        Friend WithEvents Label36 As System.Windows.Forms.Label
        Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
        Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
        Friend WithEvents grpBox_Inventario As System.Windows.Forms.GroupBox
        Friend WithEvents txtCodArticulo As System.Windows.Forms.TextBox
        Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
        Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
        Friend WithEvents txtDescripcion As System.Windows.Forms.Label
        Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents btnAgregar As System.Windows.Forms.Button
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents cboTipoPrestamo As System.Windows.Forms.ComboBox
    End Class

End Namespace
