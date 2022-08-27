Public Class vuelto
    Inherits System.Windows.Forms.Form
    Public MontoVuelto As Double
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label_Vuelto As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton4 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(vuelto))
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label_Vuelto = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.SimpleButton4 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(136, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(160, 24)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Su Cambio"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_Vuelto
        '
        Me.Label_Vuelto.BackColor = System.Drawing.Color.Transparent
        Me.Label_Vuelto.Font = New System.Drawing.Font("OCR A Extended", 26.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Vuelto.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label_Vuelto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_Vuelto.Location = New System.Drawing.Point(136, 40)
        Me.Label_Vuelto.Name = "Label_Vuelto"
        Me.Label_Vuelto.Size = New System.Drawing.Size(160, 48)
        Me.Label_Vuelto.TabIndex = 9
        Me.Label_Vuelto.Text = "0.00"
        Me.Label_Vuelto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(200, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 22)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "0.00"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton4.Location = New System.Drawing.Point(168, 120)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(128, 23)
        Me.SimpleButton4.TabIndex = 11
        Me.SimpleButton4.Text = "Aceptar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'vuelto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(304, 145)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label_Vuelto)
        Me.Controls.Add(Me.Label16)
        Me.MaximumSize = New System.Drawing.Size(320, 184)
        Me.Name = "vuelto"
        Me.Text = "Vuelto"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub vuelto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label_Vuelto.Text = "¢ " & Format(MontoVuelto, "#,#0.00").ToString
        Dim CONEX As New Conexion
        Dim TipoCambio_Dolar As Double
        TipoCambio_Dolar = CONEX.SlqExecuteScalar(CONEX.Conectar("Seguridad"), "SELECT ValorVenta FROM  Moneda WHERE (CodMoneda = 2)")
        Me.Label3.Text = "$ " & Format(MontoVuelto / TipoCambio_Dolar, "#,#0.00").ToString
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Close()
    End Sub
End Class
