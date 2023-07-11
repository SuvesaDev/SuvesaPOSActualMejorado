Public Class frmResponsableEnvioCobro
    Public IdUsuario As String = "0"
    Private Sub Loggin(_Clave As String)
        Dim dt As New System.Data.DataTable
        cFunciones.Llenar_Tabla_Generico("select Id_Usuario, Nombre from Usuarios where Clave_Interna = '" & _Clave & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.IdUsuario = dt.Rows(0).Item("Id_Usuario")
            Me.txtUsuario.Text = dt.Rows(0).Item("Nombre")
            Me.btnEnviar.Enabled = True
        Else
            Me.txtUsuario.Text = ""
            Me.IdUsuario = "0"
            Me.btnEnviar.Enabled = False
        End If
    End Sub

    Private Sub txtClave_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Loggin(Me.txtClave.Text)
        End If
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

End Class