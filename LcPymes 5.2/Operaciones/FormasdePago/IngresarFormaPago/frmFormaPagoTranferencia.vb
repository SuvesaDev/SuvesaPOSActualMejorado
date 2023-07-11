Imports System.Data
Public Class frmFormaPagoTranferencia

    Private Sub CargarBancos()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Codigo_banco, Descripcion from bancos.dbo.bancos", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.cboBanco.DataSource = dt
            Me.cboBanco.DisplayMember = "Descripcion"
            Me.cboBanco.ValueMember = "Codigo_Banco"
        End If
    End Sub

    Private Sub CargarCuentas(_IdBanco As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Id_CuentaBancaria, Cuenta from bancos.dbo.Cuentas_bancarias where Codigo_Banco = " & _IdBanco, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.cboCuenta.DataSource = dt
            Me.cboCuenta.DisplayMember = "Cuenta"
            Me.cboCuenta.ValueMember = "Id_CuentaBancaria"
        End If
    End Sub

    Private Sub CargarMonedaCuenta(_IdCuenta As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select CodMoneda, MonedaNombre from moneda where CodMoneda In(select Cod_Moneda from bancos.dbo.Cuentas_bancarias where Id_CuentaBancaria = " & _IdCuenta & ")", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.txtMoneda.Text = dt.Rows(0).Item("MonedaNombre")
        End If
    End Sub

    Private Function Duplicado() As Boolean
        Dim dt As New DataTable
        Dim Numero As Integer = 0
        If IsNumeric(Me.txtNumeroDeposito.Text) = True Then
            Numero = CDec(Me.txtNumeroDeposito.Text)
        Else
            Numero = 0
        End If
        If Numero > 0 Then
            If Me.txtNumeroDeposito.Text.Length = "6" Then
                cFunciones.Llenar_Tabla_Generico("SELECT odp.Documento, odp.TipoDocumento, odp.MontoPago, odp.Nombre, odp.Fecha FROM OpcionesDePago odp WHERE odp.NumeroDocumento = '" & Me.txtNumeroDeposito.Text & "' Order By odp.Fecha Desc", dt, CadenaConexionSeePOS)
                If dt.Rows.Count > 0 Then
                    MsgBox("El numero del documento ya esta registrado" & vbCrLf _
                           & "Fecha :" & dt.Rows(0).Item("Fecha") & vbCrLf _
                           & "Documento :" & dt.Rows(0).Item("Documento") & vbCrLf _
                           & "Tipo Documento: " & dt.Rows(0).Item("TipoDocumento") & vbCrLf _
                           & "Monto: " & dt.Rows(0).Item("MontoPago") & vbCrLf _
                           & "Cajera: " & dt.Rows(0).Item("Nombre"), MsgBoxStyle.Exclamation, Text)

                    If MsgBox("Desea Continuar", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + vbQuestion, Me.Text) = MsgBoxResult.No Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If
            Else
                MsgBox("El numero del documento debe ser de 6 digitos", MsgBoxStyle.Exclamation, Text)
                Return True
            End If
        Else
            MsgBox("Numero del documento invalido", MsgBoxStyle.Exclamation, Text)
            Return True
        End If        
    End Function

    Private Sub cboBanco_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboBanco.SelectedValueChanged
        On Error Resume Next
        Me.CargarCuentas(Me.cboBanco.SelectedValue)
    End Sub

    Private Sub cboCuenta_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboCuenta.SelectedValueChanged
        On Error Resume Next
        Me.CargarMonedaCuenta(Me.cboCuenta.SelectedValue)
    End Sub

    Private Sub frmFormaPagoTranferencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarBancos()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Duplicado() = True Then
            Exit Sub
        End If
        If Me.txtNumeroDeposito.Text <> "" Then
            If Me.txtMontoDeposito.Text <> "" Then
                If IsNumeric(Me.txtMontoDeposito.Text) = True Then
                    If CDec(Me.txtMontoDeposito.Text) > 0 Then
                        If Me.cboTipoMovimiento.Text <> "" Then
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                        Else
                            MsgBox("Seleccion un tipo de movimiento.", MsgBoxStyle.Exclamation, Text)
                            Me.cboTipoMovimiento.Focus()
                        End If
                    Else
                        MsgBox("El valor del Monto de la transferencia debe ser un valor numerico mayor a cero.", MsgBoxStyle.Exclamation, Text)
                    End If
                Else
                    MsgBox("El valor del Monto de la transferencia debe ser un valor numerico mayor a cero.", MsgBoxStyle.Exclamation, Text)
                End If
            Else
                MsgBox("El valor del Monto de la transferencia debe ser un valor numerico mayor a cero.", MsgBoxStyle.Exclamation, Text)
            End If
        Else
            MsgBox("Debe de ingresar el numero de la transferencia.", MsgBoxStyle.Exclamation, Text)
        End If
    End Sub

End Class