Imports System.Data
Public Class frmCambiarEntregaCuenta

    Public Identificacion1 As String = ""
    Private Identificacion2 As String = ""

    Private Function RegistrarDatos(_Identificacion1 As String, _Fecha As Date, _MontoEntrada As Decimal, _MontoSalida As Decimal, _Identificacion2 As String, _MontoCambio As Decimal, _IdUsuario As String) As Boolean
        Dim db As New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
        Try
            db.SetParametro("@Identificacion1", _Identificacion1)
            db.SetParametro("@Fecha", _Fecha)
            db.SetParametro("@MontoEntra", _MontoEntrada)
            db.SetParametro("@MontoSale", _MontoSalida)
            db.SetParametro("@Identificacion2", _Identificacion2)
            db.SetParametro("@MontoCambia", _MontoCambio)
            db.SetParametro("@IdUsuario", _IdUsuario)
            db.Ejecutar("Insert into Movimientos_Prepago(Identificacion1, Fecha, MontoEntra, MontoSale, Identificacion2, MontoCambia, Anular, IdUsuario) values (@Identificacion1, @Fecha, @MontoEntra, @MontoSale, @Identificacion2, @MontoCambia, 0, @IdUsuario);", Data.CommandType.Text)
            db.Commit()
            Return True
        Catch ex As Exception
            db.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Return False
        End Try
    End Function

    Private Sub ValidarRegistro(_IdUsuario As String)
        If IsNumeric(Me.txtMonto.Text) Then
            If CDec(Me.txtMonto.Text) > 0 Then
                Select Case Me.cboTipoMovimiento.SelectedIndex
                    Case 0 'aumento
                        If Me.RegistrarDatos(Me.Identificacion1, dtpFecha.Value, CDec(Me.txtMonto.Text), 0, "0", 0, _IdUsuario) = True Then
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                        End If
                    Case 1 'disminuye
                        If Me.RegistrarDatos(Me.Identificacion1, dtpFecha.Value, 0, CDec(Me.txtMonto.Text), "0", 0, _IdUsuario) = True Then
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                        End If
                    Case 2 'cambia
                        If IsNumeric(Me.Identificacion2) Then
                            If CDec(Me.Identificacion2) > 0 Then
                                If Me.RegistrarDatos(Me.Identificacion1, dtpFecha.Value, 0, 0, Me.Identificacion2, CDec(Me.txtMonto.Text), _IdUsuario) = True Then
                                    Me.DialogResult = Windows.Forms.DialogResult.OK
                                End If
                            Else
                                MsgBox("Debe seleccionar un cliente", MsgBoxStyle.Exclamation, Me.Text)
                            End If
                        Else
                            MsgBox("Debe seleccionar un cliente", MsgBoxStyle.Exclamation, Me.Text)
                        End If
                End Select
            Else
                MsgBox("el " & Me.lblEtiquetaMonto.Text & " debe ser un valor numerico mayor a cero.", MsgBoxStyle.Exclamation, Me.Text)
            End If
        Else
            MsgBox("el " & Me.lblEtiquetaMonto.Text & " debe ser un valor numerico mayor a cero.", MsgBoxStyle.Exclamation, Me.Text)
        End If
    End Sub

    Private Sub CargarCliente(_Identificacion As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * from Clientes where Identificacion = '" & _Identificacion & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.Identificacion2 = _Identificacion
            Me.txtNombreCliente.Text = dt.Rows(0).Item("nombre")
        Else
            Me.Identificacion2 = "0"
            Me.txtNombreCliente.Text = ""
        End If
    End Sub

    Private Sub BuscarCliente()
        Dim frmBuscarCliente As New frm_buscar_cliente
        frmBuscarCliente.txt_nombre.Focus()
        If frmBuscarCliente.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.CargarCliente(frmBuscarCliente.id)
        End If
    End Sub

    Private Sub LimpiarCliente()
        Me.btnBuscar.Enabled = False
        Me.txtNombreCliente.Text = ""
    End Sub

    Private Sub cboTipoMovimiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoMovimiento.SelectedIndexChanged
        Me.txtMonto.Text = ""
        Select Case cboTipoMovimiento.SelectedIndex
            Case 0 'aumento
                Me.lblEtiquetaMonto.Text = "Monto Aumentar"
                Me.LimpiarCliente()
            Case 1 'disminuye
                Me.lblEtiquetaMonto.Text = "Monto Disminuir"
                Me.LimpiarCliente()
            Case 2 'cambia
                Me.lblEtiquetaMonto.Text = "Monto Pasar"
                Me.btnBuscar.Enabled = True
        End Select

    End Sub

    Private Sub frmCambiarEntregaCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.Identificacion1 = "" Then
            Me.Close()
        End If
        Me.cboTipoMovimiento.SelectedIndex = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New frmVersionCompleta
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.ValidarRegistro(frm.IdUsuario)
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.BuscarCliente()
    End Sub
End Class