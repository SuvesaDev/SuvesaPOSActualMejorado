Public Class frmGenerarApartado
    Public PuntoVenta As String = ""
    Public Id_Preventa As Long = 0
    Public Tipo As String = ""
    Public Id_Usuario As String = ""
    Public NombreUsuario As String = ""
    Public Numero_Caja As Integer = 0
    Public MontoTotalApartado As Decimal

    Private Function ObtenerSugerido() As Decimal
        Dim sugerido As Decimal = Me.MontoTotalApartado * (20 / 100)
        Return sugerido
    End Function

    Private Sub frmGenerarApartado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dtpVence.Value = Date.Now.AddMonths(2)
        Me.txtAbonoSugerido.Text = Me.ObtenerSugerido.ToString("N2")
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.dtpVence.Value > Date.Now Then
            If Me.txtMontoAbono.Text <> "" And IsNumeric(Me.txtMontoAbono.Text) Then

            Else
                MsgBox("El Monto del Abono debe ser un valor numerico mayor a cero", MsgBoxStyle.Exclamation, Text)
                Me.txtMontoAbono.Focus()
                Exit Sub
            End If
        Else
            MsgBox("La fecha debe ser mayor a hoy", MsgBoxStyle.Exclamation, Text)
            Me.dtpVence.Focus()
            Exit Sub
        End If

        Dim frm As New frmIngresarFomasdePago
        frm.EsApartado = True
        frm.FechaVence = Me.dtpVence.Value
        frm.PuntodeVenta = Me.PuntoVenta
        frm.Id_PreVenta = Me.Id_PreVenta
        frm.TipoFactura = Me.Tipo
        frm.Id_Usuario = Me.Id_Usuario
        frm.NombreUsuario = Me.NombreUsuario
        frm.Numero_Caja = Me.Numero_Caja
        frm.TotalCobro = CDec(Me.txtMontoAbono.Text)
        frm.MontoApartado = frm.TotalCobro
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

End Class