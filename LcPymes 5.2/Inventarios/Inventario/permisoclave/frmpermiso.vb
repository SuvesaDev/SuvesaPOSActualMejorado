Imports System.Data
Imports System.Data.SqlClient

Public Class frmpermiso
    Inherits System.Windows.Forms.Form

    Public resultado As Boolean = False
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmpermiso))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtpass = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese la clave para habilitar:"
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(88, 40)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Microsoft.VisualBasic.ChrW(37)
        Me.txtpass.Size = New System.Drawing.Size(168, 26)
        Me.txtpass.TabIndex = 1
        Me.txtpass.Text = ""
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(264, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 32)
        Me.Button1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(312, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 32)
        Me.Button2.TabIndex = 3
        '
        'frmpermiso
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(384, 80)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(400, 88)
        Me.Name = "frmpermiso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Permiso para Habilitar productos"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        buscar()
    End Sub
    Sub buscar()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from permisos", dt, CadenaConexionSeePOS)
        For i As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(i).Item("clave") = Me.txtpass.Text Then
                resultado = True
                Close()
            End If
        Next
        If resultado = False Then
            MsgBox("Contraseña incorrecta o NO tiene permiso para Habilitar el producto, comunicar con gerencia", MsgBoxStyle.Critical, "Mensaje")
            Close()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        resultado = False
        Close()
    End Sub

    Private Sub txtpass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpass.TextChanged

    End Sub

    Private Sub txtpass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpass.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            buscar()
        End If
    End Sub
End Class
