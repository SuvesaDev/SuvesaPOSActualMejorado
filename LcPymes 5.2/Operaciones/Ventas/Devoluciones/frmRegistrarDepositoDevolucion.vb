Public Class frmRegistrarDepositoDevolucion

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.txtDocumento.Text <> "" Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

End Class