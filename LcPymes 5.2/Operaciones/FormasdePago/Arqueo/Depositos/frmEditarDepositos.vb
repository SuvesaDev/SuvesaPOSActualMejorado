Imports System.Data
Imports System.Windows.Forms
Public Class frmEditarDepositos
    Public IdArqueo As String = ""
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

        Dim cFunciones As New cFunciones
        Me.IdApertura = cFunciones.Buscar_X_Descripcion_Fecha("SELECT CAST(NApertura AS Varchar) as Apertura,Nombre,Fecha FROM aperturacaja where estado =  '" & "M" & "'", "Nombre", "Fecha", "Aperturas de caja sin cerrar...")

        If IdApertura <> "" And IdApertura <> Nothing Then
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select u.Id_Usuario, u.Nombre, a.NApertura, a.Num_Caja, ar.Id as IdArqueo from aperturacaja a inner join Usuarios u on a.Cedula = u.Id_Usuario inner join ArqueoCajas ar on a.NApertura = ar.IdApertura and ar.Anulado = 0 where a.NApertura = " & IdApertura, dt, CadenaConexionSeePOS)

            If dt.Rows.Count > 0 Then
                Me.Id_Usuario = dt.Rows(0).Item("Id_Usuario")
                Me.NombreUsuario = dt.Rows(0).Item("Nombre")
                Me.IdApertura = dt.Rows(0).Item("NApertura")
                Me.IdArqueo = dt.Rows(0).Item("IdArqueo")

                Me.txtCajero.Text = Me.NombreUsuario
                Me.txtIdApertura.Text = Me.IdApertura
                Me.CargarDepositos(Me.IdArqueo, Me.IdApertura)
                Me.Panel1.Enabled = True
            Else
                MsgBox("El Usuario no tiene apertura de caja abierta.")
                Me.Panel1.Enabled = False
            End If
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
        Dim depcolon As Decimal = (From x As DataGridViewRow In Me.viewDepositos.Rows
                                   Where x.Cells("cMonedadeposito").Value = "COLON" And x.Cells("cAnulado").Value = False
                                   Select CDec(x.Cells("cMontoDeposito").Value)).Sum

        Dim depdolar As Decimal = (From x As DataGridViewRow In Me.viewDepositos.Rows
                                   Where x.Cells("cMonedadeposito").Value = "DOLAR" And x.Cells("cAnulado").Value = False
                                   Select CDec(x.Cells("cMontoDeposito").Value)).Sum

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

    'Private Sub CargarDepositos(_IdArqueo As String, _IdApertura As String)
    '    Me.viewDepositos.Rows.Clear()
    '    Me.IndexDeposito = 0
    '    Dim dt As New DataTable
    '    cFunciones.Llenar_Tabla_Generico("select Banco, Cuenta, Moneda, Numero, Monto from ArqueoDeposito Where IdArqueo = " & _IdArqueo & " And IdApertura = " & Me.IdApertura, dt, CadenaConexionSeePOS)
    '    For Each r As DataRow In dt.Rows
    '        Me.AgregarDeposito(r.Item("Banco"), r.Item("Cuenta"), r.Item("Moneda"), r.Item("Numero"), r.Item("Monto"))
    '    Next
    'End Sub

    'Private Sub GuardarDeposito()
    '    Dim nuevo As Boolean = IIf(Me.IdArqueo = 0, True, False)
    '    Dim trans As OBSoluciones.SQL.Transaccion
    '    trans = New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
    '    Try
    '        trans.Ejecutar("Delete from ArqueoDeposito where IdArqueo = " & Me.IdArqueo & " And IdApertura = " & Me.IdApertura, CommandType.Text)
    '        For Each f As DataGridViewRow In Me.viewDepositos.Rows
    '            trans.Ejecutar("insert into ArqueoDeposito(IdArqueo, IdApertura, Banco, Cuenta, Moneda, Numero, Monto) values(" & Me.IdArqueo & ", " & Me.IdApertura & ", '" & f.Cells("cBanco").Value & "', '" & f.Cells("cCuenta").Value & "', '" & f.Cells("cMonedaDeposito").Value & "', '" & f.Cells("cNumero").Value & "', " & f.Cells("cMontoDeposito").Value & ")", CommandType.Text)
    '        Next
    '        trans.Ejecutar("Update ArqueoCajas Set DepositoCol = " & CDec(Me.txtDepositoColones.Text) & ", DepositoDol = " & CDec(Me.txtDepositoDolares.Text) & " where id = " & Me.IdArqueo, CommandType.Text)
    '        trans.Ejecutar("update ArqueoCajas set Total = EfectivoColones + (EfectivoDolares * TipoCambioD) + TarjetaColones + (TarjetaDolares *  TipoCambioD) + DepositoCol + (DepositoDol * TipoCambioD) where id = " & Me.IdArqueo, CommandType.Text)
    '        trans.Commit()
    '    Catch ex As Exception
    '        trans.Rollback()
    '    End Try
    'End Sub

    'Private Sub AgregarDeposito(_Banco As String, _Cuenta As String, _Moneda As String, _Numero As String, _Monto As Decimal)
    '    Me.viewDepositos.Rows.Add()
    '    Me.viewDepositos.Item("cBanco", Me.IndexDeposito).Value = _Banco
    '    Me.viewDepositos.Item("cCuenta", Me.IndexDeposito).Value = _Cuenta
    '    Me.viewDepositos.Item("cMonedaDeposito", Me.IndexDeposito).Value = _Moneda
    '    Me.viewDepositos.Item("cNumero", Me.IndexDeposito).Value = _Numero
    '    Me.viewDepositos.Item("cMontoDeposito", Me.IndexDeposito).Value = _Monto
    '    Me.IndexDeposito += 1
    '    Me.CalcualarMontosDeposito()
    '    Me.txtNumeroDeposito.Text = ""
    '    Me.txtMontoDeposito.Text = ""
    '    Me.PoneColor()
    'End Sub

    Private Sub CargarDepositos(_IdArqueo As String, _IdApertura As String)
        Me.viewDepositos.Rows.Clear()
        Me.IndexDeposito = 0
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Id, Banco, Cuenta, Moneda, Numero, Monto, TipoMovimiento, Observaciones from ArqueoDeposito Where Anulado = 0 and IdArqueo = " & _IdArqueo & " And IdApertura = " & Me.IdApertura, dt, CadenaConexionSeePOS)
        For Each r As DataRow In dt.Rows
            Me.AgregarDeposito(r.Item("Id"), r.Item("Banco"), r.Item("Cuenta"), r.Item("Moneda"), r.Item("Numero"), r.Item("Monto"), r.Item("TipoMovimiento"), r.Item("Observaciones"))
        Next
    End Sub

    Private Sub GuardarDeposito()
        Dim nuevo As Boolean = IIf(Me.IdArqueo = 0, True, False)
        Dim trans As OBSoluciones.SQL.Transaccion
        trans = New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
        Try
            'trans.Ejecutar("Delete from ArqueoDeposito where IdArqueo = " & Me.IdArqueo & " And IdApertura = " & Me.IdApertura, CommandType.Text)
            For Each f As DataGridViewRow In Me.viewDepositos.Rows
                If f.Cells("cId").Value = "0" And f.Cells("cAnulado").Value = False Then
                    trans.Ejecutar("insert into ArqueoDeposito(IdArqueo, IdApertura, Banco, Cuenta, Moneda, Numero, Monto, TipoMovimiento, Observaciones) values(" & Me.IdArqueo & ", " & Me.IdApertura & ", '" & f.Cells("cBanco").Value & "', '" & f.Cells("cCuenta").Value & "', '" & f.Cells("cMonedaDeposito").Value & "', '" & f.Cells("cNumero").Value & "', " & f.Cells("cMontoDeposito").Value & ", '" & f.Cells("cTipo").Value & "', '" & f.Cells("cObservaciones").Value & "')", CommandType.Text)
                End If

                If f.Cells("cAnulado").Value = True And CDec(f.Cells("cId").Value) > 0 Then
                    trans.Ejecutar("Update ArqueoDeposito set Anulado = 1, IdUsuarioAnulo = '" & f.Cells("cIdUsuarioAnulacion").Value & "', MotivoAnulacion = '" & f.Cells("cMotivoAnulacion").Value & "', FechaAnulacion = getdate() where Id = " & f.Cells("cId").Value & ";", CommandType.Text)
                End If
            Next
            trans.Ejecutar("Update ArqueoCajas Set DepositoCol = " & CDec(Me.txtDepositoColones.Text) & ", DepositoDol = " & CDec(Me.txtDepositoDolares.Text) & " where id = " & Me.IdArqueo, CommandType.Text)
            trans.Ejecutar("update ArqueoCajas set Total = EfectivoColones + (EfectivoDolares * TipoCambioD) + TarjetaColones + (TarjetaDolares *  TipoCambioD) + DepositoCol + (DepositoDol * TipoCambioD) where id = " & Me.IdArqueo, CommandType.Text)
            trans.Commit()
        Catch ex As Exception
            trans.Rollback()
        End Try
    End Sub


    Private Sub AgregarDeposito(_Id As Integer, _Banco As String, _Cuenta As String, _Moneda As String, _Numero As String, _Monto As Decimal, _Tipo As String, _Observaciones As String)
        Me.viewDepositos.Rows.Add()
        Me.viewDepositos.Item("cId", Me.IndexDeposito).Value = _Id
        Me.viewDepositos.Item("cBanco", Me.IndexDeposito).Value = _Banco
        Me.viewDepositos.Item("cCuenta", Me.IndexDeposito).Value = _Cuenta
        Me.viewDepositos.Item("cMonedaDeposito", Me.IndexDeposito).Value = _Moneda
        Me.viewDepositos.Item("cNumero", Me.IndexDeposito).Value = _Numero
        Me.viewDepositos.Item("cMontoDeposito", Me.IndexDeposito).Value = _Monto
        Me.viewDepositos.Item("cTipo", Me.IndexDeposito).Value = _Tipo
        Me.viewDepositos.Item("cObservaciones", Me.IndexDeposito).Value = _Observaciones

        Me.viewDepositos.Item("cAnulado", Me.IndexDeposito).Value = False
        Me.viewDepositos.Item("cIdUsuarioAnulacion", Me.IndexDeposito).Value = ""
        Me.viewDepositos.Item("cMotivoAnulacion", Me.IndexDeposito).Value = ""

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

                        If Me.cboTipo.Text = "Otros" And Me.txtObservaciones.Text.Trim = "" Then
                            MsgBox("Debe ingresar una observacion.", MsgBoxStyle.Exclamation, Me.Text)
                            Me.txtObservaciones.Focus()
                            Exit Sub
                        End If

                        Me.AgregarDeposito(0, Me.cboBanco.Text, Me.cboCuenta.Text, Me.txtMoneda.Text, txtNumeroDeposito.Text, Me.txtMontoDeposito.Text, Me.cboTipo.Text, Me.txtObservaciones.Text)
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
        Me.cboTipo.SelectedIndex = 0
        Me.CargarBancos()
        Me.TipoCambio = Me.getTipocambio        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.GuardarDeposito()
        Me.Close()
    End Sub

    Private Sub viewDepositos_KeyDown(sender As Object, e As KeyEventArgs) Handles viewDepositos.KeyDown
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
            'Me.viewDepositos.Rows.RemoveAt(Me.viewDepositos.CurrentRow.Index)
            'Me.IndexDeposito -= 1
            If MsgBox("Desea quitar el deposito", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion") = MsgBoxResult.No Then
                Exit Sub
            End If
            If CDec(Me.viewDepositos.Item("cId", Me.viewDepositos.CurrentRow.Index).Value) > 0 Then
                Dim frm As New frmMorivoAnulacionDeposito
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.viewDepositos.Item("cAnulado", Me.viewDepositos.CurrentRow.Index).Value = True
                    Me.viewDepositos.Item("cIdUsuarioAnulacion", Me.viewDepositos.CurrentRow.Index).Value = frm.txtUsuario.Text
                    Me.viewDepositos.Item("cMotivoAnulacion", Me.viewDepositos.CurrentRow.Index).Value = frm.txtMotivo.Text
                    Me.viewDepositos.CurrentRow.Visible = False
                    Me.CalcualarMontosDeposito()
                End If
            Else
                Me.viewDepositos.Item("cAnulado", Me.viewDepositos.CurrentRow.Index).Value = True
                Me.viewDepositos.CurrentRow.Visible = False
                Me.CalcualarMontosDeposito()
            End If
        End If
    End Sub

    Private Sub btnBuscarArqueo_Click(sender As Object, e As EventArgs) Handles btnBuscarArqueo.Click
        Me.CargarIdApertura()
    End Sub
End Class