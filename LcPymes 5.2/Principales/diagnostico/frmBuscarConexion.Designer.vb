<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarConexion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarConexion))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDiagnosticar = New System.Windows.Forms.Button()
        Me.btnCambiarConexion = New System.Windows.Forms.Button()
        Me.pbRed = New System.Windows.Forms.PictureBox()
        Me.btnInfoRED = New System.Windows.Forms.Button()
        Me.pbServidor = New System.Windows.Forms.PictureBox()
        Me.btnInfoServidor = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbServidor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "accept_button.png")
        Me.ImageList1.Images.SetKeyName(1, "delete.png")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Conectado a la RED"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Acceso al Servidor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(216, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 30)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Estado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(297, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 30)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Info"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCambiarConexion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.pbRed)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnInfoRED)
        Me.GroupBox1.Controls.Add(Me.pbServidor)
        Me.GroupBox1.Controls.Add(Me.btnInfoServidor)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(4, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 201)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Diagnostico"
        '
        'btnDiagnosticar
        '
        Me.btnDiagnosticar.BackColor = System.Drawing.Color.Transparent
        Me.btnDiagnosticar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiagnosticar.Image = Global.LcPymes_5._2.My.Resources.Resources.server_connect
        Me.btnDiagnosticar.Location = New System.Drawing.Point(10, 8)
        Me.btnDiagnosticar.Name = "btnDiagnosticar"
        Me.btnDiagnosticar.Size = New System.Drawing.Size(182, 44)
        Me.btnDiagnosticar.TabIndex = 8
        Me.btnDiagnosticar.Text = "Diagnosticar Conexion"
        Me.btnDiagnosticar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDiagnosticar.UseVisualStyleBackColor = False
        '
        'btnCambiarConexion
        '
        Me.btnCambiarConexion.BackColor = System.Drawing.Color.Transparent
        Me.btnCambiarConexion.Enabled = False
        Me.btnCambiarConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiarConexion.Image = Global.LcPymes_5._2.My.Resources.Resources.setting_tools
        Me.btnCambiarConexion.Location = New System.Drawing.Point(355, 126)
        Me.btnCambiarConexion.Name = "btnCambiarConexion"
        Me.btnCambiarConexion.Size = New System.Drawing.Size(48, 50)
        Me.btnCambiarConexion.TabIndex = 8
        Me.btnCambiarConexion.UseVisualStyleBackColor = False
        '
        'pbRed
        '
        Me.pbRed.Location = New System.Drawing.Point(221, 61)
        Me.pbRed.Name = "pbRed"
        Me.pbRed.Size = New System.Drawing.Size(64, 50)
        Me.pbRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbRed.TabIndex = 0
        Me.pbRed.TabStop = False
        '
        'btnInfoRED
        '
        Me.btnInfoRED.BackColor = System.Drawing.Color.Transparent
        Me.btnInfoRED.Enabled = False
        Me.btnInfoRED.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfoRED.Image = Global.LcPymes_5._2.My.Resources.Resources.information
        Me.btnInfoRED.Location = New System.Drawing.Point(296, 61)
        Me.btnInfoRED.Name = "btnInfoRED"
        Me.btnInfoRED.Size = New System.Drawing.Size(48, 50)
        Me.btnInfoRED.TabIndex = 5
        Me.btnInfoRED.UseVisualStyleBackColor = False
        '
        'pbServidor
        '
        Me.pbServidor.Location = New System.Drawing.Point(221, 126)
        Me.pbServidor.Name = "pbServidor"
        Me.pbServidor.Size = New System.Drawing.Size(64, 50)
        Me.pbServidor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbServidor.TabIndex = 3
        Me.pbServidor.TabStop = False
        '
        'btnInfoServidor
        '
        Me.btnInfoServidor.BackColor = System.Drawing.Color.Transparent
        Me.btnInfoServidor.Enabled = False
        Me.btnInfoServidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfoServidor.Image = Global.LcPymes_5._2.My.Resources.Resources.information
        Me.btnInfoServidor.Location = New System.Drawing.Point(296, 126)
        Me.btnInfoServidor.Name = "btnInfoServidor"
        Me.btnInfoServidor.Size = New System.Drawing.Size(48, 50)
        Me.btnInfoServidor.TabIndex = 4
        Me.btnInfoServidor.UseVisualStyleBackColor = False
        '
        'frmBuscarConexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 266)
        Me.Controls.Add(Me.btnDiagnosticar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscarConexion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado de la Conexion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbServidor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbRed As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pbServidor As System.Windows.Forms.PictureBox
    Friend WithEvents btnInfoServidor As System.Windows.Forms.Button
    Friend WithEvents btnInfoRED As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDiagnosticar As System.Windows.Forms.Button
    Friend WithEvents btnCambiarConexion As System.Windows.Forms.Button
End Class
