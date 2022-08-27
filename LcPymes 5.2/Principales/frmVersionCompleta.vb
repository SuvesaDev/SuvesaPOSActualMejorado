Imports System.Data
Public Class frmVersionCompleta

    Public IdUsuario As String = ""
    Public Nombre As String = ""

    Private Sub getUsuarios()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * from UsuariosAdmin Where Clave_Interna = '" & Me.txtClave.Text & "'", dt, CadenaConexionSeguridad)
        If dt.Rows.Count > 0 Then
            Me.lblUsuario.Text = dt.Rows(0).Item("Nombre")
            Me.IdUsuario = dt.Rows(0).Item("id_usuario")
            Me.Nombre = dt.Rows(0).Item("Nombre")
            Me.btnAceptar.Enabled = True
        Else
            Me.lblUsuario.Text = ""
            Me.IdUsuario = ""
            Me.Nombre = ""
            Me.btnAceptar.Enabled = False
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtClave_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter And Me.txtClave.Text <> "" Then Me.getUsuarios()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmVersionCompleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblUsuario.Text = ""
    End Sub
End Class