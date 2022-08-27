Imports System.Windows.Forms

Public Class frmEditarPrecioVenta_FacturaElectronica

    Public Base As Decimal = 0

    Private Function Utilidad(ByVal Costo As Double, ByVal Precio As Double) As Double
        Try
            Utilidad = Math.Round(((Precio / Costo) - 1) * 100, 2)
            Return Utilidad
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Function

    Private Sub TxtPrecioVenta_A_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrecioVenta_A.KeyPress, TxtPrecioVenta_B.KeyPress, TxtPrecioVenta_C.KeyPress, TxtPrecioVenta_D.KeyPress, TxtPrecioVenta_IV_A.KeyPress, TxtPrecioVenta_IV_B.KeyPress, TxtPrecioVenta_IV_C.KeyPress, TxtPrecioVenta_IV_D.KeyPress, TxtUtilidad_A.KeyPress, TxtUtilidad_B.KeyPress, TxtUtilidad_C.KeyPress, TxtUtilidad_D.KeyPress
        Dim TempFleOtros As Double
        Try

            TempFleOtros = (CDbl(TxtFleteEquivalente.Text) + CDbl(TxtOtrosCargosEquivalente.Text))          'If cargando = True Then Exit Sub
            If Keys.Enter = Asc(e.KeyChar) Then
                Select Case sender.Name
                    Case TxtUtilidad_A.Name
                        'TxtPrecioVenta_A.Text = (TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100)) * (TxtUtilidad_A.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + (TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100))
                        TxtPrecioVenta_A.Text = ((TxtBaseEquivalente.Text) * (TxtUtilidad_A.Text / 100)) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + (TxtBaseEquivalente.Text)
                        TxtPrecioVenta_IV_A.Text = (TxtPrecioVenta_A.Text - TempFleOtros) * (TxtImpuesto_Porcentaje.Text / 100) + TxtPrecioVenta_A.Text
                        SendKeys.Send("{TAB}")
                    Case TxtUtilidad_B.Name
                        'TxtPrecioVenta_B.Text = (TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100)) * (TxtUtilidad_B.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + (TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100))
                        TxtPrecioVenta_B.Text = ((TxtBaseEquivalente.Text) * (TxtUtilidad_B.Text / 100)) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + (TxtBaseEquivalente.Text)
                        TxtPrecioVenta_IV_B.Text = (TxtPrecioVenta_B.Text - TempFleOtros) * (TxtImpuesto_Porcentaje.Text / 100) + TxtPrecioVenta_B.Text
                        SendKeys.Send("{TAB}")
                    Case TxtUtilidad_C.Name
                        'TxtPrecioVenta_C.Text = (TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100)) * (TxtUtilidad_C.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + (TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100))
                        TxtPrecioVenta_C.Text = ((TxtBaseEquivalente.Text) * (TxtUtilidad_C.Text / 100)) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + (TxtBaseEquivalente.Text)
                        TxtPrecioVenta_IV_C.Text = (TxtPrecioVenta_C.Text - TempFleOtros) * (TxtImpuesto_Porcentaje.Text / 100) + TxtPrecioVenta_C.Text
                        SendKeys.Send("{TAB}")
                    Case TxtUtilidad_D.Name
                        'TxtPrecioVenta_D.Text = (TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100)) * (TxtUtilidad_D.Text / 100) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + (TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100))
                        TxtPrecioVenta_D.Text = ((TxtBaseEquivalente.Text) * (TxtUtilidad_D.Text / 100)) + (TxtFleteEquivalente.Text) + (TxtOtrosCargosEquivalente.Text) + (TxtBaseEquivalente.Text)
                        TxtPrecioVenta_IV_D.Text = (TxtPrecioVenta_D.Text - TempFleOtros) * (TxtImpuesto_Porcentaje.Text / 100) + TxtPrecioVenta_D.Text
                        SendKeys.Send("{TAB}")

                        'calculo de de utilidad por el precio A y calculo del precio com I.V.
                    Case TxtPrecioVenta_A.Name
                        'TxtUtilidad_A.Text = Utilidad((TxtBaseEquivalente.Text - (TxtBaseEquivalente.Text * Descuento_Porcentaje_Detalle.Text / 100)), (TxtPrecioVenta_A.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        TxtUtilidad_A.Text = Utilidad((TxtBaseEquivalente.Text), (TxtPrecioVenta_A.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        TxtPrecioVenta_IV_A.Text = (TxtPrecioVenta_A.Text - TempFleOtros) * (TxtImpuesto_Porcentaje.Text / 100) + (TxtPrecioVenta_A.Text)
                        SendKeys.Send("{TAB}")
                    Case TxtPrecioVenta_B.Name
                        TxtUtilidad_B.Text = Utilidad((TxtBaseEquivalente.Text), (TxtPrecioVenta_B.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        TxtPrecioVenta_IV_B.Text = (TxtPrecioVenta_B.Text - TempFleOtros) * (TxtImpuesto_Porcentaje.Text / 100) + TxtPrecioVenta_B.Text
                        SendKeys.Send("{TAB}")
                    Case TxtPrecioVenta_C.Name
                        TxtUtilidad_C.Text = Utilidad((TxtBaseEquivalente.Text), (TxtPrecioVenta_C.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        TxtPrecioVenta_IV_C.Text = (TxtPrecioVenta_C.Text - TempFleOtros) * (TxtImpuesto_Porcentaje.Text / 100) + TxtPrecioVenta_C.Text
                        SendKeys.Send("{TAB}")
                    Case TxtPrecioVenta_D.Name
                        TxtUtilidad_D.Text = Utilidad((TxtBaseEquivalente.Text), (TxtPrecioVenta_D.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        TxtPrecioVenta_IV_D.Text = (TxtPrecioVenta_D.Text - TempFleOtros) * (TxtImpuesto_Porcentaje.Text / 100) + TxtPrecioVenta_D.Text
                        SendKeys.Send("{TAB}")
                        'CALCULO DE PRECIO DE VENTA Y RECALCULAR LA  UTILIDAD CON BASE A LOS NUEVOS PRECIOS 
                    Case TxtPrecioVenta_IV_A.Name
                        TxtPrecioVenta_A.Text = (TxtPrecioVenta_IV_A.Text - TempFleOtros) / (1 + (TxtImpuesto_Porcentaje.Text / 100)) + TempFleOtros
                        TxtUtilidad_A.Text = Utilidad((TxtBaseEquivalente.Text), (TxtPrecioVenta_A.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        SendKeys.Send("{TAB}")
                    Case TxtPrecioVenta_IV_B.Name
                        TxtPrecioVenta_B.Text = (TxtPrecioVenta_IV_B.Text - TempFleOtros) / (1 + (TxtImpuesto_Porcentaje.Text / 100)) + TempFleOtros
                        TxtUtilidad_B.Text = Utilidad((TxtBaseEquivalente.Text), (TxtPrecioVenta_B.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        SendKeys.Send("{TAB}")
                    Case TxtPrecioVenta_IV_C.Name
                        TxtPrecioVenta_C.Text = (TxtPrecioVenta_IV_C.Text - TempFleOtros) / (1 + (TxtImpuesto_Porcentaje.Text / 100)) + TempFleOtros
                        TxtUtilidad_C.Text = Utilidad((TxtBaseEquivalente.Text), (TxtPrecioVenta_C.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        SendKeys.Send("{TAB}")
                    Case TxtPrecioVenta_IV_D.Name
                        TxtPrecioVenta_D.Text = (TxtPrecioVenta_IV_D.Text - TempFleOtros) / (1 + (TxtImpuesto_Porcentaje.Text / 100)) + TempFleOtros
                        TxtUtilidad_D.Text = Utilidad((TxtBaseEquivalente.Text), (TxtPrecioVenta_D.Text - TxtFleteEquivalente.Text - TxtOtrosCargosEquivalente.Text))
                        SendKeys.Send("{TAB}")
                        'calculo de precios por la utilidad
                        'Case TxtBase.Name
                        '    TxtCosto.Text = (CDbl(TxtBase.Text) + CDbl(TxtFlete.Text) + CDbl(TxtOtros.Text))
                        '    CalcularEquivalenciaMoneda()

                        'Case TxtFlete.Name
                        '    TxtCosto.Text = (CDbl(TxtBase.Text) + CDbl(TxtFlete.Text) + CDbl(TxtOtros.Text))
                        '    CalcularEquivalenciaMoneda()

                        'Case TxtOtros.Name
                        '    TxtCosto.Text = (CDbl(TxtBase.Text) + CDbl(TxtFlete.Text) + CDbl(TxtOtros.Text))
                        '    CalcularEquivalenciaMoneda()


                End Select

                'If Salto Then SendKeys.Send("{TAB}")
            End If

            If Not IsNumeric(sender.text & e.KeyChar) Then
                If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                    e.Handled = True  ' esto invalida la tecla pulsada
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje")
        End Try
    End Sub

    Private Sub CBMonedaVenta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBMonedaVenta.SelectedIndexChanged
        If CBMonedaVenta.SelectedIndex > -1 Then DolarVenta()
    End Sub

    Private Sub DolarVenta()
        Try

            Dim Link As New Conexion
            TextBoxValorMonedaEnVenta.Clear()
            TextBoxValorMonedaEnVenta.Text = CDbl(Link.SQLExeScalar("Select isnull(max(ValorCompra),0) from moneda where codmoneda = " & CBMonedaVenta.SelectedValue))
            Link.DesConectar(Link.sQlconexion)
            CalcularEquivalenciaMoneda()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje")
        End Try
    End Sub

    Private Sub CalcularEquivalenciaMoneda()
        'If cargando = True Then Exit Sub
        Try
            TxtBaseEquivalente.Text = Math.Round(Me.Base * (TextBoxValorMonedaEnCosto.Text / TextBoxValorMonedaEnVenta.Text), 2)
            Me.Base = Me.TxtBaseEquivalente.Text
            TxtFleteEquivalente.Text = 0
            TxtOtrosCargosEquivalente.Text = 0
            'TxtCostoEquivalente.Text = TxtCosto.Text * (TextBoxValorMonedaEnCosto.Text / TextBoxValorMonedaEnVenta.Text)
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub CargarMoneda()
        Try
            SqlConnection.ConnectionString = CadenaConexionSeePOS
            AdapterMoneda.Fill(DataSetCompras, "Moneda")
            Me.CBMonedaVenta.DataSource = Me.DataSetCompras
            Me.CBMonedaVenta.DisplayMember = "Moneda.MonedaNombre"
            Me.CBMonedaVenta.ValueMember = "Moneda.CodMoneda"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
        End Try        
    End Sub

    Private Sub frmEditarPrecioVenta_FacturaElectronica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarMoneda()
        Me.DolarVenta()

        Me.TxtPrecioVenta_A_KeyPress(Me.TxtPrecioVenta_A, New KeyPressEventArgs(Convert.ToChar(Keys.Enter)))
        Me.TxtPrecioVenta_A_KeyPress(Me.TxtPrecioVenta_B, New KeyPressEventArgs(Convert.ToChar(Keys.Enter)))
        Me.TxtPrecioVenta_A_KeyPress(Me.TxtPrecioVenta_C, New KeyPressEventArgs(Convert.ToChar(Keys.Enter)))
        SendKeys.Send("{TAB}")

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub ButtonAgregarDetalle_Click(sender As Object, e As EventArgs) Handles ButtonAgregarDetalle.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

End Class