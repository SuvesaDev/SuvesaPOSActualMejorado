Imports System.Data
Public Class frmConfirmarGenerarFacturas

    Public Id_Usuario As String = ""

    Private Sub CargarCajaDefecto()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Num_Caja from aperturacaja where Estado = 'A' and Cedula = '" & Me.Id_Usuario & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Select Case dt.Rows(0).Item("Num_Caja")
                Case 1
                    For Each row As DataGridViewRow In Me.viewDatos.Rows
                        row.Cells("cCaja").Value = "1"
                    Next
                Case 2
                    For Each row As DataGridViewRow In Me.viewDatos.Rows
                        row.Cells("cCaja").Value = "2"
                    Next
                Case 3
                    For Each row As DataGridViewRow In Me.viewDatos.Rows
                        row.Cells("cCaja").Value = "3"
                    Next
            End Select
        End If

        For Each row As DataGridViewRow In Me.viewDatos.Rows
            row.Cells("cTipo").Value = "CONTADO"
        Next
    End Sub

    Private Sub cargarDortores()
        'Try
        '    Dim dt As New DataTable
        '    cFunciones.Llenar_Tabla_Generico("select 0 as Id, 'Seleccione un doctor' as Nombre union select id, nombre from agente_ventas", dt, CadenaConexionSeePOS)
        '    If dt.Rows.Count > 0 Then
        '        Me.cboDoctorEncargado.DataSource = dt
        '        Me.cboDoctorEncargado.DisplayMember = "nombre"
        '        Me.cboDoctorEncargado.ValueMember = "id"
        '    End If
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub CrearCliente()
        Dim frm_cliente As New frm_cliente_rapido
        frm_cliente.Frecuente = False
        frm_cliente.txtCodigo.Enabled = True
        frm_cliente.txtNombre.Enabled = True
        frm_cliente.cbo_tipo_cliente.Enabled = True
        frm_cliente.ShowDialog()
    End Sub

    Private Function ValidarCajaAbierta(_NumCaja As Integer)
        Dim dt As New DataTable
        For Each row As DataGridViewRow In Me.viewDatos.Rows
            cFunciones.Llenar_Tabla_Generico("select * from aperturacaja where Estado = 'A' and Num_Caja = " & _NumCaja, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Next
    End Function

    Private Sub CargarCliente(_Identificacion As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * from Clientes where Identificacion = '" & _Identificacion & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.viewDatos.Item("cIdentificacion2", Me.viewDatos.CurrentRow.Index).Value = _Identificacion
            Me.viewDatos.Item("cCliente", Me.viewDatos.CurrentRow.Index).Value = dt.Rows(0).Item("nombre")
            Me.viewDatos.Item("cSaldoPrepago", Me.viewDatos.CurrentRow.Index).Value = Anticipo(_Identificacion)
        End If
    End Sub

    Private Function Anticipo(_Cedula As String) As Decimal
        Dim dt As New DataTable
        Dim cedula2 As String = Me.GetId(_Cedula)
        cFunciones.Llenar_Tabla_Generico("select IsNull(Sum(debitos - creditos),0) as Saldo from viewMovimientosPrepagos where identificacion = " & _Cedula & " or identificacion = " & cedula2, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Dim saldo As Decimal = CDec(dt.Rows(0).Item("Saldo"))
            If saldo > 0 Then
                Return saldo
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function

    Private Function GetId(_Cedula As String) As String
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select identificacion from Clientes where cedula = '" & _Cedula & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("identificacion")
        Else
            Return "-1"
        End If
    End Function


    Private Sub BuscarCliente()
        Dim frmBuscarCliente As New frm_buscar_cliente
        frmBuscarCliente.txt_nombre.Focus()
        If frmBuscarCliente.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.CargarCliente(frmBuscarCliente.id)
        End If
    End Sub

    Private Function SaldoCxC(_Identificacion As String) As Decimal
        Dim dt As New DataTable
        Dim strSQL As String = "select isnull(sum(dbo.SaldoFactura_Monto(getdate(),num_factura,tipo,cod_cliente,total)),0) from Ventas where Cod_Cliente = " & _Identificacion & " and tipo in('CRE','TCR','MCR') and Anulado = 0"
        cFunciones.Llenar_Tabla_Generico(strSQL, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function

    Private Function PasaValidacionCredito()
        Try
            Dim Id As String = "0"
            Dim Nom As String = ""
            Dim SaldoCXC As Decimal = 0
            For Each row As DataGridViewRow In (From x As DataGridViewRow In Me.viewDatos.Rows
                                                Where x.Cells("cTipo").Value = "CREDITO"
                                                Select x).ToList

                Id = row.Cells("cIdentificacion2").Value
                Nom = row.Cells("cCliente").Value

                Dim dt As New DataTable
                cFunciones.Llenar_Tabla_Generico("Select * from Clientes where Identificacion = '" & Id & "'", dt, CadenaConexionSeePOS)
                If dt.Rows.Count > 0 Then
                    If dt.Rows(0).Item("abierto") = "NO" Then
                        MsgBox("El Cliente " & Nom & ", No tiene activado el Credito" & vbCrLf _
                               & "La factura solo puede ser de CONTADO.", MsgBoxStyle.Exclamation, "No se puede procesar la Operacion.")
                        Return False 'no tiene activado el credito
                    Else
                        If dt.Rows(0).Item("sinrestriccion") = "NO" Then
                            SaldoCXC = Me.SaldoCxC(Id) + row.Cells("cTotal").Value
                            If SaldoCXC > CDec(dt.Rows(0).Item("max_credito")) Then
                                MsgBox("El saldo de credito super el Maximo permitido" & vbCrLf _
                                       & "La factura solo puede ser de CONTADO.", MsgBoxStyle.Exclamation, "No se puede procesar la Operacion.")
                                Return False
                            Else
                                row.Cells("cPlazo").Value = dt.Rows(0).Item("Plazo_credito")
                                Return True
                            End If
                        Else
                            row.Cells("cPlazo").Value = dt.Rows(0).Item("Plazo_credito")
                            Return True 'sin validar cuenta
                        End If
                    End If
                Else
                    'no existe cliente
                    Return False
                End If
            Next
        Catch ex As Exception
            'ups
            Return True
        End Try
        Return True
    End Function


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnGenerarFacturas_Click(sender As Object, e As EventArgs) Handles btnGenerarFacturas.Click
        Dim resultado As Boolean = True
        For Each row As DataGridViewRow In Me.viewDatos.Rows
            If ValidarCajaAbierta(row.Cells("cCaja").Value) = False Then
                MsgBox("Caja #" & row.Cells("cCaja").Value & " no esta abierta" & vbCrLf _
                       & "No se puede registrar la factura.", MsgBoxStyle.Exclamation, Text)
                resultado = False
            End If
        Next

        'If Me.cboDoctorEncargado.SelectedValue = "0" Then
        '    MsgBox("Debe selecccionar un encargado", MsgBoxStyle.Information, Me.Text)
        '    Me.cboDoctorEncargado.Focus()
        '    Exit Sub
        'End If

        If Me.PasaValidacionCredito = False Then
            Exit Sub
        End If

        If resultado = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub viewDatos_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles viewDatos.DataError
        e.Cancel = True
    End Sub

    Private Sub viewDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellDoubleClick
        Me.BuscarCliente()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.CrearCliente()
    End Sub

    Private Sub frmConfirmarGenerarFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarDortores()
        Me.CargarCajaDefecto()
    End Sub

    Private Sub viewDatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellContentClick

    End Sub
End Class