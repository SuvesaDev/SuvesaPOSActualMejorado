Public Class frmRegistrarAbonoApartado

    Public IdApartado As String = ""
    Public Id_Usuario As String = ""
    Public Nombre_Usuario As String = ""
    Public Num_Caja As String = ""
    Public BaseDatos As String = "SeePOS"

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.txtMontoAbono.Text <> "" And IsNumeric(Me.txtMontoAbono.Text) Then
            Dim frm As New frmIngresarFomasdePago
            frm.esSoloAbonoApartado = True
            frm.Numero_Caja = Me.Num_Caja
            frm.Id_Apartado = Me.IdApartado
            frm.Id_Usuario = Me.Id_Usuario
            frm.NombreUsuario = Me.Nombre_Usuario
            frm.TotalCobro = CDec(Me.txtMontoAbono.Text)
            frm.MontoAbonoApartado = frm.TotalCobro
            frm.MontoApartado = frm.TotalCobro
            frm.PuntodeVenta = Me.BaseDatos
            frm.TipoFactura = "APA"
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If       
    End Sub

    Private Function Calcular() As Decimal
        Dim SaldoAnterior As Decimal = CDec(Me.txtSaldoAnterior.Text)
        Dim Abono As Decimal = 0
        If Me.txtMontoAbono.Text <> "" And IsNumeric(Me.txtMontoAbono.Text) Then
            Abono = CDec(Me.txtMontoAbono.Text)
        End If
        Return SaldoAnterior - Abono
    End Function

    Private Sub frmRegistrarAbonoApartado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtSaldoAnterior.Text = Format(CDec(Me.txtSaldoAnterior.Text), "N2")
    End Sub

    Private Sub txtMontoAbono_TextChanged(sender As Object, e As EventArgs) Handles txtMontoAbono.TextChanged
        Me.txtSaldoActual.Text = Me.Calcular.ToString("N2")
    End Sub

End Class