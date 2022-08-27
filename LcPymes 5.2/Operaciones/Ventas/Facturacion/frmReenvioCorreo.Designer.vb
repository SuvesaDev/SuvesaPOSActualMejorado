<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReenvioCorreo
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
        Me.viewComprobantes = New System.Windows.Forms.DataGridView()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnImprimirPVE = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCanbiarCorreo = New System.Windows.Forms.Button()
        Me.btnNotaCredito = New System.Windows.Forms.Button()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.btnReenviar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.ckPVE = New System.Windows.Forms.CheckBox()
        CType(Me.viewComprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'viewComprobantes
        '
        Me.viewComprobantes.AllowUserToAddRows = False
        Me.viewComprobantes.AllowUserToDeleteRows = False
        Me.viewComprobantes.AllowUserToResizeColumns = False
        Me.viewComprobantes.AllowUserToResizeRows = False
        Me.viewComprobantes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewComprobantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.viewComprobantes.BackgroundColor = System.Drawing.Color.White
        Me.viewComprobantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewComprobantes.Location = New System.Drawing.Point(5, 86)
        Me.viewComprobantes.MultiSelect = False
        Me.viewComprobantes.Name = "viewComprobantes"
        Me.viewComprobantes.ReadOnly = True
        Me.viewComprobantes.RowHeadersVisible = False
        Me.viewComprobantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewComprobantes.Size = New System.Drawing.Size(818, 331)
        Me.viewComprobantes.TabIndex = 0
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(73, 17)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(134, 20)
        Me.dtpDesde.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(226, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hasta :"
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(277, 17)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(134, 20)
        Me.dtpHasta.TabIndex = 3
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(417, 14)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(120, 25)
        Me.btnMostrar.TabIndex = 5
        Me.btnMostrar.Text = "Cargar Datos"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnImprimirPVE)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnCanbiarCorreo)
        Me.GroupBox1.Controls.Add(Me.btnNotaCredito)
        Me.GroupBox1.Controls.Add(Me.lblCorreo)
        Me.GroupBox1.Controls.Add(Me.btnReenviar)
        Me.GroupBox1.Controls.Add(Me.viewComprobantes)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(829, 417)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'btnImprimirPVE
        '
        Me.btnImprimirPVE.Image = Global.LcPymes_5._2.My.Resources.Resources.printer
        Me.btnImprimirPVE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimirPVE.Location = New System.Drawing.Point(380, 39)
        Me.btnImprimirPVE.Name = "btnImprimirPVE"
        Me.btnImprimirPVE.Size = New System.Drawing.Size(181, 41)
        Me.btnImprimirPVE.TabIndex = 12
        Me.btnImprimirPVE.Text = "Imprimir PVE"
        Me.btnImprimirPVE.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Correo Electronico :"
        '
        'btnCanbiarCorreo
        '
        Me.btnCanbiarCorreo.Enabled = False
        Me.btnCanbiarCorreo.Image = Global.LcPymes_5._2.My.Resources.Resources.iconfinder_reload_all_tabs_1839
        Me.btnCanbiarCorreo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCanbiarCorreo.Location = New System.Drawing.Point(6, 39)
        Me.btnCanbiarCorreo.Name = "btnCanbiarCorreo"
        Me.btnCanbiarCorreo.Size = New System.Drawing.Size(181, 41)
        Me.btnCanbiarCorreo.TabIndex = 10
        Me.btnCanbiarCorreo.Text = "Cambiar Correo"
        Me.btnCanbiarCorreo.UseVisualStyleBackColor = True
        '
        'btnNotaCredito
        '
        Me.btnNotaCredito.Enabled = False
        Me.btnNotaCredito.ForeColor = System.Drawing.Color.Firebrick
        Me.btnNotaCredito.Image = Global.LcPymes_5._2.My.Resources.Resources.money_delete
        Me.btnNotaCredito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotaCredito.Location = New System.Drawing.Point(642, 39)
        Me.btnNotaCredito.Name = "btnNotaCredito"
        Me.btnNotaCredito.Size = New System.Drawing.Size(181, 41)
        Me.btnNotaCredito.TabIndex = 9
        Me.btnNotaCredito.Text = "Generar Devolucion"
        Me.btnNotaCredito.UseVisualStyleBackColor = True
        '
        'lblCorreo
        '
        Me.lblCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCorreo.Location = New System.Drawing.Point(131, 12)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(692, 23)
        Me.lblCorreo.TabIndex = 8
        Me.lblCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnReenviar
        '
        Me.btnReenviar.Enabled = False
        Me.btnReenviar.Image = Global.LcPymes_5._2.My.Resources.Resources.iconfinder_Forward_27850
        Me.btnReenviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReenviar.Location = New System.Drawing.Point(193, 39)
        Me.btnReenviar.Name = "btnReenviar"
        Me.btnReenviar.Size = New System.Drawing.Size(181, 41)
        Me.btnReenviar.TabIndex = 7
        Me.btnReenviar.Text = "Reenviar Correos"
        Me.btnReenviar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Detalle : "
        '
        'txtDetalle
        '
        Me.txtDetalle.Location = New System.Drawing.Point(74, 45)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(463, 20)
        Me.txtDetalle.TabIndex = 8
        '
        'ckPVE
        '
        Me.ckPVE.AutoSize = True
        Me.ckPVE.Location = New System.Drawing.Point(543, 47)
        Me.ckPVE.Name = "ckPVE"
        Me.ckPVE.Size = New System.Drawing.Size(78, 17)
        Me.ckPVE.TabIndex = 9
        Me.ckPVE.Text = "Incluir PVE"
        Me.ckPVE.UseVisualStyleBackColor = True
        '
        'frmReenvioCorreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 485)
        Me.Controls.Add(Me.ckPVE)
        Me.Controls.Add(Me.txtDetalle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpHasta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDesde)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReenvioCorreo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reenvio de Correos"
        CType(Me.viewComprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents viewComprobantes As System.Windows.Forms.DataGridView
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnReenviar As System.Windows.Forms.Button
    Friend WithEvents lblCorreo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
    Friend WithEvents btnNotaCredito As System.Windows.Forms.Button
    Friend WithEvents btnCanbiarCorreo As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ckPVE As System.Windows.Forms.CheckBox
    Friend WithEvents btnImprimirPVE As System.Windows.Forms.Button
End Class
