Imports System.Data
Imports System.Windows.Forms

Public Class frmArqueoCaja
    Private IdArqueo As Integer = 0
    Private IndexEfectivo As Integer = 0
    Private IndexDeposito As Integer = 0
    Public Id_Usuario As String = ""
    Public NombreUsuario As String = ""
    Public IdApertura As String

    Private Sub CargarLog(_IdTerminal As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Fecha, TipoTransaccion, Factura, Monto from Log where TipoTransaccion in('SALE','VOID', 'REVERSE') and idterminal = '" & _IdTerminal & "' AND IdApertura = 0", dt, CadenaConexionSeePOS)
        Me.viewDatosTarjetas.DataSource = dt
        Me.viewDatosTarjetas.Columns("Monto").DefaultCellStyle.Format = "N2"
        Me.viewDatosTarjetas.Columns("Monto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Dim MontoVentasAutomatico As Decimal = (From x As DataGridViewRow In Me.viewDatosTarjetas.Rows Where x.Cells("TipoTransaccion").Value = "SALE" Select CDec(x.Cells("Monto").Value)).Sum()
        Dim MontoAnulacionAutomatico As Decimal = (From x As DataGridViewRow In Me.viewDatosTarjetas.Rows Where x.Cells("TipoTransaccion").Value = "VOID" Select CDec(x.Cells("Monto").Value)).Sum()
        Dim MontoReversionAutomatico As Decimal = (From x As DataGridViewRow In Me.viewDatosTarjetas.Rows Where x.Cells("TipoTransaccion").Value = "REVERSE" Select CDec(x.Cells("Monto").Value)).Sum()
        If MontoVentasAutomatico > 0 Then
            Me.txtTarjetaAutomatico.Text = Format(MontoVentasAutomatico - MontoAnulacionAutomatico - MontoReversionAutomatico, "N2")
        Else
            Me.txtTarjetaAutomatico.Text = "0.00"
        End If
    End Sub

    Private Sub CargarLogArqueo(_IdArqueo As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select l.Fecha, l.TipoTransaccion, l.Factura, l.Monto from Log l inner join ArqueoCajas ac on l.IdApertura = ac.IdApertura where ac.Id = " & _IdArqueo, dt, CadenaConexionSeePOS)
        Me.viewDatosTarjetas.DataSource = dt
        Me.viewDatosTarjetas.Columns("Monto").DefaultCellStyle.Format = "N2"
        Me.viewDatosTarjetas.Columns("Monto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Dim MontoAutomatico As Decimal = (From x As DataGridViewRow In Me.viewDatosTarjetas.Rows Select CDec(x.Cells("Monto").Value)).Sum()
        If MontoAutomatico > 0 Then
            Me.txtTarjetaAutomatico.Text = Format(MontoAutomatico, "N2")
        Else
            Me.txtTarjetaAutomatico.Text = "0.00"
        End If
    End Sub

    Private Sub CargarIdApertura()
        If Me.Id_Usuario = "" Then
            Dim frm As New frmIniciodeSeccion
            frm.Text = "Clave para generar arqueo"
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
            Dim cls As New Credomatic.Configuracion.Terminal
            Me.txtTerminalId.Text = cls.Terminal
            Me.CargarLog(Me.txtTerminalId.Text)
            Me.CalcularMontoTarjeta()
            Me.CargarDepositos(0)
        Else
            MsgBox("El Usuario no tiene apertura de caja abierta.")
            Exit Sub
        End If
    End Sub

    Private Sub GuardarArqueo()
        Dim nuevo As Boolean = IIf(Me.IdArqueo = 0, True, False)
        Dim trans As OBSoluciones.SQL.Transaccion
        trans = New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
        Try
            trans.AddParametroSalida("@Id", Me.IdArqueo)
            trans.SetParametro("@EfectivoColones", CDec(Me.txtEfectivoColon.Text))
            trans.SetParametro("@EfectivoDolares", CDec(Me.txtEfectivoDolar.Text))
            trans.SetParametro("@TarjetaColones", CDec(txtTotalenTarjeta.Text))
            trans.SetParametro("@TarjetaDolares", "0")
            trans.SetParametro("@Cheques", CDec("0"))
            trans.SetParametro("@ChequesDol", CDec("0"))
            trans.SetParametro("@DepositoCol", CDec(Me.txtDepositoColones.Text))
            trans.SetParametro("@DepositoDol", CDec(Me.txtDepositoDolares.Text))
            trans.SetParametro("@Total", CDec(Me.txtEfectivoGeneral.Text) + CDec(Me.txtDepositoGeneral.Text) + CDec(Me.txtTotalenTarjeta.Text))
            trans.SetParametro("@IdApertura", Me.IdApertura)
            trans.SetParametro("@Fecha", Date.Now)
            trans.SetParametro("@Cajero", Me.NombreUsuario)
            trans.SetParametro("@Anulado", "0")
            trans.SetParametro("@TipoCambioD", Me.TipoCambio)
            trans.SetParametro("@Observaciones", "")
            trans.SetParametro("@TarjetaSistema", CDec(Me.txtTarjetaAutomatico.Text))
            trans.SetParametro("@OtrasTarjetas", CDec(Me.txtTarjetaManual.Text))
            trans.Ejecutar("GuardarArqueoCaja", CommandType.StoredProcedure, 0, Me.IdArqueo)

            trans.Ejecutar("Update ArqueoDeposito Set IdArqueo = " & Me.IdArqueo & " Where IdArqueo = 0 and IdApertura = " & Me.IdApertura, CommandType.Text)

            If nuevo = True Then
                For Each f As DataGridViewRow In Me.viewEfectivo.Rows
                    trans.Ejecutar("insert into ArqueoEfectivo(Id_Arqueo, Id_Denominacion, Monto, Cantidad) Values(" & Me.IdArqueo & ", " & f.Cells("cId_Denominacion").Value & ", " & f.Cells("cMonto").Value & ", " & f.Cells("cCantidad").Value & ")", CommandType.Text)
                Next
            Else
                'update
                trans.Ejecutar("Delete from ArqueoEfectivo where Id_Arqueo = " & Me.IdArqueo, CommandType.Text)
                For Each f As DataGridViewRow In Me.viewEfectivo.Rows
                    trans.Ejecutar("insert into ArqueoEfectivo(Id_Arqueo, Id_Denominacion, Monto, Cantidad) Values(" & Me.IdArqueo & ", " & f.Cells("cId_Denominacion").Value & ", " & f.Cells("cMonto").Value & ", " & f.Cells("cCantidad").Value & ")", CommandType.Text)
                Next
            End If

            If nuevo = True Then
                If Me.GeneraCierreCredomatic() = False Then
                    Me.IdArqueo = 0
                    trans.Rollback()
                    Exit Sub
                End If                
            End If

            trans.Commit()

            If Me.MontoCierre <> CDec(Me.txtTarjetaAutomatico.Text) Then
                'corrige problema con el monto de la tarjeta
                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                db.Ejecutar("Update ArqueoCajas Set TarjetaColones = " & (Me.MontoCierre + CDec(Me.txtTarjetaManual.Text)) & ", Total = " & CDec(Me.txtEfectivoGeneral.Text) + CDec(Me.txtDepositoGeneral.Text) + (Me.MontoCierre + CDec(Me.txtTarjetaManual.Text)) & " Where Id = " & Me.IdArqueo, CommandType.Text)
            End If

        Catch ex As Exception
            trans.Rollback()
        End Try
        Me.Close()
    End Sub

    Private Sub CargarDenominacionesMoneda(_IdArqueo As String)
        Me.viewEfectivo.Rows.Clear()
        Me.IndexEfectivo = 0

        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select dm.Id as Id_Denominacion, m.MonedaNombre, dm.Tipo, dm.Denominacion, ae.Cantidad from ArqueoEfectivo ae inner join Denominacion_Moneda dm on ae.Id_Denominacion = dm.Id inner join Moneda m on dm.CodMoneda = m.CodMoneda where ae.Id_Arqueo = " & _IdArqueo, dt, CadenaConexionSeePOS)
        For Each r As DataRow In dt.Rows
            AgregarDenominacion(r.Item("Id_Denominacion"), r.Item("MonedaNombre"), r.Item("Tipo"), r.Item("Denominacion"), r.Item("Cantidad"))
        Next
    End Sub

    Private Sub MostrarDenominacionesMoneda()
        Me.viewEfectivo.Rows.Clear()
        Me.IndexEfectivo = 0

        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select dm.Id, dm.CodMoneda, m.MonedaNombre, dm.Tipo, dm.Denominacion from Denominacion_Moneda dm inner join " & TablaSeguridad() & ".dbo.Moneda m on dm.CodMoneda = m.CodMoneda order by CodMoneda, Tipo desc, Denominacion", dt, CadenaConexionSeePOS)
        For Each r As DataRow In dt.Rows
            AgregarDenominacion(r.Item("Id"), r.Item("MonedaNombre"), r.Item("Tipo"), r.Item("Denominacion"), "0")
        Next
    End Sub

    Private Sub AgregarDenominacion(_IdDenominacion As String, _Moneda As String, _Tipo As String, _Denominacion As String, _Cantidad As String)

        With Me.viewEfectivo
            .Rows.Add()
            .Item("cId_Arqueo", Me.IndexEfectivo).Value = 0
            .Item("cId_Denominacion", Me.IndexEfectivo).Value = _IdDenominacion
            .Item("cMoneda", Me.IndexEfectivo).Value = _Moneda
            .Item("cTipo", Me.IndexEfectivo).Value = _Tipo
            .Item("cDenominacion", Me.IndexEfectivo).Value = _Denominacion
            .Item("cCantidad", Me.IndexEfectivo).Value = _Cantidad
            .Item("cMonto", Me.IndexEfectivo).Value = CDec(_Cantidad) * CDec(_Denominacion)
            Me.IndexEfectivo += 1
        End With
    End Sub

    Private Sub BuscarArqueo()
        Dim frm As New frmBuscarArqueo
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim Id As String = frm.viewDatos.Item("Arqueo", frm.viewDatos.CurrentRow.Index).Value
            Me.IdArqueo = Id
            Me.txtCajero.Text = frm.viewDatos.Item("Usuario", frm.viewDatos.CurrentRow.Index).Value
            Me.txtIdApertura.Text = frm.viewDatos.Item("Apertura", frm.viewDatos.CurrentRow.Index).Value
            Me.CargarDenominacionesMoneda(Id)
            Me.CargarDepositos(Id)
            Me.CargarLogArqueo(Id)
        Else
            Me.IdArqueo = 0
        End If
    End Sub

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
    Public MontoCierre As Decimal = 0
    Private Function GeneraCierreCredomatic() As Boolean
        Me.MontoCierre = 0
        Dim cls As New Credomatic.Operaciones.Operaciones
        Dim resultado As Credomatic.Operaciones.Respuesta = cls.Cierre()
        If resultado.Codigo = "00" Or resultado.Codigo = "21" Then
            Me.MontoCierre = cls.MontoCierre
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            db.Ejecutar("Update Log set IdApertura = " & Me.txtIdApertura.Text & " where IdTerminal = '" & Me.txtTerminalId.Text & "' and IdApertura = 0", CommandType.Text)
            cls.ImprimirResumenCierre(Me.txtIdApertura.Text)
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub CalcularMontosEfectivo()
        Dim efecolon As Decimal = (From x As DataGridViewRow In Me.viewEfectivo.Rows Where x.Cells("cMoneda").Value = "COLON" Select CDec(x.Cells("cMonto").Value)).Sum
        Dim efedolar As Decimal = (From x As DataGridViewRow In Me.viewEfectivo.Rows Where x.Cells("cMoneda").Value = "DOLAR" Select CDec(x.Cells("cMonto").Value)).Sum

        Me.txtEfectivoColon.Text = efecolon.ToString("N2")
        Me.txtEfectivoDolar.Text = efedolar.ToString("N2")
        Me.txtEfectivoGeneral.Text = (CDec(efecolon + (efedolar * Me.TipoCambio))).ToString("N2")
    End Sub

    Private Sub CalcualarMontosDeposito()
        Dim depcolon As Decimal = (From x As DataGridViewRow In Me.viewDepositos.Rows Where x.Cells("cMonedadeposito").Value = "COLON" Select CDec(x.Cells("cMontoDeposito").Value)).Sum
        Dim depdolar As Decimal = (From x As DataGridViewRow In Me.viewDepositos.Rows Where x.Cells("cMonedadeposito").Value = "DOLAR" Select CDec(x.Cells("cMontoDeposito").Value)).Sum

        Me.txtDepositoColones.Text = depcolon.ToString("N2")
        Me.txtDepositoDolares.Text = depdolar.ToString("N2")
        Me.txtDepositoGeneral.Text = (CDec(depcolon + (depdolar * Me.TipoCambio))).ToString("N2")
    End Sub

    Private Sub CalcularMontoTarjeta()
        Dim TarjetaAutomatica As Decimal = CDec(Me.txtTarjetaAutomatico.Text)
        Dim TarjetaManual As Decimal = 0
        If Me.txtTarjetaManual.Text <> "" Then
            If IsNumeric(Me.txtTarjetaManual.Text) Then
                If CDec(Me.txtTarjetaManual.Text) > 0 Then
                    TarjetaManual = CDec(Me.txtTarjetaManual.Text)
                End If
            End If
        End If
        Me.txtTotalenTarjeta.Text = CDec(TarjetaAutomatica + TarjetaManual).ToString("N2")
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

    Private Sub frmArqueoCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MostrarDenominacionesMoneda()
        Me.CargarBancos()
        Me.TipoCambio = Me.getTipocambio
        Me.CargarIdApertura()
    End Sub

    Private Sub viewDatos_CellValueChanged(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles viewEfectivo.CellValueChanged
        On Error Resume Next
        Dim Value As String = Me.viewEfectivo.Item("cCantidad", e.RowIndex).Value

        If IsNumeric(Value) Then
            Me.viewEfectivo.Item("cMonto", e.RowIndex).Value = CDec(Me.viewEfectivo.Item("cDenominacion", e.RowIndex).Value) * CDec(Value)
        Else
            Me.viewEfectivo.Item("cMonto", e.RowIndex).Value = "0"
            Me.viewEfectivo.Item("cCantidad", e.RowIndex).Value = "0"
        End If
        Me.CalcularMontosEfectivo()

    End Sub

    Private Sub CargarDepositos(_IdArqueo As String)
        Me.viewDepositos.Rows.Clear()
        Me.IndexDeposito = 0
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Banco, Cuenta, Moneda, Numero, Monto from ArqueoDeposito Where IdArqueo = " & _IdArqueo & " And IdApertura = " & Me.IdApertura, dt, CadenaConexionSeePOS)
        For Each r As DataRow In dt.Rows
            Me.AgregarDeposito(r.Item("Banco"), r.Item("Cuenta"), r.Item("Moneda"), r.Item("Numero"), r.Item("Monto"))
        Next
    End Sub

    Private Sub AgregarDeposito(_Banco As String, _Cuenta As String, _Moneda As String, _Numero As String, _Monto As Decimal)
        Me.viewDepositos.Rows.Add()
        Me.viewDepositos.Item("cBanco", Me.IndexDeposito).Value = _Banco
        Me.viewDepositos.Item("cCuenta", Me.IndexDeposito).Value = _Cuenta
        Me.viewDepositos.Item("cMonedaDeposito", Me.IndexDeposito).Value = _Moneda
        Me.viewDepositos.Item("cNumero", Me.IndexDeposito).Value = _Numero
        Me.viewDepositos.Item("cMontoDeposito", Me.IndexDeposito).Value = _Monto
        Me.IndexDeposito += 1
        Me.CalcualarMontosDeposito()
    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Me.txtNumeroDeposito.Text <> "" And Me.txtMontoDeposito.Text <> "" Then
            If IsNumeric(Me.txtNumeroDeposito.Text) = True And IsNumeric(Me.txtNumeroDeposito.Text) = True Then
                Me.AgregarDeposito(Me.cboBanco.Text, Me.cboCuenta.Text, Me.txtMoneda.Text, txtNumeroDeposito.Text, Me.txtMontoDeposito.Text)
            End If
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.MostrarDenominacionesMoneda()
        Me.viewDepositos.Rows.Clear()
        Me.IndexDeposito = 0
        Me.IdArqueo = 0
        Me.Id_Usuario = ""
        Me.CargarIdApertura()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.BuscarArqueo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If MsgBox("Esta seguro que ingreso todos los depositos, tarjetas y efectivo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Favor Confirmar Accion") = MsgBoxResult.Yes Then
            Me.GuardarArqueo()
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

    Private Sub btnCierre_Click(sender As Object, e As EventArgs) Handles btnCierre.Click
        Me.GeneraCierreCredomatic()
    End Sub

    Private Sub txtTarjetaManual_TextChanged(sender As Object, e As EventArgs) Handles txtTarjetaManual.TextChanged
        CalcularMontoTarjeta()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

    End Sub

    Private Sub btnCargarDepositos_Click(sender As Object, e As EventArgs) Handles btnCargarDepositos.Click
        CargarDepositos(Me.IdArqueo)
    End Sub

End Class