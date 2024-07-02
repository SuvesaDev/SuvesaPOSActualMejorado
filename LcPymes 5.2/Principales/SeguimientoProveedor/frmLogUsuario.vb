Public Class frmLogUsuario

    Private Sub CargarUsuarios()
        Dim dt As New System.Data.DataTable
        cFunciones.Llenar_Tabla_Generico("select Clave_Interna, Nombre from Usuarios", dt, CadenaConexionSeePOS)
        Me.cboUsuario.DataSource = dt
        Me.cboUsuario.DisplayMember = "Nombre"
        Me.cboUsuario.ValueMember = "Clave_Interna"
    End Sub

    Private Function Login() As Boolean
        If Me.cboUsuario.SelectedValue = Me.txtClave.Text Then
            Return True
        Else
            MsgBox("Usuario o Contraseña incorrectos", MsgBoxStyle.Exclamation, "No se puede procesar la operacion")
            Me.txtClave.Focus()
            Return False
        End If
    End Function

    Private Sub frmLogUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarUsuarios()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.Login = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK            
        End If
    End Sub

    Private Sub cboUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClave.KeyDown, cboUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send("{Tab}")
    End Sub
End Class