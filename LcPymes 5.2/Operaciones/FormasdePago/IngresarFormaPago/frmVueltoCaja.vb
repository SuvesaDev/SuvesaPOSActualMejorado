Public Class frmVueltoCaja

    Public Vuelto As Decimal

    Private Sub frmVueltoCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblVuelto.Text = Me.lblVuelto.Text.Replace("?", Me.Vuelto.ToString("N2"))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class