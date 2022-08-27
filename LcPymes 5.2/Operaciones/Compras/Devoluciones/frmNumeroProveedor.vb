Public Class frmNumeroProveedor

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.txtNumeroDocumento.Text <> "" Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

End Class