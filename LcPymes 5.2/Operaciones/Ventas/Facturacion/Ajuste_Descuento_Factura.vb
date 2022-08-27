Public Class Ajuste_Descuento_Factura
    Inherits System.Windows.Forms.Form
    Public maximo_porc_descuento As Double
    Public nuevo_porc_descuento As Double
    Public Maximo_Porcentaje_Credito_Cliente As Double

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    Public Sub New(ByVal des_viejo, ByVal des_max_Cliente)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        maximo_porc_descuento = des_viejo
        Me.Maximo_Porcentaje_Credito_Cliente = des_max_Cliente
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
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SimpleButton2
        '
        Me.SimpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SimpleButton2.Location = New System.Drawing.Point(248, 120)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton2.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.SimpleButton2.TabIndex = 4
        Me.SimpleButton2.Text = "Cancelar"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(144, 120)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton1.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "Aceptar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 104)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ajuste Descuento"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(304, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Este cliente no tiene predefinido un descuento máximo"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(270, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "%"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(226, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Label"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(208, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Máximo Descuento Aplicable al Cliente"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(270, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "%"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(261, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "% Sobre el Porcentaje del artículo"
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TextBox1.Location = New System.Drawing.Point(224, 60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(40, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "0"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(9, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descuento deseable:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(224, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usted puede aplicar como máximo un"
        '
        'Ajuste_Descuento_Factura
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.SimpleButton2
        Me.ClientSize = New System.Drawing.Size(488, 150)
        Me.ControlBox = False
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximumSize = New System.Drawing.Size(496, 192)
        Me.Name = "Ajuste_Descuento_Factura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajuste Descuento"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Ajuste_Descuento_Factura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label2.Text = Me.maximo_porc_descuento

        If Me.Maximo_Porcentaje_Credito_Cliente = 0 Then
            Me.Label9.Visible = True
            Me.Label6.Visible = False
            Me.Label7.Visible = False
            Me.Label8.Visible = False
        Else
            Me.Label6.Visible = True
            Me.Label7.Visible = True
            Me.Label8.Visible = True
            Me.Label9.Visible = False
            Me.Label7.Text = Me.Maximo_Porcentaje_Credito_Cliente
        End If
    End Sub


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        cambiar_descuento()
    End Sub


    Sub cambiar_descuento()
        Try
            If CDbl(Me.TextBox1.Text) > CDbl(Me.Label2.Text) Then
                MsgBox("Usted no Puede asignar ese porcentaje de descuento", MsgBoxStyle.Critical)
                Me.TextBox1.Text = Me.maximo_porc_descuento
                Exit Sub
            End If

            If Me.Label7.Visible Then
                If CDbl(Me.TextBox1.Text) > CDbl(Me.Label7.Text) Then
                    MsgBox("A este cliente no se le puede asignar este porcentaje de descuento", MsgBoxStyle.Critical)
                    Me.TextBox1.Text = Me.Maximo_Porcentaje_Credito_Cliente
                    Exit Sub
                End If
            End If
        Catch
            Me.TextBox1.Text = 0
        End Try


        Me.nuevo_porc_descuento = CDbl(Me.TextBox1.Text)
        Me.Dispose(True)
    End Sub


    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Dispose(True)
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Windows.Forms.Keys.Back)) And Not (e.KeyChar = "."c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            cambiar_descuento()
        End If
    End Sub
End Class
