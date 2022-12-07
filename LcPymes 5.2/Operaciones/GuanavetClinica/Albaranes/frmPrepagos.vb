Imports System.Data
Public Class frmPrepagos


    Private Sub CargarPrepagosActivos()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from viewSaldoPrepago where Nombre like '%" & Me.txtCliente.Text & "%' And saldo > 0 order by nombre", dt, CadenaConexionSeePOS)
        Try
            Me.viewDatos.DataSource = dt
            Me.viewDatos.Columns("Identificacion").Visible = False
            Me.viewDatos.Columns("Saldo").DefaultCellStyle.Format = "N2"
            Me.viewDatos.Columns("Saldo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmPrepagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarPrepagosActivos()
    End Sub

    Private Sub btnSincronizacion_Click(sender As Object, e As EventArgs)
        Me.CargarPrepagosActivos()
    End Sub

    Private Sub txtCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.CargarPrepagosActivos()
        End If
    End Sub

    Private Sub viewDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellDoubleClick
        Try
            Dim Identificacion As String = Me.viewDatos.Item("Identificacion", e.RowIndex).Value
            Dim frm As New frmCambiarEntregaCuenta
            frm.Identificacion1 = Identificacion
            frm.txtCliente.Text = Me.viewDatos.Item("Nombre", e.RowIndex).Value
            frm.txtSaldo.Text = Me.viewDatos.Item("Saldo", e.RowIndex).Value
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.CargarPrepagosActivos()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSolicitarDevolucion_Click(sender As Object, e As EventArgs) Handles btnSolicitarDevolucion.Click
        If Me.viewDatos.Rows.Count > 0 Then
            Try

                Dim Identificacion As String = Me.viewDatos.Item("Identificacion", Me.viewDatos.CurrentRow.Index).Value
                Dim dt As New DataTable
                cFunciones.Llenar_Tabla_Generico("select Identificacion, Cedula, Nombre from Clientes where identificacion = " & Identificacion, dt, CadenaConexionSeePOS)
                If dt.Rows.Count > 0 Then

                    Dim frm As New frmDevolverEntregaCuenta
                    frm.txtCliente.Text = dt.Rows(0).Item("Nombre")
                    frm.txtSaldo.Text = Me.viewDatos.Item("Saldo", Me.viewDatos.CurrentRow.Index).Value
                    frm.txtCedulaCuenta.Text = dt.Rows(0).Item("Cedula")
                    frm.txtNombreCuenta.Text = dt.Rows(0).Item("Nombre")
                    frm.txtCedulaCuenta.Focus()
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                        db.AddParametro("Identificacion", Identificacion)
                        db.AddParametro("Monto", CDec(frm.txtSaldo.Text))
                        db.AddParametro("Cedula", frm.txtCedulaCuenta.Text)
                        db.AddParametro("Nombre", frm.txtNombreCuenta.Text)
                        db.AddParametro("Mascota", frm.txtMascota.Text)
                        db.AddParametro("Banco", frm.txtBanco.Text)
                        db.AddParametro("Cuenta", frm.txtNumeroCuenta.Text)
                        db.AddParametro("MotivoSolicitud", frm.txtMotivo.Text)
                        db.AddParametro("FechaSolicitud", Date.Now)
                        db.AddParametro("Depositado", False)
                        db.Ejecutar("Insert into DevolucionPrepago(Identificacion,Monto,Cedula,Nombre,Mascota,Banco,Cuenta,MotivoSolicitud,FechaSolicitud,Depositado) values (@Identificacion,@Monto,@Cedula,@Nombre,@Mascota,@Banco,@Cuenta,@MotivoSolicitud,@FechaSolicitud,@Depositado)", CommandType.Text)
                        Me.CargarPrepagosActivos()
                    End If
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class