Imports System.Windows.Forms
Public Class Monto_Transporte
    Inherits System.Windows.Forms.Form
    Public Monto As Double
    Public Id_Ventas As String

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public Sub New(ByVal Id_Ventas1 As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Id_Ventas = Id_Ventas1
    End Sub
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextNumero As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.TextNumero = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.TextNumero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SimpleButton1.Location = New System.Drawing.Point(64, 88)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "Aceptar"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SimpleButton2.Location = New System.Drawing.Point(176, 88)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "Cancelar"
        '
        'TextNumero
        '
        Me.TextNumero.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TextNumero.Location = New System.Drawing.Point(184, 56)
        Me.TextNumero.Name = "TextNumero"
        '
        'TextNumero.Properties
        '
        Me.TextNumero.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextNumero.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextNumero.Properties.EditFormat.FormatString = "0"
        Me.TextNumero.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextNumero.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.TextNumero.Size = New System.Drawing.Size(112, 19)
        Me.TextNumero.TabIndex = 0
        '
        'TextEdit1
        '
        Me.TextEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TextEdit1.Location = New System.Drawing.Point(184, 8)
        Me.TextEdit1.Name = "TextEdit1"
        '
        'TextEdit1.Properties
        '
        Me.TextEdit1.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TextEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.Enabled = False
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.TextEdit1.Size = New System.Drawing.Size(112, 19)
        Me.TextEdit1.TabIndex = 0
        '
        'TextEdit2
        '
        Me.TextEdit2.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TextEdit2.Location = New System.Drawing.Point(184, 32)
        Me.TextEdit2.Name = "TextEdit2"
        '
        'TextEdit2.Properties
        '
        Me.TextEdit2.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit2.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TextEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit2.Properties.Enabled = False
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Default, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.TextEdit2.Size = New System.Drawing.Size(112, 19)
        Me.TextEdit2.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(8, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Monto Transporte Original"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Monto Transporte Devuelto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Monto Transporte a Devolver"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Monto_Transporte
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.SimpleButton2
        Me.ClientSize = New System.Drawing.Size(308, 120)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.TextEdit2)
        Me.Controls.Add(Me.TextNumero)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(314, 152)
        Me.MinimumSize = New System.Drawing.Size(314, 152)
        Me.Name = "Monto_Transporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monto Transporte......."
        CType(Me.TextNumero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        If TextNumero.Text.Length > 0 Then
            If ValidarMontos() Then
                Try
                    Monto = CDbl(TextNumero.Text)
                    Me.DialogResult = DialogResult.OK
                Catch ex As Exception
                    TextNumero.Text = "0"
                End Try
            Else
                MsgBox("Error en las cantidad a devolver, Favor reviselas")
            End If
        Else
            MsgBox("Debes digitar una cantidad", MsgBoxStyle.Information)
        End If
    End Sub


    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub


    Private Sub TextNumero_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextNumero.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextNumero.Text.Length > 0 Then
                If ValidarMontos() Then
                    Try
                        Monto = CDbl(TextNumero.Text)
                        Me.DialogResult = DialogResult.OK
                    Catch ex As Exception
                        TextNumero.Text = "0"
                    End Try
                Else
                    MsgBox("Error en las cantidad a devolver, favor revisalas")
                End If
            Else
                MsgBox("Debes digitar una cantidad", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub TextNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextNumero.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "."c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub Monto_Transporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Cantidad()
        Me.TextNumero.Focus()
    End Sub
    Sub Cargar_Cantidad()
        Dim con As New Conexion
        Dim Cantidad As String
        con.Conectar()
        Cantidad = con.SlqExecuteScalar(con.Conectar, "select Transporte from ventas where Id = " & Id_Ventas)

        If Cantidad <> "" Then Me.TextEdit1.Text = Cantidad Else Me.TextEdit1.Text = "0"
        Cantidad = 0
        Cantidad = con.SlqExecuteScalar(con.Conectar, "select isnull(sum(Transporte),0) from devoluciones_ventas where (Anulado = 0) and Id_Factura = " & Id_Ventas)

        If Cantidad <> "" Then TextEdit2.Text = Cantidad Else TextEdit2.Text = "0"

        Me.TextNumero.EditValue = Me.TextEdit1.EditValue - Me.TextEdit2.EditValue

        con.DesConectar(con.sQlconexion)
    End Sub


    Function ValidarMontos() As Boolean
        Dim Diferencia As Double = (CDbl(TextEdit1.Text) - CDbl(TextEdit2.Text))

        If Diferencia >= 0 Then
            If Diferencia >= CDbl(Me.TextNumero.Text) Then
                Return True
            Else
                Return False
            End If
        End If

    End Function
End Class
