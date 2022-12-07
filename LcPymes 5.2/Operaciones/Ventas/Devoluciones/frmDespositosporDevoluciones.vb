Imports System.Data
Public Class frmDespositosporDevoluciones

    Private Sub MostrarDatos()
        Try
            Dim dt As New DataTable
            Dim strSQL As String = "Select * from viewDepositoDevolucion "
            Dim strWhere As String = ""
            Select Case Me.ComboBox1.SelectedIndex + 1
                Case 1 : strWhere = "Where Devuelto = 0 and dbo.dateonly(fecha) >= dbo.dateonly('" & Me.dtpDesde.Value & "') and dbo.dateonly(fecha) <= dbo.dateonly('" & Me.dtpHasta.Value & "')"
                Case 2 : strWhere = "Where Devuelto = 1 and dbo.dateonly(fecha) >= dbo.dateonly('" & Me.dtpDesde.Value & "') and dbo.dateonly(fecha) <= dbo.dateonly('" & Me.dtpHasta.Value & "')"
                Case 3 : strWhere = "Where dbo.dateonly(fecha) >= dbo.dateonly('" & Me.dtpDesde.Value & "') and dbo.dateonly(fecha) <= dbo.dateonly('" & Me.dtpHasta.Value & "')"
            End Select
            cFunciones.Llenar_Tabla_Generico(strSQL & strWhere, dt, CadenaConexionSeePOS)
            Me.viewDatos.DataSource = dt
            Me.viewDatos.Columns("CodMoneda").Visible = False
            Me.viewDatos.Columns("TipoCambio").Visible = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmDespositosporDevoluciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
        Me.ComboBox1.SelectedIndex = 0
        Dim fecha As Date = CDate("01/" & Date.Now.Month & "/" & Date.Now.Year)
        Me.dtpDesde.Value = fecha
        Me.MostrarDatos()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.MostrarDatos()
    End Sub

    Private Sub viewDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellDoubleClick
        Try
            Dim frm As New frmRegistrarDepositoDevolucion
            Dim Tipo As String = Me.viewDatos.Item("Tipo", Me.viewDatos.CurrentRow.Index).Value
            frm.txtCedula.Text = Me.viewDatos.Item("Identificacion", Me.viewDatos.CurrentRow.Index).Value
            frm.txtNombre.Text = Me.viewDatos.Item("Cliente", Me.viewDatos.CurrentRow.Index).Value
            frm.txtCuenta.Text = Me.viewDatos.Item("Cuenta", Me.viewDatos.CurrentRow.Index).Value
            frm.txtMonto.Text = CDec(Me.viewDatos.Item("Monto", Me.viewDatos.CurrentRow.Index).Value).ToString("N2")
            If Me.viewDatos.Item("Devuelto", Me.viewDatos.CurrentRow.Index).Value = True Then
                frm.txtDocumento.Text = Me.viewDatos.Item("Documento", Me.viewDatos.CurrentRow.Index).Value
                frm.dtpFecha.Text = Me.viewDatos.Item("FechaDeposito", Me.viewDatos.CurrentRow.Index).Value
            End If
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                Dim strSQL As String = ""
                If Tipo = "Devolucion" Then
                    strSQL = "Update devoluciones_ventas Set Devuelto = 1, Documento = '" & frm.txtDocumento.Text & "', FechaDeposito = '" & frm.dtpFecha.Value & "' Where devolucion = " & Me.viewDatos("Id", Me.viewDatos.CurrentRow.Index).Value
                Else
                    strSQL = "Update DevolucionPrepago set Depositado = 1, Documento = '" & frm.txtDocumento.Text & "', FechaDeposito = '" & frm.dtpFecha.Value & "' Where Id = " & Me.viewDatos("Id", Me.viewDatos.CurrentRow.Index).Value
                End If
                db.Ejecutar(strSQL, CommandType.Text)
                Me.MostrarDatos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

End Class