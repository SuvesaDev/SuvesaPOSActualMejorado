<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsistenteCierre
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
        Me.pPosicion1 = New System.Windows.Forms.GroupBox()
        Me.viewOTAbiertas = New System.Windows.Forms.DataGridView()
        Me.pPosicion2 = New System.Windows.Forms.GroupBox()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTrabajoSolicitados = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnSiguente = New System.Windows.Forms.Button()
        Me.pPosicion1.SuspendLayout()
        CType(Me.viewOTAbiertas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pPosicion2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pPosicion1
        '
        Me.pPosicion1.Controls.Add(Me.viewOTAbiertas)
        Me.pPosicion1.Location = New System.Drawing.Point(8, 9)
        Me.pPosicion1.Name = "pPosicion1"
        Me.pPosicion1.Size = New System.Drawing.Size(409, 326)
        Me.pPosicion1.TabIndex = 0
        Me.pPosicion1.TabStop = False
        Me.pPosicion1.Text = "Ordenes de Trabajo Abiertas"
        '
        'viewOTAbiertas
        '
        Me.viewOTAbiertas.AllowUserToAddRows = False
        Me.viewOTAbiertas.AllowUserToDeleteRows = False
        Me.viewOTAbiertas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.viewOTAbiertas.BackgroundColor = System.Drawing.Color.White
        Me.viewOTAbiertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewOTAbiertas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewOTAbiertas.Location = New System.Drawing.Point(3, 16)
        Me.viewOTAbiertas.MultiSelect = False
        Me.viewOTAbiertas.Name = "viewOTAbiertas"
        Me.viewOTAbiertas.ReadOnly = True
        Me.viewOTAbiertas.RowHeadersVisible = False
        Me.viewOTAbiertas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewOTAbiertas.Size = New System.Drawing.Size(403, 307)
        Me.viewOTAbiertas.TabIndex = 0
        '
        'pPosicion2
        '
        Me.pPosicion2.Controls.Add(Me.txtNombreUsuario)
        Me.pPosicion2.Controls.Add(Me.txtClave)
        Me.pPosicion2.Controls.Add(Me.txtObservaciones)
        Me.pPosicion2.Controls.Add(Me.Label10)
        Me.pPosicion2.Controls.Add(Me.Label5)
        Me.pPosicion2.Controls.Add(Me.txtTrabajoSolicitados)
        Me.pPosicion2.Controls.Add(Me.Label4)
        Me.pPosicion2.Controls.Add(Me.txtCliente)
        Me.pPosicion2.Controls.Add(Me.Label3)
        Me.pPosicion2.Controls.Add(Me.txtSerie)
        Me.pPosicion2.Controls.Add(Me.Label2)
        Me.pPosicion2.Controls.Add(Me.txtOT)
        Me.pPosicion2.Controls.Add(Me.Label1)
        Me.pPosicion2.Location = New System.Drawing.Point(441, 9)
        Me.pPosicion2.Name = "pPosicion2"
        Me.pPosicion2.Size = New System.Drawing.Size(409, 326)
        Me.pPosicion2.TabIndex = 1
        Me.pPosicion2.TabStop = False
        Me.pPosicion2.Text = "Cierre de Orden"
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Location = New System.Drawing.Point(74, 296)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(328, 20)
        Me.txtNombreUsuario.TabIndex = 17
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(9, 296)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(59, 20)
        Me.txtClave.TabIndex = 16
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(10, 186)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(393, 82)
        Me.txtObservaciones.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Usuario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Observaciones del Cierre"
        '
        'txtTrabajoSolicitados
        '
        Me.txtTrabajoSolicitados.Location = New System.Drawing.Point(9, 81)
        Me.txtTrabajoSolicitados.Multiline = True
        Me.txtTrabajoSolicitados.Name = "txtTrabajoSolicitados"
        Me.txtTrabajoSolicitados.ReadOnly = True
        Me.txtTrabajoSolicitados.Size = New System.Drawing.Size(393, 82)
        Me.txtTrabajoSolicitados.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Detalle del Servicio"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(180, 41)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(222, 20)
        Me.txtCliente.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(177, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cliente"
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(74, 41)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.ReadOnly = True
        Me.txtSerie.Size = New System.Drawing.Size(100, 20)
        Me.txtSerie.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Numero de Serie"
        '
        'txtOT
        '
        Me.txtOT.Location = New System.Drawing.Point(9, 41)
        Me.txtOT.Name = "txtOT"
        Me.txtOT.ReadOnly = True
        Me.txtOT.Size = New System.Drawing.Size(59, 20)
        Me.txtOT.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Num Orden"
        '
        'btnAtras
        '
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(12, 338)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(198, 33)
        Me.btnAtras.TabIndex = 2
        Me.btnAtras.Text = "Cancelar"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnSiguente
        '
        Me.btnSiguente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguente.Location = New System.Drawing.Point(216, 338)
        Me.btnSiguente.Name = "btnSiguente"
        Me.btnSiguente.Size = New System.Drawing.Size(198, 33)
        Me.btnSiguente.TabIndex = 3
        Me.btnSiguente.Text = "Siguiente"
        Me.btnSiguente.UseVisualStyleBackColor = True
        '
        'frmAsistenteCierre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 380)
        Me.Controls.Add(Me.btnSiguente)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.pPosicion2)
        Me.Controls.Add(Me.pPosicion1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAsistenteCierre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asistente Cierre de Orden"
        Me.pPosicion1.ResumeLayout(False)
        CType(Me.viewOTAbiertas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pPosicion2.ResumeLayout(False)
        Me.pPosicion2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pPosicion1 As System.Windows.Forms.GroupBox
    Friend WithEvents viewOTAbiertas As System.Windows.Forms.DataGridView
    Friend WithEvents pPosicion2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTrabajoSolicitados As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnSiguente As System.Windows.Forms.Button
End Class
