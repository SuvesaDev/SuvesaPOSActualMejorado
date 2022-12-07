Imports System.Data
Imports System.Windows.Forms
Public Class frmAgregarDeposito
    Public IdArqueo As Integer = 0
    Private IndexDeposito As Integer = 0
    Public Id_Usuario As String = ""
    Public NombreUsuario As String = ""
    Public IdApertura As String
    Private TipoCambio As Decimal = 0

    Private Function getTipocambio() As Decimal
        Dim TipoCambio As Decimal = 0
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select ValorVenta from moneda where codmoneda = 2", dt, CadenaConexionSeguridad)
        If dt.Rows.Count > 0 Then
            TipoCambio = dt.Rows(0).Item("ValorVenta")
        End If
        Return TipoCambio
    End Function

    Private Sub CargarIdApertura()
        If Me.Id_Usuario = "" Then
            Dim frm As New frmIniciodeSeccion
            frm.Text = "Clave para ingresar deposito"
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Id_Usuario = frm.Id_Usuario
            Else
                Exit Sub
            End If
        End If

        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select u.Id_Usuario, u.Nombre, a.NApertura, a.Num_Caja from aperturacaja a inner join Usuarios u on a.Cedula = u.Id_Usuario where u.Id_Usuario = '" & Me.Id_Usuario & "' and (a.Estado = 'A' or a.Estado = 'B')", dt, CadenaConexionSeePOS)

        If dt.Rows.Count > 0 Then
            Me.Id_Usuario = dt.Rows(0).Item("Id_Usuario")
            Me.NombreUsuario = dt.Rows(0).Item("Nombre")
            Me.IdApertura = dt.Rows(0).Item("NApertura")

            Me.txtCajero.Text = Me.NombreUsuario
            Me.txtIdApertura.Text = Me.IdApertura
            Me.CargarDepositos(Me.IdArqueo, Me.IdApertura)
            Me.Panel1.Enabled = True
        Else
            MsgBox("El Usuario no tiene apertura de caja abierta.")
            Me.Panel1.Enabled = False
        End If
    End Sub

    Private Sub PoneColor()
        Try
            Dim Colon As Drawing.Color = Drawing.Color.Tomato
            Dim Dolar As Drawing.Color = Drawing.Color.SeaGreen

            Dim t As System.Collections.Generic.List(Of DataGridViewRow)

            t = (From x As DataGridViewRow In Me.viewDepositos.Rows Where x.Cells("cMonedaDeposito").Value.ToString = "COLON" Select x).ToList

            For Each r As DataGridViewRow In t
                r.DefaultCellStyle.BackColor = Colon
                r.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
                r.DefaultCellStyle.SelectionBackColor = Colon
                r.DefaultCellStyle.SelectionForeColor = Drawing.Color.White
            Next

            t = (From x As DataGridViewRow In Me.viewDepositos.Rows Where x.Cells("cMonedaDeposito").Value.ToString = "DOLAR" Select x).ToList

            For Each r As DataGridViewRow In t
                r.DefaultCellStyle.BackColor = Dolar
                r.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
                r.DefaultCellStyle.SelectionBackColor = Dolar
                r.DefaultCellStyle.SelectionForeColor = Drawing.Color.White
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CalcualarMontosDeposito()
        Dim depcolon As Decimal = (From x As DataGridViewRow In Me.viewDepositos.Rows Where x.Cells("cMonedadeposito").Value = "COLON" Select CDec(x.Cells("cMontoDeposito").Value)).Sum
        Dim depdolar As Decimal = (From x As DataGridViewRow In Me.viewDepositos.Rows Where x.Cells("cMonedadeposito").Value = "DOLAR" Select CDec(x.Cells("cMontoDeposito").Value)).Sum

        Me.txtDepositoColones.Text = depcolon.ToString("N2")
        Me.txtDepositoDolares.Text = depdolar.ToString("N2")
        Me.txtDepositoGeneral.Text = (CDec(depcolon + (depdolar * Me.TipoCambio))).ToString("N2")
    End Sub

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

    Private Sub CargarDepositos(_IdArqueo As String, _IdApertura As String)
        Me.viewDepositos.Rows.Clear()
        Me.IndexDeposito = 0
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Banco, Cuenta, Moneda, Numero, Monto, TipoMovimiento, Observaciones from ArqueoDeposito Where IdArqueo = " & _IdArqueo & " And IdApertura = " & Me.IdApertura, dt, CadenaConexionSeePOS)
        For Each r As DataRow In dt.Rows
            Me.AgregarDeposito(r.Item("Banco"), r.Item("Cuenta"), r.Item("Moneda"), r.Item("Numero"), r.Item("Monto"), r.Item("TipoMovimiento"), r.Item("Observaciones"))
        Next
    End Sub

    Private Sub GuardarDeposito()
        Dim nuevo As Boolean = IIf(Me.IdArqueo = 0, True, False)
        Dim trans As OBSoluciones.SQL.Transaccion
        trans = New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
        Try
            trans.Ejecutar("Delete from ArqueoDeposito where IdArqueo = " & Me.IdArqueo & " And IdApertura = " & Me.IdApertura, CommandType.Text)
            For Each f As DataGridViewRow In Me.viewDepositos.Rows
                trans.Ejecutar("insert into ArqueoDeposito(IdArqueo, IdApertura, Banco, Cuenta, Moneda, Numero, Monto, TipoMovimiento, Observaciones) values(" & Me.IdArqueo & ", " & Me.IdApertura & ", '" & f.Cells("cBanco").Value & "', '" & f.Cells("cCuenta").Value & "', '" & f.Cells("cMonedaDeposito").Value & "', '" & f.Cells("cNumero").Value & "', " & f.Cells("cMontoDeposito").Value & ", '" & f.Cells("cTipo").Value & "', '" & f.Cells("cObservaciones").Value & "')", CommandType.Text)
            Next
            trans.Commit()
        Catch ex As Exception
            trans.Rollback()
        End Try
    End Sub

    Private Sub AgregarDeposito(_Banco As String, _Cuenta As String, _Moneda As String, _Numero As String, _Monto As Decimal, _Tipo As String, _Observaciones As String)
        Me.viewDepositos.Rows.Add()
        Me.viewDepositos.Item("cBanco", Me.IndexDeposito).Value = _Banco
        Me.viewDepositos.Item("cCuenta", Me.IndexDeposito).Value = _Cuenta
        Me.viewDepositos.Item("cMonedaDeposito", Me.IndexDeposito).Value = _Moneda
        Me.viewDepositos.Item("cNumero", Me.IndexDeposito).Value = _Numero
        Me.viewDepositos.Item("cMontoDeposito", Me.IndexDeposito).Value = _Monto
        Me.viewDepositos.Item("cTipo", Me.IndexDeposito).Value = _Tipo
        Me.viewDepositos.Item("cObservaciones", Me.IndexDeposito).Value = _Observaciones
        Me.IndexDeposito += 1
        Me.CalcualarMontosDeposito()
        Me.txtNumeroDeposito.Text = ""
        Me.txtMontoDeposito.Text = ""
        Me.PoneColor()
    End Sub

    Private Function PasaValidacionMontos(_Moneda As String, _Monto As Decimal) As Boolean
        Select Case _Moneda
            Case "COLON"
                If _Monto < 500 Then
                    'envia advertencia, el monto podria ser en dolares
                    If MsgBox("Esta ingresando " & _Monto & " Colones" & vbCrLf _
                              & "Desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "El Monto pareciera ser en Dolares ") = MsgBoxResult.Yes Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return True
                End If
            Case "DOLAR"
                If _Monto > 1000 Then
                    'envia advertencia, el monto podria ser en colones
                    If MsgBox("Esta ingresando " & _Monto & " Dolares" & vbCrLf _
                              & "Desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "El Monto pareciera ser en Colones ") = MsgBoxResult.Yes Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return True
                End If
        End Select
    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Me.txtNumeroDeposito.Text <> "" And Me.txtMontoDeposito.Text <> "" Then
            If IsNumeric(Me.txtNumeroDeposito.Text) = True And IsNumeric(Me.txtMontoDeposito.Text) = True Then
                If CDec(Me.txtMontoDeposito.Text) > 0 Then
                    If Me.PasaValidacionMontos(Me.txtMoneda.Text, CDec(Me.txtMontoDeposito.Text)) = True Then

                        If Me.cboTipoDeposito.Text = "Otros" And Me.txtObservaciones.Text.Trim = "" Then
                            MsgBox("Debe ingresar una observacion.", MsgBoxStyle.Exclamation, Me.Text)
                            Me.txtObservaciones.Focus()
                            Exit Sub
                        End If

                        Me.AgregarDeposito(Me.cboBanco.Text, Me.cboCuenta.Text, Me.txtMoneda.Text, txtNumeroDeposito.Text, Me.txtMontoDeposito.Text, Me.cboTipoDeposito.Text, Me.txtObservaciones.Text)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cboBanco_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboBanco.SelectedValueChanged
        On Error Resume Next
        Me.CargarCuentas(Me.cboBanco.SelectedValue)
    End Sub

    Private Sub cboCuenta_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboCuenta.SelectedValueChanged
        On Error Resume Next
        Me.CargarMonedaCuenta(Me.cboCuenta.SelectedValue)
    End Sub

    Private Sub viewDepositos_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles viewDepositos.RowsRemoved
        Me.CalcualarMontosDeposito()
    End Sub

    Private Sub frmAgregarDeposito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cboTipoDeposito.SelectedIndex = 0
        Me.CargarBancos()
        Me.TipoCambio = Me.getTipocambio
        Me.CargarIdApertura()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.GuardarDeposito()
        Me.Close()
    End Sub

    Private Sub viewDepositos_KeyDown(sender As Object, e As KeyEventArgs) Handles viewDepositos.KeyDown
        If e.KeyCode = Keys.Back Then
            Me.viewDepositos.Rows.RemoveAt(Me.viewDepositos.CurrentRow.Index)
            Me.IndexDeposito -= 1
        End If
    End Sub


End Class