Imports System.Data
Imports System.Drawing.Printing
Imports System.Windows.Forms
Public Class frmNota
    Inherits System.Windows.Forms.Form
    Public resultado As Boolean
    Public Cedu_Admin As String
    Public cedu_usuario As String
    Public justificaAnulacion As Boolean
    Dim passAnulador As String

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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChkJustificacion As System.Windows.Forms.CheckBox
    Friend WithEvents LbAdmin As System.Windows.Forms.Label
    Friend WithEvents TxtpassAdmin As System.Windows.Forms.TextBox
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblContador As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_observacion As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.ChkJustificacion = New System.Windows.Forms.CheckBox
        Me.LbAdmin = New System.Windows.Forms.Label
        Me.TxtpassAdmin = New System.Windows.Forms.TextBox
        Me.txt_pass = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblContador = New System.Windows.Forms.Label
        Me.lbl_nombre = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_observacion = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.ChkJustificacion)
        Me.Panel1.Controls.Add(Me.LbAdmin)
        Me.Panel1.Controls.Add(Me.TxtpassAdmin)
        Me.Panel1.Controls.Add(Me.txt_pass)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblContador)
        Me.Panel1.Controls.Add(Me.lbl_nombre)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_observacion)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(448, 224)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Button1.Location = New System.Drawing.Point(352, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 32)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Cancelar"
        '
        'ChkJustificacion
        '
        Me.ChkJustificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkJustificacion.ForeColor = System.Drawing.Color.Blue
        Me.ChkJustificacion.Location = New System.Drawing.Point(328, 96)
        Me.ChkJustificacion.Name = "ChkJustificacion"
        Me.ChkJustificacion.Size = New System.Drawing.Size(112, 24)
        Me.ChkJustificacion.TabIndex = 19
        Me.ChkJustificacion.Text = "Justificable"
        '
        'LbAdmin
        '
        Me.LbAdmin.Location = New System.Drawing.Point(248, 24)
        Me.LbAdmin.Name = "LbAdmin"
        Me.LbAdmin.Size = New System.Drawing.Size(192, 23)
        Me.LbAdmin.TabIndex = 18
        '
        'TxtpassAdmin
        '
        Me.TxtpassAdmin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtpassAdmin.Location = New System.Drawing.Point(168, 24)
        Me.TxtpassAdmin.Name = "TxtpassAdmin"
        Me.TxtpassAdmin.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TxtpassAdmin.Size = New System.Drawing.Size(72, 20)
        Me.TxtpassAdmin.TabIndex = 17
        Me.TxtpassAdmin.Text = ""
        '
        'txt_pass
        '
        Me.txt_pass.Enabled = False
        Me.txt_pass.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_pass.Location = New System.Drawing.Point(168, 56)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(72, 20)
        Me.txt_pass.TabIndex = 13
        Me.txt_pass.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 32)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Contraseña encargado"
        '
        'lblContador
        '
        Me.lblContador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContador.Location = New System.Drawing.Point(400, 56)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(24, 23)
        Me.lblContador.TabIndex = 15
        Me.lblContador.Text = "0"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.Location = New System.Drawing.Point(248, 56)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(144, 23)
        Me.lbl_nombre.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 24)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Contraseña Usuario:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(8, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Motivo de la Reimpresión:"
        '
        'txt_observacion
        '
        Me.txt_observacion.Location = New System.Drawing.Point(8, 120)
        Me.txt_observacion.MaxLength = 250
        Me.txt_observacion.Multiline = True
        Me.txt_observacion.Name = "txt_observacion"
        Me.txt_observacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_observacion.Size = New System.Drawing.Size(432, 48)
        Me.txt_observacion.TabIndex = 0
        Me.txt_observacion.Text = ""
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Button2.Location = New System.Drawing.Point(256, 184)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 32)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Aceptar"
        '
        'frmNota
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(464, 240)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nota"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private sin_limite As Boolean
    Public Sub buscar_Usuario(ByVal clave As String)

        Dim SQL As New GestioDatos
        Dim sentencia As String = "SELECT * FROM Usuarios WHERE Clave_Interna = '" & clave & "'"
        Dim dtsUsuario As New DataTable
        dtsUsuario = SQL.Ejecuta(sentencia)

        If dtsUsuario.Rows.Count > 0 Then

            Me.lbl_nombre.Text = dtsUsuario.Rows(0).Item("nombre")
            cedu_usuario = dtsUsuario.Rows(0).Item("cedula")
        Else
            MsgBox("Contraseña Invalida", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Public Sub buscar_UsuarioAdmin(ByVal clave As String)

        Dim SQL As New GestioDatos
        Dim sentencia As String = "SELECT * FROM Usuarios WHERE Clave_Interna = '" & clave & "'"
        Dim dtsUsuario As New DataTable
        dtsUsuario = SQL.Ejecuta(sentencia)

        If dtsUsuario.Rows.Count > 0 Then

            Me.LbAdmin.Text = dtsUsuario.Rows(0).Item("nombre")
            Me.Cedu_Admin = dtsUsuario.Rows(0).Item("cedula")
        Else
            MsgBox("Contraseña Invalida", MsgBoxStyle.Exclamation)
        End If

    End Sub
    Public Sub buscar_usuario_Anulador(ByVal passAnulador As String)

        Me.sin_limite = VerificandoAcceso_a_Modulos("Permite reimprimir", "Reimprimir", Cedu_Admin, "Administración")
        If sin_limite = False Then
            MsgBox("Usted no tiene permisos para Reimprimir Facturas!", MsgBoxStyle.OKOnly)
            Exit Sub
        End If
        txt_observacion.Enabled = True

    End Sub
    Private Sub frmNota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TxtpassAdmin.Focus()
        txt_observacion.Enabled = False
        Me.justificaAnulacion = 0
    End Sub

    Private Sub txtnota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_observacion.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.resultado = False
        Me.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txt_observacion.Text = "" Or Me.txt_observacion.TextLength < 3 Then
            MsgBox("Debes registrar una observacion", MsgBoxStyle.Information)
        Else
            Me.resultado = True
            Me.Close()
        End If
    End Sub
    Private Sub txt_pass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_pass.KeyDown

        If e.KeyCode = Windows.Forms.Keys.Enter Then
            If Me.txt_pass.Text <> TxtpassAdmin.Text Then

                If Me.txt_pass.Text = "" Then
                    MsgBox("Digite su contraseña...!", MsgBoxStyle.OKOnly)
                    Exit Sub
                Else
                    buscar_usuario_Anulador(passAnulador)
                    buscar_Usuario(Me.txt_pass.Text)
                End If
            Else
                MsgBox("El Administrador y el Usuario no pueden ser el mismo", MsgBoxStyle.Exclamation, Text)
            End If
        End If

    End Sub

    Private Sub TxtpassAdmin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtpassAdmin.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then

            If Me.TxtpassAdmin.Text = "" Then
                MsgBox("Digite su contraseña...!", MsgBoxStyle.OKOnly)
                Exit Sub
            Else
                passAnulador = Me.TxtpassAdmin.Text
                Me.buscar_UsuarioAdmin(Me.TxtpassAdmin.Text)
                Me.txt_pass.Enabled = True
                Me.txt_pass.Focus()

            End If

        End If

    End Sub

    Private Sub TxtpassAdmin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtpassAdmin.TextChanged

    End Sub

    Private Sub txt_pass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pass.TextChanged

    End Sub
End Class
