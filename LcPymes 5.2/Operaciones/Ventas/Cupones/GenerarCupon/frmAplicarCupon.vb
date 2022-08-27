Imports System.Data
Public Class frmAplicarCupon

    Public Descuento As Decimal = 0
    Public Codigo As Long = 0

    Private Sub ObtenerInfoCupon(_Codigo As String)
        Try
            Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select c.*, cd.Id_Factura from Cupon c inner join CuponDetalle cd on c.idcupon = cd.idcupon where Codigo = " & _Codigo, dt, CadenaConexionSeePOS)
        Me.lblInfoCupon.Text = ""
        If dt.Rows.Count > 0 Then
            If dt.Rows(0).Item("Anulado") = False Then

                Me.Descuento = dt.Rows(0).Item("Descuento")
                Me.Codigo = Me.txtCodigoCupon.Text

                Me.lblInfoCupon.Text = "Cupon de descuento por un " & dt.Rows(0).Item("Descuento") & "%" & vbCrLf _
                    & "Valido Desde : " & CDate(dt.Rows(0).Item("Desde")).ToShortDateString & " Hasta " & CDate(dt.Rows(0).Item("Hasta")).ToShortDateString
                Me.btnAceptar.Enabled = True

                If CDate(Date.Now) > CDate(dt.Rows(0).Item("Hasta")) Then
                    Me.Descuento = 0
                    Me.Codigo = 0
                    Me.lblInfoCupon.Text += "" & vbCrLf _
                        & "" & vbCrLf _
                        & "" & vbCrLf _
                        & " El Cupon ya esta vencido."
                    Me.btnAceptar.Enabled = False
                End If

                If CDate(Date.Now) < CDate(dt.Rows(0).Item("Desde")) Then
                    Me.Descuento = 0
                    Me.Codigo = 0
                    Me.lblInfoCupon.Text += "" & vbCrLf _
                        & "" & vbCrLf _
                        & "" & vbCrLf _
                        & " El Cupon no es valido para esta fecha."
                    Me.btnAceptar.Enabled = False
                End If

                If dt.Rows(0).Item("Id_Factura") > 0 Then
                    Me.Descuento = 0
                    Me.Codigo = 0
                    Me.lblInfoCupon.Text += "" & vbCrLf _
                        & "" & vbCrLf _
                        & "" & vbCrLf _
                        & " El Cupon ya se uso en otra factura."
                    Me.btnAceptar.Enabled = False
                End If

            Else
                Me.Descuento = 0
                Me.Codigo = 0
                Me.lblInfoCupon.Text = "El Cupon esta Anulado no se puede realizar el descuento"
                Me.btnAceptar.Enabled = False
            End If
        Else
            Me.Descuento = 0
            Me.Codigo = 0
            Me.btnAceptar.Enabled = False
            MsgBox("No se encontro informacion del cupon", MsgBoxStyle.Exclamation, Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
        End Try
    End Sub

    Private Sub txtCodigoCupon_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigoCupon.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ObtenerInfoCupon(Me.txtCodigoCupon.Text)
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

End Class