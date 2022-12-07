Public Class frmDescuentoTeleton

    Public Property CantidadDevolver As Decimal
        Get
            Return Me.txtCantidad.Text
        End Get
        Set(value As Decimal)
            Me.txtCantidad.Text = Math.Round(value, 2)
        End Set
    End Property

    Public Property CantidadMaxima As Decimal
        Get
            Return Me.txtTotalTeletones.Text
        End Get
        Set(value As Decimal)
            Me.txtTotalTeletones.Text = Math.Round(value, 2)
        End Set
    End Property

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.txtCantidad.Text <> "" Then
            If IsNumeric(Me.txtCantidad.Text) Then
                If CDec(Me.txtCantidad.Text) > 0 Then
                    If CDec(Me.txtCantidad.Text) > CDec(Me.txtTotalTeletones.Text) Then
                        MsgBox("No puedes devolver mas de " & Me.CantidadMaxima & " Teletones.", MsgBoxStyle.Exclamation, "No se puede procesar la operacion")
                        Exit Sub
                    End If
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

End Class