Imports System.Windows.Forms
Namespace Prestamos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frm_presentacion
        Inherits System.Windows.Forms.Form

        'Form reemplaza a Dispose para limpiar la lista de componentes.
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

        'Requerido por el Diseñador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        'Se puede modificar usando el Diseñador de Windows Forms.  
        'No lo modifique con el editor de código.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
            Me.PictureBox2 = New System.Windows.Forms.PictureBox()
            Me.lbcargar = New System.Windows.Forms.Label()
            Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
            Me.Copyright = New System.Windows.Forms.Label()
            Me.Version = New System.Windows.Forms.Label()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Timer1
            '
            Me.Timer1.Enabled = True
            Me.Timer1.Interval = 20
            '
            'LinkLabel1
            '
            Me.LinkLabel1.AutoSize = True
            Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
            Me.LinkLabel1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LinkLabel1.LinkColor = System.Drawing.Color.Green
            Me.LinkLabel1.Location = New System.Drawing.Point(309, 281)
            Me.LinkLabel1.Name = "LinkLabel1"
            Me.LinkLabel1.Size = New System.Drawing.Size(126, 16)
            Me.LinkLabel1.TabIndex = 15
            Me.LinkLabel1.TabStop = True
            Me.LinkLabel1.Text = "mmaicol88@gmail.com"
            '
            'PictureBox2
            '
            Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
            Me.PictureBox2.Image = My.Resources.Resources.logoMM
            Me.PictureBox2.Location = New System.Drawing.Point(441, 253)
            Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(47, 44)
            Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox2.TabIndex = 14
            Me.PictureBox2.TabStop = False
            '
            'lbcargar
            '
            Me.lbcargar.AutoSize = True
            Me.lbcargar.BackColor = System.Drawing.Color.Transparent
            Me.lbcargar.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbcargar.ForeColor = System.Drawing.Color.DarkGoldenrod
            Me.lbcargar.Location = New System.Drawing.Point(348, 198)
            Me.lbcargar.Name = "lbcargar"
            Me.lbcargar.Size = New System.Drawing.Size(98, 20)
            Me.lbcargar.TabIndex = 13
            Me.lbcargar.Text = "Cargando %0"
            '
            'ProgressBar1
            '
            Me.ProgressBar1.Location = New System.Drawing.Point(288, 222)
            Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.ProgressBar1.Name = "ProgressBar1"
            Me.ProgressBar1.Size = New System.Drawing.Size(200, 23)
            Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
            Me.ProgressBar1.TabIndex = 12
            '
            'Copyright
            '
            Me.Copyright.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.Copyright.BackColor = System.Drawing.Color.Transparent
            Me.Copyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Copyright.Location = New System.Drawing.Point(296, 137)
            Me.Copyright.Name = "Copyright"
            Me.Copyright.Size = New System.Drawing.Size(197, 23)
            Me.Copyright.TabIndex = 16
            Me.Copyright.Text = "Copyright"
            '
            'Version
            '
            Me.Version.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.Version.BackColor = System.Drawing.Color.Transparent
            Me.Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Version.Location = New System.Drawing.Point(296, 119)
            Me.Version.Name = "Version"
            Me.Version.Size = New System.Drawing.Size(105, 18)
            Me.Version.TabIndex = 17
            Me.Version.Text = "Versión 0.22.9.17"
            '
            'frm_presentacion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackgroundImage = My.Resources.Resources.intro
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.ClientSize = New System.Drawing.Size(496, 303)
            Me.ControlBox = False
            Me.Controls.Add(Me.Version)
            Me.Controls.Add(Me.Copyright)
            Me.Controls.Add(Me.LinkLabel1)
            Me.Controls.Add(Me.PictureBox2)
            Me.Controls.Add(Me.lbcargar)
            Me.Controls.Add(Me.ProgressBar1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frm_presentacion"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Timer1 As Timer
        Friend WithEvents LinkLabel1 As LinkLabel
        Friend WithEvents PictureBox2 As PictureBox
        Friend WithEvents lbcargar As Label
        Friend WithEvents ProgressBar1 As ProgressBar
        Friend WithEvents Copyright As Label
        Friend WithEvents Version As Label
    End Class

End Namespace
