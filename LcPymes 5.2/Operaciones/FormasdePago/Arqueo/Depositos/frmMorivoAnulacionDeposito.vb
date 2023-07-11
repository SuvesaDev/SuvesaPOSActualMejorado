Public Class frmMorivoAnulacionDeposito

    Public IdUsuario As String = ""

    Private Sub Login()
        Try
            Dim dt As New System.Data.DataTable
            cFunciones.Llenar_Tabla_Generico("select Id_Usuario, Nombre from Usuarios where Clave_Interna = '" & Me.txtClave.Text & "'", dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Me.IdUsuario = dt.Rows(0).Item("Id_Usuario")
                Me.txtUsuario.Text = dt.Rows(0).Item("Nombre")
                Me.txtMotivo.Enabled = True
                Me.btnAceptar.Enabled = True
                Me.txtMotivo.Focus()
            Else
                Me.IdUsuario = "0"
                Me.txtUsuario.Text = ""
                Me.txtMotivo.Enabled = False
                Me.btnAceptar.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try        
    End Sub

    Private Sub txtClave_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Keys.Enter Then Me.Login()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.txtMotivo.Text.Trim <> "" Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

End Class