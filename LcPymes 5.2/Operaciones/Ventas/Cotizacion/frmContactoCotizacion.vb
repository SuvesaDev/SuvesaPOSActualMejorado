Public Class frmContactoCotizacion

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.txtTelefono.Text.Length < 8 Then
            MsgBox("Numero de telefono invalido." & vbNewLine _
                   & "El telefono debe tener almenos 8 digitos", MsgBoxStyle.Exclamation, "No se puede realizar la operacion.")
            Exit Sub
        End If
        If Me.txtContacto.Text <> "" And Me.txtTelefono.Text <> "" Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class