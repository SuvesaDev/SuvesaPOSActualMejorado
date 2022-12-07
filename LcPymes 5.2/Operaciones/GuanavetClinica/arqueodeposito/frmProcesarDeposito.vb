Public Class frmProcesarDeposito

    Public Estado As String = "pendiente"


    Private Sub btnDeposito_Click(sender As Object, e As EventArgs) Handles btnDeposito.Click
        Me.Estado = "depositado"
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnPendiente_Click(sender As Object, e As EventArgs) Handles btnPendiente.Click
        Me.Estado = "pendiente"
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub


End Class