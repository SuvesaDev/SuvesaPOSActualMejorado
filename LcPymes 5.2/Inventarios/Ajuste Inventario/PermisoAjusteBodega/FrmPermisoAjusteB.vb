Imports System.Data
Imports System.Drawing.Printing
Imports System.Windows.Forms

Public Class FrmPermisoAjusteB
    Inherits System.Windows.Forms.Form
    Public resultado As Boolean
    Public Cedu_Admin As String
    Public cedu_usuario As String
    Dim PassAjustBodega As String

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents txt_observacion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtpassAdmin As System.Windows.Forms.TextBox
    Friend WithEvents LbAdmin As System.Windows.Forms.Label
    Friend WithEvents btn_Reg As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_pass = New System.Windows.Forms.TextBox
        Me.lbl_nombre = New System.Windows.Forms.Label
        Me.txt_observacion = New System.Windows.Forms.TextBox
        Me.btn_Reg = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtpassAdmin = New System.Windows.Forms.TextBox
        Me.LbAdmin = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contraseña Usuario:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Observaciones:"
        '
        'txt_pass
        '
        Me.txt_pass.Enabled = False
        Me.txt_pass.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_pass.Location = New System.Drawing.Point(96, 64)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(72, 20)
        Me.txt_pass.TabIndex = 2
        Me.txt_pass.Text = ""
        '
        'lbl_nombre
        '
        Me.lbl_nombre.Location = New System.Drawing.Point(184, 64)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(144, 23)
        Me.lbl_nombre.TabIndex = 3
        '
        'txt_observacion
        '
        Me.txt_observacion.Location = New System.Drawing.Point(96, 96)
        Me.txt_observacion.Multiline = True
        Me.txt_observacion.Name = "txt_observacion"
        Me.txt_observacion.Size = New System.Drawing.Size(264, 80)
        Me.txt_observacion.TabIndex = 4
        Me.txt_observacion.Text = ""
        '
        'btn_Reg
        '
        Me.btn_Reg.Location = New System.Drawing.Point(96, 200)
        Me.btn_Reg.Name = "btn_Reg"
        Me.btn_Reg.TabIndex = 5
        Me.btn_Reg.Text = "Registrar"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(184, 200)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.TabIndex = 6
        Me.btn_cancelar.Text = "Cancelar"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 32)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Contraseña Administrador:"
        '
        'TxtpassAdmin
        '
        Me.TxtpassAdmin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtpassAdmin.Location = New System.Drawing.Point(96, 16)
        Me.TxtpassAdmin.Name = "TxtpassAdmin"
        Me.TxtpassAdmin.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TxtpassAdmin.Size = New System.Drawing.Size(72, 20)
        Me.TxtpassAdmin.TabIndex = 9
        Me.TxtpassAdmin.Text = ""
        '
        'LbAdmin
        '
        Me.LbAdmin.Location = New System.Drawing.Point(184, 16)
        Me.LbAdmin.Name = "LbAdmin"
        Me.LbAdmin.Size = New System.Drawing.Size(144, 23)
        Me.LbAdmin.TabIndex = 10
        '
        'FrmPermisoAjusteB
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(384, 236)
        Me.Controls.Add(Me.LbAdmin)
        Me.Controls.Add(Me.TxtpassAdmin)
        Me.Controls.Add(Me.txt_observacion)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_Reg)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPermisoAjusteB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Permiso Para Ajuste de Bodega"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Private sin_limite As Boolean
    Private Sub justificaAnulacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TxtpassAdmin.Focus()
        txt_observacion.Enabled = False
        btn_Reg.Enabled = False
    End Sub

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
            buscar_usuario_Ajuste(Cedu_Admin)
        Else
            MsgBox("Contraseña Invalida", MsgBoxStyle.Exclamation)
        End If

    End Sub


    Public Sub buscar_usuario_Ajuste(ByVal PassAjustBodega As String)
        Me.sin_limite = VerificandoAcceso_a_Modulos("FrmPermisoAjusteB", "PermisoMovimiento", Cedu_Admin, "Inventarios")

        If sin_limite = True Then
            Me.txt_pass.Enabled = True
            Me.txt_pass.Focus()
            Me.txt_observacion.Enabled = True
            btn_Reg.Enabled = True
        Else

            MsgBox("Usted no tiene permisos para Ajustar Inventario!", MsgBoxStyle.OKOnly)
            Me.resultado = False

            Exit Sub

        End If


    End Sub

    Private Sub btn_Reg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reg.Click

        If txt_observacion.Text = "" Then

            MsgBox("Debes registrar una observacion", MsgBoxStyle.Information)
        Else

            Me.resultado = True
            Me.Close()
        End If
    End Sub
    Private Sub txt_pass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_pass.KeyDown

        If e.KeyCode = Windows.Forms.Keys.Enter Then

            If Me.txt_pass.Text = "" Then
                MsgBox("Digite su contraseña...!", MsgBoxStyle.OKOnly)
                Exit Sub
            Else
                'Me.buscar_usuario_Ajuste(PassAjustBodega)
                buscar_Usuario(Me.txt_pass.Text)
            End If

        End If

    End Sub

    Private Sub TxtpassAdmin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtpassAdmin.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then

            If Me.TxtpassAdmin.Text = "" Then
                MsgBox("Digite su contraseña...!", MsgBoxStyle.OKOnly)
                Exit Sub
            Else
                PassAjustBodega = Me.TxtpassAdmin.Text
                Me.buscar_UsuarioAdmin(Me.TxtpassAdmin.Text)


            End If

        End If

    End Sub
    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click

        Me.resultado = False
        Me.Close()

    End Sub
    'Public Sub devuelve_anulados(ByVal ced As String, ByVal fecha As Date)

    '    Dim SQL As New GestioDatos
    '    Dim sentencia As String = "SELECT COUNT(*) AS Anulados FROM registro_anulaciones WHERE (cedula_usuario = '" & ced & "') AND (fecha = dbo.dateonly(getdate()) AND (justificacion = 0))"
    '    Me.lblContador.Text = SQL.Ejecuta(sentencia).Rows(0).Item(0)

    'End Sub


    Private Sub TxtpassAdmin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtpassAdmin.TextChanged

    End Sub
End Class
