<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipalCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipalCaja))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.lblUsuario = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CorteDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepositosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArqueoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.FirmadoContadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetalleTallerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnFichasActivas = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnArchivar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.DevolucionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrestamosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HistorialVueltosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.lblUsuario, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripSeparator3, Me.ToolStripButton4, Me.ToolStripSeparator5, Me.btnFichasActivas, Me.ToolStripSeparator7, Me.btnArchivar, Me.ToolStripSeparator8, Me.ToolStripButton5, Me.ToolStripSeparator9, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(965, 32)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(52, 29)
        Me.ToolStripButton2.Text = "TC $"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = Global.LcPymes_5._2.My.Resources.Resources._1339068973_electronic_billing_machine
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(113, 29)
        Me.ToolStripButton1.Text = "Facturacion"
        '
        'lblUsuario
        '
        Me.lblUsuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(89, 29)
        Me.lblUsuario.Text = "[Usuario]"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 32)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CorteDeCajaToolStripMenuItem, Me.DepositosToolStripMenuItem, Me.ArqueoToolStripMenuItem, Me.ToolStripSeparator4, Me.FirmadoContadoToolStripMenuItem, Me.DetalleTallerToolStripMenuItem, Me.HistorialVueltosToolStripMenuItem})
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(76, 29)
        Me.ToolStripButton3.Text = "Cierre"
        '
        'CorteDeCajaToolStripMenuItem
        '
        Me.CorteDeCajaToolStripMenuItem.Name = "CorteDeCajaToolStripMenuItem"
        Me.CorteDeCajaToolStripMenuItem.Size = New System.Drawing.Size(261, 30)
        Me.CorteDeCajaToolStripMenuItem.Text = "Movimientos de Caja"
        '
        'DepositosToolStripMenuItem
        '
        Me.DepositosToolStripMenuItem.Name = "DepositosToolStripMenuItem"
        Me.DepositosToolStripMenuItem.Size = New System.Drawing.Size(261, 30)
        Me.DepositosToolStripMenuItem.Text = "Depositos"
        '
        'ArqueoToolStripMenuItem
        '
        Me.ArqueoToolStripMenuItem.Name = "ArqueoToolStripMenuItem"
        Me.ArqueoToolStripMenuItem.Size = New System.Drawing.Size(261, 30)
        Me.ArqueoToolStripMenuItem.Text = "Arqueo"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(258, 6)
        '
        'FirmadoContadoToolStripMenuItem
        '
        Me.FirmadoContadoToolStripMenuItem.Name = "FirmadoContadoToolStripMenuItem"
        Me.FirmadoContadoToolStripMenuItem.Size = New System.Drawing.Size(261, 30)
        Me.FirmadoContadoToolStripMenuItem.Text = "Firmado Contado "
        '
        'DetalleTallerToolStripMenuItem
        '
        Me.DetalleTallerToolStripMenuItem.Name = "DetalleTallerToolStripMenuItem"
        Me.DetalleTallerToolStripMenuItem.Size = New System.Drawing.Size(261, 30)
        Me.DetalleTallerToolStripMenuItem.Text = "Detalle Taller"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 32)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(86, 29)
        Me.ToolStripButton4.Text = "Voucher"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 32)
        '
        'btnFichasActivas
        '
        Me.btnFichasActivas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnFichasActivas.Image = CType(resources.GetObject("btnFichasActivas.Image"), System.Drawing.Image)
        Me.btnFichasActivas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFichasActivas.Name = "btnFichasActivas"
        Me.btnFichasActivas.Size = New System.Drawing.Size(75, 29)
        Me.btnFichasActivas.Text = "Activas"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 32)
        '
        'btnArchivar
        '
        Me.btnArchivar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnArchivar.Image = CType(resources.GetObject("btnArchivar.Image"), System.Drawing.Image)
        Me.btnArchivar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnArchivar.Name = "btnArchivar"
        Me.btnArchivar.Size = New System.Drawing.Size(86, 29)
        Me.btnArchivar.Text = "Archivar"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 32)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DevolucionesToolStripMenuItem, Me.ToolStripSeparator6, Me.PrestamosToolStripMenuItem})
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(129, 29)
        Me.ToolStripButton5.Text = "Reimpresion"
        '
        'DevolucionesToolStripMenuItem
        '
        Me.DevolucionesToolStripMenuItem.Name = "DevolucionesToolStripMenuItem"
        Me.DevolucionesToolStripMenuItem.Size = New System.Drawing.Size(197, 30)
        Me.DevolucionesToolStripMenuItem.Text = "Devoluciones"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(194, 6)
        '
        'PrestamosToolStripMenuItem
        '
        Me.PrestamosToolStripMenuItem.Name = "PrestamosToolStripMenuItem"
        Me.PrestamosToolStripMenuItem.Size = New System.Drawing.Size(197, 30)
        Me.PrestamosToolStripMenuItem.Text = "Prestamos"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 32)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(26, 29)
        Me.ToolStripButton6.Text = "  "
        '
        'Timer1
        '
        '
        'HistorialVueltosToolStripMenuItem
        '
        Me.HistorialVueltosToolStripMenuItem.Name = "HistorialVueltosToolStripMenuItem"
        Me.HistorialVueltosToolStripMenuItem.Size = New System.Drawing.Size(261, 30)
        Me.HistorialVueltosToolStripMenuItem.Text = "Historial Vueltos"
        '
        'frmPrincipalCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 431)
        Me.Controls.Add(Me.ToolStrip1)
        Me.IsMdiContainer = True
        Me.Name = "frmPrincipalCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Control de Caja "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblUsuario As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnFichasActivas As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnArchivar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents CorteDeCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepositosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArqueoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FirmadoContadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DetalleTallerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents DevolucionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrestamosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents HistorialVueltosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
