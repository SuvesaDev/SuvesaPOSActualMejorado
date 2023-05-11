Imports System.Data
Public Class frmIngresarMontoPago

    Public esTarjeta As Boolean

    Private Function GetNumeroFactura(_Terminal As String) As String
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select ISNULL(max(Factura),0) + 1 as Factura from Log Where IdTerminal = '" & _Terminal & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("Factura")
        Else
            Return 0
        End If
    End Function

    Private Function PasaDigitos() As Boolean
        Dim contador As Integer = 0
        For Each c As Char In Me.txtMonto.Text
            If c = "." Then
                contador = 0
            Else
                contador += 1
            End If
        Next
        If contador <> 2 Then
            MsgBox("Solo se permiten 2 decimales", MsgBoxStyle.Exclamation, "Numero de digitos incorrectos")
            Return False
        End If
        Return True
    End Function

    Private Sub Aceptar()
        If Me.txtMonto.Text <> "" Then
            If IsNumeric(Me.txtMonto.Text) Then
                If CDec(Me.txtMonto.Text) > 0 Then
                    If esTarjeta = True Then
                        If Me.PasaDigitos = True Then
                            '***********************************************************************************
                            Dim cls As New Credomatic.Operaciones.Operaciones
                            Dim respuesta As Credomatic.Operaciones.Respuesta
                            Dim Factura = Me.GetNumeroFactura(cls.IdTerminal)
                            respuesta = cls.Venta(Factura, CDec(Me.txtMonto.Text).ToString("N2"))

                            If respuesta.Codigo = "00" Then
                                Me.DialogResult = Windows.Forms.DialogResult.OK
                            Else

                            End If
                            '***********************************************************************************
                        End If
                    Else
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.Requerido = True Then
            If Me.txtNumDocumento.Text = "" Then
                MsgBox("Debe ingresar el numero del documento", MsgBoxStyle.Exclamation, Text)
                Me.txtNumDocumento.Focus()
                Exit Sub
            End If
        End If
        Me.Aceptar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtMonto_Enter(sender As Object, e As EventArgs) Handles txtMonto.Enter
        Me.MontoSelecionado = True
    End Sub

    Private Sub txtNumDocumento_Enter(sender As Object, e As EventArgs) Handles txtNumDocumento.Enter
        Me.MontoSelecionado = False
    End Sub

    Private Sub txtMonto_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtMonto.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            Me.Aceptar()
        End If
    End Sub

    Private MontoSelecionado As Boolean = True
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click, btn0.Click
        If Me.MontoSelecionado = True Then
            Me.txtMonto.Text += sender.text.ToString
        End If

        If Me.MontoSelecionado = False Then
            Me.txtNumDocumento.Text += sender.text.ToString
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Me.txtMonto.Text = ""
    End Sub

    Public Tipo As String = "EFE"
    Public Requerido As Boolean = False
    Private Sub frmIngresarMontoPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Me.Tipo
            Case "TRA"
                Me.lblTitulo.Text = "Numero Transferencia"
                Me.Requerido = True
            Case "CHE"
                Me.lblTitulo.Text = "Numero Cheque"
                Me.Requerido = True
            Case Else
                Me.Requerido = False
                Me.SplitContainer1.Panel1Collapsed = True
                Me.SplitContainer1.Height = 283
                Me.Height = 390
                Me.CenterToScreen()
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.txtNumDocumento.Text = ""
    End Sub

End Class