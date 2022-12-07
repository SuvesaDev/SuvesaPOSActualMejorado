Public Class frmDevolverEntregaCuenta

    Private Function ValidaTexto(_Texto As String) As Boolean
        If _Texto.Trim = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Resultado As Boolean = True
        If ValidaTexto(Me.txtCedulaCuenta.Text) = False Or _
            ValidaTexto(Me.txtNombreCuenta.Text) = False Or _
            ValidaTexto(Me.txtMascota.Text) = False Or _
            ValidaTexto(Me.txtBanco.Text) = False Or _
            ValidaTexto(Me.txtNumeroCuenta.Text) = False Or _
            ValidaTexto(Me.txtMotivo.Text) = False Then
            MsgBox("Faltan datos por ingresar", MsgBoxStyle.Exclamation, Me.Text)
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub txtCedulaCuenta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumeroCuenta.KeyDown, txtNombreCuenta.KeyDown, txtMascota.KeyDown, txtCedulaCuenta.KeyDown, txtBanco.KeyDown
        If e.KeyCode = Keys.Enter And sender.Text <> "" Then SendKeys.Send("{tab}")
    End Sub
End Class