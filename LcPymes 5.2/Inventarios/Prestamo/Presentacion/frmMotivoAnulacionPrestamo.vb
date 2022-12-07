Public Class frmMotivoAnulacionPrestamo

    Public IdUsuario As String = ""

    Private Sub txtClave_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Keys.Enter And Me.txtClave.Text <> "" Then
            Dim clave As String = Me.txtClave.Text
            Dim dt As New System.Data.DataTable
            cFunciones.Llenar_Tabla_Generico("select Id_Usuario, Nombre from Usuarios where Clave_Interna = '" & clave & "'", dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Me.IdUsuario = dt.Rows(0).Item("Id_Usuario")
                Me.txtUsuario.Text = dt.Rows(0).Item("Nombre")
                Me.txtObservaciones.Enabled = True
                Me.txtObservaciones.Focus()
            Else
                Me.IdUsuario = ""
                Me.txtUsuario.Text = ""
                Me.txtObservaciones.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.txtObservaciones.Text <> "" Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

End Class