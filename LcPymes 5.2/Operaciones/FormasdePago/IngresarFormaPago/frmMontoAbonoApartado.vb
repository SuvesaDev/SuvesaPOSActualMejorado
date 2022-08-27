Public Class frmMontoAbonoApartado
    Public Tope As Decimal = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        If Me.txtAbono.Text <> "" Then
            If IsNumeric(Me.txtAbono.Text) Then
                If CDec(Me.txtAbono.Text) > 0 Then
                    If CDec(Me.txtAbono.Text) < Me.Tope Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtAbono_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAbono.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtAbono.Text <> "" Then
                If IsNumeric(Me.txtAbono.Text) Then
                    If CDec(Me.txtAbono.Text) > 0 Then
                        If CDec(Me.txtAbono.Text) < Me.Tope Then
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub frmMontoAbonoApartado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class