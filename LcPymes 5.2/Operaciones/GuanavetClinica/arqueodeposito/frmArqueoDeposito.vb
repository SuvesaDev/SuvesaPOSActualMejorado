Imports System.Data
Public Class frmArqueoDeposito

    Private Sub MostrarDatos()
        Try
            Dim dt As New DataTable
            Dim strSQL As String = "Select * from viewArqueoDeposito "
            Dim strWhere As String = "Where dbo.dateonly(FechaArqueo) >= dbo.dateonly('" & Me.dtpDesde.Value & "') and dbo.dateonly(FechaArqueo) <= dbo.dateonly('" & Me.dtpHasta.Value & "') "

            Select Case Me.cboEstados.SelectedIndex + 1
                Case 1 : strWhere += "And estado = 'pendiente'"
                Case 2 : strWhere += "And estado = 'depositado'"
                Case 3 : strWhere += ""
            End Select

            Select Case Me.cboTipo.SelectedIndex + 1
                Case 1 : strWhere += "And Tipo = 'deposito'"
                Case 2 : strWhere += "And Tipo = 'sinpe'"
                Case 3 : strWhere += "And Tipo = 'otros'"
                Case 4 : strWhere += ""
            End Select

            cFunciones.Llenar_Tabla_Generico(strSQL & strWhere, dt, CadenaConexionSeePOS)
            Me.viewDatos.DataSource = dt
            Me.viewDatos.Columns("Id").Visible = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.MostrarDatos()
    End Sub

    Private Sub frmArqueoDeposito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cboEstados.SelectedIndex = 0
        Me.cboTipo.SelectedIndex = 3
        Dim fecha As Date = CDate("01/" & Date.Now.Month & "/" & Date.Now.Year)
        Me.dtpDesde.Value = fecha
        Me.MostrarDatos()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub viewDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellDoubleClick
        Try
            'Dim frm As New frmRegistrarDepositoDevolucion
            'frm.txtCedula.Text = Me.viewDatos.Item("Identificacion", Me.viewDatos.CurrentRow.Index).Value
            'frm.txtNombre.Text = Me.viewDatos.Item("Cliente", Me.viewDatos.CurrentRow.Index).Value
            'frm.txtCuenta.Text = Me.viewDatos.Item("Cuenta", Me.viewDatos.CurrentRow.Index).Value
            'frm.txtMonto.Text = CDec(Me.viewDatos.Item("Monto", Me.viewDatos.CurrentRow.Index).Value).ToString("N2")
            'If Me.viewDatos.Item("Devuelto", Me.viewDatos.CurrentRow.Index).Value = True Then
            '    frm.txtDocumento.Text = Me.viewDatos.Item("Documento", Me.viewDatos.CurrentRow.Index).Value
            '    frm.dtpFecha.Text = Me.viewDatos.Item("FechaDeposito", Me.viewDatos.CurrentRow.Index).Value
            'End If
            'If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            '    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '    Dim strSQL As String = "Update devoluciones_ventas Set Devuelto = 1, Documento = '" & frm.txtDocumento.Text & "', FechaDeposito = '" & frm.dtpFecha.Value & "' Where devolucion = " & Me.viewDatos("Id", Me.viewDatos.CurrentRow.Index).Value
            '    db.Ejecutar(strSQL, CommandType.Text)
            '    Me.MostrarDatos()
            'End If

            Dim frm As New frmProcesarDeposito
            frm.txtBanco.Text = Me.viewDatos.Item("Banco", Me.viewDatos.CurrentRow.Index).Value
            frm.txtCuentaBancaria.Text = Me.viewDatos.Item("Cuenta", Me.viewDatos.CurrentRow.Index).Value
            frm.txtTipo.Text = Me.viewDatos.Item("Tipo", Me.viewDatos.CurrentRow.Index).Value
            frm.txtFecha.Text = CDate(Me.viewDatos.Item("FechaArqueo", Me.viewDatos.CurrentRow.Index).Value).ToShortDateString
            frm.txtMonto.Text = Me.viewDatos.Item("Monto", Me.viewDatos.CurrentRow.Index).Value
            If Me.viewDatos.Item("Estado", Me.viewDatos.CurrentRow.Index).Value = "depositado" Then
                frm.dtpFecha.Value = Me.viewDatos.Item("FechaDeposito", Me.viewDatos.CurrentRow.Index).Value
            End If
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                Dim strSQL As String = ""
                If frm.Estado = "depositado" Then
                    strSQL = "Update ArqueoDeposito set Estado = 'depositado', FechaDeposito = '" & frm.dtpFecha.Value & "' where id = " & Me.viewDatos("Id", Me.viewDatos.CurrentRow.Index).Value
                Else
                    strSQL = "Update ArqueoDeposito set Estado = 'pendiente', FechaDeposito = null where id = " & Me.viewDatos("Id", Me.viewDatos.CurrentRow.Index).Value
                End If

                db.Ejecutar(strSQL, CommandType.Text)
                Me.MostrarDatos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
End Class