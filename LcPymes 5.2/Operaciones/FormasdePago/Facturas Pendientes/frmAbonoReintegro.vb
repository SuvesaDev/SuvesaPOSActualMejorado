Public Class frmAbonoReintegro

    Public Id_Usuario As String = ""
    Public NombreUsuario As String = ""
    Public Numero_Caja As String
    Public IdFactura As Long = 0

    Private Sub btnAbonar_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.txtMonto.Text <> "" Then
            If IsNumeric(Me.txtMonto.Text) = True Then
                If CDec(Me.txtMonto.Text) > 0 Then

                    Dim frm As New frmIngresarFomasdePago
                    frm.btnPendientes.Enabled = False
                    frm.EsAbono = True
                    frm.SoloCobrar = False
                    frm.FechaAbono = Me.dtpFecha.Value
                    frm.MontoAbono = CDec(Me.txtMonto.Text)
                    frm.PuntodeVenta = ""
                    frm.Id_PreVenta = Me.IdFactura
                    frm.IdFacturaAbono = Me.IdFactura
                    frm.TipoFactura = "ABR"
                    frm.Id_Usuario = Me.Id_Usuario
                    frm.NombreUsuario = Me.NombreUsuario
                    frm.Numero_Caja = Me.Numero_Caja
                    frm.TotalCobro = CDec(Me.txtMonto.Text)
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                    If frm.RegistroTodo = True Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click, btn0.Click
        Me.txtMonto.Text += sender.text.ToString
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Me.txtMonto.Text = ""
    End Sub
End Class